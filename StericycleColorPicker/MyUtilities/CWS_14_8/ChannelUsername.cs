namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class ChannelUsername : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID channelField;
        private NamedID channelTypeField;
        private string usernameField;
        private string userNumberField;
        private ChannelUsernameNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute]
        public ActionEnum action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }

        [XmlIgnore]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(Order=0)]
        public NamedID Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
                this.RaisePropertyChanged("Channel");
            }
        }

        [XmlElement(Order=1)]
        public NamedID ChannelType
        {
            get
            {
                return this.channelTypeField;
            }
            set
            {
                this.channelTypeField = value;
                this.RaisePropertyChanged("ChannelType");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public string UserNumber
        {
            get
            {
                return this.userNumberField;
            }
            set
            {
                this.userNumberField = value;
                this.RaisePropertyChanged("UserNumber");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public ChannelUsernameNullFields ValidNullFields
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

