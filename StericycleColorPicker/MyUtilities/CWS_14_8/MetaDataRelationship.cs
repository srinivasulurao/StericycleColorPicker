namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:metadata.ws.rightnow.com/v1_2")]
    public class MetaDataRelationship : INotifyPropertyChanged
    {
        private MetaDataCardinalityEnum myCardinalityField;
        private string[] myKeyAttributesField;
        private MetaDataKeyTypeEnum myKeyTypeField;
        private string nameField;
        private MetaDataNavigabilityEnum navigabilityField;
        private MetaDataCardinalityEnum otherClassCardinalityField;
        private string[] otherClassKeyAttributesField;
        private MetaDataKeyTypeEnum[] otherClassKeyTypeField;
        private RNObjectType otherClassNameField;

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
        public MetaDataCardinalityEnum MyCardinality
        {
            get
            {
                return this.myCardinalityField;
            }
            set
            {
                this.myCardinalityField = value;
                this.RaisePropertyChanged("MyCardinality");
            }
        }

        [XmlElement("MyKeyAttributes", Order=1)]
        public string[] MyKeyAttributes
        {
            get
            {
                return this.myKeyAttributesField;
            }
            set
            {
                this.myKeyAttributesField = value;
                this.RaisePropertyChanged("MyKeyAttributes");
            }
        }

        [XmlElement(Order=2)]
        public MetaDataKeyTypeEnum MyKeyType
        {
            get
            {
                return this.myKeyTypeField;
            }
            set
            {
                this.myKeyTypeField = value;
                this.RaisePropertyChanged("MyKeyType");
            }
        }

        [XmlElement(Order=3)]
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

        [XmlElement(Order=4)]
        public MetaDataNavigabilityEnum Navigability
        {
            get
            {
                return this.navigabilityField;
            }
            set
            {
                this.navigabilityField = value;
                this.RaisePropertyChanged("Navigability");
            }
        }

        [XmlElement(Order=5)]
        public MetaDataCardinalityEnum OtherClassCardinality
        {
            get
            {
                return this.otherClassCardinalityField;
            }
            set
            {
                this.otherClassCardinalityField = value;
                this.RaisePropertyChanged("OtherClassCardinality");
            }
        }

        [XmlElement("OtherClassKeyAttributes", Order=6)]
        public string[] OtherClassKeyAttributes
        {
            get
            {
                return this.otherClassKeyAttributesField;
            }
            set
            {
                this.otherClassKeyAttributesField = value;
                this.RaisePropertyChanged("OtherClassKeyAttributes");
            }
        }

        [XmlElement("OtherClassKeyType", Order=7)]
        public MetaDataKeyTypeEnum[] OtherClassKeyType
        {
            get
            {
                return this.otherClassKeyTypeField;
            }
            set
            {
                this.otherClassKeyTypeField = value;
                this.RaisePropertyChanged("OtherClassKeyType");
            }
        }

        [XmlElement(Order=8)]
        public RNObjectType OtherClassName
        {
            get
            {
                return this.otherClassNameField;
            }
            set
            {
                this.otherClassNameField = value;
                this.RaisePropertyChanged("OtherClassName");
            }
        }
    }
}

