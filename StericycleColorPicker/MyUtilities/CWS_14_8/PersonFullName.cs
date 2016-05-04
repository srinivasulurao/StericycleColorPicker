namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class PersonFullName : INotifyPropertyChanged
    {
        private string firstField;
        private string lastField;

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
        public string First
        {
            get
            {
                return this.firstField;
            }
            set
            {
                this.firstField = value;
                this.RaisePropertyChanged("First");
            }
        }

        [XmlElement(Order=1)]
        public string Last
        {
            get
            {
                return this.lastField;
            }
            set
            {
                this.lastField = value;
                this.RaisePropertyChanged("Last");
            }
        }
    }
}

