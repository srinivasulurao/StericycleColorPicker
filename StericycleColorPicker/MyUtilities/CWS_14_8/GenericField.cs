namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:generic.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class GenericField : INotifyPropertyChanged
    {
        private DataTypeEnum dataTypeField;
        private bool dataTypeFieldSpecified;
        private MyUtilities.CWS_14_8.DataValue dataValueField;
        private string nameField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute]
        public DataTypeEnum dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
                this.RaisePropertyChanged("dataType");
            }
        }

        [XmlIgnore]
        public bool dataTypeSpecified
        {
            get
            {
                return this.dataTypeFieldSpecified;
            }
            set
            {
                this.dataTypeFieldSpecified = value;
                this.RaisePropertyChanged("dataTypeSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public MyUtilities.CWS_14_8.DataValue DataValue
        {
            get
            {
                return this.dataValueField;
            }
            set
            {
                this.dataValueField = value;
                this.RaisePropertyChanged("DataValue");
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
    }
}

