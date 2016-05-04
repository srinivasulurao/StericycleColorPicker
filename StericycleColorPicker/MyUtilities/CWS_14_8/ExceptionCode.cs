namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:faults.ws.rightnow.com/v1_2")]
    public enum ExceptionCode
    {
        ACCESS_DENIED,
        INVALID_FIELD,
        INVALID_LOGIN,
        BAD_ID,
        MISSING_ARGUMENT,
        QUERY_TIMEOUT,
        UNKNOWN_EXCEPTION,
        INVALID_REQUEST
    }
}

