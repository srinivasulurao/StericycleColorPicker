namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class QuoteLineItemNullFields : INotifyPropertyChanged
    {
        private bool adjustedDescriptionField = false;
        private bool adjustedNameField = false;
        private bool adjustedPartNumberField = false;
        private bool adjustedPriceField = false;
        private bool adjustedTotalField = false;
        private bool commentField = false;
        private bool productField = false;

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
        public bool AdjustedDescription
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

        [DefaultValue(false), XmlAttribute]
        public bool AdjustedName
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

        [XmlAttribute, DefaultValue(false)]
        public bool AdjustedPartNumber
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

        [XmlAttribute, DefaultValue(false)]
        public bool AdjustedPrice
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
    }
}

