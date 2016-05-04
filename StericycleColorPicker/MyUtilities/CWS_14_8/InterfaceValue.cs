namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class InterfaceValue : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID interfaceField;
        private string valueField;

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

        [XmlElement(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
    }
}

