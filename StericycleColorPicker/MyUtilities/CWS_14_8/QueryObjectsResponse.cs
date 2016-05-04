namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="QueryObjectsResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true)]
    public class QueryObjectsResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlElement("Result")]
        public QueryResultData[] Result;

        public QueryObjectsResponse()
        {
        }

        public QueryObjectsResponse(QueryResultData[] Result)
        {
            this.Result = Result;
        }
    }
}

