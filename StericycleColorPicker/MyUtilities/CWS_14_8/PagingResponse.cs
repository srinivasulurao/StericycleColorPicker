namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough]
    public class PagingResponse : INotifyPropertyChanged
    {
        private string queryHandleField;
        private int returnedCountField;
        private int startIndexField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=2)]
        public string QueryHandle
        {
            get
            {
                return this.queryHandleField;
            }
            set
            {
                this.queryHandleField = value;
                this.RaisePropertyChanged("QueryHandle");
            }
        }

        [XmlElement(Order=0)]
        public int ReturnedCount
        {
            get
            {
                return this.returnedCountField;
            }
            set
            {
                this.returnedCountField = value;
                this.RaisePropertyChanged("ReturnedCount");
            }
        }

        [XmlElement(Order=1)]
        public int StartIndex
        {
            get
            {
                return this.startIndexField;
            }
            set
            {
                this.startIndexField = value;
                this.RaisePropertyChanged("StartIndex");
            }
        }
    }
}

