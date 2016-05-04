namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="Batch", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class BatchRequest
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlElement("BatchRequestItem")]
        public MyUtilities.CWS_14_8.BatchRequestItem[] BatchRequestItem;
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;

        public BatchRequest()
        {
        }

        public BatchRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, MyUtilities.CWS_14_8.BatchRequestItem[] BatchRequestItem)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.BatchRequestItem = BatchRequestItem;
        }
    }
}

