namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class OrganizationServiceSettings : INotifyPropertyChanged
    {
        private SLAInstance[] sLAInstancesField;
        private OrganizationServiceSettingsNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayItem("SLAInstanceList", IsNullable=false), XmlArray(IsNullable=true, Order=0)]
        public SLAInstance[] SLAInstances
        {
            get
            {
                return this.sLAInstancesField;
            }
            set
            {
                this.sLAInstancesField = value;
                this.RaisePropertyChanged("SLAInstances");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public OrganizationServiceSettingsNullFields ValidNullFields
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

