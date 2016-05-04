namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlInclude(typeof(FileAttachmentAnswer)), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), XmlInclude(typeof(FileAttachmentIncident)), XmlInclude(typeof(SharedFileAttachmentIncident)), XmlInclude(typeof(SharedFileAttachmentCommon)), XmlInclude(typeof(SharedFileAttachmentAnswer)), DebuggerStepThrough, DesignerCategory("code")]
    public class FileAttachmentCommon : FileAttachment
    {
        private string descriptionField;
        private string nameField;

        [XmlElement(Order=0)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                base.RaisePropertyChanged("Description");
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
    }
}

