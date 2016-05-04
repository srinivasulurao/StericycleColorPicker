namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AnalyticsReport : RNObject
    {
        private AnalyticsReportColumn[] columnsField;
        private AnalyticsReportFilter[] filtersField;
        private string nameField;
        private LabelRequired[] namesField;

        [XmlElement("Columns", Order=0)]
        public AnalyticsReportColumn[] Columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
                base.RaisePropertyChanged("Columns");
            }
        }

        [XmlElement("Filters", Order=1)]
        public AnalyticsReportFilter[] Filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
                base.RaisePropertyChanged("Filters");
            }
        }

        [XmlElement(Order=2)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlArrayItem("LabelList", IsNullable=false), XmlArray(Order=3)]
        public LabelRequired[] Names
        {
            get
            {
                return this.namesField;
            }
            set
            {
                this.namesField = value;
                base.RaisePropertyChanged("Names");
            }
        }
    }
}

