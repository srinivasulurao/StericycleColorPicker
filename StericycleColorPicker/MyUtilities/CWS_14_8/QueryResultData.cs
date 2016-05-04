namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class QueryResultData : INotifyPropertyChanged
    {
        private RNFault faultField;
        private PagingResponse pagingField;
        private RNObject[] rNObjectsResultField;

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
        public RNFault Fault
        {
            get
            {
                return this.faultField;
            }
            set
            {
                this.faultField = value;
                this.RaisePropertyChanged("Fault");
            }
        }

        [XmlElement(Order=1)]
        public PagingResponse Paging
        {
            get
            {
                return this.pagingField;
            }
            set
            {
                this.pagingField = value;
                this.RaisePropertyChanged("Paging");
            }
        }

        [XmlArrayItem("RNObjects", IsNullable=false), XmlArray(Order=0)]
        public RNObject[] RNObjectsResult
        {
            get
            {
                return this.rNObjectsResultField;
            }
            set
            {
                this.rNObjectsResultField = value;
                this.RaisePropertyChanged("RNObjectsResult");
            }
        }
    }
}

