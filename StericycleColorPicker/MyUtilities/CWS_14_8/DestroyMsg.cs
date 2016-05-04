namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code")]
    public class DestroyMsg : INotifyPropertyChanged
    {
        private DestroyProcessingOptions processingOptionsField;
        private RNObject[] rNObjectsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=1)]
        public DestroyProcessingOptions ProcessingOptions
        {
            get
            {
                return this.processingOptionsField;
            }
            set
            {
                this.processingOptionsField = value;
                this.RaisePropertyChanged("ProcessingOptions");
            }
        }

        [XmlElement("RNObjects", Order=0)]
        public RNObject[] RNObjects
        {
            get
            {
                return this.rNObjectsField;
            }
            set
            {
                this.rNObjectsField = value;
                this.RaisePropertyChanged("RNObjects");
            }
        }
    }
}

