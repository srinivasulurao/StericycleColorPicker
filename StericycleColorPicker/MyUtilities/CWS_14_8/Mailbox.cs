namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(ServiceMailbox)), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), XmlInclude(typeof(MarketingMailbox)), DebuggerStepThrough, DesignerCategory("code")]
    public class Mailbox : RNObject
    {
        private MailboxIncomingEmailSettings incomingEmailSettingsField;
        private NamedID interfaceField;
        private bool? isDefaultField;
        private bool isDefaultFieldSpecified;
        private string nameField;
        private MailboxOutgoingEmailSettings outgoingEmailSettingsField;
        private NamedID typeField;
        private MailboxNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public MailboxIncomingEmailSettings IncomingEmailSettings
        {
            get
            {
                return this.incomingEmailSettingsField;
            }
            set
            {
                this.incomingEmailSettingsField = value;
                base.RaisePropertyChanged("IncomingEmailSettings");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
                base.RaisePropertyChanged("Interface");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public bool? IsDefault
        {
            get
            {
                return this.isDefaultField;
            }
            set
            {
                this.isDefaultField = value;
                base.RaisePropertyChanged("IsDefault");
            }
        }

        [XmlIgnore]
        public bool IsDefaultSpecified
        {
            get
            {
                return this.isDefaultFieldSpecified;
            }
            set
            {
                this.isDefaultFieldSpecified = value;
                base.RaisePropertyChanged("IsDefaultSpecified");
            }
        }

        [XmlElement(Order=3)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public MailboxOutgoingEmailSettings OutgoingEmailSettings
        {
            get
            {
                return this.outgoingEmailSettingsField;
            }
            set
            {
                this.outgoingEmailSettingsField = value;
                base.RaisePropertyChanged("OutgoingEmailSettings");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public NamedID Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                base.RaisePropertyChanged("Type");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public MailboxNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

