namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(WrapperName="GetMetaDataLastChangeTimeResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class GetMetaDataLastChangeTimeResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public DateTime LastChangeDateTime;

        public GetMetaDataLastChangeTimeResponse()
        {
        }

        public GetMetaDataLastChangeTimeResponse(DateTime LastChangeDateTime)
        {
            this.LastChangeDateTime = LastChangeDateTime;
        }
    }
}

