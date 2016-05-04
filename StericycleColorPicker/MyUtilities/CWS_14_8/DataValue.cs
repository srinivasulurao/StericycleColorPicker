namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:generic.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class DataValue : INotifyPropertyChanged
    {
        private ItemsChoiceType[] itemsElementNameField;
        private object[] itemsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement("LongValueList", typeof(long), Order=0), XmlElement("NamedIDHierarchyValue", typeof(NamedIDHierarchy), Order=0), XmlElement("NamedIDHierarchyValueList", typeof(NamedIDHierarchy), Order=0), XmlElement("NamedIDDeltaValueList", typeof(NamedIDDelta), Order=0), XmlElement("IntegerValue", typeof(int), Order=0), XmlElement("BooleanValue", typeof(bool), Order=0), XmlElement("BooleanValueList", typeof(bool), Order=0), XmlElement("DateTimeValue", typeof(DateTime), Order=0), XmlElement("DateTimeValueList", typeof(DateTime), Order=0), XmlChoiceIdentifier("ItemsElementName"), XmlElement("DateValueList", typeof(DateTime), DataType="date", Order=0), XmlElement("DecimalValue", typeof(double), Order=0), XmlElement("DecimalValueList", typeof(double), Order=0), XmlElement("IDValue", typeof(ID), Order=0), XmlElement("IDValueList", typeof(ID), Order=0), XmlElement("IntegerValueList", typeof(int), Order=0), XmlElement("LongValue", typeof(long), Order=0), XmlElement("DateValue", typeof(DateTime), DataType="date", Order=0), XmlElement("Base64BinaryValue", typeof(byte[]), DataType="base64Binary", Order=0), XmlElement("NamedIDValue", typeof(NamedID), Order=0), XmlElement("NamedIDValueList", typeof(NamedID), Order=0), XmlElement("ObjectValue", typeof(GenericObject), Order=0), XmlElement("ObjectValueList", typeof(GenericObject), Order=0), XmlElement("StringValue", typeof(string), Order=0), XmlElement("StringValueList", typeof(string), Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }

        [XmlIgnore, XmlElement("ItemsElementName", Order=1)]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
            }
        }
    }
}

