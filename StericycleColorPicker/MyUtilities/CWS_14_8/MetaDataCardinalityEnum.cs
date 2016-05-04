namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:metadata.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public enum MetaDataCardinalityEnum
    {
        ZERO_OR_ONE,
        ZERO_OR_MORE,
        ONE,
        ONE_OR_MORE
    }
}

