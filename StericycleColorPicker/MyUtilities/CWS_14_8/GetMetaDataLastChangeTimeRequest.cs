namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetMetaDataLastChangeTime", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class GetMetaDataLastChangeTimeRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;

        public GetMetaDataLastChangeTimeRequest()
        {
        }

        public GetMetaDataLastChangeTimeRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader)
        {
            this.ClientInfoHeader = ClientInfoHeader;
        }
    }
}

