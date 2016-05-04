namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class ServiceDisposition : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private Label[] descriptionsField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private NamedID[] dispositionHierarchyField;
        private string nameField;
        private LabelRequired[] namesField;
        private NamedIDHierarchy parentField;
        private ServiceProductDelta[] productLinksField;
        private ServiceDispositionNullFields validNullFieldsField;

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

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(IsNullable=true, Order=1)]
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

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(Order=3)]
        public NamedID[] DispositionHierarchy
        {
            get
            {
                return this.dispositionHierarchyField;
            }
            set
            {
                this.dispositionHierarchyField = value;
                base.RaisePropertyChanged("DispositionHierarchy");
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

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(Order=5)]
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

        [XmlArrayItem("ServiceProductList", IsNullable=false), XmlArray(IsNullable=true, Order=7)]
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

        [XmlElement(IsNullable=true, Order=8)]
        public ServiceDispositionNullFields ValidNullFields
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

