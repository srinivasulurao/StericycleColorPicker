namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class Answer : RNObject
    {
        private NamedIDDelta[] accessLevelsField;
        private DateTime? adminLastAccessTimeField;
        private bool adminLastAccessTimeFieldSpecified;
        private NamedID answerTypeField;
        private NamedID assignedSiblingField;
        private GroupAccount assignedToField;
        private MyUtilities.CWS_14_8.Banner bannerField;
        private NamedIDHierarchy[] categoriesField;
        private string commentField;
        private FileAttachmentShared[] commonAttachmentsField;
        private string commonCommentField;
        private GenericObject customFieldsField;
        private DateTime? expiresDateField;
        private bool expiresDateFieldSpecified;
        private FileAttachmentAnswer[] fileAttachmentsField;
        private NamedID guidedAssistanceField;
        private string keywordsField;
        private NamedID languageField;
        private DateTime? lastAccessTimeField;
        private bool lastAccessTimeFieldSpecified;
        private DateTime? lastNotificationTimeField;
        private bool lastNotificationTimeFieldSpecified;
        private AnswerLink[] linksField;
        private string nameField;
        private DateTime? nextNotificationTimeField;
        private bool nextNotificationTimeFieldSpecified;
        private Note[] notesField;
        private string originalReferenceNumberField;
        private NamedID positionInListField;
        private NamedIDHierarchy[] productsField;
        private DateTime? publishOnDateField;
        private bool publishOnDateFieldSpecified;
        private string questionField;
        private NamedID[] siblingAnswersField;
        private string solutionField;
        private MyUtilities.CWS_14_8.StatusWithType statusWithTypeField;
        private string summaryField;
        private NamedID updatedByAccountField;
        private string uRLField;
        private AnswerNullFields validNullFieldsField;

        [XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=0)]
        public NamedIDDelta[] AccessLevels
        {
            get
            {
                return this.accessLevelsField;
            }
            set
            {
                this.accessLevelsField = value;
                base.RaisePropertyChanged("AccessLevels");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public DateTime? AdminLastAccessTime
        {
            get
            {
                return this.adminLastAccessTimeField;
            }
            set
            {
                this.adminLastAccessTimeField = value;
                base.RaisePropertyChanged("AdminLastAccessTime");
            }
        }

        [XmlIgnore]
        public bool AdminLastAccessTimeSpecified
        {
            get
            {
                return this.adminLastAccessTimeFieldSpecified;
            }
            set
            {
                this.adminLastAccessTimeFieldSpecified = value;
                base.RaisePropertyChanged("AdminLastAccessTimeSpecified");
            }
        }

        [XmlElement(Order=2)]
        public NamedID AnswerType
        {
            get
            {
                return this.answerTypeField;
            }
            set
            {
                this.answerTypeField = value;
                base.RaisePropertyChanged("AnswerType");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID AssignedSibling
        {
            get
            {
                return this.assignedSiblingField;
            }
            set
            {
                this.assignedSiblingField = value;
                base.RaisePropertyChanged("AssignedSibling");
            }
        }

        [XmlElement(Order=4)]
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

        [XmlElement(IsNullable=true, Order=5)]
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

        [XmlArray(IsNullable=true, Order=6), XmlArrayItem("NamedIDHierarchyList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedIDHierarchy[] Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
                base.RaisePropertyChanged("Categories");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
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

        [XmlArray(IsNullable=true, Order=8), XmlArrayItem("FileAttachmentList", IsNullable=false)]
        public FileAttachmentShared[] CommonAttachments
        {
            get
            {
                return this.commonAttachmentsField;
            }
            set
            {
                this.commonAttachmentsField = value;
                base.RaisePropertyChanged("CommonAttachments");
            }
        }

        [XmlElement(IsNullable=true, Order=9)]
        public string CommonComment
        {
            get
            {
                return this.commonCommentField;
            }
            set
            {
                this.commonCommentField = value;
                base.RaisePropertyChanged("CommonComment");
            }
        }

        [XmlElement(Order=10)]
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

        [XmlElement(DataType="date", IsNullable=true, Order=11)]
        public DateTime? ExpiresDate
        {
            get
            {
                return this.expiresDateField;
            }
            set
            {
                this.expiresDateField = value;
                base.RaisePropertyChanged("ExpiresDate");
            }
        }

        [XmlIgnore]
        public bool ExpiresDateSpecified
        {
            get
            {
                return this.expiresDateFieldSpecified;
            }
            set
            {
                this.expiresDateFieldSpecified = value;
                base.RaisePropertyChanged("ExpiresDateSpecified");
            }
        }

        [XmlArrayItem("FileAttachmentList", IsNullable=false), XmlArray(IsNullable=true, Order=12)]
        public FileAttachmentAnswer[] FileAttachments
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

        [XmlElement(IsNullable=true, Order=13)]
        public NamedID GuidedAssistance
        {
            get
            {
                return this.guidedAssistanceField;
            }
            set
            {
                this.guidedAssistanceField = value;
                base.RaisePropertyChanged("GuidedAssistance");
            }
        }

        [XmlElement(IsNullable=true, Order=14)]
        public string Keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
                base.RaisePropertyChanged("Keywords");
            }
        }

        [XmlElement(Order=15)]
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
        public DateTime? LastAccessTime
        {
            get
            {
                return this.lastAccessTimeField;
            }
            set
            {
                this.lastAccessTimeField = value;
                base.RaisePropertyChanged("LastAccessTime");
            }
        }

        [XmlIgnore]
        public bool LastAccessTimeSpecified
        {
            get
            {
                return this.lastAccessTimeFieldSpecified;
            }
            set
            {
                this.lastAccessTimeFieldSpecified = value;
                base.RaisePropertyChanged("LastAccessTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x11)]
        public DateTime? LastNotificationTime
        {
            get
            {
                return this.lastNotificationTimeField;
            }
            set
            {
                this.lastNotificationTimeField = value;
                base.RaisePropertyChanged("LastNotificationTime");
            }
        }

        [XmlIgnore]
        public bool LastNotificationTimeSpecified
        {
            get
            {
                return this.lastNotificationTimeFieldSpecified;
            }
            set
            {
                this.lastNotificationTimeFieldSpecified = value;
                base.RaisePropertyChanged("LastNotificationTimeSpecified");
            }
        }

        [XmlArray(IsNullable=true, Order=0x12), XmlArrayItem("AnswerLinkList", IsNullable=false)]
        public AnswerLink[] Links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
                base.RaisePropertyChanged("Links");
            }
        }

        [XmlElement(Order=0x13)]
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

        [XmlElement(IsNullable=true, Order=20)]
        public DateTime? NextNotificationTime
        {
            get
            {
                return this.nextNotificationTimeField;
            }
            set
            {
                this.nextNotificationTimeField = value;
                base.RaisePropertyChanged("NextNotificationTime");
            }
        }

        [XmlIgnore]
        public bool NextNotificationTimeSpecified
        {
            get
            {
                return this.nextNotificationTimeFieldSpecified;
            }
            set
            {
                this.nextNotificationTimeFieldSpecified = value;
                base.RaisePropertyChanged("NextNotificationTimeSpecified");
            }
        }

        [XmlArray(IsNullable=true, Order=0x15), XmlArrayItem("NoteList", IsNullable=false)]
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

        [XmlElement(IsNullable=true, Order=0x16)]
        public string OriginalReferenceNumber
        {
            get
            {
                return this.originalReferenceNumberField;
            }
            set
            {
                this.originalReferenceNumberField = value;
                base.RaisePropertyChanged("OriginalReferenceNumber");
            }
        }

        [XmlElement(Order=0x17)]
        public NamedID PositionInList
        {
            get
            {
                return this.positionInListField;
            }
            set
            {
                this.positionInListField = value;
                base.RaisePropertyChanged("PositionInList");
            }
        }

        [XmlArray(IsNullable=true, Order=0x18), XmlArrayItem("NamedIDHierarchyList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false)]
        public NamedIDHierarchy[] Products
        {
            get
            {
                return this.productsField;
            }
            set
            {
                this.productsField = value;
                base.RaisePropertyChanged("Products");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=0x19)]
        public DateTime? PublishOnDate
        {
            get
            {
                return this.publishOnDateField;
            }
            set
            {
                this.publishOnDateField = value;
                base.RaisePropertyChanged("PublishOnDate");
            }
        }

        [XmlIgnore]
        public bool PublishOnDateSpecified
        {
            get
            {
                return this.publishOnDateFieldSpecified;
            }
            set
            {
                this.publishOnDateFieldSpecified = value;
                base.RaisePropertyChanged("PublishOnDateSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1a)]
        public string Question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
                base.RaisePropertyChanged("Question");
            }
        }

        [XmlArrayItem("NamedIDList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=0x1b)]
        public NamedID[] SiblingAnswers
        {
            get
            {
                return this.siblingAnswersField;
            }
            set
            {
                this.siblingAnswersField = value;
                base.RaisePropertyChanged("SiblingAnswers");
            }
        }

        [XmlElement(IsNullable=true, Order=0x1c)]
        public string Solution
        {
            get
            {
                return this.solutionField;
            }
            set
            {
                this.solutionField = value;
                base.RaisePropertyChanged("Solution");
            }
        }

        [XmlElement(Order=0x1d)]
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

        [XmlElement(Order=30)]
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

        [XmlElement(IsNullable=true, Order=0x1f)]
        public NamedID UpdatedByAccount
        {
            get
            {
                return this.updatedByAccountField;
            }
            set
            {
                this.updatedByAccountField = value;
                base.RaisePropertyChanged("UpdatedByAccount");
            }
        }

        [XmlElement(IsNullable=true, Order=0x20)]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
                base.RaisePropertyChanged("URL");
            }
        }

        [XmlElement(IsNullable=true, Order=0x21)]
        public AnswerNullFields ValidNullFields
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

