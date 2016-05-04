namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class Banner : INotifyPropertyChanged
    {
        private NamedID importanceFlagField;
        private string textField;
        private NamedID updatedByAccountField;
        private DateTime? updatedTimeField;
        private bool updatedTimeFieldSpecified;
        private BannerNullFields validNullFieldsField;

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
        public NamedID ImportanceFlag
        {
            get
            {
                return this.importanceFlagField;
            }
            set
            {
                this.importanceFlagField = value;
                this.RaisePropertyChanged("ImportanceFlag");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
                this.RaisePropertyChanged("Text");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public NamedID UpdatedByAccount
        {
            get
            {
                return this.updatedByAccountField;
            }
            set
            {
                this.updatedByAccountField = value;
                this.RaisePropertyChanged("UpdatedByAccount");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public DateTime? UpdatedTime
        {
            get
            {
                return this.updatedTimeField;
            }
            set
            {
                this.updatedTimeField = value;
                this.RaisePropertyChanged("UpdatedTime");
            }
        }

        [XmlIgnore]
        public bool UpdatedTimeSpecified
        {
            get
            {
                return this.updatedTimeFieldSpecified;
            }
            set
            {
                this.updatedTimeFieldSpecified = value;
                this.RaisePropertyChanged("UpdatedTimeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public BannerNullFields ValidNullFields
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

