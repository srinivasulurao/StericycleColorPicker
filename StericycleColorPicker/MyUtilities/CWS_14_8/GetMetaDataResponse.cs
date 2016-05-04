namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="GetMetaDataResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class GetMetaDataResponse
    {
        [XmlElement("MetaDataClass"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public MyUtilities.CWS_14_8.MetaDataClass[] MetaDataClass;

        public GetMetaDataResponse()
        {
        }

        public GetMetaDataResponse(MyUtilities.CWS_14_8.MetaDataClass[] MetaDataClass)
        {
            this.MetaDataClass = MetaDataClass;
        }
    }
}

