namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class Task : RNObject
    {
        private NamedID assignedToAccountField;
        private string commentField;
        private DateTime? completedTimeField;
        private bool completedTimeFieldSpecified;
        private NamedID contactField;
        private GenericObject customFieldsField;
        private DateTime? dueTimeField;
        private bool dueTimeFieldSpecified;
        private FileAttachmentCommon[] fileAttachmentsField;
        private InheritOptions inheritField;
        private TaskMarketingSettings marketingSettingsField;
        private string nameField;
        private Note[] notesField;
        private NamedID organizationField;
        private int? percentCompleteField;
        private bool percentCompleteFieldSpecified;
        private DateTime? plannedCompletionTimeField;
        private bool plannedCompletionTimeFieldSpecified;
        private NamedID priorityField;
        private TaskSalesSettings salesSettingsField;
        private TaskServiceSettings serviceSettingsField;
        private DateTime? startTimeField;
        private bool startTimeFieldSpecified;
        private MyUtilities.CWS_14_8.StatusWithType statusWithTypeField;
        private NamedID taskTemplateField;
        private NamedID taskTypeField;
        private TaskNullFields validNullFieldsField;

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID AssignedToAccount
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

        [XmlElement(IsNullable=true, Order=1)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
                base.RaisePropertyChanged("Comment");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public DateTime? CompletedTime
        {
            get
            {
                return this.completedTimeField;
            }
            set
            {
                this.completedTimeField = value;
                base.RaisePropertyChanged("CompletedTime");
            }
        }

        [XmlIgnore]
        public bool CompletedTimeSpecified
        {
            get
            {
                return this.completedTimeFieldSpecified;
            }
            set
            {
                this.completedTimeFieldSpecified = value;
                base.RaisePropertyChanged("CompletedTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                base.RaisePropertyChanged("Contact");
            }
        }

        [XmlElement(Order=4)]
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

        [XmlElement(IsNullable=true, Order=5)]
        public DateTime? DueTime
        {
            get
            {
                return this.dueTimeField;
            }
            set
            {
                this.dueTimeField = value;
                base.RaisePropertyChanged("DueTime");
            }
        }

        [XmlIgnore]
        public bool DueTimeSpecified
        {
            get
            {
                return this.dueTimeFieldSpecified;
            }
            set
            {
                this.dueTimeFieldSpecified = value;
                base.RaisePropertyChanged("DueTimeSpecified");
            }
        }

        [XmlArrayItem("FileAttachmentList", IsNullable=false), XmlArray(IsNullable=true, Order=6)]
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

        [XmlElement(Order=7)]
        public InheritOptions Inherit
        {
            get
            {
                return this.inheritField;
            }
            set
            {
                this.inheritField = value;
                base.RaisePropertyChanged("Inherit");
            }
        }

        [XmlElement(Order=8)]
        public TaskMarketingSettings MarketingSettings
        {
            get
            {
                return this.marketingSettingsField;
            }
            set
            {
                this.marketingSettingsField = value;
                base.RaisePropertyChanged("MarketingSettings");
            }
        }

        [XmlElement(Order=9)]
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

        [XmlArrayItem("NoteList", IsNullable=false), XmlArray(IsNullable=true, Order=10)]
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

        [XmlElement(IsNullable=true, Order=11)]
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

        [XmlElement(IsNullable=true, Order=12)]
        public int? PercentComplete
        {
            get
            {
                return this.percentCompleteField;
            }
            set
            {
                this.percentCompleteField = value;
                base.RaisePropertyChanged("PercentComplete");
            }
        }

        [XmlIgnore]
        public bool PercentCompleteSpecified
        {
            get
            {
                return this.percentCompleteFieldSpecified;
            }
            set
            {
                this.percentCompleteFieldSpecified = value;
                base.RaisePropertyChanged("PercentCompleteSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=13)]
        public DateTime? PlannedCompletionTime
        {
            get
            {
                return this.plannedCompletionTimeField;
            }
            set
            {
                this.plannedCompletionTimeField = value;
                base.RaisePropertyChanged("PlannedCompletionTime");
            }
        }

        [XmlIgnore]
        public bool PlannedCompletionTimeSpecified
        {
            get
            {
                return this.plannedCompletionTimeFieldSpecified;
            }
            set
            {
                this.plannedCompletionTimeFieldSpecified = value;
                base.RaisePropertyChanged("PlannedCompletionTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public NamedID Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
                base.RaisePropertyChanged("Priority");
            }
        }

        [XmlElement(Order=15)]
        public TaskSalesSettings SalesSettings
        {
            get
            {
                return this.salesSettingsField;
            }
            set
            {
                this.salesSettingsField = value;
                base.RaisePropertyChanged("SalesSettings");
            }
        }

        [XmlElement(Order=0x10)]
        public TaskServiceSettings ServiceSettings
        {
            get
            {
                return this.serviceSettingsField;
            }
            set
            {
                this.serviceSettingsField = value;
                base.RaisePropertyChanged("ServiceSettings");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public DateTime? StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
                base.RaisePropertyChanged("StartTime");
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
                base.RaisePropertyChanged("StartTimeSpecified");
            }
        }

        [XmlElement(Order=0x12)]
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

        [XmlElement(Order=0x13)]
        public NamedID TaskTemplate
        {
            get
            {
                return this.taskTemplateField;
            }
            set
            {
                this.taskTemplateField = value;
                base.RaisePropertyChanged("TaskTemplate");
            }
        }

        [XmlElement(IsNullable=true, Order=20)]
        public NamedID TaskType
        {
            get
            {
                return this.taskTypeField;
            }
            set
            {
                this.taskTypeField = value;
                base.RaisePropertyChanged("TaskType");
            }
        }

        [XmlElement(IsNullable=true, Order=0x15)]
        public TaskNullFields ValidNullFields
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

