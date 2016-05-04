namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code")]
    public class AnalyticsReportFilter : AnalyticsReportSearchFilter
    {
        private AnalyticsReportFilterAttributes attributesField;
        private NamedID dataTypeField;
        private string promptField;

        [XmlElement(Order=0)]
        public AnalyticsReportFilterAttributes Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
                base.RaisePropertyChanged("Attributes");
            }
        }

        [XmlElement(Order=1)]
        public NamedID DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
                base.RaisePropertyChanged("DataType");
            }
        }

        [XmlElement(Order=2)]
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
                base.RaisePropertyChanged("Prompt");
            }
        }
    }
}

