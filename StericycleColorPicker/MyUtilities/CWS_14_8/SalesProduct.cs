namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class SalesProduct : RNObject
    {
        private long acceptCountField;
        private bool acceptCountFieldSpecified;
        private NamedIDDelta[] adminVisibleInterfacesField;
        private SalesProductOptions attributesField;
        private GenericObject customFieldsField;
        private Label[] descriptionsField;
        private bool disabledField;
        private bool disabledFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private bool excludeFromOfferAdvisorField;
        private bool excludeFromOfferAdvisorFieldSpecified;
        private NamedIDHierarchy folderField;
        private string nameField;
        private LabelRequired[] namesField;
        private string partNumberField;
        private int respondCountField;
        private bool respondCountFieldSpecified;
        private SalesProductSchedule[] schedulesField;
        private NamedIDHierarchy serviceProductField;
        private SalesProductNullFields validNullFieldsField;

        [XmlElement(Order=0)]
        public long AcceptCount
        {
            get
            {
                return this.acceptCountField;
            }
            set
            {
                this.acceptCountField = value;
                base.RaisePropertyChanged("AcceptCount");
            }
        }

        [XmlIgnore]
        public bool AcceptCountSpecified
        {
            get
            {
                return this.acceptCountFieldSpecified;
            }
            set
            {
                this.acceptCountFieldSpecified = value;
                base.RaisePropertyChanged("AcceptCountSpecified");
            }
        }

        [XmlArray(IsNullable=true, Order=1), XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
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

        [XmlElement(Order=2)]
        public SalesProductOptions Attributes
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

        [XmlElement(Order=3)]
        public GenericObject CustomFields
        {
            get
            {
                return this.customFieldsField;
            }
            set
            {
                this.customFieldsField = value;
                base.RaisePropertyChanged("CustomFields");
            }
        }

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(IsNullable=true, Order=4)]
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

        [XmlElement(Order=5)]
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

        [XmlElement(Order=6)]
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

        [XmlElement(Order=7)]
        public bool ExcludeFromOfferAdvisor
        {
            get
            {
                return this.excludeFromOfferAdvisorField;
            }
            set
            {
                this.excludeFromOfferAdvisorField = value;
                base.RaisePropertyChanged("ExcludeFromOfferAdvisor");
            }
        }

        [XmlIgnore]
        public bool ExcludeFromOfferAdvisorSpecified
        {
            get
            {
                return this.excludeFromOfferAdvisorFieldSpecified;
            }
            set
            {
                this.excludeFromOfferAdvisorFieldSpecified = value;
                base.RaisePropertyChanged("ExcludeFromOfferAdvisorSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
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

        [XmlElement(Order=9)]
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

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(Order=10)]
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

        [XmlElement(IsNullable=true, Order=11)]
        public string PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
                base.RaisePropertyChanged("PartNumber");
            }
        }

        [XmlElement(Order=12)]
        public int RespondCount
        {
            get
            {
                return this.respondCountField;
            }
            set
            {
                this.respondCountField = value;
                base.RaisePropertyChanged("RespondCount");
            }
        }

        [XmlIgnore]
        public bool RespondCountSpecified
        {
            get
            {
                return this.respondCountFieldSpecified;
            }
            set
            {
                this.respondCountFieldSpecified = value;
                base.RaisePropertyChanged("RespondCountSpecified");
            }
        }

        [XmlArray(IsNullable=true, Order=13), XmlArrayItem("SalesProductScheduleList", IsNullable=false)]
        public SalesProductSchedule[] Schedules
        {
            get
            {
                return this.schedulesField;
            }
            set
            {
                this.schedulesField = value;
                base.RaisePropertyChanged("Schedules");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public NamedIDHierarchy ServiceProduct
        {
            get
            {
                return this.serviceProductField;
            }
            set
            {
                this.serviceProductField = value;
                base.RaisePropertyChanged("ServiceProduct");
            }
        }

        [XmlElement(IsNullable=true, Order=15)]
        public SalesProductNullFields ValidNullFields
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

