namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(WrapperName="ResetContactPassword", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced)]
    public class ResetContactPasswordRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public ID ContactID;

        public ResetContactPasswordRequest()
        {
        }

        public ResetContactPasswordRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, ID ContactID)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.ContactID = ContactID;
        }
    }
}

