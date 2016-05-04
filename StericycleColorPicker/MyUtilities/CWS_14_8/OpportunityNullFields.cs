namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class OpportunityNullFields : INotifyPropertyChanged
    {
        private bool assignedToAccountField = false;
        private bool bannerField = false;
        private bool closedTimeField = false;
        private bool closedValueField = false;
        private bool costOfSaleField = false;
        private bool fileAttachmentsField = false;
        private bool forecastCloseDateField = false;
        private bool initialContactDateField = false;
        private bool leadRejectDateTimeField = false;
        private bool leadRejectDescriptionField = false;
        private bool leadRejectReasonField = false;
        private bool lostTimeField = false;
        private bool managerValueField = false;
        private bool nameField = false;
        private bool notesField = false;
        private bool organizationField = false;
        private bool otherContactsField = false;
        private bool primaryContactField = false;
        private bool quotesField = false;
        private bool recallTimeField = false;
        private bool returnValueField = false;
        private bool salesRepresentativeValueField = false;
        private bool summaryField = false;
        private bool territoryField = false;
        private bool winLossDescriptionField = false;
        private bool winLossReasonField = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute, DefaultValue(false)]
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

        [DefaultValue(false), XmlAttribute]
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
        public bool ClosedTime
        {
            get
            {
                return this.closedTimeField;
            }
            set
            {
                this.closedTimeField = value;
                this.RaisePropertyChanged("ClosedTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool ClosedValue
        {
            get
            {
                return this.closedValueField;
            }
            set
            {
                this.closedValueField = value;
                this.RaisePropertyChanged("ClosedValue");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool CostOfSale
        {
            get
            {
                return this.costOfSaleField;
            }
            set
            {
                this.costOfSaleField = value;
                this.RaisePropertyChanged("CostOfSale");
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

        [XmlAttribute, DefaultValue(false)]
        public bool ForecastCloseDate
        {
            get
            {
                return this.forecastCloseDateField;
            }
            set
            {
                this.forecastCloseDateField = value;
                this.RaisePropertyChanged("ForecastCloseDate");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool InitialContactDate
        {
            get
            {
                return this.initialContactDateField;
            }
            set
            {
                this.initialContactDateField = value;
                this.RaisePropertyChanged("InitialContactDate");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool LeadRejectDateTime
        {
            get
            {
                return this.leadRejectDateTimeField;
            }
            set
            {
                this.leadRejectDateTimeField = value;
                this.RaisePropertyChanged("LeadRejectDateTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool LeadRejectDescription
        {
            get
            {
                return this.leadRejectDescriptionField;
            }
            set
            {
                this.leadRejectDescriptionField = value;
                this.RaisePropertyChanged("LeadRejectDescription");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool LeadRejectReason
        {
            get
            {
                return this.leadRejectReasonField;
            }
            set
            {
                this.leadRejectReasonField = value;
                this.RaisePropertyChanged("LeadRejectReason");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool LostTime
        {
            get
            {
                return this.lostTimeField;
            }
            set
            {
                this.lostTimeField = value;
                this.RaisePropertyChanged("LostTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool ManagerValue
        {
            get
            {
                return this.managerValueField;
            }
            set
            {
                this.managerValueField = value;
                this.RaisePropertyChanged("ManagerValue");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
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
        public bool OtherContacts
        {
            get
            {
                return this.otherContactsField;
            }
            set
            {
                this.otherContactsField = value;
                this.RaisePropertyChanged("OtherContacts");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool PrimaryContact
        {
            get
            {
                return this.primaryContactField;
            }
            set
            {
                this.primaryContactField = value;
                this.RaisePropertyChanged("PrimaryContact");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Quotes
        {
            get
            {
                return this.quotesField;
            }
            set
            {
                this.quotesField = value;
                this.RaisePropertyChanged("Quotes");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool RecallTime
        {
            get
            {
                return this.recallTimeField;
            }
            set
            {
                this.recallTimeField = value;
                this.RaisePropertyChanged("RecallTime");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool ReturnValue
        {
            get
            {
                return this.returnValueField;
            }
            set
            {
                this.returnValueField = value;
                this.RaisePropertyChanged("ReturnValue");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool SalesRepresentativeValue
        {
            get
            {
                return this.salesRepresentativeValueField;
            }
            set
            {
                this.salesRepresentativeValueField = value;
                this.RaisePropertyChanged("SalesRepresentativeValue");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
                this.RaisePropertyChanged("Summary");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool Territory
        {
            get
            {
                return this.territoryField;
            }
            set
            {
                this.territoryField = value;
                this.RaisePropertyChanged("Territory");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool WinLossDescription
        {
            get
            {
                return this.winLossDescriptionField;
            }
            set
            {
                this.winLossDescriptionField = value;
                this.RaisePropertyChanged("WinLossDescription");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool WinLossReason
        {
            get
            {
                return this.winLossReasonField;
            }
            set
            {
                this.winLossReasonField = value;
                this.RaisePropertyChanged("WinLossReason");
            }
        }
    }
}

