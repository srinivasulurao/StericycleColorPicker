namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class SalesProductOptions : INotifyPropertyChanged
    {
        private bool hasSerialNumberField;
        private bool hasSerialNumberFieldSpecified;
        private bool isSalesProductField;
        private bool isSalesProductFieldSpecified;
        private bool isServiceProductField;
        private bool isServiceProductFieldSpecified;

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
        public bool HasSerialNumber
        {
            get
            {
                return this.hasSerialNumberField;
            }
            set
            {
                this.hasSerialNumberField = value;
                this.RaisePropertyChanged("HasSerialNumber");
            }
        }

        [XmlIgnore]
        public bool HasSerialNumberSpecified
        {
            get
            {
                return this.hasSerialNumberFieldSpecified;
            }
            set
            {
                this.hasSerialNumberFieldSpecified = value;
                this.RaisePropertyChanged("HasSerialNumberSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool IsSalesProduct
        {
            get
            {
                return this.isSalesProductField;
            }
            set
            {
                this.isSalesProductField = value;
                this.RaisePropertyChanged("IsSalesProduct");
            }
        }

        [XmlIgnore]
        public bool IsSalesProductSpecified
        {
            get
            {
                return this.isSalesProductFieldSpecified;
            }
            set
            {
                this.isSalesProductFieldSpecified = value;
                this.RaisePropertyChanged("IsSalesProductSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool IsServiceProduct
        {
            get
            {
                return this.isServiceProductField;
            }
            set
            {
                this.isServiceProductField = value;
                this.RaisePropertyChanged("IsServiceProduct");
            }
        }

        [XmlIgnore]
        public bool IsServiceProductSpecified
        {
            get
            {
                return this.isServiceProductFieldSpecified;
            }
            set
            {
                this.isServiceProductFieldSpecified = value;
                this.RaisePropertyChanged("IsServiceProductSpecified");
            }
        }
    }
}

