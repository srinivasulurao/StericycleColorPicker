namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("System.ServiceModel", "4.0.0.0"), MessageContract(WrapperName="GetFileDataResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough]
    public class GetFileDataResponse
    {
        [XmlElement(DataType="base64Binary"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public byte[] FileData;

        public GetFileDataResponse()
        {
        }

        public GetFileDataResponse(byte[] FileData)
        {
            this.FileData = FileData;
        }
    }
}

