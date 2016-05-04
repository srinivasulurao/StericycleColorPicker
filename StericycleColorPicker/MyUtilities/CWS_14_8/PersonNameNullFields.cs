namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class PersonNameNullFields : INotifyPropertyChanged
    {
        private bool firstField = false;
        private bool lastField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool First
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

        [XmlAttribute, DefaultValue(false)]
        public bool Last
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

