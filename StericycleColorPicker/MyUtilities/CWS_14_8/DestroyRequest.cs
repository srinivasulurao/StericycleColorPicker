namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="Destroy", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class DestroyRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public DestroyProcessingOptions ProcessingOptions;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlElement("RNObjects")]
        public RNObject[] RNObjects;

        public DestroyRequest()
        {
        }

        public DestroyRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, DestroyProcessingOptions ProcessingOptions)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.RNObjects = RNObjects;
            this.ProcessingOptions = ProcessingOptions;
        }
    }
}

