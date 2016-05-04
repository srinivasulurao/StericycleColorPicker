namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2")]
    public class AddressNullFields : INotifyPropertyChanged
    {
        private bool cityField = false;
        private bool countryField = false;
        private bool postalCodeField = false;
        private bool stateOrProvinceField = false;
        private bool streetField = false;

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
        public bool City
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

        [DefaultValue(false), XmlAttribute]
        public bool Country
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

        [DefaultValue(false), XmlAttribute]
        public bool PostalCode
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

        [DefaultValue(false), XmlAttribute]
        public bool StateOrProvince
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

        [XmlAttribute, DefaultValue(false)]
        public bool Street
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
    }
}

