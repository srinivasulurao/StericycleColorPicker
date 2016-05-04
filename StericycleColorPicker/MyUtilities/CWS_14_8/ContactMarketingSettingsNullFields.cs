namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class ContactMarketingSettingsNullFields : INotifyPropertyChanged
    {
        private bool contactListsField = false;
        private bool emailFormatField = false;
        private bool marketingOptInField = false;
        private bool marketingOrganizationNameAltField = false;
        private bool marketingOrganizationNameField = false;
        private bool surveyOptInField = false;

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
        public bool ContactLists
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

        [XmlAttribute, DefaultValue(false)]
        public bool EmailFormat
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

        [XmlAttribute, DefaultValue(false)]
        public bool MarketingOptIn
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

        [XmlAttribute, DefaultValue(false)]
        public bool MarketingOrganizationName
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

        [DefaultValue(false), XmlAttribute]
        public bool MarketingOrganizationNameAlt
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

        [DefaultValue(false), XmlAttribute]
        public bool SurveyOptIn
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
    }
}

