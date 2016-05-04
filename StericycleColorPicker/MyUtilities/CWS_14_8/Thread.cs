namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class Thread : INotifyPropertyChanged
    {
        private NamedID accountField;
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID channelField;
        private NamedID contactField;
        private NamedID contentTypeField;
        private DateTime createdTimeField;
        private bool createdTimeFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedID entryTypeField;
        private MyUtilities.CWS_14_8.ID idField;
        private string mailHeaderField;
        private string textField;
        private ThreadNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
                this.RaisePropertyChanged("Account");
            }
        }

        [XmlAttribute]
        public ActionEnum action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }

        [XmlIgnore]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Channel
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

        [XmlElement(IsNullable=true, Order=2)]
        public NamedID Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                this.RaisePropertyChanged("Contact");
            }
        }

        [XmlElement(Order=3)]
        public NamedID ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
                this.RaisePropertyChanged("ContentType");
            }
        }

        [XmlElement(Order=4)]
        public DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
                this.RaisePropertyChanged("CreatedTime");
            }
        }

        [XmlIgnore]
        public bool CreatedTimeSpecified
        {
            get
            {
                return this.createdTimeFieldSpecified;
            }
            set
            {
                this.createdTimeFieldSpecified = value;
                this.RaisePropertyChanged("CreatedTimeSpecified");
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
                this.RaisePropertyChanged("DisplayOrder");
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
                this.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(Order=6)]
        public NamedID EntryType
        {
            get
            {
                return this.entryTypeField;
            }
            set
            {
                this.entryTypeField = value;
                this.RaisePropertyChanged("EntryType");
            }
        }

        [XmlElement(Order=7)]
        public MyUtilities.CWS_14_8.ID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
        public string MailHeader
        {
            get
            {
                return this.mailHeaderField;
            }
            set
            {
                this.mailHeaderField = value;
                this.RaisePropertyChanged("MailHeader");
            }
        }

        [XmlElement(Order=9)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
                this.RaisePropertyChanged("Text");
            }
        }

        [XmlElement(IsNullable=true, Order=10)]
        public ThreadNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                this.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

