namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetValuesForNamedIDHierarchy", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetValuesForNamedIDHierarchyRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public string FieldName;

        public GetValuesForNamedIDHierarchyRequest()
        {
        }

        public GetValuesForNamedIDHierarchyRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, string FieldName)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.FieldName = FieldName;
        }
    }
}

