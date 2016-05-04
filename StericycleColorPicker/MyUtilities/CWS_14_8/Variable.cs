namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class Variable : RNObject
    {
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedIDHierarchy folderField;
        private InterfaceValue[] interfaceValuesField;
        private string nameField;
        private bool searchIndexableField;
        private bool searchIndexableFieldSpecified;
        private VariableNullFields validNullFieldsField;

        [XmlElement(Order=0)]
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

        [XmlElement(IsNullable=true, Order=1)]
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

        [XmlArray(IsNullable=true, Order=2), XmlArrayItem("InterfaceValueList", IsNullable=false)]
        public InterfaceValue[] InterfaceValues
        {
            get
            {
                return this.interfaceValuesField;
            }
            set
            {
                this.interfaceValuesField = value;
                base.RaisePropertyChanged("InterfaceValues");
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

        [XmlElement(Order=4)]
        public bool SearchIndexable
        {
            get
            {
                return this.searchIndexableField;
            }
            set
            {
                this.searchIndexableField = value;
                base.RaisePropertyChanged("SearchIndexable");
            }
        }

        [XmlIgnore]
        public bool SearchIndexableSpecified
        {
            get
            {
                return this.searchIndexableFieldSpecified;
            }
            set
            {
                this.searchIndexableFieldSpecified = value;
                base.RaisePropertyChanged("SearchIndexableSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public VariableNullFields ValidNullFields
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

