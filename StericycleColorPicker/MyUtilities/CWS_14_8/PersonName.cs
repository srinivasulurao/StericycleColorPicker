namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class PersonName : INotifyPropertyChanged
    {
        private string firstField;
        private string lastField;
        private PersonNameNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
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

        [XmlElement(IsNullable=true, Order=1)]
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

        [XmlElement(IsNullable=true, Order=2)]
        public PersonNameNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                this.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

