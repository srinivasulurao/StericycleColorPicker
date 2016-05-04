namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class GroupAccount : INotifyPropertyChanged
    {
        private NamedID accountField;
        private NamedID staffGroupField;
        private GroupAccountNullFields validNullFieldsField;

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

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID StaffGroup
        {
            get
            {
                return this.staffGroupField;
            }
            set
            {
                this.staffGroupField = value;
                this.RaisePropertyChanged("StaffGroup");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public GroupAccountNullFields ValidNullFields
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

