namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough]
    public class BatchResponseItem : INotifyPropertyChanged
    {
        private ItemChoiceType itemElementNameField;
        private object itemField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("UnexpectedErrorFault", typeof(UnexpectedErrorFaultType), Order=0), XmlElement("GetValuesForNamedIDHierarchyResponseMsg", typeof(GetValuesForNamedIDHierarchyResponseMsg), Order=0), XmlElement("QueryCSVResponseMsg", typeof(QueryCSVResponseMsg), Order=0), XmlElement("QueryObjectsResponseMsg", typeof(QueryObjectsResponseMsg), Order=0), XmlElement("GetResponseMsg", typeof(GetResponseMsg), Order=0), XmlElement("ResetContactPasswordResponseMsg", typeof(ResetContactPasswordResponseMsg), Order=0), XmlElement("RunAnalyticsReportResponseMsg", typeof(RunAnalyticsReportResponseMsg), Order=0), XmlElement("SendMailingToContactResponseMsg", typeof(SendMailingToContactResponseMsg), Order=0), XmlElement("ServerErrorFault", typeof(ServerErrorFaultType), Order=0), XmlElement("TransferSubObjectsResponseMsg", typeof(TransferSubObjectsResponseMsg), Order=0), XmlElement("CreateResponseMsg", typeof(CreateResponseMsg), Order=0), XmlElement("UpdateResponseMsg", typeof(UpdateResponseMsg), Order=0), XmlChoiceIdentifier("ItemElementName"), XmlElement("RequestErrorFault", typeof(RequestErrorFaultType), Order=0), XmlElement("GetValuesForNamedIDResponseMsg", typeof(GetValuesForNamedIDResponseMsg), Order=0), XmlElement("DestroyResponseMsg", typeof(DestroyResponseMsg), Order=0), XmlElement("ExecuteMarketingFlowResponseMsg", typeof(ExecuteMarketingFlowResponseMsg), Order=0), XmlElement("GetFileDataResponseMsg", typeof(GetFileDataResponseMsg), Order=0), XmlElement("GetMetaDataForClassResponseMsg", typeof(GetMetaDataForClassResponseMsg), Order=0), XmlElement("GetMetaDataLastChangeTimeResponseMsg", typeof(GetMetaDataLastChangeTimeResponseMsg), Order=0), XmlElement("GetMetaDataResponseMsg", typeof(GetMetaDataResponseMsg), Order=0)]
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

        [XmlElement(Order=1), XmlIgnore]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }
    }
}

