namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class QueryObjectsMsg : INotifyPropertyChanged
    {
        private RNObject[] objectTemplatesField;
        private int pageSizeField;
        private bool pageSizeFieldSpecified;
        private string queryField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("ObjectTemplates", Order=1)]
        public RNObject[] ObjectTemplates
        {
            get
            {
                return this.objectTemplatesField;
            }
            set
            {
                this.objectTemplatesField = value;
                this.RaisePropertyChanged("ObjectTemplates");
            }
        }

        [XmlElement(Order=2)]
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
    }
}

