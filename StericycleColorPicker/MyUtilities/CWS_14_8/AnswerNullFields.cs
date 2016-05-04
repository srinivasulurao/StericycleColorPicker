namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AnswerNullFields : INotifyPropertyChanged
    {
        private bool accessLevelsField = false;
        private bool assignedSiblingField = false;
        private bool bannerField = false;
        private bool categoriesField = false;
        private bool commentField = false;
        private bool commonAttachmentsField = false;
        private bool commonCommentField = false;
        private bool expiresDateField = false;
        private bool fileAttachmentsField = false;
        private bool keywordsField = false;
        private bool linksField = false;
        private bool nextNotificationTimeField = false;
        private bool notesField = false;
        private bool originalReferenceNumberField = false;
        private bool productsField = false;
        private bool publishOnDateField = false;
        private bool questionField = false;
        private bool solutionField = false;
        private bool uRLField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool AccessLevels
        {
            get
            {
                return this.accessLevelsField;
            }
            set
            {
                this.accessLevelsField = value;
                this.RaisePropertyChanged("AccessLevels");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool AssignedSibling
        {
            get
            {
                return this.assignedSiblingField;
            }
            set
            {
                this.assignedSiblingField = value;
                this.RaisePropertyChanged("AssignedSibling");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Banner
        {
            get
            {
                return this.bannerField;
            }
            set
            {
                this.bannerField = value;
                this.RaisePropertyChanged("Banner");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
                this.RaisePropertyChanged("Categories");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool CommonAttachments
        {
            get
            {
                return this.commonAttachmentsField;
            }
            set
            {
                this.commonAttachmentsField = value;
                this.RaisePropertyChanged("CommonAttachments");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool CommonComment
        {
            get
            {
                return this.commonCommentField;
            }
            set
            {
                this.commonCommentField = value;
                this.RaisePropertyChanged("CommonComment");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool ExpiresDate
        {
            get
            {
                return this.expiresDateField;
            }
            set
            {
                this.expiresDateField = value;
                this.RaisePropertyChanged("ExpiresDate");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool FileAttachments
        {
            get
            {
                return this.fileAttachmentsField;
            }
            set
            {
                this.fileAttachmentsField = value;
                this.RaisePropertyChanged("FileAttachments");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
                this.RaisePropertyChanged("Keywords");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
                this.RaisePropertyChanged("Links");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool NextNotificationTime
        {
            get
            {
                return this.nextNotificationTimeField;
            }
            set
            {
                this.nextNotificationTimeField = value;
                this.RaisePropertyChanged("NextNotificationTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
                this.RaisePropertyChanged("Notes");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool OriginalReferenceNumber
        {
            get
            {
                return this.originalReferenceNumberField;
            }
            set
            {
                this.originalReferenceNumberField = value;
                this.RaisePropertyChanged("OriginalReferenceNumber");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Products
        {
            get
            {
                return this.productsField;
            }
            set
            {
                this.productsField = value;
                this.RaisePropertyChanged("Products");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool PublishOnDate
        {
            get
            {
                return this.publishOnDateField;
            }
            set
            {
                this.publishOnDateField = value;
                this.RaisePropertyChanged("PublishOnDate");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
                this.RaisePropertyChanged("Question");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Solution
        {
            get
            {
                return this.solutionField;
            }
            set
            {
                this.solutionField = value;
                this.RaisePropertyChanged("Solution");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
                this.RaisePropertyChanged("URL");
            }
        }
    }
}

