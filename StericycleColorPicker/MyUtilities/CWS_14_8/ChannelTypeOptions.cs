namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class ChannelTypeOptions : INotifyPropertyChanged
    {
        private bool contactVisibilityField;
        private bool contactVisibilityFieldSpecified;
        private bool incomingField;
        private bool incomingFieldSpecified;
        private bool monitoringField;
        private bool monitoringFieldSpecified;
        private bool outgoingField;
        private bool outgoingFieldSpecified;
        private bool subscriptionField;
        private bool subscriptionFieldSpecified;

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
        public bool ContactVisibility
        {
            get
            {
                return this.contactVisibilityField;
            }
            set
            {
                this.contactVisibilityField = value;
                this.RaisePropertyChanged("ContactVisibility");
            }
        }

        [XmlIgnore]
        public bool ContactVisibilitySpecified
        {
            get
            {
                return this.contactVisibilityFieldSpecified;
            }
            set
            {
                this.contactVisibilityFieldSpecified = value;
                this.RaisePropertyChanged("ContactVisibilitySpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool Incoming
        {
            get
            {
                return this.incomingField;
            }
            set
            {
                this.incomingField = value;
                this.RaisePropertyChanged("Incoming");
            }
        }

        [XmlIgnore]
        public bool IncomingSpecified
        {
            get
            {
                return this.incomingFieldSpecified;
            }
            set
            {
                this.incomingFieldSpecified = value;
                this.RaisePropertyChanged("IncomingSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool Monitoring
        {
            get
            {
                return this.monitoringField;
            }
            set
            {
                this.monitoringField = value;
                this.RaisePropertyChanged("Monitoring");
            }
        }

        [XmlIgnore]
        public bool MonitoringSpecified
        {
            get
            {
                return this.monitoringFieldSpecified;
            }
            set
            {
                this.monitoringFieldSpecified = value;
                this.RaisePropertyChanged("MonitoringSpecified");
            }
        }

        [XmlElement(Order=3)]
        public bool Outgoing
        {
            get
            {
                return this.outgoingField;
            }
            set
            {
                this.outgoingField = value;
                this.RaisePropertyChanged("Outgoing");
            }
        }

        [XmlIgnore]
        public bool OutgoingSpecified
        {
            get
            {
                return this.outgoingFieldSpecified;
            }
            set
            {
                this.outgoingFieldSpecified = value;
                this.RaisePropertyChanged("OutgoingSpecified");
            }
        }

        [XmlElement(Order=4)]
        public bool Subscription
        {
            get
            {
                return this.subscriptionField;
            }
            set
            {
                this.subscriptionField = value;
                this.RaisePropertyChanged("Subscription");
            }
        }

        [XmlIgnore]
        public bool SubscriptionSpecified
        {
            get
            {
                return this.subscriptionFieldSpecified;
            }
            set
            {
                this.subscriptionFieldSpecified = value;
                this.RaisePropertyChanged("SubscriptionSpecified");
            }
        }
    }
}

