namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class OrganizationSalesSettingsNullFields : INotifyPropertyChanged
    {
        private bool salesAccountField = false;
        private bool totalRevenueField = false;

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
        public bool SalesAccount
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

        [XmlAttribute, DefaultValue(false)]
        public bool TotalRevenue
        {
            get
            {
                return this.totalRevenueField;
            }
            set
            {
                this.totalRevenueField = value;
                this.RaisePropertyChanged("TotalRevenue");
            }
        }
    }
}

