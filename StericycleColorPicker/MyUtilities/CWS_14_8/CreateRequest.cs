namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="Create", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough]
    public class CreateRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public CreateProcessingOptions ProcessingOptions;
        [XmlElement("RNObjects"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public RNObject[] RNObjects;

        public CreateRequest()
        {
        }

        public CreateRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, CreateProcessingOptions ProcessingOptions)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.RNObjects = RNObjects;
            this.ProcessingOptions = ProcessingOptions;
        }
    }
}

