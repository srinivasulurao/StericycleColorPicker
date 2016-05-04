namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2")]
    public class GetFileDataMsg : INotifyPropertyChanged
    {
        private bool disableMTOMField;
        private bool disableMTOMFieldSpecified;
        private ID fileIDField;
        private MyUtilities.CWS_14_8.RNObject rNObjectField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(Order=2)]
        public bool DisableMTOM
        {
            get
            {
                return this.disableMTOMField;
            }
            set
            {
                this.disableMTOMField = value;
                this.RaisePropertyChanged("DisableMTOM");
            }
        }

        [XmlIgnore]
        public bool DisableMTOMSpecified
        {
            get
            {
                return this.disableMTOMFieldSpecified;
            }
            set
            {
                this.disableMTOMFieldSpecified = value;
                this.RaisePropertyChanged("DisableMTOMSpecified");
            }
        }

        [XmlElement(Order=1)]
        public ID FileID
        {
            get
            {
                return this.fileIDField;
            }
            set
            {
                this.fileIDField = value;
                this.RaisePropertyChanged("FileID");
            }
        }

        [XmlElement(Order=0)]
        public MyUtilities.CWS_14_8.RNObject RNObject
        {
            get
            {
                return this.rNObjectField;
            }
            set
            {
                this.rNObjectField = value;
                this.RaisePropertyChanged("RNObject");
            }
        }
    }
}

