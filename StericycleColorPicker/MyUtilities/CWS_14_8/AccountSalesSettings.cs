namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AccountSalesSettings : INotifyPropertyChanged
    {
        private NamedID defaultCurrencyField;
        private NamedIDHierarchy territoryField;
        private AccountSalesSettingsNullFields validNullFieldsField;

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
        public NamedID DefaultCurrency
        {
            get
            {
                return this.defaultCurrencyField;
            }
            set
            {
                this.defaultCurrencyField = value;
                this.RaisePropertyChanged("DefaultCurrency");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedIDHierarchy Territory
        {
            get
            {
                return this.territoryField;
            }
            set
            {
                this.territoryField = value;
                this.RaisePropertyChanged("Territory");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public AccountSalesSettingsNullFields ValidNullFields
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

