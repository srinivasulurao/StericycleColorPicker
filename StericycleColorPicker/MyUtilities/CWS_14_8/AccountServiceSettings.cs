namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class AccountServiceSettings : INotifyPropertyChanged
    {
        private int screenPopPortField;
        private bool screenPopPortFieldSpecified;

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
        public int ScreenPopPort
        {
            get
            {
                return this.screenPopPortField;
            }
            set
            {
                this.screenPopPortField = value;
                this.RaisePropertyChanged("ScreenPopPort");
            }
        }

        [XmlIgnore]
        public bool ScreenPopPortSpecified
        {
            get
            {
                return this.screenPopPortFieldSpecified;
            }
            set
            {
                this.screenPopPortFieldSpecified = value;
                this.RaisePropertyChanged("ScreenPopPortSpecified");
            }
        }
    }
}

