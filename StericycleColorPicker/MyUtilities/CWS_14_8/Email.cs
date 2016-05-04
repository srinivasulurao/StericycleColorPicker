namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class Email : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private string addressField;
        private NamedID addressTypeField;
        private string certificateField;
        private bool invalidField;
        private bool invalidFieldSpecified;

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
        public string Address
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

        [XmlElement(Order=1)]
        public NamedID AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
                this.RaisePropertyChanged("AddressType");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string Certificate
        {
            get
            {
                return this.certificateField;
            }
            set
            {
                this.certificateField = value;
                this.RaisePropertyChanged("Certificate");
            }
        }

        [XmlElement(Order=3)]
        public bool Invalid
        {
            get
            {
                return this.invalidField;
            }
            set
            {
                this.invalidField = value;
                this.RaisePropertyChanged("Invalid");
            }
        }

        [XmlIgnore]
        public bool InvalidSpecified
        {
            get
            {
                return this.invalidFieldSpecified;
            }
            set
            {
                this.invalidFieldSpecified = value;
                this.RaisePropertyChanged("InvalidSpecified");
            }
        }
    }
}

