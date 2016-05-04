namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), DebuggerStepThrough]
    public class TaskServiceSettings : INotifyPropertyChanged
    {
        private NamedID answerField;
        private NamedID incidentField;
        private TaskServiceSettingsNullFields validNullFieldsField;

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
        public NamedID Answer
        {
            get
            {
                return this.answerField;
            }
            set
            {
                this.answerField = value;
                this.RaisePropertyChanged("Answer");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Incident
        {
            get
            {
                return this.incidentField;
            }
            set
            {
                this.incidentField = value;
                this.RaisePropertyChanged("Incident");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public TaskServiceSettingsNullFields ValidNullFields
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

