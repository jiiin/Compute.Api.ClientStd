﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.ContractsStd.Vip
{
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

    using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://oec.api.opsource.net/schemas/vip")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://oec.api.opsource.net/schemas/vip", IsNullable = false
        )]
    public partial class NewRealServer
    {

        private string nameField;

        private string serverIdField;

        private string inServiceField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string serverId
        {
            get { return this.serverIdField; }
            set { this.serverIdField = value; }
        }

        /// <remarks/>
        public string inService
        {
            get { return this.inServiceField; }
            set { this.inServiceField = value; }
        }
    }


}
