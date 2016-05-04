namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class MailboxOutgoingEmailSettings : INotifyPropertyChanged
    {
        private string displayNameField;
        private string friendlyFromAddressField;
        private string fromAddressField;
        private bool? isEnabledField;
        private bool isEnabledFieldSpecified;
        private string replyToAddressField;
        private MailboxOutgoingEmailSettingsNullFields validNullFieldsField;

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
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
                this.RaisePropertyChanged("DisplayName");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public string FriendlyFromAddress
        {
            get
            {
                return this.friendlyFromAddressField;
            }
            set
            {
                this.friendlyFromAddressField = value;
                this.RaisePropertyChanged("FriendlyFromAddress");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string FromAddress
        {
            get
            {
                return this.fromAddressField;
            }
            set
            {
                this.fromAddressField = value;
                this.RaisePropertyChanged("FromAddress");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
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

        [XmlElement(IsNullable=true, Order=4)]
        public string ReplyToAddress
        {
            get
            {
                return this.replyToAddressField;
            }
            set
            {
                this.replyToAddressField = value;
                this.RaisePropertyChanged("ReplyToAddress");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public MailboxOutgoingEmailSettingsNullFields ValidNullFields
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

