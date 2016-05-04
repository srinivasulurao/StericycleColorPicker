namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough, EditorBrowsable(EditorBrowsableState.Advanced), MessageContract(WrapperName="GetValuesForNamedIDResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true)]
    public class GetValuesForNamedIDResponse
    {
        [XmlElement("Entry"), MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0)]
        public NamedID[] Entry;

        public GetValuesForNamedIDResponse()
        {
        }

        public GetValuesForNamedIDResponse(NamedID[] Entry)
        {
            this.Entry = Entry;
        }
    }
}

