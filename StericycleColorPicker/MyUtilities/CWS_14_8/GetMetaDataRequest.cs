namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(WrapperName="GetMetaData", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetMetaDataRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;

        public GetMetaDataRequest()
        {
        }

        public GetMetaDataRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader)
        {
            this.ClientInfoHeader = ClientInfoHeader;
        }
    }
}

