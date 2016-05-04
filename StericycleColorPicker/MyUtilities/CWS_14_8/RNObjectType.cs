namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:generic.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class RNObjectType : INotifyPropertyChanged
    {
        private string namespaceField;
        private string typeNameField;

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
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
                this.RaisePropertyChanged("Namespace");
            }
        }

        [XmlElement(Order=1)]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
                this.RaisePropertyChanged("TypeName");
            }
        }
    }
}

