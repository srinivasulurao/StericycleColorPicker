namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class Organization : RNObject
    {
        private TypedAddress[] addressesField;
        private MyUtilities.CWS_14_8.Banner bannerField;
        private MyUtilities.CWS_14_8.CRMModules cRMModulesField;
        private GenericObject customFieldsField;
        private FileAttachmentCommon[] fileAttachmentsField;
        private NamedID industryField;
        private string loginField;
        private string nameField;
        private string nameFuriganaField;
        private string newPasswordField;
        private Note[] notesField;
        private int? numberOfEmployeesField;
        private bool numberOfEmployeesFieldSpecified;
        private NamedID[] organizationHierarchyField;
        private NamedIDHierarchy parentField;
        private OrganizationSalesSettings salesSettingsField;
        private OrganizationServiceSettings serviceSettingsField;
        private NamedIDHierarchy sourceField;
        private OrganizationNullFields validNullFieldsField;

        [XmlArrayItem("TypedAddressList", IsNullable=false), XmlArray(IsNullable=true, Order=0)]
        public TypedAddress[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
                base.RaisePropertyChanged("Addresses");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public MyUtilities.CWS_14_8.Banner Banner
        {
            get
            {
                return this.bannerField;
            }
            set
            {
                this.bannerField = value;
                base.RaisePropertyChanged("Banner");
            }
        }

        [XmlElement(Order=2)]
        public MyUtilities.CWS_14_8.CRMModules CRMModules
        {
            get
            {
                return this.cRMModulesField;
            }
            set
            {
                this.cRMModulesField = value;
                base.RaisePropertyChanged("CRMModules");
            }
        }

        [XmlElement(Order=3)]
        public GenericObject CustomFields
        {
            get
            {
                return this.customFieldsField;
            }
            set
            {
                this.customFieldsField = value;
                base.RaisePropertyChanged("CustomFields");
            }
        }

        [XmlArray(IsNullable=true, Order=4), XmlArrayItem("FileAttachmentList", IsNullable=false)]
        public FileAttachmentCommon[] FileAttachments
        {
            get
            {
                return this.fileAttachmentsField;
            }
            set
            {
                this.fileAttachmentsField = value;
                base.RaisePropertyChanged("FileAttachments");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public NamedID Industry
        {
            get
            {
                return this.industryField;
            }
            set
            {
                this.industryField = value;
                base.RaisePropertyChanged("Industry");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public string Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
                base.RaisePropertyChanged("Login");
            }
        }

        [XmlElement(Order=7)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
        public string NameFurigana
        {
            get
            {
                return this.nameFuriganaField;
            }
            set
            {
                this.nameFuriganaField = value;
                base.RaisePropertyChanged("NameFurigana");
            }
        }

        [XmlElement(IsNullable=true, Order=9)]
        public string NewPassword
        {
            get
            {
                return this.newPasswordField;
            }
            set
            {
                this.newPasswordField = value;
                base.RaisePropertyChanged("NewPassword");
            }
        }

        [XmlArrayItem("NoteList", IsNullable=false), XmlArray(IsNullable=true, Order=10)]
        public Note[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
                base.RaisePropertyChanged("Notes");
            }
        }

        [XmlElement(IsNullable=true, Order=11)]
        public int? NumberOfEmployees
        {
            get
            {
                return this.numberOfEmployeesField;
            }
            set
            {
                this.numberOfEmployeesField = value;
                base.RaisePropertyChanged("NumberOfEmployees");
            }
        }

        [XmlIgnore]
        public bool NumberOfEmployeesSpecified
        {
            get
            {
                return this.numberOfEmployeesFieldSpecified;
            }
            set
            {
                this.numberOfEmployeesFieldSpecified = value;
                base.RaisePropertyChanged("NumberOfEmployeesSpecified");
            }
        }

        [XmlArray(Order=12), XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedID[] OrganizationHierarchy
        {
            get
            {
                return this.organizationHierarchyField;
            }
            set
            {
                this.organizationHierarchyField = value;
                base.RaisePropertyChanged("OrganizationHierarchy");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public NamedIDHierarchy Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
                base.RaisePropertyChanged("Parent");
            }
        }

        [XmlElement(Order=14)]
        public OrganizationSalesSettings SalesSettings
        {
            get
            {
                return this.salesSettingsField;
            }
            set
            {
                this.salesSettingsField = value;
                base.RaisePropertyChanged("SalesSettings");
            }
        }

        [XmlElement(Order=15)]
        public OrganizationServiceSettings ServiceSettings
        {
            get
            {
                return this.serviceSettingsField;
            }
            set
            {
                this.serviceSettingsField = value;
                base.RaisePropertyChanged("ServiceSettings");
            }
        }

        [XmlElement(Order=0x10)]
        public NamedIDHierarchy Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                base.RaisePropertyChanged("Source");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public OrganizationNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

