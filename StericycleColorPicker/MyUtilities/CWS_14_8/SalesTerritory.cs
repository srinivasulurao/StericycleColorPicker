namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class SalesTerritory : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private string commentField;
        private bool disabledField;
        private bool disabledFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private string nameField;
        private LabelRequired[] namesField;
        private NamedIDHierarchy parentField;
        private NamedID[] territoryHierarchyField;
        private SalesTerritoryNullFields validNullFieldsField;

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

        [XmlElement(IsNullable=true, Order=1)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
                base.RaisePropertyChanged("Comment");
            }
        }

        [XmlElement(Order=2)]
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

        [XmlElement(Order=4)]
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

        [XmlArray(Order=5), XmlArrayItem("LabelList", IsNullable=false)]
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

        [XmlElement(IsNullable=true, Order=6)]
        public NamedIDHierarchy Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
                base.RaisePropertyChanged("Parent");
            }
        }

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=7)]
        public NamedID[] TerritoryHierarchy
        {
            get
            {
                return this.territoryHierarchyField;
            }
            set
            {
                this.territoryHierarchyField = value;
                base.RaisePropertyChanged("TerritoryHierarchy");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
        public SalesTerritoryNullFields ValidNullFields
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

