namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class ThreadNullFields : INotifyPropertyChanged
    {
        private bool channelField = false;
        private bool contactField = false;
        private bool mailHeaderField = false;

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
        public bool Channel
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

        [DefaultValue(false), XmlAttribute]
        public bool Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                this.RaisePropertyChanged("Contact");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool MailHeader
        {
            get
            {
                return this.mailHeaderField;
            }
            set
            {
                this.mailHeaderField = value;
                this.RaisePropertyChanged("MailHeader");
            }
        }
    }
}

