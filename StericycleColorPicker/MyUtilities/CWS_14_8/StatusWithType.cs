namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class StatusWithType : INotifyPropertyChanged
    {
        private NamedID statusField;
        private NamedID statusTypeField;

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
        public NamedID Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }

        [XmlElement(Order=1)]
        public NamedID StatusType
        {
            get
            {
                return this.statusTypeField;
            }
            set
            {
                this.statusTypeField = value;
                this.RaisePropertyChanged("StatusType");
            }
        }
    }
}

