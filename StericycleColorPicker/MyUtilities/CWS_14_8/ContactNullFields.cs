namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class ContactNullFields : INotifyPropertyChanged
    {
        private bool addressField = false;
        private bool bannerField = false;
        private bool channelUsernamesField = false;
        private bool contactTypeField = false;
        private bool emailsField = false;
        private bool fileAttachmentsField = false;
        private bool loginField = false;
        private bool newPasswordField = false;
        private bool notesField = false;
        private bool organizationField = false;
        private bool titleField = false;

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
        public bool Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
        public bool ChannelUsernames
        {
            get
            {
                return this.channelUsernamesField;
            }
            set
            {
                this.channelUsernamesField = value;
                this.RaisePropertyChanged("ChannelUsernames");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool ContactType
        {
            get
            {
                return this.contactTypeField;
            }
            set
            {
                this.contactTypeField = value;
                this.RaisePropertyChanged("ContactType");
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

        [DefaultValue(false), XmlAttribute]
        public bool Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                this.RaisePropertyChanged("Organization");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
    }
}

