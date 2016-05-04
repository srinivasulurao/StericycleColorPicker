namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="QueryObjects", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class QueryObjectsRequest
    {
        [MessageHeader(Namespace="urn:messages.ws.rightnow.com/v1_2")]
        public MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader;
        [XmlElement("ObjectTemplates"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1)]
        public RNObject[] ObjectTemplates;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=2)]
        public int PageSize;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public string Query;

        public QueryObjectsRequest()
        {
        }

        public QueryObjectsRequest(MyUtilities.CWS_14_8.ClientInfoHeader ClientInfoHeader, string Query, RNObject[] ObjectTemplates, int PageSize)
        {
            this.ClientInfoHeader = ClientInfoHeader;
            this.Query = Query;
            this.ObjectTemplates = ObjectTemplates;
            this.PageSize = PageSize;
        }
    }
}

