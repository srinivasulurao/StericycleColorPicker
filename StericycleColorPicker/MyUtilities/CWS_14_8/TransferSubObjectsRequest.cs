namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="TransferSubObjects", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class TransferSubObjectsRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public RNObject DestinationRNObject;
        [XmlElement("SourceRNObjects"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public RNObject[] SourceRNObjects;

        public TransferSubObjectsRequest()
        {
        }

        public TransferSubObjectsRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, RNObject DestinationRNObject, RNObject[] SourceRNObjects)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.DestinationRNObject = DestinationRNObject;
            this.SourceRNObjects = SourceRNObjects;
        }
    }
}

