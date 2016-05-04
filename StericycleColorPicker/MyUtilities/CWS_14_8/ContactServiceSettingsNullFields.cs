namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:nullfields.ws.rightnow.com/v1_2"), DebuggerStepThrough, DesignerCategory("code")]
    public class ContactServiceSettingsNullFields : INotifyPropertyChanged
    {
        private bool answerNotificationsField = false;
        private bool categoryNotificationsField = false;
        private bool productNotificationsField = false;
        private bool sLAInstancesField = false;

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
        public bool AnswerNotifications
        {
            get
            {
                return this.answerNotificationsField;
            }
            set
            {
                this.answerNotificationsField = value;
                this.RaisePropertyChanged("AnswerNotifications");
            }
        }

        [DefaultValue(false), XmlAttribute]
        public bool CategoryNotifications
        {
            get
            {
                return this.categoryNotificationsField;
            }
            set
            {
                this.categoryNotificationsField = value;
                this.RaisePropertyChanged("CategoryNotifications");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool ProductNotifications
        {
            get
            {
                return this.productNotificationsField;
            }
            set
            {
                this.productNotificationsField = value;
                this.RaisePropertyChanged("ProductNotifications");
            }
        }

        [XmlAttribute, DefaultValue(false)]
        public bool SLAInstances
        {
            get
            {
                return this.sLAInstancesField;
            }
            set
            {
                this.sLAInstancesField = value;
                this.RaisePropertyChanged("SLAInstances");
            }
        }
    }
}

