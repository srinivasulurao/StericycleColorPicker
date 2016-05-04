namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="SendMailingToContact", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class SendMailingToContactRequest
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=5)]
        public ID ChatID;
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public ID ContactID;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=3), XmlElement(IsNullable=true)]
        public ID IncidentID;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public ID MailingID;
        [XmlElement(IsNullable=true), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=4)]
        public ID OpportunityID;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2), XmlElement(IsNullable=true)]
        public DateTime? ScheduledTime;

        public SendMailingToContactRequest()
        {
        }

        public SendMailingToContactRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, ID ContactID, ID MailingID, DateTime? ScheduledTime, ID IncidentID, ID OpportunityID, ID ChatID)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.ContactID = ContactID;
            this.MailingID = MailingID;
            this.ScheduledTime = ScheduledTime;
            this.IncidentID = IncidentID;
            this.OpportunityID = OpportunityID;
            this.ChatID = ChatID;
        }
    }
}

