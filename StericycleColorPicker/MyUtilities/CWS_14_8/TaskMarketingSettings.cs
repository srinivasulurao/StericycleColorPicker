namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class TaskMarketingSettings : INotifyPropertyChanged
    {
        private NamedID campaignField;
        private NamedID documentField;
        private NamedID mailingField;
        private NamedID surveyField;
        private TaskMarketingSettingsNullFields validNullFieldsField;

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
        public NamedID Campaign
        {
            get
            {
                return this.campaignField;
            }
            set
            {
                this.campaignField = value;
                this.RaisePropertyChanged("Campaign");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
                this.RaisePropertyChanged("Document");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public NamedID Mailing
        {
            get
            {
                return this.mailingField;
            }
            set
            {
                this.mailingField = value;
                this.RaisePropertyChanged("Mailing");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID Survey
        {
            get
            {
                return this.surveyField;
            }
            set
            {
                this.surveyField = value;
                this.RaisePropertyChanged("Survey");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public TaskMarketingSettingsNullFields ValidNullFields
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

