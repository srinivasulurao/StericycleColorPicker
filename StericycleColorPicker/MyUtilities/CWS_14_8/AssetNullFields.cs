namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class AssetNullFields : INotifyPropertyChanged
    {
        private bool contactField = false;
        private bool descriptionField = false;
        private bool installedDateField = false;
        private bool organizationField = false;
        private bool priceField = false;
        private bool productField = false;
        private bool purchasedDateField = false;
        private bool retiredDateField = false;
        private bool serialNumberField = false;
        private bool sLAInstancesField = false;
        private bool statusWithTypeField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                this.RaisePropertyChanged("Contact");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool InstalledDate
        {
            get
            {
                return this.installedDateField;
            }
            set
            {
                this.installedDateField = value;
                this.RaisePropertyChanged("InstalledDate");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                this.RaisePropertyChanged("Organization");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                this.RaisePropertyChanged("Price");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
                this.RaisePropertyChanged("Product");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool PurchasedDate
        {
            get
            {
                return this.purchasedDateField;
            }
            set
            {
                this.purchasedDateField = value;
                this.RaisePropertyChanged("PurchasedDate");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool RetiredDate
        {
            get
            {
                return this.retiredDateField;
            }
            set
            {
                this.retiredDateField = value;
                this.RaisePropertyChanged("RetiredDate");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
                this.RaisePropertyChanged("SerialNumber");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool SLAInstances
        {
            get
            {
                return this.sLAInstancesField;
            }
            set
            {
                this.sLAInstancesField = value;
                this.RaisePropertyChanged("SLAInstances");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool StatusWithType
        {
            get
            {
                return this.statusWithTypeField;
            }
            set
            {
                this.statusWithTypeField = value;
                this.RaisePropertyChanged("StatusWithType");
            }
        }
    }
}

