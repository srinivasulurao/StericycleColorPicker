namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class Contact : RNObject
    {
        private MyUtilities.CWS_14_8.Address addressField;
        private MyUtilities.CWS_14_8.Banner bannerField;
        private ChannelUsername[] channelUsernamesField;
        private NamedID contactTypeField;
        private MyUtilities.CWS_14_8.CRMModules cRMModulesField;
        private GenericObject customFieldsField;
        private bool disabledField;
        private bool disabledFieldSpecified;
        private Email[] emailsField;
        private FileAttachmentCommon[] fileAttachmentsField;
        private string loginField;
        private ContactMarketingSettings marketingSettingsField;
        private PersonName nameField;
        private PersonName nameFuriganaField;
        private string newPasswordField;
        private Note[] notesField;
        private ContactOpenIDAccount[] openIDAccountsField;
        private NamedID organizationField;
        private DateTime? passwordEmailExpirationTimeField;
        private bool passwordEmailExpirationTimeFieldSpecified;
        private DateTime? passwordExpirationTimeField;
        private bool passwordExpirationTimeFieldSpecified;
        private Phone[] phonesField;
        private ContactSalesSettings salesSettingsField;
        private ContactServiceSettings serviceSettingsField;
        private NamedIDHierarchy sourceField;
        private string titleField;
        private ContactNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public MyUtilities.CWS_14_8.Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                base.RaisePropertyChanged("Address");
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

        [XmlArray(IsNullable=true, Order=2), XmlArrayItem("ChannelUsernameList", IsNullable=false)]
        public ChannelUsername[] ChannelUsernames
        {
            get
            {
                return this.channelUsernamesField;
            }
            set
            {
                this.channelUsernamesField = value;
                base.RaisePropertyChanged("ChannelUsernames");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID ContactType
        {
            get
            {
                return this.contactTypeField;
            }
            set
            {
                this.contactTypeField = value;
                base.RaisePropertyChanged("ContactType");
            }
        }

        [XmlElement(Order=4)]
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

        [XmlElement(Order=5)]
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

        [XmlElement(Order=6)]
        public bool Disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
                base.RaisePropertyChanged("Disabled");
            }
        }

        [XmlIgnore]
        public bool DisabledSpecified
        {
            get
            {
                return this.disabledFieldSpecified;
            }
            set
            {
                this.disabledFieldSpecified = value;
                base.RaisePropertyChanged("DisabledSpecified");
            }
        }

        [XmlArray(IsNullable=true, Order=7), XmlArrayItem("EmailList", IsNullable=false)]
        public Email[] Emails
        {
            get
            {
                return this.emailsField;
            }
            set
            {
                this.emailsField = value;
                base.RaisePropertyChanged("Emails");
            }
        }

        [XmlArrayItem("FileAttachmentList", IsNullable=false), XmlArray(IsNullable=true, Order=8)]
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

        [XmlElement(IsNullable=true, Order=9)]
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

        [XmlElement(Order=10)]
        public ContactMarketingSettings MarketingSettings
        {
            get
            {
                return this.marketingSettingsField;
            }
            set
            {
                this.marketingSettingsField = value;
                base.RaisePropertyChanged("MarketingSettings");
            }
        }

        [XmlElement(Order=11)]
        public PersonName Name
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

        [XmlElement(Order=12)]
        public PersonName NameFurigana
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

        [XmlElement(IsNullable=true, Order=13)]
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

        [XmlArray(IsNullable=true, Order=14), XmlArrayItem("NoteList", IsNullable=false)]
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

        [XmlArrayItem("ContactOpenIDAccountList", IsNullable=false), XmlArray(Order=15)]
        public ContactOpenIDAccount[] OpenIDAccounts
        {
            get
            {
                return this.openIDAccountsField;
            }
            set
            {
                this.openIDAccountsField = value;
                base.RaisePropertyChanged("OpenIDAccounts");
            }
        }

        [XmlElement(IsNullable=true, Order=0x10)]
        public NamedID Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                base.RaisePropertyChanged("Organization");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public DateTime? PasswordEmailExpirationTime
        {
            get
            {
                return this.passwordEmailExpirationTimeField;
            }
            set
            {
                this.passwordEmailExpirationTimeField = value;
                base.RaisePropertyChanged("PasswordEmailExpirationTime");
            }
        }

        [XmlIgnore]
        public bool PasswordEmailExpirationTimeSpecified
        {
            get
            {
                return this.passwordEmailExpirationTimeFieldSpecified;
            }
            set
            {
                this.passwordEmailExpirationTimeFieldSpecified = value;
                base.RaisePropertyChanged("PasswordEmailExpirationTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x12)]
        public DateTime? PasswordExpirationTime
        {
            get
            {
                return this.passwordExpirationTimeField;
            }
            set
            {
                this.passwordExpirationTimeField = value;
                base.RaisePropertyChanged("PasswordExpirationTime");
            }
        }

        [XmlIgnore]
        public bool PasswordExpirationTimeSpecified
        {
            get
            {
                return this.passwordExpirationTimeFieldSpecified;
            }
            set
            {
                this.passwordExpirationTimeFieldSpecified = value;
                base.RaisePropertyChanged("PasswordExpirationTimeSpecified");
            }
        }

        [XmlArray(Order=0x13), XmlArrayItem("PhoneList", IsNullable=false)]
        public Phone[] Phones
        {
            get
            {
                return this.phonesField;
            }
            set
            {
                this.phonesField = value;
                base.RaisePropertyChanged("Phones");
            }
        }

        [XmlElement(Order=20)]
        public ContactSalesSettings SalesSettings
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

        [XmlElement(Order=0x15)]
        public ContactServiceSettings ServiceSettings
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

        [XmlElement(Order=0x16)]
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

        [XmlElement(IsNullable=true, Order=0x17)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
                base.RaisePropertyChanged("Title");
            }
        }

        [XmlElement(IsNullable=true, Order=0x18)]
        public ContactNullFields ValidNullFields
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

