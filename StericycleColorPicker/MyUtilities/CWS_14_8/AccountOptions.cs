namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="urn:objects.ws.rightnow.com/v1_2"), GeneratedCode("System.Xml", "4.0.30319.18060")]
    public class AccountOptions : INotifyPropertyChanged
    {
        private bool accountLockedField;
        private bool accountLockedFieldSpecified;
        private bool canModifyEmailSignatureField;
        private bool canModifyEmailSignatureFieldSpecified;
        private bool forcePasswordChangeField;
        private bool forcePasswordChangeFieldSpecified;
        private bool passwordNeverExpiresField;
        private bool passwordNeverExpiresFieldSpecified;
        private bool permanentlyDisabledField;
        private bool permanentlyDisabledFieldSpecified;
        private bool staffAssignmentDisabledField;
        private bool staffAssignmentDisabledFieldSpecified;
        private bool viewsReportsDisabledField;
        private bool viewsReportsDisabledFieldSpecified;
        private bool virtualAccountField;
        private bool virtualAccountFieldSpecified;

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
        public bool AccountLocked
        {
            get
            {
                return this.accountLockedField;
            }
            set
            {
                this.accountLockedField = value;
                this.RaisePropertyChanged("AccountLocked");
            }
        }

        [XmlIgnore]
        public bool AccountLockedSpecified
        {
            get
            {
                return this.accountLockedFieldSpecified;
            }
            set
            {
                this.accountLockedFieldSpecified = value;
                this.RaisePropertyChanged("AccountLockedSpecified");
            }
        }

        [XmlElement(Order=1)]
        public bool CanModifyEmailSignature
        {
            get
            {
                return this.canModifyEmailSignatureField;
            }
            set
            {
                this.canModifyEmailSignatureField = value;
                this.RaisePropertyChanged("CanModifyEmailSignature");
            }
        }

        [XmlIgnore]
        public bool CanModifyEmailSignatureSpecified
        {
            get
            {
                return this.canModifyEmailSignatureFieldSpecified;
            }
            set
            {
                this.canModifyEmailSignatureFieldSpecified = value;
                this.RaisePropertyChanged("CanModifyEmailSignatureSpecified");
            }
        }

        [XmlElement(Order=2)]
        public bool ForcePasswordChange
        {
            get
            {
                return this.forcePasswordChangeField;
            }
            set
            {
                this.forcePasswordChangeField = value;
                this.RaisePropertyChanged("ForcePasswordChange");
            }
        }

        [XmlIgnore]
        public bool ForcePasswordChangeSpecified
        {
            get
            {
                return this.forcePasswordChangeFieldSpecified;
            }
            set
            {
                this.forcePasswordChangeFieldSpecified = value;
                this.RaisePropertyChanged("ForcePasswordChangeSpecified");
            }
        }

        [XmlElement(Order=3)]
        public bool PasswordNeverExpires
        {
            get
            {
                return this.passwordNeverExpiresField;
            }
            set
            {
                this.passwordNeverExpiresField = value;
                this.RaisePropertyChanged("PasswordNeverExpires");
            }
        }

        [XmlIgnore]
        public bool PasswordNeverExpiresSpecified
        {
            get
            {
                return this.passwordNeverExpiresFieldSpecified;
            }
            set
            {
                this.passwordNeverExpiresFieldSpecified = value;
                this.RaisePropertyChanged("PasswordNeverExpiresSpecified");
            }
        }

        [XmlElement(Order=4)]
        public bool PermanentlyDisabled
        {
            get
            {
                return this.permanentlyDisabledField;
            }
            set
            {
                this.permanentlyDisabledField = value;
                this.RaisePropertyChanged("PermanentlyDisabled");
            }
        }

        [XmlIgnore]
        public bool PermanentlyDisabledSpecified
        {
            get
            {
                return this.permanentlyDisabledFieldSpecified;
            }
            set
            {
                this.permanentlyDisabledFieldSpecified = value;
                this.RaisePropertyChanged("PermanentlyDisabledSpecified");
            }
        }

        [XmlElement(Order=5)]
        public bool StaffAssignmentDisabled
        {
            get
            {
                return this.staffAssignmentDisabledField;
            }
            set
            {
                this.staffAssignmentDisabledField = value;
                this.RaisePropertyChanged("StaffAssignmentDisabled");
            }
        }

        [XmlIgnore]
        public bool StaffAssignmentDisabledSpecified
        {
            get
            {
                return this.staffAssignmentDisabledFieldSpecified;
            }
            set
            {
                this.staffAssignmentDisabledFieldSpecified = value;
                this.RaisePropertyChanged("StaffAssignmentDisabledSpecified");
            }
        }

        [XmlElement(Order=6)]
        public bool ViewsReportsDisabled
        {
            get
            {
                return this.viewsReportsDisabledField;
            }
            set
            {
                this.viewsReportsDisabledField = value;
                this.RaisePropertyChanged("ViewsReportsDisabled");
            }
        }

        [XmlIgnore]
        public bool ViewsReportsDisabledSpecified
        {
            get
            {
                return this.viewsReportsDisabledFieldSpecified;
            }
            set
            {
                this.viewsReportsDisabledFieldSpecified = value;
                this.RaisePropertyChanged("ViewsReportsDisabledSpecified");
            }
        }

        [XmlElement(Order=7)]
        public bool VirtualAccount
        {
            get
            {
                return this.virtualAccountField;
            }
            set
            {
                this.virtualAccountField = value;
                this.RaisePropertyChanged("VirtualAccount");
            }
        }

        [XmlIgnore]
        public bool VirtualAccountSpecified
        {
            get
            {
                return this.virtualAccountFieldSpecified;
            }
            set
            {
                this.virtualAccountFieldSpecified = value;
                this.RaisePropertyChanged("VirtualAccountSpecified");
            }
        }
    }
}

