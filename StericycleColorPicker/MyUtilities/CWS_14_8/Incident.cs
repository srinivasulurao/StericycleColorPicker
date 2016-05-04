namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough]
    public class Incident : RNObject
    {
        private NamedID assetField;
        private GroupAccount assignedToField;
        private MyUtilities.CWS_14_8.Banner bannerField;
        private TimeBilled[] billedMinutesField;
        private NamedIDHierarchy categoryField;
        private NamedID channelField;
        private NamedID chatQueueField;
        private DateTime? closedTimeField;
        private bool closedTimeFieldSpecified;
        private NamedID createdByAccountField;
        private GenericObject customFieldsField;
        private NamedIDHierarchy dispositionField;
        private FileAttachmentIncident[] fileAttachmentsField;
        private DateTime? initialResponseDueTimeField;
        private bool initialResponseDueTimeFieldSpecified;
        private DateTime? initialSolutionTimeField;
        private bool initialSolutionTimeFieldSpecified;
        private NamedID interfaceField;
        private NamedID languageField;
        private DateTime? lastResponseTimeField;
        private bool lastResponseTimeFieldSpecified;
        private NamedID mailboxField;
        private NamedID mailingField;
        private NamedID organizationField;
        private IncidentContactDelta[] otherContactsField;
        private IncidentContact primaryContactField;
        private NamedIDHierarchy productField;
        private NamedID queueField;
        private string referenceNumberField;
        private int? resolutionIntervalField;
        private bool resolutionIntervalFieldSpecified;
        private int? responseIntervalField;
        private bool responseIntervalFieldSpecified;
        private NamedID severityField;
        private AssignedSLAInstance sLAInstanceField;
        private int? smartSenseCustomerField;
        private bool smartSenseCustomerFieldSpecified;
        private int? smartSenseStaffField;
        private bool smartSenseStaffFieldSpecified;
        private NamedIDHierarchy sourceField;
        private MyUtilities.CWS_14_8.StatusWithType statusWithTypeField;
        private string subjectField;
        private Thread[] threadsField;
        private IncidentNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Asset
        {
            get
            {
                return this.assetField;
            }
            set
            {
                this.assetField = value;
                base.RaisePropertyChanged("Asset");
            }
        }

        [XmlElement(Order=1)]
        public GroupAccount AssignedTo
        {
            get
            {
                return this.assignedToField;
            }
            set
            {
                this.assignedToField = value;
                base.RaisePropertyChanged("AssignedTo");
            }
        }

        [XmlElement(Order=2)]
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

        [XmlArray(IsNullable=true, Order=3), XmlArrayItem("TimeBilledList", IsNullable=false)]
        public TimeBilled[] BilledMinutes
        {
            get
            {
                return this.billedMinutesField;
            }
            set
            {
                this.billedMinutesField = value;
                base.RaisePropertyChanged("BilledMinutes");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public NamedIDHierarchy Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
                base.RaisePropertyChanged("Category");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public NamedID Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
                base.RaisePropertyChanged("Channel");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public NamedID ChatQueue
        {
            get
            {
                return this.chatQueueField;
            }
            set
            {
                this.chatQueueField = value;
                base.RaisePropertyChanged("ChatQueue");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
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

        [XmlElement(IsNullable=true, Order=8)]
        public NamedID CreatedByAccount
        {
            get
            {
                return this.createdByAccountField;
            }
            set
            {
                this.createdByAccountField = value;
                base.RaisePropertyChanged("CreatedByAccount");
            }
        }

        [XmlElement(Order=9)]
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

        [XmlElement(IsNullable=true, Order=10)]
        public NamedIDHierarchy Disposition
        {
            get
            {
                return this.dispositionField;
            }
            set
            {
                this.dispositionField = value;
                base.RaisePropertyChanged("Disposition");
            }
        }

        [XmlArray(IsNullable=true, Order=11), XmlArrayItem("FileAttachmentList", IsNullable=false)]
        public FileAttachmentIncident[] FileAttachments
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

        [XmlElement(IsNullable=true, Order=12)]
        public DateTime? InitialResponseDueTime
        {
            get
            {
                return this.initialResponseDueTimeField;
            }
            set
            {
                this.initialResponseDueTimeField = value;
                base.RaisePropertyChanged("InitialResponseDueTime");
            }
        }

        [XmlIgnore]
        public bool InitialResponseDueTimeSpecified
        {
            get
            {
                return this.initialResponseDueTimeFieldSpecified;
            }
            set
            {
                this.initialResponseDueTimeFieldSpecified = value;
                base.RaisePropertyChanged("InitialResponseDueTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public DateTime? InitialSolutionTime
        {
            get
            {
                return this.initialSolutionTimeField;
            }
            set
            {
                this.initialSolutionTimeField = value;
                base.RaisePropertyChanged("InitialSolutionTime");
            }
        }

        [XmlIgnore]
        public bool InitialSolutionTimeSpecified
        {
            get
            {
                return this.initialSolutionTimeFieldSpecified;
            }
            set
            {
                this.initialSolutionTimeFieldSpecified = value;
                base.RaisePropertyChanged("InitialSolutionTimeSpecified");
            }
        }

        [XmlElement(Order=14)]
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

        [XmlElement(IsNullable=true, Order=15)]
        public NamedID Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                base.RaisePropertyChanged("Language");
            }
        }

        [XmlElement(IsNullable=true, Order=0x10)]
        public DateTime? LastResponseTime
        {
            get
            {
                return this.lastResponseTimeField;
            }
            set
            {
                this.lastResponseTimeField = value;
                base.RaisePropertyChanged("LastResponseTime");
            }
        }

        [XmlIgnore]
        public bool LastResponseTimeSpecified
        {
            get
            {
                return this.lastResponseTimeFieldSpecified;
            }
            set
            {
                this.lastResponseTimeFieldSpecified = value;
                base.RaisePropertyChanged("LastResponseTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public NamedID Mailbox
        {
            get
            {
                return this.mailboxField;
            }
            set
            {
                this.mailboxField = value;
                base.RaisePropertyChanged("Mailbox");
            }
        }

        [XmlElement(IsNullable=true, Order=0x12)]
        public NamedID Mailing
        {
            get
            {
                return this.mailingField;
            }
            set
            {
                this.mailingField = value;
                base.RaisePropertyChanged("Mailing");
            }
        }

        [XmlElement(IsNullable=true, Order=0x13)]
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

        [XmlArray(IsNullable=true, Order=20), XmlArrayItem("IncidentContactList", IsNullable=false)]
        public IncidentContactDelta[] OtherContacts
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

        [XmlElement(Order=0x15)]
        public IncidentContact PrimaryContact
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

        [XmlElement(IsNullable=true, Order=0x16)]
        public NamedIDHierarchy Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
                base.RaisePropertyChanged("Product");
            }
        }

        [XmlElement(IsNullable=true, Order=0x17)]
        public NamedID Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
                base.RaisePropertyChanged("Queue");
            }
        }

        [XmlElement(Order=0x18)]
        public string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
                base.RaisePropertyChanged("ReferenceNumber");
            }
        }

        [XmlElement(IsNullable=true, Order=0x19)]
        public int? ResolutionInterval
        {
            get
            {
                return this.resolutionIntervalField;
            }
            set
            {
                this.resolutionIntervalField = value;
                base.RaisePropertyChanged("ResolutionInterval");
            }
        }

        [XmlIgnore]
        public bool ResolutionIntervalSpecified
        {
            get
            {
                return this.resolutionIntervalFieldSpecified;
            }
            set
            {
                this.resolutionIntervalFieldSpecified = value;
                base.RaisePropertyChanged("ResolutionIntervalSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1a)]
        public int? ResponseInterval
        {
            get
            {
                return this.responseIntervalField;
            }
            set
            {
                this.responseIntervalField = value;
                base.RaisePropertyChanged("ResponseInterval");
            }
        }

        [XmlIgnore]
        public bool ResponseIntervalSpecified
        {
            get
            {
                return this.responseIntervalFieldSpecified;
            }
            set
            {
                this.responseIntervalFieldSpecified = value;
                base.RaisePropertyChanged("ResponseIntervalSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1b)]
        public NamedID Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
                base.RaisePropertyChanged("Severity");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1c)]
        public AssignedSLAInstance SLAInstance
        {
            get
            {
                return this.sLAInstanceField;
            }
            set
            {
                this.sLAInstanceField = value;
                base.RaisePropertyChanged("SLAInstance");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1d)]
        public int? SmartSenseCustomer
        {
            get
            {
                return this.smartSenseCustomerField;
            }
            set
            {
                this.smartSenseCustomerField = value;
                base.RaisePropertyChanged("SmartSenseCustomer");
            }
        }

        [XmlIgnore]
        public bool SmartSenseCustomerSpecified
        {
            get
            {
                return this.smartSenseCustomerFieldSpecified;
            }
            set
            {
                this.smartSenseCustomerFieldSpecified = value;
                base.RaisePropertyChanged("SmartSenseCustomerSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=30)]
        public int? SmartSenseStaff
        {
            get
            {
                return this.smartSenseStaffField;
            }
            set
            {
                this.smartSenseStaffField = value;
                base.RaisePropertyChanged("SmartSenseStaff");
            }
        }

        [XmlIgnore]
        public bool SmartSenseStaffSpecified
        {
            get
            {
                return this.smartSenseStaffFieldSpecified;
            }
            set
            {
                this.smartSenseStaffFieldSpecified = value;
                base.RaisePropertyChanged("SmartSenseStaffSpecified");
            }
        }

        [XmlElement(Order=0x1f)]
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

        [XmlElement(Order=0x20)]
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

        [XmlElement(IsNullable=true, Order=0x21)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
                base.RaisePropertyChanged("Subject");
            }
        }

        [XmlArrayItem("ThreadList", IsNullable=false), XmlArray(Order=0x22)]
        public Thread[] Threads
        {
            get
            {
                return this.threadsField;
            }
            set
            {
                this.threadsField = value;
                base.RaisePropertyChanged("Threads");
            }
        }

        [XmlElement(IsNullable=true, Order=0x23)]
        public IncidentNullFields ValidNullFields
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
    }
}

