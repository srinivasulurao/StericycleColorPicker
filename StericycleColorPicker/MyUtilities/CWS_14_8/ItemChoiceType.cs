namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2", IncludeInSchema=false), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public enum ItemChoiceType
    {
        CreateResponseMsg,
        DestroyResponseMsg,
        ExecuteMarketingFlowResponseMsg,
        GetFileDataResponseMsg,
        GetMetaDataForClassResponseMsg,
        GetMetaDataLastChangeTimeResponseMsg,
        GetMetaDataResponseMsg,
        GetResponseMsg,
        GetValuesForNamedIDHierarchyResponseMsg,
        GetValuesForNamedIDResponseMsg,
        QueryCSVResponseMsg,
        QueryObjectsResponseMsg,
        RequestErrorFault,
        ResetContactPasswordResponseMsg,
        RunAnalyticsReportResponseMsg,
        SendMailingToContactResponseMsg,
        ServerErrorFault,
        TransferSubObjectsResponseMsg,
        UnexpectedErrorFault,
        UpdateResponseMsg
    }
}

