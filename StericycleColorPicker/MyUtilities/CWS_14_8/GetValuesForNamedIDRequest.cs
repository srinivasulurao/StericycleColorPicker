namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetValuesForNamedID", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetValuesForNamedIDRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public string FieldName;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public string PackageName;

        public GetValuesForNamedIDRequest()
        {
        }

        public GetValuesForNamedIDRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, string PackageName, string FieldName)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.PackageName = PackageName;
            this.FieldName = FieldName;
        }
    }
}

