namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:metadata.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class MetaDataClass : INotifyPropertyChanged
    {
        private MetaDataAttribute[] attributesField;
        private bool canCreateField;
        private bool canDestroyField;
        private bool canGetField;
        private bool canUpdateField;
        private RNObjectType derivedFromField;
        private string metaDataLinkField;
        private RNObjectType nameField;
        private MetaDataRelationship[] relationshipsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlArray(Order=0), XmlArrayItem("MetaDataAttributeList", IsNullable=false)]
        public MetaDataAttribute[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
                this.RaisePropertyChanged("Attributes");
            }
        }

        [XmlElement(Order=1)]
        public bool CanCreate
        {
            get
            {
                return this.canCreateField;
            }
            set
            {
                this.canCreateField = value;
                this.RaisePropertyChanged("CanCreate");
            }
        }

        [XmlElement(Order=2)]
        public bool CanDestroy
        {
            get
            {
                return this.canDestroyField;
            }
            set
            {
                this.canDestroyField = value;
                this.RaisePropertyChanged("CanDestroy");
            }
        }

        [XmlElement(Order=3)]
        public bool CanGet
        {
            get
            {
                return this.canGetField;
            }
            set
            {
                this.canGetField = value;
                this.RaisePropertyChanged("CanGet");
            }
        }

        [XmlElement(Order=4)]
        public bool CanUpdate
        {
            get
            {
                return this.canUpdateField;
            }
            set
            {
                this.canUpdateField = value;
                this.RaisePropertyChanged("CanUpdate");
            }
        }

        [XmlElement(Order=5)]
        public RNObjectType DerivedFrom
        {
            get
            {
                return this.derivedFromField;
            }
            set
            {
                this.derivedFromField = value;
                this.RaisePropertyChanged("DerivedFrom");
            }
        }

        [XmlElement(Order=6)]
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
        public RNObjectType Name
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

        [XmlElement("Relationships", Order=8)]
        public MetaDataRelationship[] Relationships
        {
            get
            {
                return this.relationshipsField;
            }
            set
            {
                this.relationshipsField = value;
                this.RaisePropertyChanged("Relationships");
            }
        }
    }
}

