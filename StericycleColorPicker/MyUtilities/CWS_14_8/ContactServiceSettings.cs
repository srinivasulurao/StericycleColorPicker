namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class ContactServiceSettings : INotifyPropertyChanged
    {
        private AnswerNotification[] answerNotificationsField;
        private CategoryNotification[] categoryNotificationsField;
        private ProductNotification[] productNotificationsField;
        private SLAInstance[] sLAInstancesField;
        private ContactServiceSettingsNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArrayItem("AnswerNotificationList", IsNullable=false), XmlArray(IsNullable=true, Order=0)]
        public AnswerNotification[] AnswerNotifications
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

        [XmlArrayItem("CategoryNotificationList", IsNullable=false), XmlArray(IsNullable=true, Order=1)]
        public CategoryNotification[] CategoryNotifications
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

        [XmlArray(IsNullable=true, Order=2), XmlArrayItem("ProductNotificationList", IsNullable=false)]
        public ProductNotification[] ProductNotifications
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

        [XmlArray(IsNullable=true, Order=3), XmlArrayItem("SLAInstanceList", IsNullable=false)]
        public SLAInstance[] SLAInstances
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

        [XmlElement(IsNullable=true, Order=4)]
        public ContactServiceSettingsNullFields ValidNullFields
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

