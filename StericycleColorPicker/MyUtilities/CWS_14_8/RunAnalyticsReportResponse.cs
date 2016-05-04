namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="RunAnalyticsReportResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class RunAnalyticsReportResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public MyUtilities.CWS_14_8.CSVTableSet CSVTableSet;
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=1), XmlElement(DataType="base64Binary")]
        public byte[] FileData;

        public RunAnalyticsReportResponse()
        {
        }

        public RunAnalyticsReportResponse(MyUtilities.CWS_14_8.CSVTableSet CSVTableSet, byte[] FileData)
        {
            this.CSVTableSet = CSVTableSet;
            this.FileData = FileData;
        }
    }
}

