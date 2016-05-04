namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class PurchasedProduct : RNObject
    {
        private NamedID campaignField;
        private string commentField;
        private NamedID contactField;
        private GenericObject customFieldsField;
        private NamedID finalizedByAccountField;
        private DateTime? licenseEndTimeField;
        private bool licenseEndTimeFieldSpecified;
        private DateTime? licenseStartTimeField;
        private bool licenseStartTimeFieldSpecified;
        private NamedID mailingField;
        private NamedID opportunityField;
        private NamedID organizationField;
        private MonetaryValue priceField;
        private DateTime? purchaseTimeField;
        private bool purchaseTimeFieldSpecified;
        private NamedID salesProductField;
        private string serialNumberField;
        private PurchasedProductNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Campaign
        {
            get
            {
                return this.campaignField;
            }
            set
            {
                this.campaignField = value;
                base.RaisePropertyChanged("Campaign");
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

        [XmlElement(IsNullable=true, Order=2)]
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

        [XmlElement(IsNullable=true, Order=4)]
        public NamedID FinalizedByAccount
        {
            get
            {
                return this.finalizedByAccountField;
            }
            set
            {
                this.finalizedByAccountField = value;
                base.RaisePropertyChanged("FinalizedByAccount");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public DateTime? LicenseEndTime
        {
            get
            {
                return this.licenseEndTimeField;
            }
            set
            {
                this.licenseEndTimeField = value;
                base.RaisePropertyChanged("LicenseEndTime");
            }
        }

        [XmlIgnore]
        public bool LicenseEndTimeSpecified
        {
            get
            {
                return this.licenseEndTimeFieldSpecified;
            }
            set
            {
                this.licenseEndTimeFieldSpecified = value;
                base.RaisePropertyChanged("LicenseEndTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public DateTime? LicenseStartTime
        {
            get
            {
                return this.licenseStartTimeField;
            }
            set
            {
                this.licenseStartTimeField = value;
                base.RaisePropertyChanged("LicenseStartTime");
            }
        }

        [XmlIgnore]
        public bool LicenseStartTimeSpecified
        {
            get
            {
                return this.licenseStartTimeFieldSpecified;
            }
            set
            {
                this.licenseStartTimeFieldSpecified = value;
                base.RaisePropertyChanged("LicenseStartTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
        public NamedID Mailing
        {
            get
            {
                return this.mailingField;
            }
            set
            {
                this.mailingField = value;
                base.RaisePropertyChanged("Mailing");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
        public NamedID Opportunity
        {
            get
            {
                return this.opportunityField;
            }
            set
            {
                this.opportunityField = value;
                base.RaisePropertyChanged("Opportunity");
            }
        }

        [XmlElement(IsNullable=true, Order=9)]
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

        [XmlElement(IsNullable=true, Order=10)]
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

        [XmlElement(IsNullable=true, Order=11)]
        public DateTime? PurchaseTime
        {
            get
            {
                return this.purchaseTimeField;
            }
            set
            {
                this.purchaseTimeField = value;
                base.RaisePropertyChanged("PurchaseTime");
            }
        }

        [XmlIgnore]
        public bool PurchaseTimeSpecified
        {
            get
            {
                return this.purchaseTimeFieldSpecified;
            }
            set
            {
                this.purchaseTimeFieldSpecified = value;
                base.RaisePropertyChanged("PurchaseTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=12)]
        public NamedID SalesProduct
        {
            get
            {
                return this.salesProductField;
            }
            set
            {
                this.salesProductField = value;
                base.RaisePropertyChanged("SalesProduct");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
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

        [XmlElement(IsNullable=true, Order=14)]
        public PurchasedProductNullFields ValidNullFields
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

