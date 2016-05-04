namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class IncidentNullFields : INotifyPropertyChanged
    {
        private bool assetField = false;
        private bool billedMinutesField = false;
        private bool categoryField = false;
        private bool channelField = false;
        private bool chatQueueField = false;
        private bool dispositionField = false;
        private bool fileAttachmentsField = false;
        private bool languageField = false;
        private bool mailboxField = false;
        private bool organizationField = false;
        private bool otherContactsField = false;
        private bool productField = false;
        private bool queueField = false;
        private bool severityField = false;
        private bool sLAInstanceField = false;
        private bool subjectField = false;

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
        public bool Asset
        {
            get
            {
                return this.assetField;
            }
            set
            {
                this.assetField = value;
                this.RaisePropertyChanged("Asset");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool BilledMinutes
        {
            get
            {
                return this.billedMinutesField;
            }
            set
            {
                this.billedMinutesField = value;
                this.RaisePropertyChanged("BilledMinutes");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
                this.RaisePropertyChanged("Category");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
                this.RaisePropertyChanged("Channel");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool ChatQueue
        {
            get
            {
                return this.chatQueueField;
            }
            set
            {
                this.chatQueueField = value;
                this.RaisePropertyChanged("ChatQueue");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Disposition
        {
            get
            {
                return this.dispositionField;
            }
            set
            {
                this.dispositionField = value;
                this.RaisePropertyChanged("Disposition");
            }
        }

        [DefaultValue(false), XmlAttribute]
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
        public bool Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                this.RaisePropertyChanged("Language");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Mailbox
        {
            get
            {
                return this.mailboxField;
            }
            set
            {
                this.mailboxField = value;
                this.RaisePropertyChanged("Mailbox");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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

        [DefaultValue(false), XmlAttribute]
        public bool OtherContacts
        {
            get
            {
                return this.otherContactsField;
            }
            set
            {
                this.otherContactsField = value;
                this.RaisePropertyChanged("OtherContacts");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
                this.RaisePropertyChanged("Product");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
                this.RaisePropertyChanged("Queue");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
                this.RaisePropertyChanged("Severity");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool SLAInstance
        {
            get
            {
                return this.sLAInstanceField;
            }
            set
            {
                this.sLAInstanceField = value;
                this.RaisePropertyChanged("SLAInstance");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
                this.RaisePropertyChanged("Subject");
            }
        }
    }
}

