namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(WrapperName="GetMetaDataForClass", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true)]
    public class GetMetaDataForClassRequest
    {
        [XmlElement("ClassName"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public string[] ClassName;
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2), XmlElement("MetaDataLink")]
        public string[] MetaDataLink;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1), XmlElement("QualifiedClassName")]
        public RNObjectType[] QualifiedClassName;

        public GetMetaDataForClassRequest()
        {
        }

        public GetMetaDataForClassRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, string[] ClassName, RNObjectType[] QualifiedClassName, string[] MetaDataLink)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.ClassName = ClassName;
            this.QualifiedClassName = QualifiedClassName;
            this.MetaDataLink = MetaDataLink;
        }
    }
}

