namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class ChannelUsernameNullFields : INotifyPropertyChanged
    {
        private bool usernameField = false;
        private bool userNumberField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Username
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

        [XmlAttribute, DefaultValue(false)]
        public bool UserNumber
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
    }
}

