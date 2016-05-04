namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class BatchRequestItem : INotifyPropertyChanged
    {
        private bool commitAfterField;
        private bool commitAfterFieldSpecified;
        private object itemField;
        private bool preserveChainIDField;
        private bool preserveChainIDFieldSpecified;

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
        public bool CommitAfter
        {
            get
            {
                return this.commitAfterField;
            }
            set
            {
                this.commitAfterField = value;
                this.RaisePropertyChanged("CommitAfter");
            }
        }

        [XmlIgnore]
        public bool CommitAfterSpecified
        {
            get
            {
                return this.commitAfterFieldSpecified;
            }
            set
            {
                this.commitAfterFieldSpecified = value;
                this.RaisePropertyChanged("CommitAfterSpecified");
            }
        }

        [XmlElement("GetValuesForNamedIDHierarchyMsg", typeof(GetValuesForNamedIDHierarchyMsg), Order=0), XmlElement("GetMetaDataMsg", typeof(GetMetaDataMsg), Order=0), XmlElement("QueryCSVMsg", typeof(QueryMsg), Order=0), XmlElement("QueryObjectsMsg", typeof(QueryObjectsMsg), Order=0), XmlElement("ResetContactPasswordMsg", typeof(ResetContactPasswordMsg), Order=0), XmlElement("RunAnalyticsReportMsg", typeof(RunAnalyticsReportMsg), Order=0), XmlElement("SendMailingToContactMsg", typeof(SendMailingToContactMsg), Order=0), XmlElement("TransferSubObjectsMsg", typeof(TransferSubObjectsMsg), Order=0), XmlElement("UpdateMsg", typeof(UpdateMsg), Order=0), XmlElement("GetMsg", typeof(GetMsg), Order=0), XmlElement("CreateMsg", typeof(CreateMsg), Order=0), XmlElement("GetValuesForNamedIDMsg", typeof(GetValuesForNamedIDMsg), Order=0), XmlElement("DestroyMsg", typeof(DestroyMsg), Order=0), XmlElement("ExecuteMarketingFlowMsg", typeof(ExecuteMarketingFlowMsg), Order=0), XmlElement("GetFileDataMsg", typeof(GetFileDataMsg), Order=0), XmlElement("GetMetaDataForClassMsg", typeof(GetMetaDataForClassMsg), Order=0), XmlElement("GetMetaDataLastChangeTimeMsg", typeof(GetMetaDataLastChangeTimeMsg), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        [XmlElement(Order=2)]
        public bool PreserveChainID
        {
            get
            {
                return this.preserveChainIDField;
            }
            set
            {
                this.preserveChainIDField = value;
                this.RaisePropertyChanged("PreserveChainID");
            }
        }

        [XmlIgnore]
        public bool PreserveChainIDSpecified
        {
            get
            {
                return this.preserveChainIDFieldSpecified;
            }
            set
            {
                this.preserveChainIDFieldSpecified = value;
                this.RaisePropertyChanged("PreserveChainIDSpecified");
            }
        }
    }
}

