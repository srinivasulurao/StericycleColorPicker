namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class ServiceCategory : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private NamedID[] categoryHierarchyField;
        private Label[] descriptionsField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedIDDelta[] endUserVisibleInterfacesField;
        private string nameField;
        private LabelRequired[] namesField;
        private NamedIDHierarchy parentField;
        private ServiceProductDelta[] productLinksField;
        private ServiceCategoryNullFields validNullFieldsField;

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

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(Order=1)]
        public NamedID[] CategoryHierarchy
        {
            get
            {
                return this.categoryHierarchyField;
            }
            set
            {
                this.categoryHierarchyField = value;
                base.RaisePropertyChanged("CategoryHierarchy");
            }
        }

        [XmlArray(IsNullable=true, Order=2), XmlArrayItem("LabelList", IsNullable=false)]
        public Label[] Descriptions
        {
            get
            {
                return this.descriptionsField;
            }
            set
            {
                this.descriptionsField = value;
                base.RaisePropertyChanged("Descriptions");
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

        [XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=4)]
        public NamedIDDelta[] EndUserVisibleInterfaces
        {
            get
            {
                return this.endUserVisibleInterfacesField;
            }
            set
            {
                this.endUserVisibleInterfacesField = value;
                base.RaisePropertyChanged("EndUserVisibleInterfaces");
            }
        }

        [XmlElement(Order=5)]
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

        [XmlArray(Order=6), XmlArrayItem("LabelList", IsNullable=false)]
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

        [XmlElement(IsNullable=true, Order=7)]
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

        [XmlArray(IsNullable=true, Order=8), XmlArrayItem("ServiceProductList", IsNullable=false)]
        public ServiceProductDelta[] ProductLinks
        {
            get
            {
                return this.productLinksField;
            }
            set
            {
                this.productLinksField = value;
                base.RaisePropertyChanged("ProductLinks");
            }
        }

        [XmlElement(IsNullable=true, Order=9)]
        public ServiceCategoryNullFields ValidNullFields
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

