namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2")]
    public class TaskMarketingSettingsNullFields : INotifyPropertyChanged
    {
        private bool campaignField = false;
        private bool documentField = false;
        private bool mailingField = false;
        private bool surveyField = false;

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
        public bool Campaign
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

        [DefaultValue(false), XmlAttribute]
        public bool Document
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

        [DefaultValue(false), XmlAttribute]
        public bool Mailing
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

        [DefaultValue(false), XmlAttribute]
        public bool Survey
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
    }
}

