namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:metadata.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class MetaDataAttribute : INotifyPropertyChanged
    {
        private DataTypeEnum dataTypeField;
        private string dataTypeNameField;
        private string descriptionField;
        private bool isDeprecatedField;
        private int maxLengthField;
        private bool maxLengthFieldSpecified;
        private int maxValueField;
        private bool maxValueFieldSpecified;
        private string metaDataLinkField;
        private int minValueField;
        private bool minValueFieldSpecified;
        private string nameField;
        private bool nullableField;
        private string patternField;
        private MetaDataUsageEnum usageOnCreateField;
        private MetaDataUsageEnum usageOnDestroyField;
        private MetaDataUsageEnum usageOnGetField;
        private MetaDataUsageEnum usageOnUpdateField;
        private bool usedAsNameField;

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
        public DataTypeEnum DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
                this.RaisePropertyChanged("DataType");
            }
        }

        [XmlElement(Order=1)]
        public string DataTypeName
        {
            get
            {
                return this.dataTypeNameField;
            }
            set
            {
                this.dataTypeNameField = value;
                this.RaisePropertyChanged("DataTypeName");
            }
        }

        [XmlElement(Order=4)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }

        [XmlElement(Order=3)]
        public bool IsDeprecated
        {
            get
            {
                return this.isDeprecatedField;
            }
            set
            {
                this.isDeprecatedField = value;
                this.RaisePropertyChanged("IsDeprecated");
            }
        }

        [XmlElement(Order=5)]
        public int MaxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
                this.RaisePropertyChanged("MaxLength");
            }
        }

        [XmlIgnore]
        public bool MaxLengthSpecified
        {
            get
            {
                return this.maxLengthFieldSpecified;
            }
            set
            {
                this.maxLengthFieldSpecified = value;
                this.RaisePropertyChanged("MaxLengthSpecified");
            }
        }

        [XmlElement(Order=6)]
        public int MaxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
                this.RaisePropertyChanged("MaxValue");
            }
        }

        [XmlIgnore]
        public bool MaxValueSpecified
        {
            get
            {
                return this.maxValueFieldSpecified;
            }
            set
            {
                this.maxValueFieldSpecified = value;
                this.RaisePropertyChanged("MaxValueSpecified");
            }
        }

        [XmlElement(Order=2)]
        public string MetaDataLink
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

        [XmlElement(Order=7)]
        public int MinValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
                this.RaisePropertyChanged("MinValue");
            }
        }

        [XmlIgnore]
        public bool MinValueSpecified
        {
            get
            {
                return this.minValueFieldSpecified;
            }
            set
            {
                this.minValueFieldSpecified = value;
                this.RaisePropertyChanged("MinValueSpecified");
            }
        }

        [XmlElement(Order=8)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(Order=9)]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
                this.RaisePropertyChanged("Nullable");
            }
        }

        [XmlElement(Order=10)]
        public string Pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
                this.RaisePropertyChanged("Pattern");
            }
        }

        [XmlElement(Order=11)]
        public MetaDataUsageEnum UsageOnCreate
        {
            get
            {
                return this.usageOnCreateField;
            }
            set
            {
                this.usageOnCreateField = value;
                this.RaisePropertyChanged("UsageOnCreate");
            }
        }

        [XmlElement(Order=12)]
        public MetaDataUsageEnum UsageOnDestroy
        {
            get
            {
                return this.usageOnDestroyField;
            }
            set
            {
                this.usageOnDestroyField = value;
                this.RaisePropertyChanged("UsageOnDestroy");
            }
        }

        [XmlElement(Order=13)]
        public MetaDataUsageEnum UsageOnGet
        {
            get
            {
                return this.usageOnGetField;
            }
            set
            {
                this.usageOnGetField = value;
                this.RaisePropertyChanged("UsageOnGet");
            }
        }

        [XmlElement(Order=14)]
        public MetaDataUsageEnum UsageOnUpdate
        {
            get
            {
                return this.usageOnUpdateField;
            }
            set
            {
                this.usageOnUpdateField = value;
                this.RaisePropertyChanged("UsageOnUpdate");
            }
        }

        [XmlElement(Order=15)]
        public bool UsedAsName
        {
            get
            {
                return this.usedAsNameField;
            }
            set
            {
                this.usedAsNameField = value;
                this.RaisePropertyChanged("UsedAsName");
            }
        }
    }
}

