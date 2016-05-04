namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class Note : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID channelField;
        private NamedID createdByAccountField;
        private DateTime createdTimeField;
        private bool createdTimeFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private string textField;
        private NamedID updatedByAccountField;
        private DateTime updatedTimeField;
        private bool updatedTimeFieldSpecified;
        private NoteNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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

        [XmlElement(IsNullable=true, Order=0)]
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

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID CreatedByAccount
        {
            get
            {
                return this.createdByAccountField;
            }
            set
            {
                this.createdByAccountField = value;
                this.RaisePropertyChanged("CreatedByAccount");
            }
        }

        [XmlElement(Order=2)]
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

        [XmlElement(Order=3)]
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

        [XmlElement(Order=4)]
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

        [XmlElement(IsNullable=true, Order=5)]
        public NamedID UpdatedByAccount
        {
            get
            {
                return this.updatedByAccountField;
            }
            set
            {
                this.updatedByAccountField = value;
                this.RaisePropertyChanged("UpdatedByAccount");
            }
        }

        [XmlElement(Order=6)]
        public DateTime UpdatedTime
        {
            get
            {
                return this.updatedTimeField;
            }
            set
            {
                this.updatedTimeField = value;
                this.RaisePropertyChanged("UpdatedTime");
            }
        }

        [XmlIgnore]
        public bool UpdatedTimeSpecified
        {
            get
            {
                return this.updatedTimeFieldSpecified;
            }
            set
            {
                this.updatedTimeFieldSpecified = value;
                this.RaisePropertyChanged("UpdatedTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
        public NoteNullFields ValidNullFields
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

