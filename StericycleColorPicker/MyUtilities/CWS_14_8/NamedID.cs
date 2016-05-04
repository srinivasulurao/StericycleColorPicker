namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(AccessLevelType)), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:base.ws.rightnow.com/v1_2"), XmlInclude(typeof(NamedIDDelta)), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlInclude(typeof(NamedReadOnlyID))]
    public class NamedID : INotifyPropertyChanged
    {
        private MyUtilities.CWS_14_8.ID idField;
        private string nameField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=0)]
        public MyUtilities.CWS_14_8.ID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
    }
}

