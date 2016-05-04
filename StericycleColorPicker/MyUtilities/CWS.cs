namespace MyUtilities
{
    using MyUtilities.CWS_14_8;
    using RightNow.AddIns.AddInViews;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web.Services.Protocols;
    using System.Windows.Forms;

    public class CWS
    {
        public ClientInfoHeader _cih;
        public RightNowSyncPortClient _service;
        public Dictionary<string, object> GeneralCache;
        public Dictionary<string, MetaDataClass> MetaDataCache;

        public event QueryReturnedRowsEventHandler onQueryReturnedRows;
        
        public CWS(IGlobalContext globalContext)
        {
            this.MetaDataCache = new Dictionary<string, MetaDataClass>();
            this.GeneralCache = new Dictionary<string, object>();
            string uri = globalContext.InterfaceURL;
            if (uri.Contains(".cfg/php") || uri.Contains("http:"))
            {
                uri = uri.Replace("http:", "https:").Replace("/php/", "/services/soap");
            }
            EndpointAddress remoteAddress = new EndpointAddress(uri);
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.MaxBufferSize = 0x7fffffff;
            binding.MaxReceivedMessageSize = 0x7fffffffL;
            binding.ReaderQuotas.MaxStringContentLength = 0x7fffffff;
            this._service = new RightNowSyncPortClient(binding, remoteAddress);
            BindingElementCollection bindingElementsInTopDownChannelStackOrder = this._service.Endpoint.Binding.CreateBindingElements();
            bindingElementsInTopDownChannelStackOrder.Find<SecurityBindingElement>().IncludeTimestamp = false;
            this._service.Endpoint.Binding = new CustomBinding(bindingElementsInTopDownChannelStackOrder);
            globalContext.PrepareConnectSession(this._service.ChannelFactory);
            this._cih = new ClientInfoHeader();
            this._cih.AppID = "Thread Alternatives";
            this.AssociateCWSToCBO();
        }

        public CWS(string username, string password, string cwsURL = "")
        {
            this.MetaDataCache = new Dictionary<string, MetaDataClass>();
            this.GeneralCache = new Dictionary<string, object>();
            if (cwsURL.Contains(".cfg/php") || cwsURL.Contains("http:"))
            {
                cwsURL = cwsURL.Replace("http:", "https:");
                cwsURL = cwsURL.Replace("/php/", "/services/soap");
            }
            EndpointAddress remoteAddress = new EndpointAddress(cwsURL);
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.MaxBufferSize = 0x7fffffff;
            binding.MaxReceivedMessageSize = 0x7fffffffL;
            binding.ReaderQuotas.MaxStringContentLength = 0x7fffffff;
            this._service = new RightNowSyncPortClient(binding, remoteAddress);
            this._service.ClientCredentials.UserName.UserName = username;
            this._service.ClientCredentials.UserName.Password = password;
            BindingElementCollection bindingElementsInTopDownChannelStackOrder = this._service.Endpoint.Binding.CreateBindingElements();
            bindingElementsInTopDownChannelStackOrder.Find<SecurityBindingElement>().IncludeTimestamp = false;
            this._service.Endpoint.Binding = new CustomBinding(bindingElementsInTopDownChannelStackOrder);
            this._cih = new ClientInfoHeader();
            this._cih.AppID = "Thread Alternatives";
            this.AssociateCWSToCBO();
        }

        private void AssociateCWSToCBO()
        {
            CBO.cih = this._cih;
            CBO.service = this._service;
        }

        public int createObject(RNObject newObject, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            return (int) this.createObjects(new RNObject[] { newObject }, runExternalEvents, runBusinessRules)[0].ID.id;
        }

        public RNObject[] createObjects(RNObject[] newObjects, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            CreateProcessingOptions processingOptions = new CreateProcessingOptions {
                SuppressExternalEvents = !runExternalEvents,
                SuppressRules = !runBusinessRules
            };
            try
            {
                return this._service.Create(this._cih, newObjects, processingOptions);
            }
            catch (WebException exception)
            {
                throw exception;
                //Console.WriteLine("Web Exception:");
                //Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                throw exception2;
                //Console.WriteLine("Fault Exception:");
                //Console.WriteLine(exception2.Code);
                //Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                throw exception3;
                //Console.WriteLine(exception3.Code);
                //Console.WriteLine(exception3.Message);
            }
            return new RNObject[0];
        }

        public RunAnalyticsReportMsg CreateReportBatchItem(int reportID, int start = 0, int limit = 0x3e8, char delimiter = ',', AnalyticsReportFilter[] filters = null)
        {
            AnalyticsReport report = new AnalyticsReport();
            ID id = new ID {
                id = reportID,
                idSpecified = true
            };
            report.ID = id;
            if (filters != null)
            {
                report.Filters = filters;
            }
            CSVTableSet set = new CSVTableSet();
            string str = delimiter.ToString();
            return new RunAnalyticsReportMsg { AnalyticsReport = report, Delimiter = str, DisableMTOM = true, DisableMTOMSpecified = true, Limit = limit, LimitSpecified = true, ReturnRawResult = false, ReturnRawResultSpecified = true, Start = 0, StartSpecified = true };
        }

        public DataTable CSVTableSet2DataTable(CSVTableSet results)
        {
            DataTable appendTable = null;
            CSVTable[] cSVTables = null;
            cSVTables = results.CSVTables;
            if ((appendTable == null) && (cSVTables[0].Columns != null))
            {
                appendTable = new DataTable();
                string[] strArray = ParseCsvRow(cSVTables[0].Columns, ',');
                for (int i = 0; i < strArray.Length; i++)
                {
                    string name = strArray[i];
                    int num2 = 0;
                    while (appendTable.Columns.Contains(name))
                    {
                        num2++;
                        name = strArray[i] + "_" + num2.ToString();
                    }
                    appendTable.Columns.Add(name);
                }
            }
            if (appendTable == null)
            {
                return this.rows2DataTable(cSVTables[0].Rows, false, ',', null);
            }
            return this.rows2DataTable(cSVTables[0].Rows, false, ',', appendTable);
        }

        public bool deleteObject(RNObject newObject, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            return this.deleteObjects(new RNObject[] { newObject }, runExternalEvents, runBusinessRules);
        }

        public bool deleteObjects(RNObject[] newObjects, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            DestroyProcessingOptions processingOptions = new DestroyProcessingOptions {
                SuppressExternalEvents = !runExternalEvents,
                SuppressRules = !runBusinessRules
            };
            try
            {
                this._service.Destroy(this._cih, newObjects, processingOptions);
                return true;
            }
            catch (WebException exception)
            {
                throw exception;
                //Console.WriteLine("Web Exception:");
                //Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                throw exception2;
                //Console.WriteLine("Fault Exception:");
                //Console.WriteLine(exception2.Code);
                //Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                throw exception3;
                //Console.WriteLine(exception3.Code);
                //Console.WriteLine(exception3.Message);
            }
            return false;
        }

        public MetaDataClass getMetaDataFor(string MetaDataClassName)
        {
            if (!this.MetaDataCache.ContainsKey(MetaDataClassName))
            {
                string[] className = new string[] { MetaDataClassName };
                string[] metaDataLink = new string[0];
                RNObjectType[] qualifiedClassName = new RNObjectType[0];
                MetaDataClass class2 = this._service.GetMetaDataForClass(this._cih, className, qualifiedClassName, metaDataLink)[0];
                this.MetaDataCache.Add(MetaDataClassName, class2);
            }
            return this.MetaDataCache[MetaDataClassName];
        }

        public NamedIDWithParent[] getValuesForNamedIDHierarchy(string DataType)
        {
            List<CustomGenNamedIDHierarchy> genNamedIDHierarchy = new List<CustomGenNamedIDHierarchy>();
            NamedIDWithParent[] valuesForNamedIDHierarchy = this._service.GetValuesForNamedIDHierarchy(this._cih, DataType);
            return valuesForNamedIDHierarchy;
        }
        public DataTable getNamedIDs(string fieldName, string packageName)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            try
            {
                if (packageName.Trim() == "")
                {
                    packageName = null;
                }
                NamedID[] source = null;
                source = this._service.GetValuesForNamedID(this._cih, packageName, fieldName);
                if (source.Count<NamedID>() <= 0)
                {
                    return table;
                }
                foreach (NamedID did in source)
                {
                    DataRow row = table.NewRow();
                    row["ID"] = (int) did.ID.id;
                    row["Name"] = did.Name;
                    table.Rows.Add(row);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return table;
        }


        public QueryResultData[] getObjects(string query)
        {
            GetProcessingOptions options = new GetProcessingOptions {
                FetchAllNames = true
            };
            try
            {
                return this._service.QueryObjects(this._cih, query, new RNObject[0], 0x3e8);
            }
            catch (WebException exception)
            {
                throw exception;
                //Console.WriteLine("Web Exception:");
                //Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                throw exception2;
                //Console.WriteLine("Fault Exception:");
                //Console.WriteLine(exception2.Code);
                //Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                throw exception3;
                //Console.WriteLine(exception3.Code);
                //Console.WriteLine(exception3.Message);
            }
            return null;
        }
        /// <summary>
        /// Helper method for creating CWS SOAP Update Messages
        /// </summary>
        /// <param name="items"></param>
        /// <param name="supEE"></param>
        /// <param name="supRules"></param>
        /// <returns></returns>
        public  UpdateMsg CreateUpdateMessage(RNObject[] items, bool supEE = false, bool supRules = false)
        {
            UpdateMsg updateMsg = new UpdateMsg();
            UpdateProcessingOptions updateParentOptions = new UpdateProcessingOptions();
            updateParentOptions.SuppressExternalEvents = supEE;
            updateParentOptions.SuppressRules = supRules;

            updateMsg.RNObjects = items;

            return updateMsg;
        }
        public bool executeBatch(BatchRequestItem[] requests)
        {
            try
            {
                BatchResponseItem[] batchRes = this._service.Batch(this._cih, requests);
                foreach (BatchResponseItem response in batchRes)
                {
                    if (response.ItemElementName == ItemChoiceType.RequestErrorFault)
                    {
                        RequestErrorFaultType error = response.Item as RequestErrorFaultType;
                        throw new Exception(error.exceptionMessage);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        public QueryResultData[] getObjectsWithTemplates(string query, RNObject[] objectTemplates)
        {
            GetProcessingOptions options = new GetProcessingOptions
            {
                FetchAllNames = false
            };
            try
            {
                return this._service.QueryObjects(this._cih, query, objectTemplates, 0x3e8);
            }
            catch (WebException exception)
            {
                throw exception;
                //Console.WriteLine("Web Exception:");
                //Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                throw exception2;
                //Console.WriteLine("Fault Exception:");
                //Console.WriteLine(exception2.Code);
                //Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                throw exception3;
                //Console.WriteLine(exception3.Code);
                //Console.WriteLine(exception3.Message);
            }
            return null;
        }

        public AnalyticsReport getReportDefinition(int reportID)
        {
            AnalyticsReport report = new AnalyticsReport();
            ID id = new ID {
                id = reportID,
                idSpecified = true
            };
            report.ID = id;
            AnalyticsReportFilter filter = new AnalyticsReportFilter();
            report.Filters = new AnalyticsReportFilter[] { filter };
            GetProcessingOptions processingOptions = new GetProcessingOptions {
                FetchAllNames = true
            };
            RNObject[] rNObjects = new RNObject[] { report };
            return (AnalyticsReport) this._service.Get(this._cih, rNObjects, processingOptions)[0];
        }

        public static ID int2ID(int intID)
        {
            return new ID { id = intID, idSpecified = true };
        }

        private byte ParseByte(string val)
        {
            return byte.Parse(val);
        }

        public static string[] ParseCsvRow(string r, char delimiter = ',')
        {
            return CSVHelper.ParseCSVString(r, delimiter, '"', '"');
        }

        public void PopulateTreeView(TreeView TargetTree, string DataType, ProcessNodeCallbackDelegate processNodeMethod, ProgressBar pb)
        {
            UpdateProgressDelegate method = new UpdateProgressDelegate(this.UpdateProgressSafe);
            TargetTree.BeginUpdate();
            int num = 0;
            Dictionary<long, TreeNode> dictionary = new Dictionary<long, TreeNode>();
            try
            {
                TreeNode node;
                pb.Invoke(method, new object[] { pb, 1 });
                NamedIDWithParent[] valuesForNamedIDHierarchy = this._service.GetValuesForNamedIDHierarchy(this._cih, DataType);
                pb.Invoke(method, new object[] { pb, 5 });
                foreach (NamedIDWithParent parent in valuesForNamedIDHierarchy)
                {
                    node = new TreeNode {
                        Text = parent.Name,
                        Name = DataType + "." + parent.ID,
                        Tag = parent.ID
                    };
                    dictionary[parent.ID] = node;
                }
                foreach (NamedIDWithParent parent in valuesForNamedIDHierarchy)
                {
                    num++;
                    if ((num % 0x3e8) == 0)
                    {
                        int num2 = (int) Math.Ceiling((double) ((((double) num) / ((double) valuesForNamedIDHierarchy.Count<NamedIDWithParent>())) * 100.0));
                        pb.Invoke(method, new object[] { pb, num2 });
                    }
                    node = dictionary[parent.ID];
                    processNodeMethod(node);
                    if (TargetTree.Nodes.IndexOfKey(node.Name) <= 0)
                    {
                        if (parent.ParentID.ToString() == "")
                        {
                            TargetTree.Nodes.Add(node);
                        }
                        else
                        {
                            try
                            {
                                TreeNode node2 = dictionary[parent.ParentID.Value];
                                node2.Nodes.Add(node);
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine("ERR: Couldn't find parent for " + node.Text + " Id: " + node.Name + exception.Message);
                            }
                        }
                    }
                }
                pb.Invoke(method, new object[] { pb, 100 });
            }
            catch (FaultException exception2)
            {
                Console.WriteLine(exception2.Code);
                Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                Console.WriteLine(exception3.Code);
                Console.WriteLine(exception3.Message);
            }
            TargetTree.EndUpdate();
        }

        public DataTable quickQuery(string query, int limit = 0x2710, bool autoPaginate = true, QueryReturnedRowsEventHandler perQueryEventHandler = null, DataTable dtReturn = null)
        {
            CSVHelper.charEscapeQuote = '"';
            CSVHelper.chrEscapeQuote = CSVHelper.charEscapeQuote;
            CSVTable[] cSVTables = null;
            bool flag = true;
            string str = query;
            int num = 0;
            bool flag2 = str.Contains("ID_PAGINATION");
            bool flag3 = true;
            Regex regex = new Regex(" LIMIT ([0-9]+)");
            Regex regex2 = new Regex(" OFFSET ([0-9]+)");
            Match match = regex.Match(query);
            Match match2 = regex2.Match(query);
            if (match.Success)
            {
                limit = int.Parse(match.Groups[1].Value);
                query = query.Replace(match.Value, "");
                flag3 = false;
            }
            if (match2.Success)
            {
                num = int.Parse(match2.Groups[1].Value);
                query = query.Replace(match2.Value, "");
            }
            str = query;
            while (flag)
            {
                if (autoPaginate)
                {
                    if (flag2)
                    {
                        query = str.Replace("ID_PAGINATION", "ID >= " + num);
                    }
                    else
                    {
                        query = string.Concat(new object[] { str, " LIMIT ", limit, " OFFSET ", num });
                    }
                }
                try
                {
                    byte[] buffer;
                    CSVTableSet results = this._service.QueryCSV(this._cih, query, limit, ",", false, false, out buffer);
                    cSVTables = results.CSVTables;
                    dtReturn = this.CSVTableSet2DataTable(results);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Fault Exception:");
                }
                if (autoPaginate)
                {
                    if (cSVTables[0].Rows.Count<string>() == limit)
                    {
                        if (flag2)
                        {
                            num = int.Parse(cSVTables[0].Rows[cSVTables[0].Rows.Length - 1].Split(new char[] { ',' })[0]);
                            int num2 = dtReturn.Rows.Count - 1;
                            string str2 = dtReturn.Rows[num2][0].ToString();
                            for (string str3 = str2; str3 == str2; str3 = dtReturn.Rows[num2][0].ToString())
                            {
                                dtReturn.Rows[num2].Delete();
                                num2--;
                            }
                        }
                        else
                        {
                            num += limit;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                }
                QueryReturnedRowsEventArgs e = new QueryReturnedRowsEventArgs(cSVTables[0].Rows.Count<string>(), dtReturn, !flag);
                if (perQueryEventHandler != null)
                {
                    bool flag4 = perQueryEventHandler(this, e);
                    if (!(!flag || flag4))
                    {
                        flag = false;
                    }
                }
                if (!flag3)
                {
                    flag = false;
                }
                this.raiseEvent_onQueryReturnedRows(e);
            }
            return dtReturn;
        }

        protected virtual void raiseEvent_onQueryReturnedRows(QueryReturnedRowsEventArgs e)
        {
            if (this.onQueryReturnedRows != null)
            {
                this.onQueryReturnedRows(this, e);
            }
        }

        private DataTable rows2DataTable(string[] rows, bool hasHeader = true, char delimiter = ',', DataTable appendTable = null)
        {
            DataTable table;
            int num2;
            if (rows.Length == 0)
            {
                throw new Exception("No data!");
            }
            int num = hasHeader ? 1 : 0;
            if (appendTable == null)
            {
                table = new DataTable();
                if (hasHeader)
                {
                    string[] strArray = rows[0].Split(new char[] { delimiter });
                    foreach (string str in strArray)
                    {
                        table.Columns.Add(str, typeof(string));
                    }
                }
                else
                {
                    string[] strArray2 = rows[0].Split(new char[] { delimiter });
                    for (num2 = 0; num2 < strArray2.Length; num2++)
                    {
                        table.Columns.Add("f" + num2.ToString(), typeof(string));
                    }
                }
            }
            else
            {
                table = appendTable;
            }
            for (num2 = num; num2 < rows.Length; num2++)
            {
                string[] strArray3 = rows[num2].Split(new char[] { delimiter });
                DataRow row = table.NewRow();
                if (strArray3.Length > row.ItemArray.Length)
                {
                    strArray3 = CSVHelper.ParseCSVString(rows[num2], delimiter, '"', '"');
                    if (strArray3.Length > row.ItemArray.Length)
                    {
                        strArray3 = CSVHelper.ParseCSVString(rows[num2], delimiter, '"', '\\');
                    }
                }
                for (int i = 0; i < strArray3.Length; i++)
                {
                    Exception exception;
                    string str2 = table.Columns[i].DataType.ToString();
                    if (str2 != null)
                    {
                        if (!(str2 == "System.Byte"))
                        {
                            if (str2 == "System.Int16")
                            {
                                goto Label_0258;
                            }
                            if (str2 == "System.Int32")
                            {
                                goto Label_02BC;
                            }
                            if (str2 == "System.String")
                            {
                                goto Label_031D;
                            }
                        }
                        else if (strArray3[i] == "")
                        {
                            row[i] = 0;
                        }
                        else
                        {
                            try
                            {
                                row[i] = byte.Parse(strArray3[i]);
                            }
                            catch (Exception exception1)
                            {
                                exception = exception1;
                                row[i] = 0;
                            }
                        }
                    }
                    continue;
                Label_0258:
                    if (strArray3[i] == "")
                    {
                        row[i] = 0;
                    }
                    else
                    {
                        try
                        {
                            row[i] = short.Parse(strArray3[i]);
                        }
                        catch (Exception exception2)
                        {
                            exception = exception2;
                            row[i] = 0;
                        }
                    }
                    continue;
                Label_02BC:
                    if (strArray3[i] == "")
                    {
                        row[i] = 0;
                    }
                    else
                    {
                        try
                        {
                            row[i] = int.Parse(strArray3[i]);
                        }
                        catch (Exception exception3)
                        {
                            exception = exception3;
                            row[i] = 0;
                        }
                    }
                    continue;
                Label_031D:
                    row[i] = strArray3[i];
                }
                table.Rows.Add(row);
            }
            return table;
        }

        public DataTable runReport(int reportID, int start = 0, int limit = 0x3e8, char delimiter = ',', AnalyticsReportFilter[] filters = null)
        {
            byte[] buffer;
            AnalyticsReport analyticsReport = new AnalyticsReport();
            ID id = new ID {
                id = reportID,
                idSpecified = true
            };
            analyticsReport.ID = id;
            if (filters != null)
            {
                analyticsReport.Filters = filters;
            }
            CSVTableSet set = new CSVTableSet();
            string str = delimiter.ToString();
            CSVTable[] cSVTables = this._service.RunAnalyticsReport(this._cih, analyticsReport, limit, start, str, false, false, out buffer).CSVTables;
            DataTable appendTable = new DataTable("Report " + reportID);
            string[] strArray = ParseCsvRow(cSVTables[0].Columns, ',');
            foreach (string str2 in strArray)
            {
                appendTable.Columns.Add(str2);
            }
            if (cSVTables[0].Rows.Length > 0)
            {
                appendTable = this.rows2DataTable(cSVTables[0].Rows, false, delimiter, appendTable);
            }
            return appendTable;
        }

        public Dictionary<int, DataTable> RunReportBatch(BatchRequestItem[] ReportBatchItems, char delimiter = ',')
        {
            Dictionary<int, DataTable> dictionary = new Dictionary<int, DataTable>();
            BatchResponseItem[] itemArray = this._service.Batch(this._cih, ReportBatchItems);
            for (int i = 0; i < itemArray.Length; i++)
            {
                BatchResponseItem item = itemArray[i];
                if (item.Item != null)
                {
                    try
                    {
                        if (item.Item.GetType().Name == "RunAnalyticsReportResponseMsg")
                        {
                            RunAnalyticsReportResponseMsg msg = (RunAnalyticsReportResponseMsg) item.Item;
                            CSVTable[] cSVTables = msg.CSVTableSet.CSVTables;
                            DataTable appendTable = new DataTable("Report " + msg.CSVTableSet.CSVTables[0].Name);
                            string[] strArray = ParseCsvRow(cSVTables[0].Columns, ',');
                            foreach (string str in strArray)
                            {
                                appendTable.Columns.Add(str);
                            }
                            if (cSVTables[0].Rows.Length == 0)
                            {
                                dictionary[i] = appendTable;
                            }
                            else
                            {
                                dictionary[i] = this.rows2DataTable(cSVTables[0].Rows, false, delimiter, appendTable);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Something other than RunAnalyticsReportResponseMsg returned in response.");
                        }
                    }
                    catch (Exception exception)
                    {
                        throw exception;
                    }
                }
            }
            return dictionary;
        }

        public bool updateObject(RNObject newObject, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            return this.updateObjects(new RNObject[] { newObject }, runExternalEvents, runBusinessRules);
        }

        public bool SendMailingToContact(ID ContactID, ID MailingID, DateTime? ScheduledTime, ID IncidentID, ID OpportunityID, ID ChatID)
        {
            try
            {
                this._service.SendMailingToContact(this._cih, ContactID, MailingID, ScheduledTime, IncidentID, OpportunityID, ChatID);
                return true;
            }
            catch (WebException exception)
            {
                Console.WriteLine("Web Exception:");
                Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                Console.WriteLine("Fault Exception:");
                Console.WriteLine(exception2.Code);
                Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                Console.WriteLine(exception3.Code);
                Console.WriteLine(exception3.Message);
            }
            catch (Exception expection4)
            {
                Console.WriteLine(expection4.Source);
                Console.WriteLine(expection4.Message);
            }
            return false;     
        }
        public bool updateObjects(RNObject[] newObjects, bool runExternalEvents = false, bool runBusinessRules = false)
        {
            UpdateProcessingOptions processingOptions = new UpdateProcessingOptions {
                SuppressExternalEvents = !runExternalEvents,
                SuppressRules = !runBusinessRules
            };
            try
            {
                this._service.Update(this._cih, newObjects, processingOptions);
                return true;
            }
            catch (WebException exception)
            {
                throw exception;
                //Console.WriteLine("Web Exception:");
                //Console.WriteLine(exception.Message);
            }
            catch (FaultException exception2)
            {
                throw exception2;
                //Console.WriteLine("Fault Exception:");
                //Console.WriteLine(exception2.Code);
                //Console.WriteLine(exception2.Message);
            }
            catch (SoapException exception3)
            {
                throw exception3;
                //Console.WriteLine(exception3.Code);
                //Console.WriteLine(exception3.Message);
            }
            return false;
        }

        public void UpdateProgressSafe(ProgressBar pb, int value)
        {
            pb.Value = value;
        }

        public class CustomObject
        {
            private Dictionary<string, MetaDataAttribute> attributeLookupTable;
            public CreateProcessingOptions cpo;
            private CWS cwsInstance;
            private List<GenericField> fields;
            private GetProcessingOptions gpo;
            public int ID = 0;
            private MetaDataClass metaData;
            public bool newObject = true;
            public GenericObject obj;
            private RNObjectType objType;
            public UpdateProcessingOptions upo;

            public CustomObject(CWS CWSInstance, string CustomObjectName, int LoadID = 0)
            {
                this.cwsInstance = CWSInstance;
                string[] strArray = CustomObjectName.Split(new char[] { '\\' });
                this.obj = new GenericObject();
                this.objType = new RNObjectType();
                this.objType.Namespace = strArray[0];
                this.objType.TypeName = strArray[1];
                this.obj.ObjectType = this.objType;
                if (this.cwsInstance.MetaDataCache.ContainsKey(CustomObjectName))
                {
                    this.metaData = this.cwsInstance.MetaDataCache[CustomObjectName];
                }
                else
                {
                    string[] className = new string[] { this.objType.Namespace + "." + this.objType.TypeName };
                    string[] metaDataLink = new string[0];
                    RNObjectType[] qualifiedClassName = new RNObjectType[0];
                    try
                    {
                        MetaDataClass[] classArray = this.cwsInstance._service.GetMetaDataForClass(this.cwsInstance._cih, className, qualifiedClassName, metaDataLink);
                        this.metaData = classArray[0];
                        this.cwsInstance.MetaDataCache.Add(CustomObjectName, this.metaData);
                    }
                    catch (Exception exception)
                    {
                        throw new Exception(exception.Message);
                    }
                }
                if (this.cwsInstance.GeneralCache.ContainsKey(CustomObjectName + "_AttributesLookup"))
                {
                    this.attributeLookupTable = (Dictionary<string, MetaDataAttribute>) this.cwsInstance.GeneralCache[CustomObjectName + "_AttributesLookup"];
                }
                else
                {
                    this.attributeLookupTable = new Dictionary<string, MetaDataAttribute>();
                    foreach (MetaDataAttribute attribute in this.metaData.Attributes)
                    {
                        this.attributeLookupTable.Add(attribute.Name, attribute);
                    }
                    this.cwsInstance.GeneralCache.Add(CustomObjectName + "_AttributesLookup", this.attributeLookupTable);
                }
                if (!((LoadID != 0) && this.LoadByID(LoadID)))
                {
                    this.fields = new List<GenericField>();
                    this.cpo = new CreateProcessingOptions();
                    this.cpo.SuppressExternalEvents = false;
                    this.cpo.SuppressRules = false;
                }
            }

            private GenericField createGenericField(string Name, ItemsChoiceType itemsChoiceType, object Value)
            {
                GenericField field = new GenericField {
                    name = Name,
                    DataValue = new DataValue()
                };
                field.DataValue.Items = new object[] { Value };
                field.DataValue.ItemsElementName = new ItemsChoiceType[] { itemsChoiceType };
                return field;
            }

            public bool LoadByID(int IDToLoad)
            {
                this.obj.ID = new MyUtilities.CWS_14_8.ID();
                this.obj.ID.id = IDToLoad;
                this.obj.ID.idSpecified = true;
                this.gpo = new GetProcessingOptions();
                this.gpo.FetchAllNames = false;
                RNObject[] objArray = this.cwsInstance._service.Get(this.cwsInstance._cih, new RNObject[] { this.obj }, this.gpo);
                if ((objArray != null) && (objArray.Length > 0))
                {
                    this.obj = (GenericObject) objArray[0];
                    this.fields = this.obj.GenericFields.ToList<GenericField>();
                    this.upo = new UpdateProcessingOptions();
                    this.upo.SuppressExternalEvents = false;
                    this.upo.SuppressRules = false;
                    this.newObject = false;
                    this.ID = IDToLoad;
                    return true;
                }
                return false;
            }

            public void PrepareForSave()
            {
                try
                {
                    List<GenericField> list = new List<GenericField>();
                    foreach (GenericField field in this.fields)
                    {
                        MetaDataAttribute attribute = this.attributeLookupTable[field.name];
                        if (this.newObject)
                        {
                            if (attribute.UsageOnCreate != MetaDataUsageEnum.NOT_ALLOWED)
                            {
                                list.Add(field);
                            }
                        }
                        else if (attribute.UsageOnUpdate != MetaDataUsageEnum.NOT_ALLOWED)
                        {
                            list.Add(field);
                        }
                    }
                    this.obj.GenericFields = list.ToArray();
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }

            private void RemoveField(string fieldName)
            {
                if (this.fields.Count > 0)
                {
                    foreach (GenericField field in this.fields)
                    {
                        if (field.name == fieldName)
                        {
                            this.fields.Remove(field);
                            break;
                        }
                    }
                }
            }

            public int Save()
            {
                this.PrepareForSave();
                try
                {
                    RNObject[] objArray;
                    if (this.newObject)
                    {
                        objArray = this.cwsInstance._service.Create(this.cwsInstance._cih, new RNObject[] { this.obj }, this.cpo);
                    }
                    else
                    {
                        this.cwsInstance._service.Update(this.cwsInstance._cih, new RNObject[] { this.obj }, this.upo);
                        objArray = new RNObject[] { new GenericObject() };
                    }
                    if ((objArray != null) && (objArray.Length > 0))
                    {
                        foreach (GenericObject obj2 in objArray)
                        {
                            if ((obj2 != null) && (obj2.ID != null))
                            {
                                this.ID = (int) obj2.ID.id;
                                Console.WriteLine(string.Concat(new object[] { "*** Created ", obj2.GetType().ToString(), " with ID ", obj2.ID.id }));
                            }
                        }
                    }
                }
                catch (FaultException exception)
                {
                    throw exception;
                    //MessageBox.Show(exception.Message);
                }
                catch (Exception exception2)
                {
                    throw exception2;
                    //MessageBox.Show(exception2.Message);
                }
                return this.ID;
            }

            public void SetBooleanField(string fieldName, bool value)
            {
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.BooleanValue, value));
            }

            public void SetDateField(string fieldName, DateTime value)
            {
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.DateValue, value.ToString("s").Substring(0, 10) + "Z"));
            }

            public void SetDateTimeField(string fieldName, DateTime value)
            {
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.DateTimeValue, value.ToString("s") + "Z"));
            }

            public void SetField(string fieldName, object value)
            {
                if (!this.attributeLookupTable.ContainsKey(fieldName))
                {
                    throw new Exception("Field name " + fieldName + " is invalid!");
                }
                MetaDataAttribute attribute = this.attributeLookupTable[fieldName];
                this.RemoveField(fieldName);
                switch (attribute.DataType)
                {
                    case DataTypeEnum.BOOLEAN:
                        this.SetBooleanField(fieldName, (bool) value);
                        return;

                    case DataTypeEnum.DATE:
                        this.SetDateField(fieldName, (DateTime) value);
                        return;

                    case DataTypeEnum.DATETIME:
                        this.SetDateTimeField(fieldName, (DateTime) value);
                        return;

                    case DataTypeEnum.INTEGER:
                        this.SetIntegerField(fieldName, Convert.ToInt32(value));
                        return;

                    case DataTypeEnum.LONG:
                        this.SetIntegerField(fieldName, Convert.ToInt32(value));
                        return;

                    case DataTypeEnum.NAMED_ID:
                        if (!(value.GetType().ToString() == "System.String"))
                        {
                            this.SetMenuField(fieldName, Convert.ToInt32(value));
                            return;
                        }
                        this.SetMenuField(fieldName, (string) value);
                        return;

                    case DataTypeEnum.STRING:
                        this.SetStringField(fieldName, (string) value);
                        return;
                }
                throw new Exception("Unsupported type!");
            }

            public void SetIntegerField(string fieldName, int value)
            {
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.IntegerValue, value));
            }

            public void SetMenuField(string fieldName, int value)
            {
                NamedID did = new NamedID {
                    ID = new MyUtilities.CWS_14_8.ID()
                };
                did.ID.id = value;
                did.ID.idSpecified = true;
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.NamedIDValue, did));
            }

            public void SetMenuField(string fieldName, string value)
            {
                NamedID[] didArray = null;
                string key = this.objType.Namespace + @"\" + this.objType.TypeName + "." + fieldName + "_NamedIDValues";
                if (this.cwsInstance.GeneralCache.ContainsKey(key))
                {
                    didArray = (NamedID[]) this.cwsInstance.GeneralCache[key];
                }
                else
                {
                    didArray = this.cwsInstance._service.GetValuesForNamedID(this.cwsInstance._cih, this.objType.Namespace, this.objType.TypeName + "." + fieldName);
                    this.cwsInstance.GeneralCache.Add(key, didArray);
                }
                bool flag = false;
                string str2 = "";
                Regex regex = new Regex("[^a-z]");
                foreach (NamedID did in didArray)
                {
                    if (did.Name == value)
                    {
                        flag = true;
                        this.SetMenuField(fieldName, (int) did.ID.id);
                    }
                    else if (regex.Replace(did.Name.ToLower(), "") == regex.Replace(value.ToLower(), ""))
                    {
                        str2 = str2 + "\"" + did.Name + "\"\r\n";
                    }
                }
                if (!flag)
                {
                    if (str2.Length > 0)
                    {
                        throw new Exception("\"" + value + "\"  was not a valid menu option for " + this.objType.Namespace + @"\" + this.objType.TypeName + "." + fieldName + " but similar matches were found:\r\n" + str2);
                    }
                    throw new Exception("\"" + value + "\" was not a valid menu option for " + this.objType.Namespace + @"\" + this.objType.TypeName + "." + fieldName);
                }
            }

            public void SetStringField(string fieldName, string value)
            {
                this.fields.Add(this.createGenericField(fieldName, ItemsChoiceType.StringValue, value));
            }
        }

        public class CustomObjectBatch
        {
            private bool autosave;
            private CreateProcessingOptions cpo;
            private List<GenericObject> createObjects = new List<GenericObject>();
            private int itemCount = 0;
            private int itemLimit = 0x3e8;
            private Profiler profiler = new Profiler("CustomObjectBatch Load");
            private bool resetOnSave;
            private CWS soap;
            private List<GenericObject> updateObjects = new List<GenericObject>();
            private UpdateProcessingOptions upo;

            public CustomObjectBatch(CWS SoapInstance, bool AutoSave = false, bool ResetOnSave = true)
            {
                this.soap = SoapInstance;
                this.autosave = AutoSave;
                this.resetOnSave = ResetOnSave;
            }

            public void Add(CWS.CustomObject CustomObject, bool InheritProcessingOptions = true)
            {
                if (this.itemCount == this.itemLimit)
                {
                    throw new Exception("Batch is full and must be saved before any more items can be added!");
                }
                if (CustomObject.newObject)
                {
                    this.createObjects.Add(CustomObject.obj);
                    if (InheritProcessingOptions)
                    {
                        this.cpo = CustomObject.cpo;
                    }
                }
                else
                {
                    this.updateObjects.Add(CustomObject.obj);
                    if (InheritProcessingOptions)
                    {
                        this.upo = CustomObject.upo;
                    }
                }
                this.itemCount++;
                if ((this.itemCount == this.itemLimit) && this.autosave)
                {
                    this.Save();
                }
            }

            public RNObject[] Save()
            {
                RNObject[] objArray = null;
                if (this.createObjects.Count > 0)
                {
                    RNObject[] rNObjects = this.createObjects.ToArray();
                    objArray = this.soap._service.Create(this.soap._cih, rNObjects, this.cpo);
                }
                if (this.updateObjects.Count > 0)
                {
                    RNObject[] objArray3 = this.updateObjects.ToArray();
                    this.soap._service.Update(this.soap._cih, objArray3, this.upo);
                }
                if (this.resetOnSave)
                {
                    this.createObjects.Clear();
                    this.updateObjects.Clear();
                    this.itemCount = 0;
                }
                return objArray;
            }
        }

        private delegate object DataHandler(string val);

        public delegate void ProcessNodeCallbackDelegate(TreeNode node);

        public class QueryReturnedRowsEventArgs : EventArgs
        {
            private System.Data.DataTable dataTable = null;
            private bool finishedQuerying = false;
            private int numRows = 0;

            public QueryReturnedRowsEventArgs(int _numRows, System.Data.DataTable _dataTable, bool _finishedQuerying)
            {
                this.numRows = _numRows;
                this.dataTable = _dataTable;
                this.finishedQuerying = _finishedQuerying;
            }

            public System.Data.DataTable DataTable
            {
                get
                {
                    return this.dataTable;
                }
            }

            public bool FinishedQuery
            {
                get
                {
                    return this.finishedQuerying;
                }
            }

            public int RowsReturned
            {
                get
                {
                    return this.numRows;
                }
            }

            public int RowsTotal
            {
                get
                {
                    return this.dataTable.Rows.Count;
                }
            }
        }

       

        public delegate bool QueryReturnedRowsEventHandler(object sender, CWS.QueryReturnedRowsEventArgs e);

        public delegate void UpdateProgressDelegate(ProgressBar pb, int value);
    }
}

