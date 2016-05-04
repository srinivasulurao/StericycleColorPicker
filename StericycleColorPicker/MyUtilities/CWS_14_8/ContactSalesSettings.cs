namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class ContactSalesSettings : INotifyPropertyChanged
    {
        private DateTime? acquiredDateField;
        private bool acquiredDateFieldSpecified;
        private NamedID salesAccountField;
        private ContactSalesSettingsNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(DataType="date", IsNullable=true, Order=0)]
        public DateTime? AcquiredDate
        {
            get
            {
                return this.acquiredDateField;
            }
            set
            {
                this.acquiredDateField = value;
                this.RaisePropertyChanged("AcquiredDate");
            }
        }

        [XmlIgnore]
        public bool AcquiredDateSpecified
        {
            get
            {
                return this.acquiredDateFieldSpecified;
            }
            set
            {
                this.acquiredDateFieldSpecified = value;
                this.RaisePropertyChanged("AcquiredDateSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID SalesAccount
        {
            get
            {
                return this.salesAccountField;
            }
            set
            {
                this.salesAccountField = value;
                this.RaisePropertyChanged("SalesAccount");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public ContactSalesSettingsNullFields ValidNullFields
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

