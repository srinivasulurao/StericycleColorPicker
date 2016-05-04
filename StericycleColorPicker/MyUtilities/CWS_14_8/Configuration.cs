namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class Configuration : RNObject
    {
        private NamedID dataTypeField;
        private string nameField;
        private string valueField;

        [XmlElement(Order=0)]
        public NamedID DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
                base.RaisePropertyChanged("DataType");
            }
        }

        [XmlElement(Order=1)]
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

