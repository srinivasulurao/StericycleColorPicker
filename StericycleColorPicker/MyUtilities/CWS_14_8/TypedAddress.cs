namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class TypedAddress : Address
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID addressTypeField;

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
                base.RaisePropertyChanged("action");
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
                base.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(Order=0)]
        public NamedID AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
                base.RaisePropertyChanged("AddressType");
            }
        }
    }
}

