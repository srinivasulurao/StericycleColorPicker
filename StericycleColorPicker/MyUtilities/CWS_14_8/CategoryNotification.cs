namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class CategoryNotification : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedIDHierarchy categoryField;
        private NamedID interfaceField;
        private DateTime startTimeField;
        private bool startTimeFieldSpecified;
        private CategoryNotificationNullFields validNullFieldsField;

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

        [XmlElement(Order=0)]
        public NamedIDHierarchy Category
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

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
                this.RaisePropertyChanged("Interface");
            }
        }

        [XmlElement(Order=2)]
        public DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
                this.RaisePropertyChanged("StartTime");
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
                this.RaisePropertyChanged("StartTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public CategoryNotificationNullFields ValidNullFields
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

