namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class CRMModules : INotifyPropertyChanged
    {
        private bool marketingField;
        private bool marketingFieldSpecified;
        private bool salesField;
        private bool salesFieldSpecified;
        private bool serviceField;
        private bool serviceFieldSpecified;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=0)]
        public bool Marketing
        {
            get
            {
                return this.marketingField;
            }
            set
            {
                this.marketingField = value;
                this.RaisePropertyChanged("Marketing");
            }
        }

        [XmlIgnore]
        public bool MarketingSpecified
        {
            get
            {
                return this.marketingFieldSpecified;
            }
            set
            {
                this.marketingFieldSpecified = value;
                this.RaisePropertyChanged("MarketingSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool Sales
        {
            get
            {
                return this.salesField;
            }
            set
            {
                this.salesField = value;
                this.RaisePropertyChanged("Sales");
            }
        }

        [XmlIgnore]
        public bool SalesSpecified
        {
            get
            {
                return this.salesFieldSpecified;
            }
            set
            {
                this.salesFieldSpecified = value;
                this.RaisePropertyChanged("SalesSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
                this.RaisePropertyChanged("Service");
            }
        }

        [XmlIgnore]
        public bool ServiceSpecified
        {
            get
            {
                return this.serviceFieldSpecified;
            }
            set
            {
                this.serviceFieldSpecified = value;
                this.RaisePropertyChanged("ServiceSpecified");
            }
        }
    }
}

