namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class StandardContentNullFields : INotifyPropertyChanged
    {
        private bool adminVisibleInterfacesField = false;
        private bool contentValuesField = false;
        private bool folderField = false;
        private bool hotKeyField = false;

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
        public bool ContentValues
        {
            get
            {
                return this.contentValuesField;
            }
            set
            {
                this.contentValuesField = value;
                this.RaisePropertyChanged("ContentValues");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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
        public bool HotKey
        {
            get
            {
                return this.hotKeyField;
            }
            set
            {
                this.hotKeyField = value;
                this.RaisePropertyChanged("HotKey");
            }
        }
    }
}

