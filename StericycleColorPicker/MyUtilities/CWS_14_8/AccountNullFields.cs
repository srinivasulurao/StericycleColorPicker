namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class AccountNullFields : INotifyPropertyChanged
    {
        private bool displayNameField = false;
        private bool emailNotificationField = false;
        private bool emailsField = false;
        private bool managerField = false;
        private bool newPasswordField = false;
        private bool phonesField = false;
        private bool profileField = false;
        private bool signatureField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
                this.RaisePropertyChanged("DisplayName");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool EmailNotification
        {
            get
            {
                return this.emailNotificationField;
            }
            set
            {
                this.emailNotificationField = value;
                this.RaisePropertyChanged("EmailNotification");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Emails
        {
            get
            {
                return this.emailsField;
            }
            set
            {
                this.emailsField = value;
                this.RaisePropertyChanged("Emails");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Manager
        {
            get
            {
                return this.managerField;
            }
            set
            {
                this.managerField = value;
                this.RaisePropertyChanged("Manager");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool NewPassword
        {
            get
            {
                return this.newPasswordField;
            }
            set
            {
                this.newPasswordField = value;
                this.RaisePropertyChanged("NewPassword");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Phones
        {
            get
            {
                return this.phonesField;
            }
            set
            {
                this.phonesField = value;
                this.RaisePropertyChanged("Phones");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
                this.RaisePropertyChanged("Profile");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
                this.RaisePropertyChanged("Signature");
            }
        }
    }
}

