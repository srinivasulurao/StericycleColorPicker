namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class SiteInterface : RNObject
    {
        private string displayNameField;
        private NamedID languageField;
        private string nameField;

        [XmlElement(Order=0)]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
                base.RaisePropertyChanged("DisplayName");
            }
        }

        [XmlElement(Order=1)]
        public NamedID Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                base.RaisePropertyChanged("Language");
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
    }
}

