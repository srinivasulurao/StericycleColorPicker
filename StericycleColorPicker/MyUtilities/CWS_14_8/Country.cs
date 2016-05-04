namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class Country : RNObject
    {
        private string abbreviationField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private string iSOCodeField;
        private string nameField;
        private LabelRequired[] namesField;
        private string phoneCodeField;
        private string phoneMaskField;
        private string postalMaskField;
        private Province[] provincesField;
        private CountryNullFields validNullFieldsField;

        [XmlElement(Order=0)]
        public string Abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
                base.RaisePropertyChanged("Abbreviation");
            }
        }

        [XmlElement(Order=1)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                base.RaisePropertyChanged("DisplayOrder");
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
                base.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(Order=2)]
        public string ISOCode
        {
            get
            {
                return this.iSOCodeField;
            }
            set
            {
                this.iSOCodeField = value;
                base.RaisePropertyChanged("ISOCode");
            }
        }

        [XmlElement(Order=3)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlArray(Order=4), XmlArrayItem("LabelList", IsNullable=false)]
        public LabelRequired[] Names
        {
            get
            {
                return this.namesField;
            }
            set
            {
                this.namesField = value;
                base.RaisePropertyChanged("Names");
            }
        }

        [XmlElement(Order=5)]
        public string PhoneCode
        {
            get
            {
                return this.phoneCodeField;
            }
            set
            {
                this.phoneCodeField = value;
                base.RaisePropertyChanged("PhoneCode");
            }
        }

        [XmlElement(Order=6)]
        public string PhoneMask
        {
            get
            {
                return this.phoneMaskField;
            }
            set
            {
                this.phoneMaskField = value;
                base.RaisePropertyChanged("PhoneMask");
            }
        }

        [XmlElement(Order=7)]
        public string PostalMask
        {
            get
            {
                return this.postalMaskField;
            }
            set
            {
                this.postalMaskField = value;
                base.RaisePropertyChanged("PostalMask");
            }
        }

        [XmlArray(IsNullable=true, Order=8), XmlArrayItem("ProvinceList", IsNullable=false)]
        public Province[] Provinces
        {
            get
            {
                return this.provincesField;
            }
            set
            {
                this.provincesField = value;
                base.RaisePropertyChanged("Provinces");
            }
        }

        [XmlElement(IsNullable=true, Order=9)]
        public CountryNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

