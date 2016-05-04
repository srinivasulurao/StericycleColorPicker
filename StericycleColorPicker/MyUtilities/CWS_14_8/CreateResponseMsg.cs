namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class CreateResponseMsg : INotifyPropertyChanged
    {
        private RNObject[] rNObjectsResultField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayItem("RNObjects", IsNullable=false), XmlArray(Order=0)]
        public RNObject[] RNObjectsResult
        {
            get
            {
                return this.rNObjectsResultField;
            }
            set
            {
                this.rNObjectsResultField = value;
                this.RaisePropertyChanged("RNObjectsResult");
            }
        }
    }
}

