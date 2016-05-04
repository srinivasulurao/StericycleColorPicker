namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class StandardContentUsage : INotifyPropertyChanged
    {
        private bool chatTextField;
        private bool chatTextFieldSpecified;
        private bool chatURLField;
        private bool chatURLFieldSpecified;
        private bool incidentTextField;
        private bool incidentTextFieldSpecified;
        private bool ruleTextField;
        private bool ruleTextFieldSpecified;

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
        public bool ChatText
        {
            get
            {
                return this.chatTextField;
            }
            set
            {
                this.chatTextField = value;
                this.RaisePropertyChanged("ChatText");
            }
        }

        [XmlIgnore]
        public bool ChatTextSpecified
        {
            get
            {
                return this.chatTextFieldSpecified;
            }
            set
            {
                this.chatTextFieldSpecified = value;
                this.RaisePropertyChanged("ChatTextSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool ChatURL
        {
            get
            {
                return this.chatURLField;
            }
            set
            {
                this.chatURLField = value;
                this.RaisePropertyChanged("ChatURL");
            }
        }

        [XmlIgnore]
        public bool ChatURLSpecified
        {
            get
            {
                return this.chatURLFieldSpecified;
            }
            set
            {
                this.chatURLFieldSpecified = value;
                this.RaisePropertyChanged("ChatURLSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool IncidentText
        {
            get
            {
                return this.incidentTextField;
            }
            set
            {
                this.incidentTextField = value;
                this.RaisePropertyChanged("IncidentText");
            }
        }

        [XmlIgnore]
        public bool IncidentTextSpecified
        {
            get
            {
                return this.incidentTextFieldSpecified;
            }
            set
            {
                this.incidentTextFieldSpecified = value;
                this.RaisePropertyChanged("IncidentTextSpecified");
            }
        }

        [XmlElement(Order=3)]
        public bool RuleText
        {
            get
            {
                return this.ruleTextField;
            }
            set
            {
                this.ruleTextField = value;
                this.RaisePropertyChanged("RuleText");
            }
        }

        [XmlIgnore]
        public bool RuleTextSpecified
        {
            get
            {
                return this.ruleTextFieldSpecified;
            }
            set
            {
                this.ruleTextFieldSpecified = value;
                this.RaisePropertyChanged("RuleTextSpecified");
            }
        }
    }
}

