namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class StandardContent : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private StandardContentAttributes attributesField;
        private StandardContentContentValue[] contentValuesField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedIDHierarchy folderField;
        private string hotKeyField;
        private string nameField;
        private StandardContentUsage usageField;
        private StandardContentNullFields validNullFieldsField;

        [XmlArray(IsNullable=true, Order=0), XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedIDDelta[] AdminVisibleInterfaces
        {
            get
            {
                return this.adminVisibleInterfacesField;
            }
            set
            {
                this.adminVisibleInterfacesField = value;
                base.RaisePropertyChanged("AdminVisibleInterfaces");
            }
        }

        [XmlElement(Order=1)]
        public StandardContentAttributes Attributes
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

        [XmlArray(IsNullable=true, Order=2), XmlArrayItem("ContentValueList", IsNullable=false)]
        public StandardContentContentValue[] ContentValues
        {
            get
            {
                return this.contentValuesField;
            }
            set
            {
                this.contentValuesField = value;
                base.RaisePropertyChanged("ContentValues");
            }
        }

        [XmlElement(Order=3)]
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

        [XmlElement(IsNullable=true, Order=4)]
        public NamedIDHierarchy Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
                base.RaisePropertyChanged("Folder");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public string HotKey
        {
            get
            {
                return this.hotKeyField;
            }
            set
            {
                this.hotKeyField = value;
                base.RaisePropertyChanged("HotKey");
            }
        }

        [XmlElement(Order=6)]
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

        [XmlElement(Order=7)]
        public StandardContentUsage Usage
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

        [XmlElement(IsNullable=true, Order=8)]
        public StandardContentNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

