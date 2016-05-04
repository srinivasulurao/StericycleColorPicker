namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2")]
    public class SalesProductNullFields : INotifyPropertyChanged
    {
        private bool adminVisibleInterfacesField = false;
        private bool descriptionsField = false;
        private bool folderField = false;
        private bool partNumberField = false;
        private bool schedulesField = false;
        private bool serviceProductField = false;

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
        public bool Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
                this.RaisePropertyChanged("Folder");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
                this.RaisePropertyChanged("PartNumber");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Schedules
        {
            get
            {
                return this.schedulesField;
            }
            set
            {
                this.schedulesField = value;
                this.RaisePropertyChanged("Schedules");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool ServiceProduct
        {
            get
            {
                return this.serviceProductField;
            }
            set
            {
                this.serviceProductField = value;
                this.RaisePropertyChanged("ServiceProduct");
            }
        }
    }
}

