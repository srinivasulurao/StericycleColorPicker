namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlInclude(typeof(SharedFileAttachmentAnswer)), DebuggerStepThrough]
    public class FileAttachmentAnswer : FileAttachmentCommon
    {
        private bool disabledField;
        private bool disabledFieldSpecified;
        private bool indexedField;
        private bool indexedFieldSpecified;
        private bool privateField;
        private bool privateFieldSpecified;

        [XmlElement(Order=0)]
        public bool Disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
                base.RaisePropertyChanged("Disabled");
            }
        }

        [XmlIgnore]
        public bool DisabledSpecified
        {
            get
            {
                return this.disabledFieldSpecified;
            }
            set
            {
                this.disabledFieldSpecified = value;
                base.RaisePropertyChanged("DisabledSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool Indexed
        {
            get
            {
                return this.indexedField;
            }
            set
            {
                this.indexedField = value;
                base.RaisePropertyChanged("Indexed");
            }
        }

        [XmlIgnore]
        public bool IndexedSpecified
        {
            get
            {
                return this.indexedFieldSpecified;
            }
            set
            {
                this.indexedFieldSpecified = value;
                base.RaisePropertyChanged("IndexedSpecified");
            }
        }

        [XmlElement(Order=2)]
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

