namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), DesignerCategory("code"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class InheritOptions : INotifyPropertyChanged
    {
        private bool inheritContactField;
        private bool inheritContactFieldSpecified;
        private bool inheritOrganizationField;
        private bool inheritOrganizationFieldSpecified;
        private bool inheritStaffAssignmentField;
        private bool inheritStaffAssignmentFieldSpecified;

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
        public bool InheritContact
        {
            get
            {
                return this.inheritContactField;
            }
            set
            {
                this.inheritContactField = value;
                this.RaisePropertyChanged("InheritContact");
            }
        }

        [XmlIgnore]
        public bool InheritContactSpecified
        {
            get
            {
                return this.inheritContactFieldSpecified;
            }
            set
            {
                this.inheritContactFieldSpecified = value;
                this.RaisePropertyChanged("InheritContactSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool InheritOrganization
        {
            get
            {
                return this.inheritOrganizationField;
            }
            set
            {
                this.inheritOrganizationField = value;
                this.RaisePropertyChanged("InheritOrganization");
            }
        }

        [XmlIgnore]
        public bool InheritOrganizationSpecified
        {
            get
            {
                return this.inheritOrganizationFieldSpecified;
            }
            set
            {
                this.inheritOrganizationFieldSpecified = value;
                this.RaisePropertyChanged("InheritOrganizationSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool InheritStaffAssignment
        {
            get
            {
                return this.inheritStaffAssignmentField;
            }
            set
            {
                this.inheritStaffAssignmentField = value;
                this.RaisePropertyChanged("InheritStaffAssignment");
            }
        }

        [XmlIgnore]
        public bool InheritStaffAssignmentSpecified
        {
            get
            {
                return this.inheritStaffAssignmentFieldSpecified;
            }
            set
            {
                this.inheritStaffAssignmentFieldSpecified = value;
                this.RaisePropertyChanged("InheritStaffAssignmentSpecified");
            }
        }
    }
}

