namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:generic.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class GenericObject : RNObject
    {
        private GenericField[] genericFieldsField;
        private RNObjectType objectTypeField;

        [XmlElement("GenericFields", Order=1)]
        public GenericField[] GenericFields
        {
            get
            {
                return this.genericFieldsField;
            }
            set
            {
                this.genericFieldsField = value;
                base.RaisePropertyChanged("GenericFields");
            }
        }

        [XmlElement(Order=0)]
        public RNObjectType ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
                base.RaisePropertyChanged("ObjectType");
            }
        }
    }
}

