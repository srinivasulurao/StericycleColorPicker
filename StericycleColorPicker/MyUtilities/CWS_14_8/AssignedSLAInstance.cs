namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AssignedSLAInstance : INotifyPropertyChanged
    {
        private DateTime activeDateField;
        private bool activeDateFieldSpecified;
        private DateTime expireDateField;
        private bool expireDateFieldSpecified;
        private MyUtilities.CWS_14_8.ID idField;
        private NamedID nameOfSLAField;
        private int? remainingFromChatField;
        private bool remainingFromChatFieldSpecified;
        private int? remainingFromCSRField;
        private bool remainingFromCSRFieldSpecified;
        private int? remainingFromEmailField;
        private bool remainingFromEmailFieldSpecified;
        private int? remainingFromWebField;
        private bool remainingFromWebFieldSpecified;
        private int? remainingTotalField;
        private bool remainingTotalFieldSpecified;
        private int sLASetField;
        private bool sLASetFieldSpecified;
        private NamedID stateOfSLAField;
        private AssignedSLAInstanceNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(DataType="date", Order=0)]
        public DateTime ActiveDate
        {
            get
            {
                return this.activeDateField;
            }
            set
            {
                this.activeDateField = value;
                this.RaisePropertyChanged("ActiveDate");
            }
        }

        [XmlIgnore]
        public bool ActiveDateSpecified
        {
            get
            {
                return this.activeDateFieldSpecified;
            }
            set
            {
                this.activeDateFieldSpecified = value;
                this.RaisePropertyChanged("ActiveDateSpecified");
            }
        }

        [XmlElement(DataType="date", Order=1)]
        public DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.RaisePropertyChanged("ExpireDate");
            }
        }

        [XmlIgnore]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
                this.RaisePropertyChanged("ExpireDateSpecified");
            }
        }

        [XmlElement(Order=2)]
        public MyUtilities.CWS_14_8.ID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public NamedID NameOfSLA
        {
            get
            {
                return this.nameOfSLAField;
            }
            set
            {
                this.nameOfSLAField = value;
                this.RaisePropertyChanged("NameOfSLA");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public int? RemainingFromChat
        {
            get
            {
                return this.remainingFromChatField;
            }
            set
            {
                this.remainingFromChatField = value;
                this.RaisePropertyChanged("RemainingFromChat");
            }
        }

        [XmlIgnore]
        public bool RemainingFromChatSpecified
        {
            get
            {
                return this.remainingFromChatFieldSpecified;
            }
            set
            {
                this.remainingFromChatFieldSpecified = value;
                this.RaisePropertyChanged("RemainingFromChatSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=5)]
        public int? RemainingFromCSR
        {
            get
            {
                return this.remainingFromCSRField;
            }
            set
            {
                this.remainingFromCSRField = value;
                this.RaisePropertyChanged("RemainingFromCSR");
            }
        }

        [XmlIgnore]
        public bool RemainingFromCSRSpecified
        {
            get
            {
                return this.remainingFromCSRFieldSpecified;
            }
            set
            {
                this.remainingFromCSRFieldSpecified = value;
                this.RaisePropertyChanged("RemainingFromCSRSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public int? RemainingFromEmail
        {
            get
            {
                return this.remainingFromEmailField;
            }
            set
            {
                this.remainingFromEmailField = value;
                this.RaisePropertyChanged("RemainingFromEmail");
            }
        }

        [XmlIgnore]
        public bool RemainingFromEmailSpecified
        {
            get
            {
                return this.remainingFromEmailFieldSpecified;
            }
            set
            {
                this.remainingFromEmailFieldSpecified = value;
                this.RaisePropertyChanged("RemainingFromEmailSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=7)]
        public int? RemainingFromWeb
        {
            get
            {
                return this.remainingFromWebField;
            }
            set
            {
                this.remainingFromWebField = value;
                this.RaisePropertyChanged("RemainingFromWeb");
            }
        }

        [XmlIgnore]
        public bool RemainingFromWebSpecified
        {
            get
            {
                return this.remainingFromWebFieldSpecified;
            }
            set
            {
                this.remainingFromWebFieldSpecified = value;
                this.RaisePropertyChanged("RemainingFromWebSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=8)]
        public int? RemainingTotal
        {
            get
            {
                return this.remainingTotalField;
            }
            set
            {
                this.remainingTotalField = value;
                this.RaisePropertyChanged("RemainingTotal");
            }
        }

        [XmlIgnore]
        public bool RemainingTotalSpecified
        {
            get
            {
                return this.remainingTotalFieldSpecified;
            }
            set
            {
                this.remainingTotalFieldSpecified = value;
                this.RaisePropertyChanged("RemainingTotalSpecified");
            }
        }

        [XmlElement(Order=9)]
        public int SLASet
        {
            get
            {
                return this.sLASetField;
            }
            set
            {
                this.sLASetField = value;
                this.RaisePropertyChanged("SLASet");
            }
        }

        [XmlIgnore]
        public bool SLASetSpecified
        {
            get
            {
                return this.sLASetFieldSpecified;
            }
            set
            {
                this.sLASetFieldSpecified = value;
                this.RaisePropertyChanged("SLASetSpecified");
            }
        }

        [XmlElement(Order=10)]
        public NamedID StateOfSLA
        {
            get
            {
                return this.stateOfSLAField;
            }
            set
            {
                this.stateOfSLAField = value;
                this.RaisePropertyChanged("StateOfSLA");
            }
        }

        [XmlElement(IsNullable=true, Order=11)]
        public AssignedSLAInstanceNullFields ValidNullFields
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

