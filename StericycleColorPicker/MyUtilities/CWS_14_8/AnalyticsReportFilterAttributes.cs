namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class AnalyticsReportFilterAttributes : INotifyPropertyChanged
    {
        private bool editableField;
        private bool editableFieldSpecified;
        private bool requiredField;
        private bool requiredFieldSpecified;

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
        public bool Editable
        {
            get
            {
                return this.editableField;
            }
            set
            {
                this.editableField = value;
                this.RaisePropertyChanged("Editable");
            }
        }

        [XmlIgnore]
        public bool EditableSpecified
        {
            get
            {
                return this.editableFieldSpecified;
            }
            set
            {
                this.editableFieldSpecified = value;
                this.RaisePropertyChanged("EditableSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool Required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
                this.RaisePropertyChanged("Required");
            }
        }

        [XmlIgnore]
        public bool RequiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }
            set
            {
                this.requiredFieldSpecified = value;
                this.RaisePropertyChanged("RequiredSpecified");
            }
        }
    }
}

