namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class TransferSubObjectsMsg : INotifyPropertyChanged
    {
        private RNObject destinationRNObjectField;
        private RNObject[] sourceRNObjectsField;

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
        public RNObject DestinationRNObject
        {
            get
            {
                return this.destinationRNObjectField;
            }
            set
            {
                this.destinationRNObjectField = value;
                this.RaisePropertyChanged("DestinationRNObject");
            }
        }

        [XmlElement("SourceRNObjects", Order=1)]
        public RNObject[] SourceRNObjects
        {
            get
            {
                return this.sourceRNObjectsField;
            }
            set
            {
                this.sourceRNObjectsField = value;
                this.RaisePropertyChanged("SourceRNObjects");
            }
        }
    }
}

