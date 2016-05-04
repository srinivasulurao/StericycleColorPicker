namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class QuoteNullFields : INotifyPropertyChanged
    {
        private bool adjustedTotalField = false;
        private bool commentField = false;
        private bool fileAttachmentsField = false;
        private bool lineItemsField = false;
        private bool offerEndTimeField = false;
        private bool offerStartTimeField = false;
        private bool priceScheduleField = false;
        private bool sentTimeField = false;
        private bool sentToField = false;
        private bool statusField = false;
        private bool templateField = false;
        private bool totalField = false;

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
        public bool AdjustedTotal
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
        public bool FileAttachments
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

        [DefaultValue(false), XmlAttribute]
        public bool LineItems
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

        [XmlAttribute, DefaultValue(false)]
        public bool OfferEndTime
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

        [DefaultValue(false), XmlAttribute]
        public bool OfferStartTime
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

        [XmlAttribute, DefaultValue(false)]
        public bool PriceSchedule
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

        [XmlAttribute, DefaultValue(false)]
        public bool SentTime
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

        [XmlAttribute, DefaultValue(false)]
        public bool SentTo
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

        [XmlAttribute, DefaultValue(false)]
        public bool Status
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

        [DefaultValue(false), XmlAttribute]
        public bool Template
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

        [DefaultValue(false), XmlAttribute]
        public bool Total
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
    }
}

