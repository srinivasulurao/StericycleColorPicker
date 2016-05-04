namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough]
    public class Opportunity : RNObject
    {
        private NamedID[] accountHierarchyField;
        private NamedIDHierarchy assignedToAccountField;
        private MyUtilities.CWS_14_8.Banner bannerField;
        private NamedID campaignField;
        private DateTime? closedTimeField;
        private bool closedTimeFieldSpecified;
        private MonetaryValue closedValueField;
        private MonetaryValue costOfSaleField;
        private GenericObject customFieldsField;
        private FileAttachmentCommon[] fileAttachmentsField;
        private DateTime? forecastCloseDateField;
        private bool forecastCloseDateFieldSpecified;
        private DateTime? initialContactDateField;
        private bool initialContactDateFieldSpecified;
        private NamedID interfaceField;
        private DateTime? leadRejectDateTimeField;
        private bool leadRejectDateTimeFieldSpecified;
        private string leadRejectDescriptionField;
        private NamedID leadRejectReasonField;
        private DateTime? lostTimeField;
        private bool lostTimeFieldSpecified;
        private bool managerCommitField;
        private bool managerCommitFieldSpecified;
        private MonetaryValue managerValueField;
        private string nameField;
        private Note[] notesField;
        private NamedID organizationField;
        private OpportunityContactDelta[] otherContactsField;
        private OpportunityContact primaryContactField;
        private Quote[] quotesField;
        private DateTime? recallTimeField;
        private bool recallTimeFieldSpecified;
        private MonetaryValue returnValueField;
        private bool salesRepresentativeCommitField;
        private bool salesRepresentativeCommitFieldSpecified;
        private MonetaryValue salesRepresentativeValueField;
        private NamedIDHierarchy sourceField;
        private MyUtilities.CWS_14_8.StageWithStrategy stageWithStrategyField;
        private MyUtilities.CWS_14_8.StatusWithType statusWithTypeField;
        private string summaryField;
        private NamedID surveyField;
        private NamedIDHierarchy territoryField;
        private NamedID[] territoryHierarchyField;
        private OpportunityNullFields validNullFieldsField;
        private string winLossDescriptionField;
        private NamedID winLossReasonField;

        [XmlArray(IsNullable=true, Order=0), XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedID[] AccountHierarchy
        {
            get
            {
                return this.accountHierarchyField;
            }
            set
            {
                this.accountHierarchyField = value;
                base.RaisePropertyChanged("AccountHierarchy");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedIDHierarchy AssignedToAccount
        {
            get
            {
                return this.assignedToAccountField;
            }
            set
            {
                this.assignedToAccountField = value;
                base.RaisePropertyChanged("AssignedToAccount");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public MyUtilities.CWS_14_8.Banner Banner
        {
            get
            {
                return this.bannerField;
            }
            set
            {
                this.bannerField = value;
                base.RaisePropertyChanged("Banner");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID Campaign
        {
            get
            {
                return this.campaignField;
            }
            set
            {
                this.campaignField = value;
                base.RaisePropertyChanged("Campaign");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public DateTime? ClosedTime
        {
            get
            {
                return this.closedTimeField;
            }
            set
            {
                this.closedTimeField = value;
                base.RaisePropertyChanged("ClosedTime");
            }
        }

        [XmlIgnore]
        public bool ClosedTimeSpecified
        {
            get
            {
                return this.closedTimeFieldSpecified;
            }
            set
            {
                this.closedTimeFieldSpecified = value;
                base.RaisePropertyChanged("ClosedTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public MonetaryValue ClosedValue
        {
            get
            {
                return this.closedValueField;
            }
            set
            {
                this.closedValueField = value;
                base.RaisePropertyChanged("ClosedValue");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public MonetaryValue CostOfSale
        {
            get
            {
                return this.costOfSaleField;
            }
            set
            {
                this.costOfSaleField = value;
                base.RaisePropertyChanged("CostOfSale");
            }
        }

        [XmlElement(Order=7)]
        public GenericObject CustomFields
        {
            get
            {
                return this.customFieldsField;
            }
            set
            {
                this.customFieldsField = value;
                base.RaisePropertyChanged("CustomFields");
            }
        }

        [XmlArrayItem("FileAttachmentList", IsNullable=false), XmlArray(IsNullable=true, Order=8)]
        public FileAttachmentCommon[] FileAttachments
        {
            get
            {
                return this.fileAttachmentsField;
            }
            set
            {
                this.fileAttachmentsField = value;
                base.RaisePropertyChanged("FileAttachments");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=9)]
        public DateTime? ForecastCloseDate
        {
            get
            {
                return this.forecastCloseDateField;
            }
            set
            {
                this.forecastCloseDateField = value;
                base.RaisePropertyChanged("ForecastCloseDate");
            }
        }

        [XmlIgnore]
        public bool ForecastCloseDateSpecified
        {
            get
            {
                return this.forecastCloseDateFieldSpecified;
            }
            set
            {
                this.forecastCloseDateFieldSpecified = value;
                base.RaisePropertyChanged("ForecastCloseDateSpecified");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=10)]
        public DateTime? InitialContactDate
        {
            get
            {
                return this.initialContactDateField;
            }
            set
            {
                this.initialContactDateField = value;
                base.RaisePropertyChanged("InitialContactDate");
            }
        }

        [XmlIgnore]
        public bool InitialContactDateSpecified
        {
            get
            {
                return this.initialContactDateFieldSpecified;
            }
            set
            {
                this.initialContactDateFieldSpecified = value;
                base.RaisePropertyChanged("InitialContactDateSpecified");
            }
        }

        [XmlElement(Order=11)]
        public NamedID Interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
                base.RaisePropertyChanged("Interface");
            }
        }

        [XmlElement(IsNullable=true, Order=12)]
        public DateTime? LeadRejectDateTime
        {
            get
            {
                return this.leadRejectDateTimeField;
            }
            set
            {
                this.leadRejectDateTimeField = value;
                base.RaisePropertyChanged("LeadRejectDateTime");
            }
        }

        [XmlIgnore]
        public bool LeadRejectDateTimeSpecified
        {
            get
            {
                return this.leadRejectDateTimeFieldSpecified;
            }
            set
            {
                this.leadRejectDateTimeFieldSpecified = value;
                base.RaisePropertyChanged("LeadRejectDateTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public string LeadRejectDescription
        {
            get
            {
                return this.leadRejectDescriptionField;
            }
            set
            {
                this.leadRejectDescriptionField = value;
                base.RaisePropertyChanged("LeadRejectDescription");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public NamedID LeadRejectReason
        {
            get
            {
                return this.leadRejectReasonField;
            }
            set
            {
                this.leadRejectReasonField = value;
                base.RaisePropertyChanged("LeadRejectReason");
            }
        }

        [XmlElement(IsNullable=true, Order=15)]
        public DateTime? LostTime
        {
            get
            {
                return this.lostTimeField;
            }
            set
            {
                this.lostTimeField = value;
                base.RaisePropertyChanged("LostTime");
            }
        }

        [XmlIgnore]
        public bool LostTimeSpecified
        {
            get
            {
                return this.lostTimeFieldSpecified;
            }
            set
            {
                this.lostTimeFieldSpecified = value;
                base.RaisePropertyChanged("LostTimeSpecified");
            }
        }

        [XmlElement(Order=0x10)]
        public bool ManagerCommit
        {
            get
            {
                return this.managerCommitField;
            }
            set
            {
                this.managerCommitField = value;
                base.RaisePropertyChanged("ManagerCommit");
            }
        }

        [XmlIgnore]
        public bool ManagerCommitSpecified
        {
            get
            {
                return this.managerCommitFieldSpecified;
            }
            set
            {
                this.managerCommitFieldSpecified = value;
                base.RaisePropertyChanged("ManagerCommitSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public MonetaryValue ManagerValue
        {
            get
            {
                return this.managerValueField;
            }
            set
            {
                this.managerValueField = value;
                base.RaisePropertyChanged("ManagerValue");
            }
        }

        [XmlElement(IsNullable=true, Order=0x12)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlArray(IsNullable=true, Order=0x13), XmlArrayItem("NoteList", IsNullable=false)]
        public Note[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
                base.RaisePropertyChanged("Notes");
            }
        }

        [XmlElement(IsNullable=true, Order=20)]
        public NamedID Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                base.RaisePropertyChanged("Organization");
            }
        }

        [XmlArrayItem("OpportunityContactList", IsNullable=false), XmlArray(IsNullable=true, Order=0x15)]
        public OpportunityContactDelta[] OtherContacts
        {
            get
            {
                return this.otherContactsField;
            }
            set
            {
                this.otherContactsField = value;
                base.RaisePropertyChanged("OtherContacts");
            }
        }

        [XmlElement(IsNullable=true, Order=0x16)]
        public OpportunityContact PrimaryContact
        {
            get
            {
                return this.primaryContactField;
            }
            set
            {
                this.primaryContactField = value;
                base.RaisePropertyChanged("PrimaryContact");
            }
        }

        [XmlArray(IsNullable=true, Order=0x17), XmlArrayItem("QuoteList", IsNullable=false)]
        public Quote[] Quotes
        {
            get
            {
                return this.quotesField;
            }
            set
            {
                this.quotesField = value;
                base.RaisePropertyChanged("Quotes");
            }
        }

        [XmlElement(IsNullable=true, Order=0x18)]
        public DateTime? RecallTime
        {
            get
            {
                return this.recallTimeField;
            }
            set
            {
                this.recallTimeField = value;
                base.RaisePropertyChanged("RecallTime");
            }
        }

        [XmlIgnore]
        public bool RecallTimeSpecified
        {
            get
            {
                return this.recallTimeFieldSpecified;
            }
            set
            {
                this.recallTimeFieldSpecified = value;
                base.RaisePropertyChanged("RecallTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x19)]
        public MonetaryValue ReturnValue
        {
            get
            {
                return this.returnValueField;
            }
            set
            {
                this.returnValueField = value;
                base.RaisePropertyChanged("ReturnValue");
            }
        }

        [XmlElement(Order=0x1a)]
        public bool SalesRepresentativeCommit
        {
            get
            {
                return this.salesRepresentativeCommitField;
            }
            set
            {
                this.salesRepresentativeCommitField = value;
                base.RaisePropertyChanged("SalesRepresentativeCommit");
            }
        }

        [XmlIgnore]
        public bool SalesRepresentativeCommitSpecified
        {
            get
            {
                return this.salesRepresentativeCommitFieldSpecified;
            }
            set
            {
                this.salesRepresentativeCommitFieldSpecified = value;
                base.RaisePropertyChanged("SalesRepresentativeCommitSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1b)]
        public MonetaryValue SalesRepresentativeValue
        {
            get
            {
                return this.salesRepresentativeValueField;
            }
            set
            {
                this.salesRepresentativeValueField = value;
                base.RaisePropertyChanged("SalesRepresentativeValue");
            }
        }

        [XmlElement(Order=0x1c)]
        public NamedIDHierarchy Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                base.RaisePropertyChanged("Source");
            }
        }

        [XmlElement(Order=0x1d)]
        public MyUtilities.CWS_14_8.StageWithStrategy StageWithStrategy
        {
            get
            {
                return this.stageWithStrategyField;
            }
            set
            {
                this.stageWithStrategyField = value;
                base.RaisePropertyChanged("StageWithStrategy");
            }
        }

        [XmlElement(Order=30)]
        public MyUtilities.CWS_14_8.StatusWithType StatusWithType
        {
            get
            {
                return this.statusWithTypeField;
            }
            set
            {
                this.statusWithTypeField = value;
                base.RaisePropertyChanged("StatusWithType");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1f)]
        public string Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
                base.RaisePropertyChanged("Summary");
            }
        }

        [XmlElement(IsNullable=true, Order=0x20)]
        public NamedID Survey
        {
            get
            {
                return this.surveyField;
            }
            set
            {
                this.surveyField = value;
                base.RaisePropertyChanged("Survey");
            }
        }

        [XmlElement(IsNullable=true, Order=0x21)]
        public NamedIDHierarchy Territory
        {
            get
            {
                return this.territoryField;
            }
            set
            {
                this.territoryField = value;
                base.RaisePropertyChanged("Territory");
            }
        }

        [XmlArray(IsNullable=true, Order=0x22), XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedID[] TerritoryHierarchy
        {
            get
            {
                return this.territoryHierarchyField;
            }
            set
            {
                this.territoryHierarchyField = value;
                base.RaisePropertyChanged("TerritoryHierarchy");
            }
        }

        [XmlElement(IsNullable=true, Order=0x25)]
        public OpportunityNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }

        [XmlElement(IsNullable=true, Order=0x23)]
        public string WinLossDescription
        {
            get
            {
                return this.winLossDescriptionField;
            }
            set
            {
                this.winLossDescriptionField = value;
                base.RaisePropertyChanged("WinLossDescription");
            }
        }

        [XmlElement(IsNullable=true, Order=0x24)]
        public NamedID WinLossReason
        {
            get
            {
                return this.winLossReasonField;
            }
            set
            {
                this.winLossReasonField = value;
                base.RaisePropertyChanged("WinLossReason");
            }
        }
    }
}

