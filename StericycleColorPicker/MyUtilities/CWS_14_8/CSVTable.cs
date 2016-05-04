namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class CSVTable : INotifyPropertyChanged
    {
        private string columnsField;
        private string nameField;
        private string[] rowsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=1)]
        public string Columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
                this.RaisePropertyChanged("Columns");
            }
        }

        [XmlElement(Order=0)]
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

        [XmlArrayItem("Row", IsNullable=false), XmlArray(Order=2)]
        public string[] Rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
                this.RaisePropertyChanged("Rows");
            }
        }
    }
}

