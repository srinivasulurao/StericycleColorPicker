namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class TaskServiceSettingsNullFields : INotifyPropertyChanged
    {
        private bool answerField = false;
        private bool incidentField = false;

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
        public bool Answer
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

        [XmlAttribute, DefaultValue(false)]
        public bool Incident
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
    }
}

