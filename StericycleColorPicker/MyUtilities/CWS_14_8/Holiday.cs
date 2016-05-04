namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class Holiday : RNObject
    {
        private NamedIDDelta[] adminVisibleInterfacesField;
        private int displayOrderField;
        private bool displayOrderFieldSpecified;
        private DateTime holidayDateField;
        private bool holidayDateFieldSpecified;
        private string nameField;
        private HolidayNullFields validNullFieldsField;

        [XmlArrayItem("NamedIDDeltaList", Namespace="urn:base.ws.rightnow.com/v1_2", IsNullable=false), XmlArray(IsNullable=true, Order=0)]
        public NamedIDDelta[] AdminVisibleInterfaces
        {
            get
            {
                return this.adminVisibleInterfacesField;
            }
            set
            {
                this.adminVisibleInterfacesField = value;
                base.RaisePropertyChanged("AdminVisibleInterfaces");
            }
        }

        [XmlElement(Order=1)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                base.RaisePropertyChanged("DisplayOrder");
            }
        }

        [XmlIgnore]
        public bool DisplayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
                base.RaisePropertyChanged("DisplayOrderSpecified");
            }
        }

        [XmlElement(DataType="date", Order=2)]
        public DateTime HolidayDate
        {
            get
            {
                return this.holidayDateField;
            }
            set
            {
                this.holidayDateField = value;
                base.RaisePropertyChanged("HolidayDate");
            }
        }

        [XmlIgnore]
        public bool HolidayDateSpecified
        {
            get
            {
                return this.holidayDateFieldSpecified;
            }
            set
            {
                this.holidayDateFieldSpecified = value;
                base.RaisePropertyChanged("HolidayDateSpecified");
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
                base.RaisePropertyChanged("Name");
            }
        }

        [XmlElement(IsNullable=true, Order=4)]
        public HolidayNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                base.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

