namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code")]
    public class AssignedSLAInstanceNullFields : INotifyPropertyChanged
    {
        private bool nameOfSLAField = false;

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
        public bool NameOfSLA
        {
            get
            {
                return this.nameOfSLAField;
            }
            set
            {
                this.nameOfSLAField = value;
                this.RaisePropertyChanged("NameOfSLA");
            }
        }
    }
}

