namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="ConvertGenericToObject", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class ConvertGenericToObjectRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [XmlElement("RNObjects"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public RNObject[] RNObjects;

        public ConvertGenericToObjectRequest()
        {
        }

        public ConvertGenericToObjectRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.RNObjects = RNObjects;
        }
    }
}

