namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
    public class RightNowFedAuthSyncPortClient : ClientBase<RightNowFedAuthSyncPort>, RightNowFedAuthSyncPort
    {
        public RightNowFedAuthSyncPortClient()
        {
        }

        public RightNowFedAuthSyncPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public RightNowFedAuthSyncPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public RightNowFedAuthSyncPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public RightNowFedAuthSyncPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public BatchResponseItem[] Batch(ClientInfoHeader ClientInfoHeader, BatchRequestItem[] BatchRequestItem)
        {
            BatchRequest request = new BatchRequest {
                ClientInfoHeader = ClientInfoHeader,
                BatchRequestItem = BatchRequestItem
            };
            return ((RightNowFedAuthSyncPort) this).Batch(request).BatchResponseItem;
        }

        public RNObject[] ConvertGenericToObject(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects)
        {
            ConvertGenericToObjectRequest request = new ConvertGenericToObjectRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects
            };
            return ((RightNowFedAuthSyncPort) this).ConvertGenericToObject(request).RNObjectsResult;
        }

        public RNObject[] ConvertObjectToGeneric(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects)
        {
            ConvertObjectToGenericRequest request = new ConvertObjectToGenericRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects
            };
            return ((RightNowFedAuthSyncPort) this).ConvertObjectToGeneric(request).RNObjectsResult;
        }

        public RNObject[] Create(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, CreateProcessingOptions ProcessingOptions)
        {
            CreateRequest request = new CreateRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects,
                ProcessingOptions = ProcessingOptions
            };
            return ((RightNowFedAuthSyncPort) this).Create(request).RNObjectsResult;
        }

        public void Destroy(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, DestroyProcessingOptions ProcessingOptions)
        {
            DestroyRequest request = new DestroyRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects,
                ProcessingOptions = ProcessingOptions
            };
            DestroyResponse response = ((RightNowFedAuthSyncPort) this).Destroy(request);
        }

        public void ExecuteMarketingFlow(ClientInfoHeader ClientInfoHeader, ID ContactID, ID CampaignID, string EntryPoint)
        {
            ExecuteMarketingFlowRequest request = new ExecuteMarketingFlowRequest {
                ClientInfoHeader = ClientInfoHeader,
                ContactID = ContactID,
                CampaignID = CampaignID,
                EntryPoint = EntryPoint
            };
            ExecuteMarketingFlowResponse response = ((RightNowFedAuthSyncPort) this).ExecuteMarketingFlow(request);
        }

        public RNObject[] Get(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, GetProcessingOptions ProcessingOptions)
        {
            GetRequest request = new GetRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects,
                ProcessingOptions = ProcessingOptions
            };
            return ((RightNowFedAuthSyncPort) this).Get(request).RNObjectsResult;
        }

        public byte[] GetFileData(ClientInfoHeader ClientInfoHeader, RNObject RNObject, ID FileID, bool DisableMTOM)
        {
            GetFileDataRequest request = new GetFileDataRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObject = RNObject,
                FileID = FileID,
                DisableMTOM = DisableMTOM
            };
            return ((RightNowFedAuthSyncPort) this).GetFileData(request).FileData;
        }

        public MetaDataClass[] GetMetaData(ClientInfoHeader ClientInfoHeader)
        {
            GetMetaDataRequest request = new GetMetaDataRequest {
                ClientInfoHeader = ClientInfoHeader
            };
            return ((RightNowFedAuthSyncPort) this).GetMetaData(request).MetaDataClass;
        }

        public MetaDataClass[] GetMetaDataForClass(ClientInfoHeader ClientInfoHeader, string[] ClassName, RNObjectType[] QualifiedClassName, string[] MetaDataLink)
        {
            GetMetaDataForClassRequest request = new GetMetaDataForClassRequest {
                ClientInfoHeader = ClientInfoHeader,
                ClassName = ClassName,
                QualifiedClassName = QualifiedClassName,
                MetaDataLink = MetaDataLink
            };
            return ((RightNowFedAuthSyncPort) this).GetMetaDataForClass(request).MetaDataClass;
        }

        public DateTime GetMetaDataLastChangeTime(ClientInfoHeader ClientInfoHeader)
        {
            GetMetaDataLastChangeTimeRequest request = new GetMetaDataLastChangeTimeRequest {
                ClientInfoHeader = ClientInfoHeader
            };
            return ((RightNowFedAuthSyncPort) this).GetMetaDataLastChangeTime(request).LastChangeDateTime;
        }

        public NamedID[] GetValuesForNamedID(ClientInfoHeader ClientInfoHeader, string PackageName, string FieldName)
        {
            GetValuesForNamedIDRequest request = new GetValuesForNamedIDRequest {
                ClientInfoHeader = ClientInfoHeader,
                PackageName = PackageName,
                FieldName = FieldName
            };
            return ((RightNowFedAuthSyncPort) this).GetValuesForNamedID(request).Entry;
        }

        public NamedIDWithParent[] GetValuesForNamedIDHierarchy(ClientInfoHeader ClientInfoHeader, string FieldName)
        {
            GetValuesForNamedIDHierarchyRequest request = new GetValuesForNamedIDHierarchyRequest {
                ClientInfoHeader = ClientInfoHeader,
                FieldName = FieldName
            };
            return ((RightNowFedAuthSyncPort) this).GetValuesForNamedIDHierarchy(request).Entry;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BatchResponse RightNowFedAuthSyncPort.Batch(BatchRequest request)
        {
            return base.Channel.Batch(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ConvertGenericToObjectResponse RightNowFedAuthSyncPort.ConvertGenericToObject(ConvertGenericToObjectRequest request)
        {
            return base.Channel.ConvertGenericToObject(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ConvertObjectToGenericResponse RightNowFedAuthSyncPort.ConvertObjectToGeneric(ConvertObjectToGenericRequest request)
        {
            return base.Channel.ConvertObjectToGeneric(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        CreateResponse RightNowFedAuthSyncPort.Create(CreateRequest request)
        {
            return base.Channel.Create(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        DestroyResponse RightNowFedAuthSyncPort.Destroy(DestroyRequest request)
        {
            return base.Channel.Destroy(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ExecuteMarketingFlowResponse RightNowFedAuthSyncPort.ExecuteMarketingFlow(ExecuteMarketingFlowRequest request)
        {
            return base.Channel.ExecuteMarketingFlow(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetResponse RightNowFedAuthSyncPort.Get(GetRequest request)
        {
            return base.Channel.Get(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetFileDataResponse RightNowFedAuthSyncPort.GetFileData(GetFileDataRequest request)
        {
            return base.Channel.GetFileData(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetMetaDataResponse RightNowFedAuthSyncPort.GetMetaData(GetMetaDataRequest request)
        {
            return base.Channel.GetMetaData(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetMetaDataForClassResponse RightNowFedAuthSyncPort.GetMetaDataForClass(GetMetaDataForClassRequest request)
        {
            return base.Channel.GetMetaDataForClass(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetMetaDataLastChangeTimeResponse RightNowFedAuthSyncPort.GetMetaDataLastChangeTime(GetMetaDataLastChangeTimeRequest request)
        {
            return base.Channel.GetMetaDataLastChangeTime(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetValuesForNamedIDResponse RightNowFedAuthSyncPort.GetValuesForNamedID(GetValuesForNamedIDRequest request)
        {
            return base.Channel.GetValuesForNamedID(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GetValuesForNamedIDHierarchyResponse RightNowFedAuthSyncPort.GetValuesForNamedIDHierarchy(GetValuesForNamedIDHierarchyRequest request)
        {
            return base.Channel.GetValuesForNamedIDHierarchy(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        QueryCSVResponse RightNowFedAuthSyncPort.QueryCSV(QueryCSVRequest request)
        {
            return base.Channel.QueryCSV(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        QueryObjectsResponse RightNowFedAuthSyncPort.QueryObjects(QueryObjectsRequest request)
        {
            return base.Channel.QueryObjects(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ResetContactPasswordResponse RightNowFedAuthSyncPort.ResetContactPassword(ResetContactPasswordRequest request)
        {
            return base.Channel.ResetContactPassword(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        RunAnalyticsReportResponse RightNowFedAuthSyncPort.RunAnalyticsReport(RunAnalyticsReportRequest request)
        {
            return base.Channel.RunAnalyticsReport(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        SendMailingToContactResponse RightNowFedAuthSyncPort.SendMailingToContact(SendMailingToContactRequest request)
        {
            return base.Channel.SendMailingToContact(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TransferSubObjectsResponse RightNowFedAuthSyncPort.TransferSubObjects(TransferSubObjectsRequest request)
        {
            return base.Channel.TransferSubObjects(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateResponse RightNowFedAuthSyncPort.Update(UpdateRequest request)
        {
            return base.Channel.Update(request);
        }

        public CSVTableSet QueryCSV(ClientInfoHeader ClientInfoHeader, string Query, int PageSize, string Delimiter, bool ReturnRawResult, bool DisableMTOM, out byte[] FileData)
        {
            QueryCSVRequest request = new QueryCSVRequest {
                ClientInfoHeader = ClientInfoHeader,
                Query = Query,
                PageSize = PageSize,
                Delimiter = Delimiter,
                ReturnRawResult = ReturnRawResult,
                DisableMTOM = DisableMTOM
            };
            QueryCSVResponse response = ((RightNowFedAuthSyncPort) this).QueryCSV(request);
            FileData = response.FileData;
            return response.CSVTableSet;
        }

        public QueryResultData[] QueryObjects(ClientInfoHeader ClientInfoHeader, string Query, RNObject[] ObjectTemplates, int PageSize)
        {
            QueryObjectsRequest request = new QueryObjectsRequest {
                ClientInfoHeader = ClientInfoHeader,
                Query = Query,
                ObjectTemplates = ObjectTemplates,
                PageSize = PageSize
            };
            return ((RightNowFedAuthSyncPort) this).QueryObjects(request).Result;
        }

        public void ResetContactPassword(ClientInfoHeader ClientInfoHeader, ID ContactID)
        {
            ResetContactPasswordRequest request = new ResetContactPasswordRequest {
                ClientInfoHeader = ClientInfoHeader,
                ContactID = ContactID
            };
            ResetContactPasswordResponse response = ((RightNowFedAuthSyncPort) this).ResetContactPassword(request);
        }

        public CSVTableSet RunAnalyticsReport(ClientInfoHeader ClientInfoHeader, AnalyticsReport AnalyticsReport, int Limit, int Start, string Delimiter, bool ReturnRawResult, bool DisableMTOM, out byte[] FileData)
        {
            RunAnalyticsReportRequest request = new RunAnalyticsReportRequest {
                ClientInfoHeader = ClientInfoHeader,
                AnalyticsReport = AnalyticsReport,
                Limit = Limit,
                Start = Start,
                Delimiter = Delimiter,
                ReturnRawResult = ReturnRawResult,
                DisableMTOM = DisableMTOM
            };
            RunAnalyticsReportResponse response = ((RightNowFedAuthSyncPort) this).RunAnalyticsReport(request);
            FileData = response.FileData;
            return response.CSVTableSet;
        }

        public void SendMailingToContact(ClientInfoHeader ClientInfoHeader, ID ContactID, ID MailingID, DateTime? ScheduledTime, ID IncidentID, ID OpportunityID, ID ChatID)
        {
            SendMailingToContactRequest request = new SendMailingToContactRequest {
                ClientInfoHeader = ClientInfoHeader,
                ContactID = ContactID,
                MailingID = MailingID,
                ScheduledTime = ScheduledTime,
                IncidentID = IncidentID,
                OpportunityID = OpportunityID,
                ChatID = ChatID
            };
            SendMailingToContactResponse response = ((RightNowFedAuthSyncPort) this).SendMailingToContact(request);
        }

        public void TransferSubObjects(ClientInfoHeader ClientInfoHeader, RNObject DestinationRNObject, RNObject[] SourceRNObjects)
        {
            TransferSubObjectsRequest request = new TransferSubObjectsRequest {
                ClientInfoHeader = ClientInfoHeader,
                DestinationRNObject = DestinationRNObject,
                SourceRNObjects = SourceRNObjects
            };
            TransferSubObjectsResponse response = ((RightNowFedAuthSyncPort) this).TransferSubObjects(request);
        }

        public void Update(ClientInfoHeader ClientInfoHeader, RNObject[] RNObjects, UpdateProcessingOptions ProcessingOptions)
        {
            UpdateRequest request = new UpdateRequest {
                ClientInfoHeader = ClientInfoHeader,
                RNObjects = RNObjects,
                ProcessingOptions = ProcessingOptions
            };
            UpdateResponse response = ((RightNowFedAuthSyncPort) this).Update(request);
        }
    }
}

