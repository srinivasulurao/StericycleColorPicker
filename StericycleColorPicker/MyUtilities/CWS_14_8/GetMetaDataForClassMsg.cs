namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code")]
    public class GetMetaDataForClassMsg : INotifyPropertyChanged
    {
        private string[] classNameField;
        private string[] metaDataLinkField;
        private RNObjectType[] qualifiedClassNameField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("ClassName", Order=0)]
        public string[] ClassName
        {
            get
            {
                return this.classNameField;
            }
            set
            {
                this.classNameField = value;
                this.RaisePropertyChanged("ClassName");
            }
        }

        [XmlElement("MetaDataLink", Order=2)]
        public string[] MetaDataLink
        {
            get
            {
                return this.metaDataLinkField;
            }
            set
            {
                this.metaDataLinkField = value;
                this.RaisePropertyChanged("MetaDataLink");
            }
        }

        [XmlElement("QualifiedClassName", Order=1)]
        public RNObjectType[] QualifiedClassName
        {
            get
            {
                return this.qualifiedClassNameField;
            }
            set
            {
                this.qualifiedClassNameField = value;
                this.RaisePropertyChanged("QualifiedClassName");
            }
        }
    }
}

