namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class MailboxIncomingEmailSettingsNullFields : INotifyPropertyChanged
    {
        private bool forceReplyBetweenLinesField = false;
        private bool forwardRejectMessageAddressField = false;
        private bool isEnabledField = false;

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
        public bool ForceReplyBetweenLines
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

        [XmlAttribute, DefaultValue(false)]
        public bool ForwardRejectMessageAddress
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
    }
}

