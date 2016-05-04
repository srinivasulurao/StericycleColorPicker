namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:metadata.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public enum MetaDataUsageEnum
    {
        NOT_ALLOWED,
        ALLOWED,
        IGNORED,
        REQUIRED
    }
}

