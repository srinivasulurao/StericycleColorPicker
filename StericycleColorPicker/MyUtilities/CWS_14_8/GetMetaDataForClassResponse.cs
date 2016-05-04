namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetMetaDataForClassResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetMetaDataForClassResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlElement("MetaDataClass")]
        public MyUtilities.CWS_14_8.MetaDataClass[] MetaDataClass;

        public GetMetaDataForClassResponse()
        {
        }

        public GetMetaDataForClassResponse(MyUtilities.CWS_14_8.MetaDataClass[] MetaDataClass)
        {
            this.MetaDataClass = MetaDataClass;
        }
    }
}

