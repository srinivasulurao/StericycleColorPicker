namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="RunAnalyticsReport", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class RunAnalyticsReportRequest
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public MyUtilities.CWS_14_8.AnalyticsReport AnalyticsReport;
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=3)]
        public string Delimiter;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=5)]
        public bool DisableMTOM;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public int Limit;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=4)]
        public bool ReturnRawResult;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2)]
        public int Start;

        public RunAnalyticsReportRequest()
        {
        }

        public RunAnalyticsReportRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, MyUtilities.CWS_14_8.AnalyticsReport AnalyticsReport, int Limit, int Start, string Delimiter, bool ReturnRawResult, bool DisableMTOM)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.AnalyticsReport = AnalyticsReport;
            this.Limit = Limit;
            this.Start = Start;
            this.Delimiter = Delimiter;
            this.ReturnRawResult = ReturnRawResult;
            this.DisableMTOM = DisableMTOM;
        }
    }
}

