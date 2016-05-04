namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class GetMetaDataForClassResponseMsg : INotifyPropertyChanged
    {
        private MyUtilities.CWS_14_8.MetaDataClass[] metaDataClassField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("MetaDataClass", Order=0)]
        public MyUtilities.CWS_14_8.MetaDataClass[] MetaDataClass
        {
            get
            {
                return this.metaDataClassField;
            }
            set
            {
                this.metaDataClassField = value;
                this.RaisePropertyChanged("MetaDataClass");
            }
        }
    }
}

