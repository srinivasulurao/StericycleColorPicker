namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class Province : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private string nameField;
        private LabelRequired[] namesField;

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

        [XmlElement(Order=1)]
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

        [XmlElement(Order=0)]
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

        [XmlElement(Order=2)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(Order=3)]
        public LabelRequired[] Names
        {
            get
            {
                return this.namesField;
            }
            set
            {
                this.namesField = value;
                this.RaisePropertyChanged("Names");
            }
        }
    }
}

