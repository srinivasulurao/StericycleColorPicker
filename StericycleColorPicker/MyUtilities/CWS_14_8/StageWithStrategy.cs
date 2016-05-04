namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class StageWithStrategy : INotifyPropertyChanged
    {
        private NamedID stageField;
        private NamedID strategyField;
        private StageWithStrategyNullFields validNullFieldsField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public NamedID Stage
        {
            get
            {
                return this.stageField;
            }
            set
            {
                this.stageField = value;
                this.RaisePropertyChanged("Stage");
            }
        }

        [XmlElement(IsNullable=true, Order=1)]
        public NamedID Strategy
        {
            get
            {
                return this.strategyField;
            }
            set
            {
                this.strategyField = value;
                this.RaisePropertyChanged("Strategy");
            }
        }

        [XmlElement(IsNullable=true, Order=2)]
        public StageWithStrategyNullFields ValidNullFields
        {
            get
            {
                return this.validNullFieldsField;
            }
            set
            {
                this.validNullFieldsField = value;
                this.RaisePropertyChanged("ValidNullFields");
            }
        }
    }
}

