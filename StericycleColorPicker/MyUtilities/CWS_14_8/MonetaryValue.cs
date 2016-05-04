namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class MonetaryValue : INotifyPropertyChanged
    {
        private NamedID currencyField;
        private NamedID exchangeRateField;
        private MonetaryValueNullFields validNullFieldsField;
        private double valueField;
        private bool valueFieldSpecified;

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
        public NamedID Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
                this.RaisePropertyChanged("Currency");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
                this.RaisePropertyChanged("ExchangeRate");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public MonetaryValueNullFields ValidNullFields
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

        [XmlElement(Order=2)]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        [XmlIgnore]
        public bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
                this.RaisePropertyChanged("ValueSpecified");
            }
        }
    }
}

