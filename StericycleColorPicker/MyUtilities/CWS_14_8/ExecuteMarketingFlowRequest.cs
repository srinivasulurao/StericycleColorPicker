namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="ExecuteMarketingFlow", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class ExecuteMarketingFlowRequest
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public ID CampaignID;
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public ID ContactID;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2)]
        public string EntryPoint;

        public ExecuteMarketingFlowRequest()
        {
        }

        public ExecuteMarketingFlowRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, ID ContactID, ID CampaignID, string EntryPoint)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.ContactID = ContactID;
            this.CampaignID = CampaignID;
            this.EntryPoint = EntryPoint;
        }
    }
}

