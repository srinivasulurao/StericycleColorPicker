namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(WrapperName="GetResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true)]
    public class GetResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlArrayItem("RNObjects", IsNullable=false)]
        public RNObject[] RNObjectsResult;

        public GetResponse()
        {
        }

        public GetResponse(RNObject[] RNObjectsResult)
        {
            this.RNObjectsResult = RNObjectsResult;
        }
    }
}

