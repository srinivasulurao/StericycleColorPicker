namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetFileData", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class GetFileDataRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2)]
        public bool DisableMTOM;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public ID FileID;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public MyUtilities.CWS_14_8.RNObject RNObject;

        public GetFileDataRequest()
        {
        }

        public GetFileDataRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, MyUtilities.CWS_14_8.RNObject RNObject, ID FileID, bool DisableMTOM)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.RNObject = RNObject;
            this.FileID = FileID;
            this.DisableMTOM = DisableMTOM;
        }
    }
}

