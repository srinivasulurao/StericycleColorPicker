/**
 * CBO v1.3 (2013-12-11)
 * @author: Jonathan Hilgeman
 * 
 * This class provides a way to easily work with custom objects via the CWSS SOAP API. 
 * It exposes simple CRUD operations, and allows you to easily extend the class to
 * create strongly-typed classes that represent the actual various CBO object 
 * definitions for much cleaner code.
 * 
 * History:
 * v1.3 - Added Destroy() method
 * v1.2 - Added a constructor with dynamic package/object lookups and dynamic property name lookups,
 *        and added GetMenuItems for MenuCBOs.
 * v1.1 - Added NamedIDField constructor to accept string / Name values.
 * 
 * Custom Object Definition Example:
 * ==================================================================================================
 * 
 * using MyUtilities;
 * 
 * namespace CO
 * {
 *   class Movie : CBO
 *   {
 *       // Constructor
 *       public Movie(int ID = 0) : base(ID)
 *       {
 *          // Any Movie-specific constructor code.
 *       }
 *
 *       // An integer field
 *       public int? Profit
 *       {
 *           set { Set(value, FieldTypes.Integer); }
 *           get { return GetIntegerFieldValue(); }
 *       }
 *
 *       // A Named ID field
 *       public int? Genre 
 *       {
 *           set { Set(value, FieldTypes.NamedID); }
 *           get { return GetNamedIDFieldValue(); }
 *       }
 *
 *       // A string field
 *       public string AlternateTitle
 *       {
 *           set { Set(value, FieldTypes.String); }
 *           get { return GetStringFieldValue(); }
 *       }
 * 
 *       // A date/time field
 *       public DateTime ReleaseDate
 *       {
 *           set { Set(value, FieldTypes.DateTime); }
 *           get { return GetDateTimeFieldValue(); }
 *       }
 *       
 *       // A boolean field
 *       public bool GotTwoThumbsUp
 *       {
 *           set { Set(value, FieldTypes.Boolean); }
 *           get { return GetDateTimeFieldValue(); }
 *       }
 *   }
 *   
 * }
 * 
 * 
 * Then in later code:
 * 
 * // Create a new CO\Movie record
 * CO.Movie = new CO.Movie();
 * CO.Profit = 1000000;
 * CO.Genre = 4; // 4 = ID for Horror
 * CO.AlternateTitle = "The Oregon Chainsaw Massacre";
 * CO.ReleaseDate = DateTime.Now;
 * CO.GotTwoThumbsUp = false;
 * 
 * // Can either create the record like this:
 * CO.Create();
 * 
 * // or just get the GenericObject that we can pass to the API later (if we want more manual control):
 * GenericObject createObject = CO.ToObject(CBO.FieldSelection.OnlyModifiedFields);
 * _service.Create(_cih, new RNObject[] { createObject }, CreateSuppressOptions);
 * 
 * ==================================================================================================
 * 
 * It also provides a MenuCBO derivative (at the bottom) that gives you an easy way
 * to load records into CBOs that generate menus.
 * 
 * 
 * Menu Custom Object Definition Example:
 * ==================================================================================================
 * 
 * using MyUtilities;
 * 
 * namespace CO
 * {
 *   class MovieGenre : MenuCBO
 *   {
 *       // Constructor
 *       public MovieGenre(int ID = 0) : base(ID) { }
 *   }
 * }
 * 
 * Then in later code:
 * 
 * // And to intelligently import menu items into the CO\MovieGenre menu CBO:
 * MenuCBO.ImportMenuItems<CO.MovieGenre>(new List<string>()
 * {
 *      "Action",
 *      "Adventure",
 *      "Comedy",
 *      "Horror",
 *      "Romance"
 * });
 * 
 * // And to get existing menu items from the CO\MovieGenre menu CBO:
 * Dictionary<int,string> MovieGenres = MenuCBO.GetMenuItems<CO.MovieGenre>();
 * 
 * ==================================================================================================
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Reflection;

using MyUtilities.CWS_14_8;
using RightNowService = MyUtilities.CWS_14_8;

namespace MyUtilities
{
    // ------------------------------------------------------------------------
    // Base class for working with custom objects
    // ------------------------------------------------------------------------
    public class CBO
    {
        // Basic properties
        public string PackageName;
        public string ObjectName;
        public int ID;
        public GenericObject Object;
        public object[] Notes;
        public DataTable dtNotes;
        public GenericObject Attachments; // Not supported just yet...
        public DateTime lastPulled;
        public List<string> ModifiedFields = new List<string>();

        // Static CWS reference
        public static RightNowSyncPortClient service = null;
        public static ClientInfoHeader cih = null;

        // Holds snapshots of field values to make rolling back easier
        public Dictionary<string, Dictionary<string, GenericField>> FieldSnapshots = new Dictionary<string, Dictionary<string, GenericField>>();

        // Fields
        public Dictionary<string, GenericField> Fields = new Dictionary<string, GenericField>();

        // Template for stuff like Get, QueryObjects, etc...
        // protected GenericObject objectTemplate;
        public string[] StandardReadOnlyFields = new string[] { "UpdatedTime", "UpdatedByAccount", "CreatedTime", "CreatedByAccount" };

        // Processing options
        #region Standard Get, Create, Update, and Destroy Processing Options
        protected GetProcessingOptions GetOptions = new GetProcessingOptions()
        {
            FetchAllNames = true
        };
        protected UpdateProcessingOptions UpdateOptions = new UpdateProcessingOptions()
        {
            SuppressExternalEvents = true,
            SuppressRules = true
        };
        protected CreateProcessingOptions CreateOptions = new CreateProcessingOptions()
        {
            SuppressExternalEvents = true,
            SuppressRules = true
        };
        protected DestroyProcessingOptions DestroyOptions = new DestroyProcessingOptions()
        {
            SuppressExternalEvents = true,
            SuppressRules = true
        };
        #endregion

        // Field Types
        public enum FieldTypes
        {
            String,
            TextArea,
            Integer,
            Boolean,
            DateTime,
            Date,
            NamedID
        };

        // Determine how ToObject() will work
        public enum FieldSelection
        {
            OnlyID,
            OnlyModifiedFields,
            AllEditableFields,
            AllFields
        }

        // Our constructor (get package and object name from class namespace and class name)
        public CBO(int ID = 0)
        {
            this.PackageName = this.GetType().Namespace;
            this.ObjectName = this.GetType().Name;

            if (ID > 0)
            {
                // Specify Record ID
                this.ID = ID;
            }
        }

        // Second constructor, in case we want to specify the package and object name
        public CBO(string PackageName, string ObjectName, int ID = 0)
        {
            this.PackageName = PackageName;
            this.ObjectName = ObjectName;

            if (ID > 0)
            {
                // Specify Record ID
                this.ID = ID;
            }
        }

        public string field_modified
        {
            set { Set(value, FieldTypes.String); }
            get { return GetStringFieldValue(); }
        }

        public string old_value
        {
            set { Set(value, FieldTypes.String); }
            get { return GetStringFieldValue(); }
        }
        public string new_value
        {
            set { Set(value, FieldTypes.String); }
            get { return GetStringFieldValue(); }
        }

        public int? incident_id
        {
            set { Set(value, FieldTypes.NamedID); }
            get { return GetIntegerFieldValue(); }
      }

        #region Get, Create, Update, and Destroy (future) Methods
        public delegate RNObject[] CustomGetHandler(RNObject OriginalObject, GetProcessingOptions GetOptions);
        public CustomGetHandler CustomGetHook;
        public GenericObject Get(RightNowSyncPortClient service = null, ClientInfoHeader cih = null, bool GetNotes = false)
        {
            try
            {
                // Use static CWS references if they're set and nothing is passed
                if ((service == null) && (CBO.service != null))
                {
                    service = CBO.service;
                }
                if ((cih == null) && (CBO.cih != null))
                {
                    cih = CBO.cih;
                }
                if ((service == null) || (cih == null))
                {
                    throw new Exception("Service and ClientInfoHeader need to be passed to the method or be defined as static CBO properties!");
                }

                // Build the object template we're requesting
                GenericObject GetObjectTemplate = this.ToObject(FieldSelection.OnlyID);
                if (GetObjectTemplate.ID == null)
                {
                    throw new Exception("Get() requires an ID to be set first!");
                }
                List<GenericField> AdditionalFields = new List<GenericField>();
                if (GetNotes)
                {
                    AdditionalFields.Add(new GenericField() { name = "Notes" });
                }
                if (AdditionalFields.Count > 0)
                {
                    GetObjectTemplate.GenericFields = AdditionalFields.ToArray();
                }

                // CWS: Get()                
                RNObject[] returned = null;
                if (CustomGetHook != null)
                {
                    returned = CustomGetHook(GetObjectTemplate, GetOptions);
                }
                else
                {
                    returned = service.Get(cih, new RNObject[] { GetObjectTemplate }, GetOptions);
                }
                if (returned.Length > 0)
                {
                    // Success!
                    lastPulled = DateTime.Now;
                    this.Object = (GenericObject)returned.First();

                    // Load fields
                    Fields.Clear();
                    foreach (GenericField gf in Object.GenericFields)
                    {
                        Fields.Add(gf.name, gf);
                    }

                    if (GetNotes)
                    {
                        // Create Notes table
                        dtNotes = new DataTable("Notes");
                        dtNotes.Columns.Add("ID", typeof(int));
                        dtNotes.Columns.Add("Channel");
                        dtNotes.Columns.Add("ChannelID", typeof(int));
                        dtNotes.Columns.Add("CreatedTime", typeof(DateTime));
                        dtNotes.Columns.Add("Text");

                        // Pull Notes into separate Notes property
                        GenericField gfNotes = extractField(this.Object.GenericFields, "Notes");
                        if (gfNotes != null)
                        {
                            Notes = (object[])gfNotes.DataValue.Items;

                            // Load Notes structure into DataTable
                            foreach (GenericObject Note in Notes)
                            {
                                DataRow drNewNote = dtNotes.NewRow();
                                foreach (GenericField NoteField in Note.GenericFields)
                                {
                                    switch (NoteField.name)
                                    {
                                        case "ID":
                                            ID noteID = (ID)NoteField.DataValue.Items[0];
                                            drNewNote["ID"] = (int)noteID.id;
                                            break;

                                        case "Channel":
                                            NamedID noteChannel = (NamedID)NoteField.DataValue.Items[0];
                                            drNewNote["Channel"] = noteChannel.Name;
                                            drNewNote["ChannelID"] = (int)noteChannel.ID.id;
                                            break;

                                        case "CreatedTime":
                                            DateTime noteCreatedTime = (DateTime)NoteField.DataValue.Items[0];
                                            drNewNote["CreatedTime"] = noteCreatedTime.ToLocalTime(); // .ToString("G");
                                            break;

                                        case "Text":
                                            drNewNote["Text"] = (string)NoteField.DataValue.Items[0];
                                            break;

                                        default:
                                            break;
                                    }
                                }

                                dtNotes.Rows.Add(drNewNote);
                            }

                        }
                    } // End of if(GetNotes)

                    return this.Object;
                }
                else
                {
                    MessageBox.Show("Could not find " + PackageName + "\\" + ObjectName + " Record ID " + ID + ".", "Database Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to retrieve " + PackageName + "\\" + ObjectName + " Record ID " + ID + ":\n" + ex.Message, "Database Error");
            }


            // Failure!
            return null;
        }

        public void Update(bool OnlyModifiedFields = true, RightNowSyncPortClient service = null, ClientInfoHeader cih = null)
        {
            // Use static CWS references if they're set and nothing is passed
            if ((service == null) && (CBO.service != null))
            {
                service = CBO.service;
            }
            if ((cih == null) && (CBO.cih != null))
            {
                cih = CBO.cih;
            }
            if ((service == null) || (cih == null))
            {
                throw new Exception("Service and ClientInfoHeader need to be passed to the method or be defined as static CBO properties!");
            }

            try
            {
                // Get the right update object
                GenericObject UpdateObject;
                if (OnlyModifiedFields)
                {
                    UpdateObject = ToObject(FieldSelection.OnlyModifiedFields);
                }
                else
                {
                    UpdateObject = ToObject(FieldSelection.AllEditableFields);
                }

                // Try to update object via CWS
                service.Update(cih, new RNObject[] { UpdateObject }, UpdateOptions);

                // Clear any modified fields
                ModifiedFields.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException.Message);
            }
        }

        public GenericObject Create(RightNowSyncPortClient service = null, ClientInfoHeader cih = null)
        {
            // Use static CWS references if they're set and nothing is passed
            if ((service == null) && (CBO.service != null))
            {
                service = CBO.service;
            }
            if ((cih == null) && (CBO.cih != null))
            {
                cih = CBO.cih;
            }
            if ((service == null) || (cih == null))
            {
                throw new Exception("Service and ClientInfoHeader need to be passed to the method or be defined as static CBO properties!");
            }

            try
            {
                // Prepare the object
                GenericObject CreateObject = ToObject(FieldSelection.OnlyModifiedFields);

                // Try to update object via CWS
                RNObject[] createResponses = service.Create(cih, new RNObject[] { CreateObject }, CreateOptions);

                // Get IDs
                if ((createResponses != null) && (createResponses.Length > 0))
                {
                    // Clear any modified fields
                    ModifiedFields.Clear();

                    // Return object
                    return (GenericObject)createResponses[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException.Message);
            }

            return null;
        }

        public bool Destroy(RightNowSyncPortClient service = null, ClientInfoHeader cih = null)
        {
            // Use static CWS references if they're set and nothing is passed
            if ((service == null) && (CBO.service != null))
            {
                service = CBO.service;
            }
            if ((cih == null) && (CBO.cih != null))
            {
                cih = CBO.cih;
            }
            if ((service == null) || (cih == null))
            {
                throw new Exception("Service and ClientInfoHeader need to be passed to the method or be defined as static CBO properties!");
            }

            try
            {
                // Prepare the object
                GenericObject DestroyObject = ToObject(FieldSelection.OnlyModifiedFields);

                // Try to update object via CWS
                service.Destroy(cih, new RNObject[] { DestroyObject }, DestroyOptions);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException.Message);
            }

            return false;
        }
        #endregion

        // Builds a GenericObject value to be used in CWS requests using the class properties
        public GenericObject ToObject(FieldSelection WhichFields = FieldSelection.AllFields)
        {
            // Build template for pulling
            GenericObject returnObject = new GenericObject()
            {
                ObjectType = new RNObjectType()
                {
                    Namespace = PackageName,
                    TypeName = ObjectName
                }
            };

            // Specify ID
            if (this.ID > 0)
            {
                returnObject.ID = new ID()
                {
                    id = this.ID,
                    idSpecified = true
                };
            }

            // ID-only
            if (WhichFields == FieldSelection.OnlyID)
            {
                return returnObject;
            }

            // Modified fields
            if (WhichFields == FieldSelection.OnlyModifiedFields)
            {
                returnObject.GenericFields = GetAllModifiedFields();
                return returnObject;
            }

            // All editable fields
            if (WhichFields == FieldSelection.AllEditableFields)
            {
                returnObject.GenericFields = removeFields(Fields.Values.ToArray(), StandardReadOnlyFields);
                return returnObject;
            }

            // All fields
            returnObject.GenericFields = Fields.Values.ToArray();
            return returnObject;
        }

        public T[] QueryObjectsWhere<T>(string WhereClause, int Limit = 10000) where T : CBO
        {
            try
            {
                GenericObject Template = this.ToObject(FieldSelection.AllFields);
                QueryResultData[] results = service.QueryObjects(cih, "SELECT " + PackageName + "." + ObjectName + " FROM " + PackageName + "." + ObjectName + " WHERE " + WhereClause, new RNObject[] { Template }, Limit);

                List<T> returnObjects = new List<T>();
                foreach (QueryResultData result in results)
                {
                    foreach (GenericObject go in result.RNObjectsResult)
                    {
                        returnObjects.Add(GenericObjectToCBO<T>(go));
                    }
                }
                return returnObjects.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GenericObjectToCBO<T>(GenericObject go) where T : CBO
        {
            T cboObject = (T)Activator.CreateInstance(typeof(T), new object[] { (int)go.ID.id });
            foreach (GenericField gf in go.GenericFields)
            {
                FieldTypes FieldType = FieldTypes.String;
                switch (gf.dataType)
                {
                    case DataTypeEnum.BOOLEAN:
                        FieldType = FieldTypes.Boolean;
                        break;

                    case DataTypeEnum.DATE:
                        FieldType = FieldTypes.Date;
                        break;

                    case DataTypeEnum.DATETIME:
                        FieldType = FieldTypes.DateTime;
                        break;

                    case DataTypeEnum.INTEGER:
                        FieldType = FieldTypes.Integer;
                        break;

                    case DataTypeEnum.NAMED_ID:
                        FieldType = FieldTypes.NamedID;
                        break;

                    case DataTypeEnum.STRING:
                        FieldType = FieldTypes.String;
                        break;

                    case DataTypeEnum.BASE64_BINARY:
                        FieldType = FieldTypes.TextArea;
                        break;

                }

                try
                {
                    cboObject.Set(gf.name, (gf.DataValue == null ? null : gf.DataValue.Items[0]), FieldType);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception while setting field " + gf.name + ": " + ex.Message);
                    throw ex;
                }
            }

            // Store full object
            cboObject.Object = go;
            cboObject.ModifiedFields.Clear(); // Unmark our fields

            return cboObject;
        }

        public GenericObject[] QueryObjectsWhere(string WhereClause, int Limit = 10000)
        {
            try
            {
                GenericObject Template = this.ToObject(FieldSelection.AllFields);
                QueryResultData[] results = service.QueryObjects(cih, "SELECT " + PackageName + "." + ObjectName + " FROM " + PackageName + "." + ObjectName + " WHERE " + WhereClause, new RNObject[] { Template }, Limit);

                List<GenericObject> returnObjects = new List<GenericObject>();
                foreach (QueryResultData result in results)
                {
                    foreach (GenericObject go in result.RNObjectsResult)
                    {
                        returnObjects.Add(go);
                    }
                }
                return returnObjects.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProcessCustomFields(GenericObject RecordCustomFields)
        {
            // Pull out the custom fields into a dictionary for easier access
            foreach (GenericField packageGF in RecordCustomFields.GenericFields)
            {
                string cfPackage = packageGF.name;
                if ((packageGF.DataValue != null) && (packageGF.DataValue.Items.Length > 0))
                {
                    GenericObject cfPackageObject = (GenericObject)packageGF.DataValue.Items[0];
                    if (cfPackageObject.GenericFields != null)
                    {
                        foreach (GenericField cfPackageField in cfPackageObject.GenericFields)
                        {
                            Fields.Add(cfPackage + "$" + cfPackageField.name, cfPackageField);
                        }
                    }
                }
            }
        }


        #region Static Methods - Field Finding
        public static GenericField extractField(GenericField[] allFields, string fieldName)
        {
            return allFields.Where(item => (item.name == fieldName)).FirstOrDefault();
        }

        public static GenericField[] extractFields(GenericField[] allFields, string[] fieldNames)
        {
            return allFields.Where(item => fieldNames.Contains(item.name)).ToArray();
        }

        public GenericField[] GetAllModifiedFields()
        {
            if (ModifiedFields.Count > 0)
            {
                return extractFields(Fields.Values.ToArray(), ModifiedFields.ToArray());
            }
            else
            {
                MessageBox.Show("No fields were modified!");
                return null;
            }
        }

        public static GenericField[] removeFields(GenericField[] allFields, string[] fieldNames)
        {
            return allFields.Except(extractFields(allFields, fieldNames)).ToArray();
        }

        #endregion

        #region Dynamic Method for Getting Property Name and Type
        // Delimiters for parsing
        private string[] split_GetPropertyName = new string[] { "GetPropertyName" };
        private string[] split_setget = new string[] { ".set_", ".get_", " ", "(", ")" };

        /// <summary>
        /// Uses the stack trace to extract the name and type (string representation, not Type) of the property being set or get
        /// </summary>
        /// <returns></returns>
        private string GetPropertyName()
        {
            string PropertyName = "";

            // Parse stack trace for name and type
            string stackTrace = Environment.StackTrace;
            string[] lines = stackTrace.Split(split_GetPropertyName, StringSplitOptions.None).Last().Split('\n');
            foreach (string line in lines)
            {
                if (line.Contains(".set_") || line.Contains(".get_"))
                {
                    string[] linepieces = line.Split(split_setget, StringSplitOptions.RemoveEmptyEntries);
                    PropertyName = linepieces[2];
                    break;
                }
            }

            return PropertyName;
        }
        #endregion

        #region Object Methods - Field Setting
        public string GetField<T>()
        {
            string PropertyName = GetPropertyName();
            Console.WriteLine("(GetField) " + PropertyName);
            return "";
        }

        /// <summary>
        /// Wrapper for Set that automatically looks up the property name being set.
        /// </summary>
        /// <param name="FieldValue"></param>
        /// <param name="FieldType"></param>
        public void Set(object FieldValue, FieldTypes FieldType)
        {
            Set(GetPropertyName(), FieldValue, FieldType);
        }

        public void Set(string FieldName, object FieldValue, FieldTypes FieldType)
        {
            // Build the new field
            GenericField newField = null;

            if (FieldType == FieldTypes.Boolean)
            {
                newField = BooleanField(FieldName, (bool?)FieldValue);
            }
            if (FieldType == FieldTypes.String)
            {
                newField = StringField(FieldName, (string)FieldValue);
            }
            if (FieldType == FieldTypes.Integer)
            {
                if (FieldValue != null)
                {
                    // For doubles and decimals, round
                    if (FieldValue.GetType().ToString() == "System.Double")
                    {
                        double originalValue = (double)FieldValue;
                        FieldValue = (int)Math.Round(originalValue, 0);
                    }
                }

                newField = IntegerField(FieldName, (int?)FieldValue);
            }
            if (FieldType == FieldTypes.Date)
            {
                newField = DateField(FieldName, (DateTime?)FieldValue);
            }
            if (FieldType == FieldTypes.DateTime)
            {
                newField = DateTimeField(FieldName, (DateTime?)FieldValue);
            }
            if (FieldType == FieldTypes.NamedID)
            {
                // A NamedID can accept an int (ID), a string (Name), or NamedID object
                if (FieldValue != null)
                {
                    if (FieldValue.GetType() == typeof(int))
                    {
                        // Use the ID
                        newField = NamedIDField(FieldName, (int)FieldValue);
                    }
                    else if (FieldValue.GetType() == typeof(NamedID))
                    {
                        // In case a NamedID is passed in, just use the ID
                        newField = NamedIDField(FieldName, (int?)((NamedID)FieldValue).ID.id);
                    }
                    else if (FieldValue.GetType() == typeof(string))
                    {
                        // Use the lookup name
                        newField = NamedIDField(FieldName, (string)FieldValue);
                    }
                }
                else
                {
                    // Null
                    newField = NamedIDField(FieldName, (int?)FieldValue);
                }
            }
            if (FieldType == FieldTypes.TextArea)
            {
                newField = TextAreaField(FieldName, (string)FieldValue);
            }

            // Add/Update fields
            if (Fields.ContainsKey(FieldName))
            {
                // Update field
                Fields[FieldName].DataValue = newField.DataValue;
            }
            else
            {
                // Add field
                Fields.Add(FieldName, newField);
            }

            // Indicate field was modified
            ModifiedFields.Add(FieldName);
        }
        public void AddNote(int ChannelID, string NoteText)
        {
            GenericField notesField;

            // Note field
            notesField = new GenericField()
            {
                name = "Notes",
                dataType = DataTypeEnum.OBJECT_LIST,
                dataTypeSpecified = true,
                DataValue = new DataValue()
            };

            // Note object
            GenericObject noteObject = new GenericObject()
            {
                ObjectType = new RNObjectType()
                {
                    Namespace = Object.ObjectType.Namespace,
                    TypeName = "Note"
                },
                GenericFields = new GenericField[] {
                    NamedIDField("Channel",ChannelID),
                    StringField("Text",NoteText)
                },
            };

            // Note object fields
            notesField.DataValue.Items = new GenericObject[] { noteObject };
            notesField.DataValue.ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.ObjectValueList };

            // Add / update the Notes field
            if (!Fields.ContainsKey("Notes"))
            {
                Fields.Add("Notes", notesField);
            }
            else
            {
                Fields["Notes"] = notesField;
            }

            // Update the object's fields
            // Object.GenericFields = objFields.ToArray();

            // Indicate Notes field was modified
            ModifiedFields.Add("Notes");
        }
        #endregion


        // Methods to get values and create fields
        #region Get<Type>FieldValue
        public object Get(FieldTypes FieldType)
        {
            return 0;
        }
        public string GetStringFieldValue(string FieldName = null)
        {
            if (FieldName == null) { FieldName = GetPropertyName(); }
            if (Fields[FieldName].DataValue != null)
            {
                return (string)Fields[FieldName].DataValue.Items[0];
            }
            else
            {
                return null;
            }
        }

        public int? GetIntegerFieldValue(string FieldName = null)
        {
            if (FieldName == null) { FieldName = GetPropertyName(); }
            if (Fields[FieldName].DataValue != null)
            {
                return (int)Fields[FieldName].DataValue.Items[0];
            }
            else
            {
                return null;
            }
        }

        public int? GetNamedIDFieldValue(string FieldName = null)
        {
            if (FieldName == null) { FieldName = GetPropertyName(); }
            if (Fields[FieldName].DataValue != null)
            {
                return (int)((NamedID)Fields[FieldName].DataValue.Items[0]).ID.id;
            }
            else
            {
                return null;
            }
        }

        public DateTime? GetDateTimeFieldValue(string FieldName = null)
        {
            if (FieldName == null) { FieldName = GetPropertyName(); }
            if (Fields[FieldName].DataValue != null)
            {
                return (DateTime)Fields[FieldName].DataValue.Items[0];
            }
            else
            {
                return null;
            }
        }

        public bool? GetBooleanFieldValue(string FieldName = null)
        {
            if (FieldName == null) { FieldName = GetPropertyName(); }
            if (Fields[FieldName].DataValue != null)
            {
                return (bool)Fields[FieldName].DataValue.Items[0];
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Static Methods - <Type>Field Generators
        public static GenericField ObjectField(string FieldName, object FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.OBJECT,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = (FieldValue == null ? null : new object[] { FieldValue }),
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.ObjectValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField NamedIDField(string FieldName, int? FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.NAMED_ID,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = (FieldValue == null ? null : new object[] {
                            new NamedID()
                            {
                                ID = new ID() {
                                    id = (int)FieldValue,
                                    idSpecified = true
                                }
                            }
                        }),
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.NamedIDValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField NamedIDField(string FieldName, string FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.NAMED_ID,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = (FieldValue == null ? null : new object[] {
                            new NamedID()
                            {
                                Name = FieldValue
                            }
                        }),
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.NamedIDValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField StringField(string FieldName, string FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.STRING,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.StringValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField IntegerField(string FieldName, int? FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.INTEGER,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.IntegerValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField DateTimeField(string FieldName, DateTime? FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.DATETIME,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.DateTimeValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField DateField(string FieldName, DateTime? FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.DATE,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.DateValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField BooleanField(string FieldName, bool? FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.BOOLEAN,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.BooleanValue }
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        public static GenericField TextAreaField(string FieldName, string FieldValue)
        {
            GenericField newField = new GenericField()
            {
                name = FieldName,
                dataType = DataTypeEnum.STRING, // BASE64_BINARY,
                dataTypeSpecified = true,
                DataValue = new DataValue()
                {
                    Items = new object[] { FieldValue },
                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.StringValue } // .Base64BinaryValue
                }
            };

            if (FieldValue == null)
            {
                newField.DataValue = null;
            }

            return newField;
        }
        #endregion


        #region Snapshots and Rollbacks
        // Create a snapshot for rollback purposes
        public void SnapshotCurrentFieldValues(string SnapshotName)
        {
            Dictionary<string, GenericField> FieldsSnapshot = CBO.DeepClone<Dictionary<string, GenericField>>(Fields);
            if (FieldSnapshots.ContainsKey(SnapshotName))
            {
                FieldSnapshots[SnapshotName] = FieldsSnapshot;
            }
            else
            {
                FieldSnapshots.Add(SnapshotName, FieldsSnapshot);
            }
        }

        // Restore fields from a snapshot
        public void RestoreSnapshot(string SnapshotName)
        {
            if (FieldSnapshots.ContainsKey(SnapshotName))
            {
                // Roll back to previous values
                Fields = FieldSnapshots[SnapshotName];
            }
            else
            {
                MessageBox.Show("Trying to restore an invalid snapshot of fields: " + SnapshotName);
            }
        }

        // Tool to help us create full clones of objects for snapshots
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
        #endregion
    }

    /// <summary>
    /// A slight derivative of the CBO type that simply predefines/enforces the Name
    /// field and offers a helper method to quickly load up menu item records.
    /// </summary>
    class MenuCBO : CBO
    {
        // Our constructor (get package and object name from class namespace and class name)
        public MenuCBO(int ID = 0)
            : base(ID)
        {
        }

        // Constructor
        public MenuCBO(string PackageName, string ObjectName, int ID = 0)
            : base(PackageName, ObjectName, ID)
        {
        }

        public string Name
        {
            set { Set("Name", value, FieldTypes.String); }
            get { return GetStringFieldValue("Name"); }
        }

        /// <summary>
        /// Quickly load a lookup table of existing menu items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<int, string> GetMenuItems<T>() where T : MenuCBO
        {
            // Our object to return
            Dictionary<int, string> MenuItems = new Dictionary<int, string>();

            // Create a template object with ID = 0
            T Template = (T)Activator.CreateInstance(typeof(T), new object[] { 0 });

            // Use our template to query for all menu item records
            T[] ExistingRecords = Template.QueryObjectsWhere<T>("1=1");

            // Remove any existing items
            foreach (T ExistingRecord in ExistingRecords)
            {
                //Console.WriteLine("Removing " + ExistingRecord.Name + " because it already exists!");
                MenuItems.Add(ExistingRecord.ID, ExistingRecord.Name);
            }

            // Return a dictionary with our current menu items
            return MenuItems;
        }

        /// <summary>
        /// Quicky import a list of menu items (skip existing ones)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="MenuItems"></param>
        public static void ImportMenuItems<T>(List<string> MenuItems) where T : MenuCBO
        {
            // Get existing records
            Dictionary<int, string> ExistingMenuItems = GetMenuItems<T>();

            // Remove any existing items from our import list
            foreach (string ExistingMenuItemName in ExistingMenuItems.Values)
            {
                //Console.WriteLine("Removing " + ExistingRecord.Name + " because it already exists!");
                MenuItems.Remove(ExistingMenuItemName);
            }

            // If there are any items left to create...
            if (MenuItems.Count > 0)
            {
                // Create the menu items and add the resulting GenericObject to a list
                List<GenericObject> CreateObjects = new List<GenericObject>();
                foreach (string MenuItem in MenuItems)
                {
                    T NewItem = (T)Activator.CreateInstance(typeof(T), new object[] { 0 });
                    NewItem.Name = MenuItem;
                    CreateObjects.Add(NewItem.ToObject(CBO.FieldSelection.OnlyModifiedFields));
                    //Console.WriteLine("Preparing " + NewItem.Name + " for creation!");
                }

                // Send all the GenericObjects in the list to the Create() operation
                //Console.WriteLine("Creating " + CreateObjects.Count + " records!");
                CBO.service.Create(CBO.cih, CreateObjects.ToArray(), new CreateProcessingOptions() { SuppressRules = true, SuppressExternalEvents = true });
                //Console.WriteLine("Finished!");
            }
            else
            {
                //Console.WriteLine("No records need to be created!");
            }
        }
    }

}
