namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [MessageContract(WrapperName="QueryCSV", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough]
    public class QueryCSVRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2)]
        public string Delimiter;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=4)]
        public bool DisableMTOM;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public int PageSize;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public string Query;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=3)]
        public bool ReturnRawResult;

        public QueryCSVRequest()
        {
        }

        public QueryCSVRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, string Query, int PageSize, string Delimiter, bool ReturnRawResult, bool DisableMTOM)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.Query = Query;
            this.PageSize = PageSize;
            this.Delimiter = Delimiter;
            this.ReturnRawResult = ReturnRawResult;
            this.DisableMTOM = DisableMTOM;
        }
    }
}

