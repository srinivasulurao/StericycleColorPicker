namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class SharedFileAttachmentShared : FileAttachmentShared
    {
        private RNObject attachmentOwnerField;

        [XmlElement(Order=0)]
        public RNObject AttachmentOwner
        {
            get
            {
                return this.attachmentOwnerField;
            }
            set
            {
                this.attachmentOwnerField = value;
                base.RaisePropertyChanged("AttachmentOwner");
            }
        }
    }
}

