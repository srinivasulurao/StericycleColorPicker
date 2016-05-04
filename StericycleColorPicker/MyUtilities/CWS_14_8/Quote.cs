namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class Quote : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private MonetaryValue adjustedTotalField;
        private string commentField;
        private DateTime createdTimeField;
        private bool createdTimeFieldSpecified;
        private GenericObject customFieldsField;
        private int discountPercentField;
        private bool discountPercentFieldSpecified;
        private FileAttachment[] fileAttachmentsField;
        private bool forecastedField;
        private bool forecastedFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private QuoteLineItem[] lineItemsField;
        private string nameField;
        private DateTime? offerEndTimeField;
        private bool offerEndTimeFieldSpecified;
        private DateTime? offerStartTimeField;
        private bool offerStartTimeFieldSpecified;
        private NamedID priceScheduleField;
        private DateTime? sentTimeField;
        private bool sentTimeFieldSpecified;
        private string sentToField;
        private NamedID statusField;
        private NamedID templateField;
        private MonetaryValue totalField;
        private DateTime updatedTimeField;
        private bool updatedTimeFieldSpecified;
        private QuoteNullFields validNullFieldsField;

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
                this.RaisePropertyChanged("Comment");
            }
        }

        [XmlElement(Order=2)]
        public DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
                this.RaisePropertyChanged("CreatedTime");
            }
        }

        [XmlIgnore]
        public bool CreatedTimeSpecified
        {
            get
            {
                return this.createdTimeFieldSpecified;
            }
            set
            {
                this.createdTimeFieldSpecified = value;
                this.RaisePropertyChanged("CreatedTimeSpecified");
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
                this.RaisePropertyChanged("CustomFields");
            }
        }

        [XmlElement(Order=4)]
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

        [XmlArray(IsNullable=true, Order=5), XmlArrayItem("FileAttachmentList", IsNullable=false)]
        public FileAttachment[] FileAttachments
        {
            get
            {
                return this.fileAttachmentsField;
            }
            set
            {
                this.fileAttachmentsField = value;
                this.RaisePropertyChanged("FileAttachments");
            }
        }

        [XmlElement(Order=6)]
        public bool Forecasted
        {
            get
            {
                return this.forecastedField;
            }
            set
            {
                this.forecastedField = value;
                this.RaisePropertyChanged("Forecasted");
            }
        }

        [XmlIgnore]
        public bool ForecastedSpecified
        {
            get
            {
                return this.forecastedFieldSpecified;
            }
            set
            {
                this.forecastedFieldSpecified = value;
                this.RaisePropertyChanged("ForecastedSpecified");
            }
        }

        [XmlElement(Order=7)]
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

        [XmlArray(IsNullable=true, Order=8), XmlArrayItem("QuoteLineItemList", IsNullable=false)]
        public QuoteLineItem[] LineItems
        {
            get
            {
                return this.lineItemsField;
            }
            set
            {
                this.lineItemsField = value;
                this.RaisePropertyChanged("LineItems");
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
                this.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(IsNullable=true, Order=10)]
        public DateTime? OfferEndTime
        {
            get
            {
                return this.offerEndTimeField;
            }
            set
            {
                this.offerEndTimeField = value;
                this.RaisePropertyChanged("OfferEndTime");
            }
        }

        [XmlIgnore]
        public bool OfferEndTimeSpecified
        {
            get
            {
                return this.offerEndTimeFieldSpecified;
            }
            set
            {
                this.offerEndTimeFieldSpecified = value;
                this.RaisePropertyChanged("OfferEndTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=11)]
        public DateTime? OfferStartTime
        {
            get
            {
                return this.offerStartTimeField;
            }
            set
            {
                this.offerStartTimeField = value;
                this.RaisePropertyChanged("OfferStartTime");
            }
        }

        [XmlIgnore]
        public bool OfferStartTimeSpecified
        {
            get
            {
                return this.offerStartTimeFieldSpecified;
            }
            set
            {
                this.offerStartTimeFieldSpecified = value;
                this.RaisePropertyChanged("OfferStartTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=12)]
        public NamedID PriceSchedule
        {
            get
            {
                return this.priceScheduleField;
            }
            set
            {
                this.priceScheduleField = value;
                this.RaisePropertyChanged("PriceSchedule");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public DateTime? SentTime
        {
            get
            {
                return this.sentTimeField;
            }
            set
            {
                this.sentTimeField = value;
                this.RaisePropertyChanged("SentTime");
            }
        }

        [XmlIgnore]
        public bool SentTimeSpecified
        {
            get
            {
                return this.sentTimeFieldSpecified;
            }
            set
            {
                this.sentTimeFieldSpecified = value;
                this.RaisePropertyChanged("SentTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public string SentTo
        {
            get
            {
                return this.sentToField;
            }
            set
            {
                this.sentToField = value;
                this.RaisePropertyChanged("SentTo");
            }
        }

        [XmlElement(IsNullable=true, Order=15)]
        public NamedID Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }

        [XmlElement(IsNullable=true, Order=0x10)]
        public NamedID Template
        {
            get
            {
                return this.templateField;
            }
            set
            {
                this.templateField = value;
                this.RaisePropertyChanged("Template");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public MonetaryValue Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
                this.RaisePropertyChanged("Total");
            }
        }

        [XmlElement(Order=0x12)]
        public DateTime UpdatedTime
        {
            get
            {
                return this.updatedTimeField;
            }
            set
            {
                this.updatedTimeField = value;
                this.RaisePropertyChanged("UpdatedTime");
            }
        }

        [XmlIgnore]
        public bool UpdatedTimeSpecified
        {
            get
            {
                return this.updatedTimeFieldSpecified;
            }
            set
            {
                this.updatedTimeFieldSpecified = value;
                this.RaisePropertyChanged("UpdatedTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x13)]
        public QuoteNullFields ValidNullFields
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

