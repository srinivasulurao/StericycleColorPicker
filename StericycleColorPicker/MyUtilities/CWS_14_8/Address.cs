namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), XmlInclude(typeof(TypedAddress)), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class Address : INotifyPropertyChanged
    {
        private string cityField;
        private NamedID countryField;
        private string postalCodeField;
        private NamedID stateOrProvinceField;
        private string streetField;
        private AddressNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
                this.RaisePropertyChanged("PostalCode");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID StateOrProvince
        {
            get
            {
                return this.stateOrProvinceField;
            }
            set
            {
                this.stateOrProvinceField = value;
                this.RaisePropertyChanged("StateOrProvince");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
                this.RaisePropertyChanged("Street");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public AddressNullFields ValidNullFields
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

