namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlInclude(typeof(OpportunityContactDelta))]
    public class OpportunityContact : INotifyPropertyChanged
    {
        private NamedID contactField;
        private NamedID contactRoleField;
        private OpportunityContactNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=0)]
        public NamedID Contact
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

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID ContactRole
        {
            get
            {
                return this.contactRoleField;
            }
            set
            {
                this.contactRoleField = value;
                this.RaisePropertyChanged("ContactRole");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public OpportunityContactNullFields ValidNullFields
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

