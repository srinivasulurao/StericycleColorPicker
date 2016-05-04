namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class Account : RNObject
    {
        private NamedID[] accountHierarchyField;
        private AccountOptions attributesField;
        private NamedID countryField;
        private GenericObject customFieldsField;
        private string displayNameField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedID emailNotificationField;
        private Email[] emailsField;
        private string loginField;
        private NamedIDHierarchy managerField;
        private PersonFullName nameField;
        private PersonName nameFuriganaField;
        private string newPasswordField;
        private bool notificationPendingField;
        private bool notificationPendingFieldSpecified;
        private DateTime? passwordExpirationTimeField;
        private bool passwordExpirationTimeFieldSpecified;
        private Phone[] phonesField;
        private NamedID profileField;
        private AccountSalesSettings salesSettingsField;
        private AccountServiceSettings serviceSettingsField;
        private string signatureField;
        private NamedID staffGroupField;
        private AccountNullFields validNullFieldsField;

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(Order=0)]
        public NamedID[] AccountHierarchy
        {
            get
            {
                return this.accountHierarchyField;
            }
            set
            {
                this.accountHierarchyField = value;
                base.RaisePropertyChanged("AccountHierarchy");
            }
        }

        [XmlElement(Order=1)]
        public AccountOptions Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
                base.RaisePropertyChanged("Attributes");
            }
        }

        [XmlElement(Order=2)]
        public NamedID Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                base.RaisePropertyChanged("Country");
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

        [XmlElement(IsNullable=true, Order=4)]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
                base.RaisePropertyChanged("DisplayName");
            }
        }

        [XmlElement(Order=5)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                base.RaisePropertyChanged("DisplayOrder");
            }
        }

        [XmlIgnore]
        public bool DisplayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
                base.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public NamedID EmailNotification
        {
            get
            {
                return this.emailNotificationField;
            }
            set
            {
                this.emailNotificationField = value;
                base.RaisePropertyChanged("EmailNotification");
            }
        }

        [XmlArrayItem("EmailList", IsNullable=false), XmlArray(IsNullable=true, Order=7)]
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

        [XmlElement(Order=8)]
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

        [XmlElement(IsNullable=true, Order=9)]
        public NamedIDHierarchy Manager
        {
            get
            {
                return this.managerField;
            }
            set
            {
                this.managerField = value;
                base.RaisePropertyChanged("Manager");
            }
        }

        [XmlElement(Order=10)]
        public PersonFullName Name
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

        [XmlElement(Order=11)]
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

        [XmlElement(IsNullable=true, Order=12)]
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

        [XmlElement(Order=13)]
        public bool NotificationPending
        {
            get
            {
                return this.notificationPendingField;
            }
            set
            {
                this.notificationPendingField = value;
                base.RaisePropertyChanged("NotificationPending");
            }
        }

        [XmlIgnore]
        public bool NotificationPendingSpecified
        {
            get
            {
                return this.notificationPendingFieldSpecified;
            }
            set
            {
                this.notificationPendingFieldSpecified = value;
                base.RaisePropertyChanged("NotificationPendingSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
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

        [XmlArray(IsNullable=true, Order=15), XmlArrayItem("PhoneList", IsNullable=false)]
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

        [XmlElement(IsNullable=true, Order=0x10)]
        public NamedID Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
                base.RaisePropertyChanged("Profile");
            }
        }

        [XmlElement(Order=0x11)]
        public AccountSalesSettings SalesSettings
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

        [XmlElement(Order=0x12)]
        public AccountServiceSettings ServiceSettings
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

        [XmlElement(IsNullable=true, Order=0x13)]
        public string Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
                base.RaisePropertyChanged("Signature");
            }
        }

        [XmlElement(Order=20)]
        public NamedID StaffGroup
        {
            get
            {
                return this.staffGroupField;
            }
            set
            {
                this.staffGroupField = value;
                base.RaisePropertyChanged("StaffGroup");
            }
        }

        [XmlElement(IsNullable=true, Order=0x15)]
        public AccountNullFields ValidNullFields
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

