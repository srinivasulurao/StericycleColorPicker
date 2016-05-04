namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class GroupAccountNullFields : INotifyPropertyChanged
    {
        private bool accountField = false;
        private bool staffGroupField = false;

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
        public bool Account
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

        [XmlAttribute, DefaultValue(false)]
        public bool StaffGroup
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
    }
}

