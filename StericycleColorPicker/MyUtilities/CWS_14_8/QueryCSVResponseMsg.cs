namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class QueryCSVResponseMsg : INotifyPropertyChanged
    {
        private MyUtilities.CWS_14_8.CSVTableSet cSVTableSetField;
        private byte[] fileDataField;

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
        public MyUtilities.CWS_14_8.CSVTableSet CSVTableSet
        {
            get
            {
                return this.cSVTableSetField;
            }
            set
            {
                this.cSVTableSetField = value;
                this.RaisePropertyChanged("CSVTableSet");
            }
        }

        [XmlElement(DataType="base64Binary", Order=1)]
        public byte[] FileData
        {
            get
            {
                return this.fileDataField;
            }
            set
            {
                this.fileDataField = value;
                this.RaisePropertyChanged("FileData");
            }
        }
    }
}

