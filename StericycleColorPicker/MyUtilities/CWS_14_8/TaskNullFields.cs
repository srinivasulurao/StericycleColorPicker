namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class TaskNullFields : INotifyPropertyChanged
    {
        private bool assignedToAccountField = false;
        private bool commentField = false;
        private bool completedTimeField = false;
        private bool contactField = false;
        private bool dueTimeField = false;
        private bool fileAttachmentsField = false;
        private bool notesField = false;
        private bool organizationField = false;
        private bool percentCompleteField = false;
        private bool plannedCompletionTimeField = false;
        private bool priorityField = false;
        private bool startTimeField = false;
        private bool taskTypeField = false;

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
        public bool AssignedToAccount
        {
            get
            {
                return this.assignedToAccountField;
            }
            set
            {
                this.assignedToAccountField = value;
                this.RaisePropertyChanged("AssignedToAccount");
            }
        }

        [XmlAttribute, DefaultValue(false)]
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

        [XmlAttribute, DefaultValue(false)]
        public bool CompletedTime
        {
            get
            {
                return this.completedTimeField;
            }
            set
            {
                this.completedTimeField = value;
                this.RaisePropertyChanged("CompletedTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                this.RaisePropertyChanged("Contact");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool DueTime
        {
            get
            {
                return this.dueTimeField;
            }
            set
            {
                this.dueTimeField = value;
                this.RaisePropertyChanged("DueTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
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

        [DefaultValue(false), XmlAttribute]
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
        public bool Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
                this.RaisePropertyChanged("Organization");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool PercentComplete
        {
            get
            {
                return this.percentCompleteField;
            }
            set
            {
                this.percentCompleteField = value;
                this.RaisePropertyChanged("PercentComplete");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool PlannedCompletionTime
        {
            get
            {
                return this.plannedCompletionTimeField;
            }
            set
            {
                this.plannedCompletionTimeField = value;
                this.RaisePropertyChanged("PlannedCompletionTime");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
                this.RaisePropertyChanged("Priority");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
                this.RaisePropertyChanged("StartTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool TaskType
        {
            get
            {
                return this.taskTypeField;
            }
            set
            {
                this.taskTypeField = value;
                this.RaisePropertyChanged("TaskType");
            }
        }
    }
}

