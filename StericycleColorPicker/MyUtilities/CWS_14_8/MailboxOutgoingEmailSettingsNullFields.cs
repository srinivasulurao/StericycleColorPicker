namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class MailboxOutgoingEmailSettingsNullFields : INotifyPropertyChanged
    {
        private bool displayNameField = false;
        private bool friendlyFromAddressField = false;
        private bool fromAddressField = false;
        private bool isEnabledField = false;
        private bool replyToAddressField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool DisplayName
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

        [XmlAttribute, DefaultValue(false)]
        public bool FriendlyFromAddress
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

        [DefaultValue(false), XmlAttribute]
        public bool FromAddress
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

        [DefaultValue(false), XmlAttribute]
        public bool IsEnabled
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

        [DefaultValue(false), XmlAttribute]
        public bool ReplyToAddress
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
    }
}

