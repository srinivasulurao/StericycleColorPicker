namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class GetValuesForNamedIDHierarchyResponseMsg : INotifyPropertyChanged
    {
        private NamedIDWithParent[] entryField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("Entry", Order=0)]
        public NamedIDWithParent[] Entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
                this.RaisePropertyChanged("Entry");
            }
        }
    }
}

