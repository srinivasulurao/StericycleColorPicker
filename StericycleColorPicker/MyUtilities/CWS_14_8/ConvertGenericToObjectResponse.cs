namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="ConvertGenericToObjectResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class ConvertGenericToObjectResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlArrayItem("RNObjects", IsNullable=false)]
        public RNObject[] RNObjectsResult;

        public ConvertGenericToObjectResponse()
        {
        }

        public ConvertGenericToObjectResponse(RNObject[] RNObjectsResult)
        {
            this.RNObjectsResult = RNObjectsResult;
        }
    }
}

