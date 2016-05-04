namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class MailboxIncomingEmailSettings : INotifyPropertyChanged
    {
        private bool? forceReplyBetweenLinesField;
        private bool forceReplyBetweenLinesFieldSpecified;
        private string forwardRejectMessageAddressField;
        private bool? isEnabledField;
        private bool isEnabledFieldSpecified;
        private MailboxIncomingEmailSettingsNullFields validNullFieldsField;

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
        public bool? ForceReplyBetweenLines
        {
            get
            {
                return this.forceReplyBetweenLinesField;
            }
            set
            {
                this.forceReplyBetweenLinesField = value;
                this.RaisePropertyChanged("ForceReplyBetweenLines");
            }
        }

        [XmlIgnore]
        public bool ForceReplyBetweenLinesSpecified
        {
            get
            {
                return this.forceReplyBetweenLinesFieldSpecified;
            }
            set
            {
                this.forceReplyBetweenLinesFieldSpecified = value;
                this.RaisePropertyChanged("ForceReplyBetweenLinesSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public string ForwardRejectMessageAddress
        {
            get
            {
                return this.forwardRejectMessageAddressField;
            }
            set
            {
                this.forwardRejectMessageAddressField = value;
                this.RaisePropertyChanged("ForwardRejectMessageAddress");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public bool? IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
                this.RaisePropertyChanged("IsEnabled");
            }
        }

        [XmlIgnore]
        public bool IsEnabledSpecified
        {
            get
            {
                return this.isEnabledFieldSpecified;
            }
            set
            {
                this.isEnabledFieldSpecified = value;
                this.RaisePropertyChanged("IsEnabledSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public MailboxIncomingEmailSettingsNullFields ValidNullFields
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

