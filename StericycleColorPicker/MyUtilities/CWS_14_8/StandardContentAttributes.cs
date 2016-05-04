namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class StandardContentAttributes : INotifyPropertyChanged
    {
        private bool displayRightToLeftField;
        private bool displayRightToLeftFieldSpecified;

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
        public bool DisplayRightToLeft
        {
            get
            {
                return this.displayRightToLeftField;
            }
            set
            {
                this.displayRightToLeftField = value;
                this.RaisePropertyChanged("DisplayRightToLeft");
            }
        }

        [XmlIgnore]
        public bool DisplayRightToLeftSpecified
        {
            get
            {
                return this.displayRightToLeftFieldSpecified;
            }
            set
            {
                this.displayRightToLeftFieldSpecified = value;
                this.RaisePropertyChanged("DisplayRightToLeftSpecified");
            }
        }
    }
}

