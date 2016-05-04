namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class SendMailingToContactMsg : INotifyPropertyChanged
    {
        private ID chatIDField;
        private ID contactIDField;
        private ID incidentIDField;
        private ID mailingIDField;
        private ID opportunityIDField;
        private DateTime? scheduledTimeField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=5)]
        public ID ChatID
        {
            get
            {
                return this.chatIDField;
            }
            set
            {
                this.chatIDField = value;
                this.RaisePropertyChanged("ChatID");
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

        [XmlElement(IsNullable=true, Order=3)]
        public ID IncidentID
        {
            get
            {
                return this.incidentIDField;
            }
            set
            {
                this.incidentIDField = value;
                this.RaisePropertyChanged("IncidentID");
            }
        }

        [XmlElement(Order=1)]
        public ID MailingID
        {
            get
            {
                return this.mailingIDField;
            }
            set
            {
                this.mailingIDField = value;
                this.RaisePropertyChanged("MailingID");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public ID OpportunityID
        {
            get
            {
                return this.opportunityIDField;
            }
            set
            {
                this.opportunityIDField = value;
                this.RaisePropertyChanged("OpportunityID");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public DateTime? ScheduledTime
        {
            get
            {
                return this.scheduledTimeField;
            }
            set
            {
                this.scheduledTimeField = value;
                this.RaisePropertyChanged("ScheduledTime");
            }
        }
    }
}

