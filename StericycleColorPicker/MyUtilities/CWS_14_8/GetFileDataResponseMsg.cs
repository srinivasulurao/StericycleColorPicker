﻿namespace MyUtilities.CWS_14_8
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.18060"), DesignerCategory("code"), XmlType(Namespace="urn:messages.ws.rightnow.com/v1_2"), DebuggerStepThrough]
    public class GetFileDataResponseMsg : INotifyPropertyChanged
    {
        private byte[] fileDataField;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlElement(DataType="base64Binary", Order=0)]
        public byte[] FileData
        {
            get
            {
                return this.fileDataField;
            }
            set
            {
                this.fileDataField = value;
                this.RaisePropertyChanged("FileData");
            }
        }
    }
}

