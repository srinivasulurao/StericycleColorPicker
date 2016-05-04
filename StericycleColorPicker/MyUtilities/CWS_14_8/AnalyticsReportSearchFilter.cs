namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(AnalyticsReportFilter)), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AnalyticsReportSearchFilter : INotifyPropertyChanged
    {
        private string nameField;
        private NamedID operatorField;
        private string[] valuesField;

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
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(Order=1)]
        public NamedID Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
                this.RaisePropertyChanged("Operator");
            }
        }

        [XmlElement("Values", IsNullable=true, Order=2)]
        public string[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
                this.RaisePropertyChanged("Values");
            }
        }
    }
}

