namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class QueryMsg : INotifyPropertyChanged
    {
        private string delimiterField;
        private bool disableMTOMField;
        private bool disableMTOMFieldSpecified;
        private int pageSizeField;
        private bool pageSizeFieldSpecified;
        private string queryField;
        private bool returnRawResultField;
        private bool returnRawResultFieldSpecified;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=2)]
        public string Delimiter
        {
            get
            {
                return this.delimiterField;
            }
            set
            {
                this.delimiterField = value;
                this.RaisePropertyChanged("Delimiter");
            }
        }

        [XmlElement(Order=4)]
        public bool DisableMTOM
        {
            get
            {
                return this.disableMTOMField;
            }
            set
            {
                this.disableMTOMField = value;
                this.RaisePropertyChanged("DisableMTOM");
            }
        }

        [XmlIgnore]
        public bool DisableMTOMSpecified
        {
            get
            {
                return this.disableMTOMFieldSpecified;
            }
            set
            {
                this.disableMTOMFieldSpecified = value;
                this.RaisePropertyChanged("DisableMTOMSpecified");
            }
        }

        [XmlElement(Order=1)]
        public int PageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
                this.RaisePropertyChanged("PageSize");
            }
        }

        [XmlIgnore]
        public bool PageSizeSpecified
        {
            get
            {
                return this.pageSizeFieldSpecified;
            }
            set
            {
                this.pageSizeFieldSpecified = value;
                this.RaisePropertyChanged("PageSizeSpecified");
            }
        }

        [XmlElement(Order=0)]
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
                this.RaisePropertyChanged("Query");
            }
        }

        [XmlElement(Order=3)]
        public bool ReturnRawResult
        {
            get
            {
                return this.returnRawResultField;
            }
            set
            {
                this.returnRawResultField = value;
                this.RaisePropertyChanged("ReturnRawResult");
            }
        }

        [XmlIgnore]
        public bool ReturnRawResultSpecified
        {
            get
            {
                return this.returnRawResultFieldSpecified;
            }
            set
            {
                this.returnRawResultFieldSpecified = value;
                this.RaisePropertyChanged("ReturnRawResultSpecified");
            }
        }
    }
}

