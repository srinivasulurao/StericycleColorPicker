namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class ContactMarketingSettings : INotifyPropertyChanged
    {
        private NamedIDDelta[] contactListsField;
        private NamedID emailFormatField;
        private bool? marketingOptInField;
        private bool marketingOptInFieldSpecified;
        private string marketingOrganizationNameAltField;
        private string marketingOrganizationNameField;
        private bool? surveyOptInField;
        private bool surveyOptInFieldSpecified;
        private ContactMarketingSettingsNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArray(IsNullable=true, Order=0), XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedIDDelta[] ContactLists
        {
            get
            {
                return this.contactListsField;
            }
            set
            {
                this.contactListsField = value;
                this.RaisePropertyChanged("ContactLists");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID EmailFormat
        {
            get
            {
                return this.emailFormatField;
            }
            set
            {
                this.emailFormatField = value;
                this.RaisePropertyChanged("EmailFormat");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public bool? MarketingOptIn
        {
            get
            {
                return this.marketingOptInField;
            }
            set
            {
                this.marketingOptInField = value;
                this.RaisePropertyChanged("MarketingOptIn");
            }
        }

        [XmlIgnore]
        public bool MarketingOptInSpecified
        {
            get
            {
                return this.marketingOptInFieldSpecified;
            }
            set
            {
                this.marketingOptInFieldSpecified = value;
                this.RaisePropertyChanged("MarketingOptInSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public string MarketingOrganizationName
        {
            get
            {
                return this.marketingOrganizationNameField;
            }
            set
            {
                this.marketingOrganizationNameField = value;
                this.RaisePropertyChanged("MarketingOrganizationName");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public string MarketingOrganizationNameAlt
        {
            get
            {
                return this.marketingOrganizationNameAltField;
            }
            set
            {
                this.marketingOrganizationNameAltField = value;
                this.RaisePropertyChanged("MarketingOrganizationNameAlt");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public bool? SurveyOptIn
        {
            get
            {
                return this.surveyOptInField;
            }
            set
            {
                this.surveyOptInField = value;
                this.RaisePropertyChanged("SurveyOptIn");
            }
        }

        [XmlIgnore]
        public bool SurveyOptInSpecified
        {
            get
            {
                return this.surveyOptInFieldSpecified;
            }
            set
            {
                this.surveyOptInFieldSpecified = value;
                this.RaisePropertyChanged("SurveyOptInSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public ContactMarketingSettingsNullFields ValidNullFields
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

