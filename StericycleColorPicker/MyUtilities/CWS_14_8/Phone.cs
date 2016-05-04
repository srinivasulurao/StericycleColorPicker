namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class Phone : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private string numberField;
        private NamedID phoneTypeField;
        private string rawNumberField;

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
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
                this.RaisePropertyChanged("Number");
            }
        }

        [XmlElement(Order=1)]
        public NamedID PhoneType
        {
            get
            {
                return this.phoneTypeField;
            }
            set
            {
                this.phoneTypeField = value;
                this.RaisePropertyChanged("PhoneType");
            }
        }

        [XmlElement(Order=2)]
        public string RawNumber
        {
            get
            {
                return this.rawNumberField;
            }
            set
            {
                this.rawNumberField = value;
                this.RaisePropertyChanged("RawNumber");
            }
        }
    }
}

