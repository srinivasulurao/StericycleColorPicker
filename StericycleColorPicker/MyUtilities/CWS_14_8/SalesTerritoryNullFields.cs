namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class SalesTerritoryNullFields : INotifyPropertyChanged
    {
        private bool adminVisibleInterfacesField = false;
        private bool commentField = false;
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

        [XmlAttribute, DefaultValue(false)]
        public bool Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
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
    }
}

