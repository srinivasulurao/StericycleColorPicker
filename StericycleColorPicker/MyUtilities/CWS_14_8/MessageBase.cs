namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code")]
    public class MessageBase : RNObject
    {
        private string nameField;
        private NamedID usageField;
        private string valueField;

        [XmlElement(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(Order=1)]
        public NamedID Usage
        {
            get
            {
                return this.usageField;
            }
            set
            {
                this.usageField = value;
                base.RaisePropertyChanged("Usage");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                base.RaisePropertyChanged("Value");
            }
        }
    }
}

