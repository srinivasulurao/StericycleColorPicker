namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class GetMetaDataLastChangeTimeResponseMsg : INotifyPropertyChanged
    {
        private DateTime lastChangeDateTimeField;

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
        public DateTime LastChangeDateTime
        {
            get
            {
                return this.lastChangeDateTimeField;
            }
            set
            {
                this.lastChangeDateTimeField = value;
                this.RaisePropertyChanged("LastChangeDateTime");
            }
        }
    }
}

