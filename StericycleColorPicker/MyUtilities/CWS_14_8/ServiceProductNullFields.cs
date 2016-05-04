namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class ServiceProductNullFields : INotifyPropertyChanged
    {
        private bool adminVisibleInterfacesField = false;
        private bool categoryLinksField = false;
        private bool descriptionsField = false;
        private bool dispositionLinksField = false;
        private bool endUserVisibleInterfacesField = false;
        private bool parentField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
        public bool CategoryLinks
        {
            get
            {
                return this.categoryLinksField;
            }
            set
            {
                this.categoryLinksField = value;
                this.RaisePropertyChanged("CategoryLinks");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
        public bool DispositionLinks
        {
            get
            {
                return this.dispositionLinksField;
            }
            set
            {
                this.dispositionLinksField = value;
                this.RaisePropertyChanged("DispositionLinks");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool EndUserVisibleInterfaces
        {
            get
            {
                return this.endUserVisibleInterfacesField;
            }
            set
            {
                this.endUserVisibleInterfacesField = value;
                this.RaisePropertyChanged("EndUserVisibleInterfaces");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
    }
}

