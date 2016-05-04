namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Organization)), XmlInclude(typeof(Holiday)), XmlInclude(typeof(Country)), XmlType(Namespace="urn:base.ws.rightnow.com/v1_2"), XmlInclude(typeof(Variable)), XmlInclude(typeof(Task)), XmlInclude(typeof(StandardContent)), XmlInclude(typeof(SiteInterface)), XmlInclude(typeof(ServiceProduct)), XmlInclude(typeof(ServiceDisposition)), XmlInclude(typeof(ServiceCategory)), XmlInclude(typeof(SalesTerritory)), XmlInclude(typeof(SalesProduct)), XmlInclude(typeof(PurchasedProduct)), XmlInclude(typeof(Opportunity)), XmlInclude(typeof(MessageBase)), XmlInclude(typeof(Mailbox)), XmlInclude(typeof(ServiceMailbox)), XmlInclude(typeof(MarketingMailbox)), XmlInclude(typeof(Incident)), XmlInclude(typeof(Contact)), XmlInclude(typeof(Configuration)), XmlInclude(typeof(ChannelType)), XmlInclude(typeof(AssetStatus)), XmlInclude(typeof(Asset)), XmlInclude(typeof(Answer)), XmlInclude(typeof(AnalyticsReport)), XmlInclude(typeof(Account)), XmlInclude(typeof(GenericObject)), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class RNObject : INotifyPropertyChanged
    {
        private DateTime createdTimeField;
        private bool createdTimeFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private string lookupNameField;
        private DateTime updatedTimeField;
        private bool updatedTimeFieldSpecified;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=2)]
        public DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
                this.RaisePropertyChanged("CreatedTime");
            }
        }

        [XmlIgnore]
        public bool CreatedTimeSpecified
        {
            get
            {
                return this.createdTimeFieldSpecified;
            }
            set
            {
                this.createdTimeFieldSpecified = value;
                this.RaisePropertyChanged("CreatedTimeSpecified");
            }
        }

        [XmlElement(Order=0)]
        public MyUtilities.CWS_14_8.ID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(Order=1)]
        public string LookupName
        {
            get
            {
                return this.lookupNameField;
            }
            set
            {
                this.lookupNameField = value;
                this.RaisePropertyChanged("LookupName");
            }
        }

        [XmlElement(Order=3)]
        public DateTime UpdatedTime
        {
            get
            {
                return this.updatedTimeField;
            }
            set
            {
                this.updatedTimeField = value;
                this.RaisePropertyChanged("UpdatedTime");
            }
        }

        [XmlIgnore]
        public bool UpdatedTimeSpecified
        {
            get
            {
                return this.updatedTimeFieldSpecified;
            }
            set
            {
                this.updatedTimeFieldSpecified = value;
                this.RaisePropertyChanged("UpdatedTimeSpecified");
            }
        }
    }
}

