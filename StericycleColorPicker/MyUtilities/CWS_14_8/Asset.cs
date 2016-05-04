namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class Asset : RNObject
    {
        private NamedID contactField;
        private GenericObject customFieldsField;
        private string descriptionField;
        private DateTime? installedDateField;
        private bool installedDateFieldSpecified;
        private string nameField;
        private NamedID organizationField;
        private MonetaryValue priceField;
        private NamedID productField;
        private DateTime? purchasedDateField;
        private bool purchasedDateFieldSpecified;
        private DateTime? retiredDateField;
        private bool retiredDateFieldSpecified;
        private string serialNumberField;
        private AssetSLAInstance[] sLAInstancesField;
        private AssetStatuses statusWithTypeField;
        private AssetNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                base.RaisePropertyChanged("Contact");
            }
        }

        [XmlElement(Order=1)]
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

        [XmlElement(IsNullable=true, Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                base.RaisePropertyChanged("Description");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=3)]
        public DateTime? InstalledDate
        {
            get
            {
                return this.installedDateField;
            }
            set
            {
                this.installedDateField = value;
                base.RaisePropertyChanged("InstalledDate");
            }
        }

        [XmlIgnore]
        public bool InstalledDateSpecified
        {
            get
            {
                return this.installedDateFieldSpecified;
            }
            set
            {
                this.installedDateFieldSpecified = value;
                base.RaisePropertyChanged("InstalledDateSpecified");
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

        [XmlElement(IsNullable=true, Order=5)]
        public NamedID Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                base.RaisePropertyChanged("Organization");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public MonetaryValue Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                base.RaisePropertyChanged("Price");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
        public NamedID Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
                base.RaisePropertyChanged("Product");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=8)]
        public DateTime? PurchasedDate
        {
            get
            {
                return this.purchasedDateField;
            }
            set
            {
                this.purchasedDateField = value;
                base.RaisePropertyChanged("PurchasedDate");
            }
        }

        [XmlIgnore]
        public bool PurchasedDateSpecified
        {
            get
            {
                return this.purchasedDateFieldSpecified;
            }
            set
            {
                this.purchasedDateFieldSpecified = value;
                base.RaisePropertyChanged("PurchasedDateSpecified");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=9)]
        public DateTime? RetiredDate
        {
            get
            {
                return this.retiredDateField;
            }
            set
            {
                this.retiredDateField = value;
                base.RaisePropertyChanged("RetiredDate");
            }
        }

        [XmlIgnore]
        public bool RetiredDateSpecified
        {
            get
            {
                return this.retiredDateFieldSpecified;
            }
            set
            {
                this.retiredDateFieldSpecified = value;
                base.RaisePropertyChanged("RetiredDateSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=10)]
        public string SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
                base.RaisePropertyChanged("SerialNumber");
            }
        }

        [XmlArray(IsNullable=true, Order=11), XmlArrayItem("AssetSLAInstanceList", IsNullable=false)]
        public AssetSLAInstance[] SLAInstances
        {
            get
            {
                return this.sLAInstancesField;
            }
            set
            {
                this.sLAInstancesField = value;
                base.RaisePropertyChanged("SLAInstances");
            }
        }

        [XmlElement(IsNullable=true, Order=12)]
        public AssetStatuses StatusWithType
        {
            get
            {
                return this.statusWithTypeField;
            }
            set
            {
                this.statusWithTypeField = value;
                base.RaisePropertyChanged("StatusWithType");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public AssetNullFields ValidNullFields
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

