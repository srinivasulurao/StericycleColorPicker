namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), XmlInclude(typeof(SharedFileAttachmentIncident)), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class FileAttachmentIncident : FileAttachmentCommon
    {
        private bool privateField;
        private bool privateFieldSpecified;

        [XmlElement(Order=0)]
        public bool Private
        {
            get
            {
                return this.privateField;
            }
            set
            {
                this.privateField = value;
                base.RaisePropertyChanged("Private");
            }
        }

        [XmlIgnore]
        public bool PrivateSpecified
        {
            get
            {
                return this.privateFieldSpecified;
            }
            set
            {
                this.privateFieldSpecified = value;
                base.RaisePropertyChanged("PrivateSpecified");
            }
        }
    }
}

