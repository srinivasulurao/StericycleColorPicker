namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class QuoteLineItem : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private string adjustedDescriptionField;
        private string adjustedNameField;
        private string adjustedPartNumberField;
        private MonetaryValue adjustedPriceField;
        private MonetaryValue adjustedTotalField;
        private string commentField;
        private GenericObject customFieldsField;
        private int discountPercentField;
        private bool discountPercentFieldSpecified;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private string originalDescriptionField;
        private string originalNameField;
        private string originalPartNumberField;
        private MonetaryValue originalPriceField;
        private NamedID productField;
        private int quantityField;
        private bool quantityFieldSpecified;
        private QuoteLineItemNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute]
        public ActionEnum action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }

        [XmlIgnore]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public string AdjustedDescription
        {
            get
            {
                return this.adjustedDescriptionField;
            }
            set
            {
                this.adjustedDescriptionField = value;
                this.RaisePropertyChanged("AdjustedDescription");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public string AdjustedName
        {
            get
            {
                return this.adjustedNameField;
            }
            set
            {
                this.adjustedNameField = value;
                this.RaisePropertyChanged("AdjustedName");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string AdjustedPartNumber
        {
            get
            {
                return this.adjustedPartNumberField;
            }
            set
            {
                this.adjustedPartNumberField = value;
                this.RaisePropertyChanged("AdjustedPartNumber");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public MonetaryValue AdjustedPrice
        {
            get
            {
                return this.adjustedPriceField;
            }
            set
            {
                this.adjustedPriceField = value;
                this.RaisePropertyChanged("AdjustedPrice");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public MonetaryValue AdjustedTotal
        {
            get
            {
                return this.adjustedTotalField;
            }
            set
            {
                this.adjustedTotalField = value;
                this.RaisePropertyChanged("AdjustedTotal");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public string Comment
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

        [XmlElement(Order=6)]
        public GenericObject CustomFields
        {
            get
            {
                return this.customFieldsField;
            }
            set
            {
                this.customFieldsField = value;
                this.RaisePropertyChanged("CustomFields");
            }
        }

        [XmlElement(Order=7)]
        public int DiscountPercent
        {
            get
            {
                return this.discountPercentField;
            }
            set
            {
                this.discountPercentField = value;
                this.RaisePropertyChanged("DiscountPercent");
            }
        }

        [XmlIgnore]
        public bool DiscountPercentSpecified
        {
            get
            {
                return this.discountPercentFieldSpecified;
            }
            set
            {
                this.discountPercentFieldSpecified = value;
                this.RaisePropertyChanged("DiscountPercentSpecified");
            }
        }

        [XmlElement(Order=8)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                this.RaisePropertyChanged("DisplayOrder");
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
                this.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(Order=9)]
        public MyUtilities.CWS_14_8.ID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(IsNullable=true, Order=10)]
        public string OriginalDescription
        {
            get
            {
                return this.originalDescriptionField;
            }
            set
            {
                this.originalDescriptionField = value;
                this.RaisePropertyChanged("OriginalDescription");
            }
        }

        [XmlElement(IsNullable=true, Order=11)]
        public string OriginalName
        {
            get
            {
                return this.originalNameField;
            }
            set
            {
                this.originalNameField = value;
                this.RaisePropertyChanged("OriginalName");
            }
        }

        [XmlElement(IsNullable=true, Order=12)]
        public string OriginalPartNumber
        {
            get
            {
                return this.originalPartNumberField;
            }
            set
            {
                this.originalPartNumberField = value;
                this.RaisePropertyChanged("OriginalPartNumber");
            }
        }

        [XmlElement(Order=13)]
        public MonetaryValue OriginalPrice
        {
            get
            {
                return this.originalPriceField;
            }
            set
            {
                this.originalPriceField = value;
                this.RaisePropertyChanged("OriginalPrice");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public NamedID Product
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

        [XmlElement(Order=15)]
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
                this.RaisePropertyChanged("Quantity");
            }
        }

        [XmlIgnore]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
                this.RaisePropertyChanged("QuantitySpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x10)]
        public QuoteLineItemNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                this.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

