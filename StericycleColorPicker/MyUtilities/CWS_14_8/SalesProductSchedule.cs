namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class SalesProductSchedule : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private string commentField;
        private MonetaryValue priceField;
        private DateTime? scheduleEndDateField;
        private bool scheduleEndDateFieldSpecified;
        private NamedID scheduleField;
        private DateTime scheduleStartDateField;
        private bool scheduleStartDateFieldSpecified;
        private SalesProductScheduleNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute]
        public ActionEnum action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }

        [XmlIgnore]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public string Comment
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

        [XmlElement(Order=1)]
        public MonetaryValue Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                this.RaisePropertyChanged("Price");
            }
        }

        [XmlElement(Order=2)]
        public NamedID Schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
                this.RaisePropertyChanged("Schedule");
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=3)]
        public DateTime? ScheduleEndDate
        {
            get
            {
                return this.scheduleEndDateField;
            }
            set
            {
                this.scheduleEndDateField = value;
                this.RaisePropertyChanged("ScheduleEndDate");
            }
        }

        [XmlIgnore]
        public bool ScheduleEndDateSpecified
        {
            get
            {
                return this.scheduleEndDateFieldSpecified;
            }
            set
            {
                this.scheduleEndDateFieldSpecified = value;
                this.RaisePropertyChanged("ScheduleEndDateSpecified");
            }
        }

        [XmlElement(DataType="date", Order=4)]
        public DateTime ScheduleStartDate
        {
            get
            {
                return this.scheduleStartDateField;
            }
            set
            {
                this.scheduleStartDateField = value;
                this.RaisePropertyChanged("ScheduleStartDate");
            }
        }

        [XmlIgnore]
        public bool ScheduleStartDateSpecified
        {
            get
            {
                return this.scheduleStartDateFieldSpecified;
            }
            set
            {
                this.scheduleStartDateFieldSpecified = value;
                this.RaisePropertyChanged("ScheduleStartDateSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public SalesProductScheduleNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                this.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

