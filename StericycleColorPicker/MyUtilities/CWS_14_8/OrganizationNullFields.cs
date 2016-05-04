namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class OrganizationNullFields : INotifyPropertyChanged
    {
        private bool addressesField = false;
        private bool bannerField = false;
        private bool fileAttachmentsField = false;
        private bool industryField = false;
        private bool loginField = false;
        private bool nameFuriganaField = false;
        private bool newPasswordField = false;
        private bool notesField = false;
        private bool numberOfEmployeesField = false;
        private bool parentField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
                this.RaisePropertyChanged("Addresses");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Banner
        {
            get
            {
                return this.bannerField;
            }
            set
            {
                this.bannerField = value;
                this.RaisePropertyChanged("Banner");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool FileAttachments
        {
            get
            {
                return this.fileAttachmentsField;
            }
            set
            {
                this.fileAttachmentsField = value;
                this.RaisePropertyChanged("FileAttachments");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Industry
        {
            get
            {
                return this.industryField;
            }
            set
            {
                this.industryField = value;
                this.RaisePropertyChanged("Industry");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
                this.RaisePropertyChanged("Login");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool NameFurigana
        {
            get
            {
                return this.nameFuriganaField;
            }
            set
            {
                this.nameFuriganaField = value;
                this.RaisePropertyChanged("NameFurigana");
            }
        }

        [DefaultValue(false), XmlAttribute]
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

        [DefaultValue(false), XmlAttribute]
        public bool Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
                this.RaisePropertyChanged("Notes");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool NumberOfEmployees
        {
            get
            {
                return this.numberOfEmployeesField;
            }
            set
            {
                this.numberOfEmployeesField = value;
                this.RaisePropertyChanged("NumberOfEmployees");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
                this.RaisePropertyChanged("Parent");
            }
        }
    }
}

