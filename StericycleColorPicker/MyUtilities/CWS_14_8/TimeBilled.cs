namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough]
    public class TimeBilled : INotifyPropertyChanged
    {
        private NamedID accountField;
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private NamedID billableTaskField;
        private DateTime billTimeField;
        private bool billTimeFieldSpecified;
        private string commentField;
        private MyUtilities.CWS_14_8.ID idField;
        private int minutesField;
        private bool minutesFieldSpecified;
        private TimeBilledNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
                this.RaisePropertyChanged("Account");
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

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID BillableTask
        {
            get
            {
                return this.billableTaskField;
            }
            set
            {
                this.billableTaskField = value;
                this.RaisePropertyChanged("BillableTask");
            }
        }

        [XmlElement(Order=2)]
        public DateTime BillTime
        {
            get
            {
                return this.billTimeField;
            }
            set
            {
                this.billTimeField = value;
                this.RaisePropertyChanged("BillTime");
            }
        }

        [XmlIgnore]
        public bool BillTimeSpecified
        {
            get
            {
                return this.billTimeFieldSpecified;
            }
            set
            {
                this.billTimeFieldSpecified = value;
                this.RaisePropertyChanged("BillTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
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

        [XmlElement(Order=4)]
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

        [XmlElement(Order=5)]
        public int Minutes
        {
            get
            {
                return this.minutesField;
            }
            set
            {
                this.minutesField = value;
                this.RaisePropertyChanged("Minutes");
            }
        }

        [XmlIgnore]
        public bool MinutesSpecified
        {
            get
            {
                return this.minutesFieldSpecified;
            }
            set
            {
                this.minutesFieldSpecified = value;
                this.RaisePropertyChanged("MinutesSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=6)]
        public TimeBilledNullFields ValidNullFields
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

