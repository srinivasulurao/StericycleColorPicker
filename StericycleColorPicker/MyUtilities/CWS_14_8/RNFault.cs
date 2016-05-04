namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlInclude(typeof(ServerErrorFaultType)), XmlInclude(typeof(UnexpectedErrorFaultType)), XmlInclude(typeof(RequestErrorFaultType)), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class RNFault : INotifyPropertyChanged
    {
        private ExceptionCode exceptionCodeField;
        private string exceptionMessageField;

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
        public ExceptionCode exceptionCode
        {
            get
            {
                return this.exceptionCodeField;
            }
            set
            {
                this.exceptionCodeField = value;
                this.RaisePropertyChanged("exceptionCode");
            }
        }

        [XmlElement(Order=1)]
        public string exceptionMessage
        {
            get
            {
                return this.exceptionMessageField;
            }
            set
            {
                this.exceptionMessageField = value;
                this.RaisePropertyChanged("exceptionMessage");
            }
        }
    }
}

