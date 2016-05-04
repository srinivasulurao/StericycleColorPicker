namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, MessageContract(WrapperName="ConvertObjectToGenericResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class ConvertObjectToGenericResponse
    {
        [XmlArrayItem("RNObjects", IsNullable=false), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public RNObject[] RNObjectsResult;

        public ConvertObjectToGenericResponse()
        {
        }

        public ConvertObjectToGenericResponse(RNObject[] RNObjectsResult)
        {
            this.RNObjectsResult = RNObjectsResult;
        }
    }
}

