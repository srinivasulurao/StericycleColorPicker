namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), XmlInclude(typeof(SharedFileAttachmentShared)), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class FileAttachmentShared : FileAttachment
    {
        private bool disabledField;
        private bool disabledFieldSpecified;
        private LabelRequired[] namesField;
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

        [XmlArray(Order=1), XmlArrayItem("LabelList", IsNullable=false)]
        public LabelRequired[] Names
        {
            get
            {
                return this.namesField;
            }
            set
            {
                this.namesField = value;
                base.RaisePropertyChanged("Names");
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

