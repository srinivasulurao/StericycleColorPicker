namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="ConvertObjectToGeneric", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class ConvertObjectToGenericRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [XmlElement("RNObjects"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public RNObject[] RNObjects;

        public ConvertObjectToGenericRequest()
        {
        }

        public ConvertObjectToGenericRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.RNObjects = RNObjects;
        }
    }
}

