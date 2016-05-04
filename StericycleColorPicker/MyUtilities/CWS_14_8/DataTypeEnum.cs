namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:generic.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public enum DataTypeEnum
    {
        BASE64_BINARY,
        BOOLEAN,
        BOOLEAN_LIST,
        DATE,
        DATE_LIST,
        DATETIME,
        DATETIME_LIST,
        DECIMAL,
        DECIMAL_LIST,
        ID,
        ID_LIST,
        INTEGER,
        INTEGER_LIST,
        LONG,
        LONG_LIST,
        NAMED_ID,
        NAMED_ID_DELTA_LIST,
        NAMED_ID_LIST,
        NAMED_ID_HIERARCHY,
        NAMED_ID_HIERARCHY_LIST,
        OBJECT,
        OBJECT_LIST,
        STRING,
        STRING_LIST
    }
}

