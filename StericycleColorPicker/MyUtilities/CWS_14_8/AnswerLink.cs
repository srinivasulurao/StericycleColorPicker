namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2")]
    public class AnswerLink : INotifyPropertyChanged
    {
        private ActionEnum actionField;
        private bool actionFieldSpecified;
        private int? learnedLinkStrengthField;
        private bool learnedLinkStrengthFieldSpecified;
        private int manualLinkStrengthField;
        private bool manualLinkStrengthFieldSpecified;
        private NamedID toAnswerField;
        private AnswerLinkNullFields validNullFieldsField;

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
        public ActionEnum action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }

        [XmlIgnore]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }

        [XmlElement(IsNullable=true, Order=0)]
        public int? LearnedLinkStrength
        {
            get
            {
                return this.learnedLinkStrengthField;
            }
            set
            {
                this.learnedLinkStrengthField = value;
                this.RaisePropertyChanged("LearnedLinkStrength");
            }
        }

        [XmlIgnore]
        public bool LearnedLinkStrengthSpecified
        {
            get
            {
                return this.learnedLinkStrengthFieldSpecified;
            }
            set
            {
                this.learnedLinkStrengthFieldSpecified = value;
                this.RaisePropertyChanged("LearnedLinkStrengthSpecified");
            }
        }

        [XmlElement(Order=1)]
        public int ManualLinkStrength
        {
            get
            {
                return this.manualLinkStrengthField;
            }
            set
            {
                this.manualLinkStrengthField = value;
                this.RaisePropertyChanged("ManualLinkStrength");
            }
        }

        [XmlIgnore]
        public bool ManualLinkStrengthSpecified
        {
            get
            {
                return this.manualLinkStrengthFieldSpecified;
            }
            set
            {
                this.manualLinkStrengthFieldSpecified = value;
                this.RaisePropertyChanged("ManualLinkStrengthSpecified");
            }
        }

        [XmlElement(Order=2)]
        public NamedID ToAnswer
        {
            get
            {
                return this.toAnswerField;
            }
            set
            {
                this.toAnswerField = value;
                this.RaisePropertyChanged("ToAnswer");
            }
        }

        [XmlElement(IsNullable=true, Order=3)]
        public AnswerLinkNullFields ValidNullFields
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

