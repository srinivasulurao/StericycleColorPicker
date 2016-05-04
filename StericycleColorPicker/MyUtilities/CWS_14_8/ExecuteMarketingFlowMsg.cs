namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class ExecuteMarketingFlowMsg : INotifyPropertyChanged
    {
        private ID campaignIDField;
        private ID contactIDField;
        private string entryPointField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=1)]
        public ID CampaignID
        {
            get
            {
                return this.campaignIDField;
            }
            set
            {
                this.campaignIDField = value;
                this.RaisePropertyChanged("CampaignID");
            }
        }

        [XmlElement(Order=0)]
        public ID ContactID
        {
            get
            {
                return this.contactIDField;
            }
            set
            {
                this.contactIDField = value;
                this.RaisePropertyChanged("ContactID");
            }
        }

        [XmlElement(Order=2)]
        public string EntryPoint
        {
            get
            {
                return this.entryPointField;
            }
            set
            {
                this.entryPointField = value;
                this.RaisePropertyChanged("EntryPoint");
            }
        }
    }
}

