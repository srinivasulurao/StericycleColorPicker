namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class ChannelType : RNObject
    {
        private ChannelTypeOptions attributesField;
        private bool contactVisibilityField;
        private bool contactVisibilityFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private string nameField;
        private LabelRequired[] namesField;

        [XmlElement(Order=0)]
        public ChannelTypeOptions Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
                base.RaisePropertyChanged("Attributes");
            }
        }

        [XmlElement(Order=1)]
        public bool ContactVisibility
        {
            get
            {
                return this.contactVisibilityField;
            }
            set
            {
                this.contactVisibilityField = value;
                base.RaisePropertyChanged("ContactVisibility");
            }
        }

        [XmlIgnore]
        public bool ContactVisibilitySpecified
        {
            get
            {
                return this.contactVisibilityFieldSpecified;
            }
            set
            {
                this.contactVisibilityFieldSpecified = value;
                base.RaisePropertyChanged("ContactVisibilitySpecified");
            }
        }

        [XmlElement(Order=2)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                base.RaisePropertyChanged("DisplayOrder");
            }
        }

        [XmlIgnore]
        public bool DisplayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
                base.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(Order=3)]
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

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(Order=4)]
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
    }
}

