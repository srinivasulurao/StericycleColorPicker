namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class GetValuesForNamedIDMsg : INotifyPropertyChanged
    {
        private string fieldNameField;
        private string packageNameField;

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
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
                this.RaisePropertyChanged("FieldName");
            }
        }

        [XmlElement(Order=0)]
        public string PackageName
        {
            get
            {
                return this.packageNameField;
            }
            set
            {
                this.packageNameField = value;
                this.RaisePropertyChanged("PackageName");
            }
        }
    }
}

