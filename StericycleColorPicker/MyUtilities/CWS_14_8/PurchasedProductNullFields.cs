namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class PurchasedProductNullFields : INotifyPropertyChanged
    {
        private bool campaignField = false;
        private bool commentField = false;
        private bool contactField = false;
        private bool finalizedByAccountField = false;
        private bool licenseEndTimeField = false;
        private bool licenseStartTimeField = false;
        private bool mailingField = false;
        private bool opportunityField = false;
        private bool organizationField = false;
        private bool priceField = false;
        private bool purchaseTimeField = false;
        private bool salesProductField = false;
        private bool serialNumberField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Campaign
        {
            get
            {
                return this.campaignField;
            }
            set
            {
                this.campaignField = value;
                this.RaisePropertyChanged("Campaign");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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

        [DefaultValue(false), XmlAttribute]
        public bool FinalizedByAccount
        {
            get
            {
                return this.finalizedByAccountField;
            }
            set
            {
                this.finalizedByAccountField = value;
                this.RaisePropertyChanged("FinalizedByAccount");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool LicenseEndTime
        {
            get
            {
                return this.licenseEndTimeField;
            }
            set
            {
                this.licenseEndTimeField = value;
                this.RaisePropertyChanged("LicenseEndTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool LicenseStartTime
        {
            get
            {
                return this.licenseStartTimeField;
            }
            set
            {
                this.licenseStartTimeField = value;
                this.RaisePropertyChanged("LicenseStartTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Mailing
        {
            get
            {
                return this.mailingField;
            }
            set
            {
                this.mailingField = value;
                this.RaisePropertyChanged("Mailing");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Opportunity
        {
            get
            {
                return this.opportunityField;
            }
            set
            {
                this.opportunityField = value;
                this.RaisePropertyChanged("Opportunity");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
        public bool PurchaseTime
        {
            get
            {
                return this.purchaseTimeField;
            }
            set
            {
                this.purchaseTimeField = value;
                this.RaisePropertyChanged("PurchaseTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool SalesProduct
        {
            get
            {
                return this.salesProductField;
            }
            set
            {
                this.salesProductField = value;
                this.RaisePropertyChanged("SalesProduct");
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
    }
}

