namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class ServiceDispositionNullFields : INotifyPropertyChanged
    {
        private bool adminVisibleInterfacesField = false;
        private bool descriptionsField = false;
        private bool parentField = false;
        private bool productLinksField = false;

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
        public bool AdminVisibleInterfaces
        {
            get
            {
                return this.adminVisibleInterfacesField;
            }
            set
            {
                this.adminVisibleInterfacesField = value;
                this.RaisePropertyChanged("AdminVisibleInterfaces");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Descriptions
        {
            get
            {
                return this.descriptionsField;
            }
            set
            {
                this.descriptionsField = value;
                this.RaisePropertyChanged("Descriptions");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
                this.RaisePropertyChanged("Parent");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool ProductLinks
        {
            get
            {
                return this.productLinksField;
            }
            set
            {
                this.productLinksField = value;
                this.RaisePropertyChanged("ProductLinks");
            }
        }
    }
}

