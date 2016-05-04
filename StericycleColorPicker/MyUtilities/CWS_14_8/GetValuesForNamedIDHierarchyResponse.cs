namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.Xml.Serialization;

    [MessageContract(WrapperName="GetValuesForNamedIDHierarchyResponse", WrapperNamespace="urn:messages.ws.rightnow.com/v1_2", IsWrapped=true), DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced)]
    public class GetValuesForNamedIDHierarchyResponse
    {
        [MessageBodyMember(Namespace="urn:messages.ws.rightnow.com/v1_2", Order=0), XmlElement("Entry")]
        public NamedIDWithParent[] Entry;

        public GetValuesForNamedIDHierarchyResponse()
        {
        }

        public GetValuesForNamedIDHierarchyResponse(NamedIDWithParent[] Entry)
        {
            this.Entry = Entry;
        }
    }
}

