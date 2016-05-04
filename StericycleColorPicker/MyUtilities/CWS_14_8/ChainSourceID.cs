namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:base.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class ChainSourceID : ID
    {
        private string variableNameField;

        [XmlAttribute]
        public string variableName
        {
            get
            {
                return this.variableNameField;
            }
            set
            {
                this.variableNameField = value;
                base.RaisePropertyChanged("variableName");
            }
        }
    }
}

