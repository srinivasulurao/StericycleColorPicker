namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class CSVTableSet : INotifyPropertyChanged
    {
        private CSVTable[] cSVTablesField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayItem(IsNullable=false), XmlArray(Order=0)]
        public CSVTable[] CSVTables
        {
            get
            {
                return this.cSVTablesField;
            }
            set
            {
                this.cSVTablesField = value;
                this.RaisePropertyChanged("CSVTables");
            }
        }
    }
}

