namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2")]
    public class CreateProcessingOptions : INotifyPropertyChanged
    {
        private bool suppressExternalEventsField;
        private bool suppressRulesField;

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
        public bool SuppressExternalEvents
        {
            get
            {
                return this.suppressExternalEventsField;
            }
            set
            {
                this.suppressExternalEventsField = value;
                this.RaisePropertyChanged("SuppressExternalEvents");
            }
        }

        [XmlElement(Order=1)]
        public bool SuppressRules
        {
            get
            {
                return this.suppressRulesField;
            }
            set
            {
                this.suppressRulesField = value;
                this.RaisePropertyChanged("SuppressRules");
            }
        }
    }
}

