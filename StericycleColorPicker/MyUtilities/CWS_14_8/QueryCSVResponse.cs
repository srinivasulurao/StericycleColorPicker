namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="QueryCSVResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true)]
    public class QueryCSVResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public MyUtilities.CWS_14_8.CSVTableSet CSVTableSet;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1), XmlElement(DataType="base64Binary")]
        public byte[] FileData;

        public QueryCSVResponse()
        {
        }

        public QueryCSVResponse(MyUtilities.CWS_14_8.CSVTableSet CSVTableSet, byte[] FileData)
        {
            this.CSVTableSet = CSVTableSet;
            this.FileData = FileData;
        }
    }
}

