namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class RunAnalyticsReportMsg : INotifyPropertyChanged
    {
        private MyUtilities.CWS_14_8.AnalyticsReport analyticsReportField;
        private string delimiterField;
        private bool disableMTOMField;
        private bool disableMTOMFieldSpecified;
        private int limitField;
        private bool limitFieldSpecified;
        private bool returnRawResultField;
        private bool returnRawResultFieldSpecified;
        private int startField;
        private bool startFieldSpecified;

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
        public MyUtilities.CWS_14_8.AnalyticsReport AnalyticsReport
        {
            get
            {
                return this.analyticsReportField;
            }
            set
            {
                this.analyticsReportField = value;
                this.RaisePropertyChanged("AnalyticsReport");
            }
        }

        [XmlElement(Order=3)]
        public string Delimiter
        {
            get
            {
                return this.delimiterField;
            }
            set
            {
                this.delimiterField = value;
                this.RaisePropertyChanged("Delimiter");
            }
        }

        [XmlElement(Order=5)]
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
        public int Limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
                this.RaisePropertyChanged("Limit");
            }
        }

        [XmlIgnore]
        public bool LimitSpecified
        {
            get
            {
                return this.limitFieldSpecified;
            }
            set
            {
                this.limitFieldSpecified = value;
                this.RaisePropertyChanged("LimitSpecified");
            }
        }

        [XmlElement(Order=4)]
        public bool ReturnRawResult
        {
            get
            {
                return this.returnRawResultField;
            }
            set
            {
                this.returnRawResultField = value;
                this.RaisePropertyChanged("ReturnRawResult");
            }
        }

        [XmlIgnore]
        public bool ReturnRawResultSpecified
        {
            get
            {
                return this.returnRawResultFieldSpecified;
            }
            set
            {
                this.returnRawResultFieldSpecified = value;
                this.RaisePropertyChanged("ReturnRawResultSpecified");
            }
        }

        [XmlElement(Order=2)]
        public int Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
                this.RaisePropertyChanged("Start");
            }
        }

        [XmlIgnore]
        public bool StartSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
                this.RaisePropertyChanged("StartSpecified");
            }
        }
    }
}

