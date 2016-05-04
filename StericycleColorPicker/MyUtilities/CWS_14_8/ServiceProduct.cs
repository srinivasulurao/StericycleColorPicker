namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class ServiceProduct : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private ServiceCategoryDelta[] categoryLinksField;
        private Label[] descriptionsField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private ServiceDispositionDelta[] dispositionLinksField;
        private NamedIDDelta[] endUserVisibleInterfacesField;
        private string nameField;
        private LabelRequired[] namesField;
        private NamedIDHierarchy parentField;
        private NamedID[] productHierarchyField;
        private ServiceProductNullFields validNullFieldsField;

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

        [XmlArrayItem("ServiceCategoryList", IsNullable=false), XmlArray(IsNullable=true, Order=1)]
        public ServiceCategoryDelta[] CategoryLinks
        {
            get
            {
                return this.categoryLinksField;
            }
            set
            {
                this.categoryLinksField = value;
                base.RaisePropertyChanged("CategoryLinks");
            }
        }

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(IsNullable=true, Order=2)]
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

        [XmlArrayItem("ServiceDispositionList", IsNullable=false), XmlArray(IsNullable=true, Order=4)]
        public ServiceDispositionDelta[] DispositionLinks
        {
            get
            {
                return this.dispositionLinksField;
            }
            set
            {
                this.dispositionLinksField = value;
                base.RaisePropertyChanged("DispositionLinks");
            }
        }

        [XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=5)]
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

        [XmlArray(Order=7), XmlArrayItem("LabelList", IsNullable=false)]
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

        [XmlElement(IsNullable=true, Order=8)]
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

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(Order=9)]
        public NamedID[] ProductHierarchy
        {
            get
            {
                return this.productHierarchyField;
            }
            set
            {
                this.productHierarchyField = value;
                base.RaisePropertyChanged("ProductHierarchy");
            }
        }

        [XmlElement(IsNullable=true, Order=10)]
        public ServiceProductNullFields ValidNullFields
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

