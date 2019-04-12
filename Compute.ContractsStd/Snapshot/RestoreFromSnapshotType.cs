using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.Contracts.Snapshot
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("restoreFromSnapshot", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class RestoreFromSnapshotType
	{

		private string pathOnSourceSnapshotField;

		private string pathOnTargetServerField;

		private string targetServerUsernameField;

		private string targetServerPasswordField;

		private string snapshotIdField;

		/// <remarks/>
		public string pathOnSourceSnapshot
		{
			get
			{
				return this.pathOnSourceSnapshotField;
			}
			set
			{
				this.pathOnSourceSnapshotField = value;
			}
		}

		/// <remarks/>
		public string pathOnTargetServer
		{
			get
			{
				return this.pathOnTargetServerField;
			}
			set
			{
				this.pathOnTargetServerField = value;
			}
		}

		/// <remarks/>
		public string targetServerUsername
		{
			get
			{
				return this.targetServerUsernameField;
			}
			set
			{
				this.targetServerUsernameField = value;
			}
		}

		/// <remarks/>
		public string targetServerPassword
		{
			get
			{
				return this.targetServerPasswordField;
			}
			set
			{
				this.targetServerPasswordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string snapshotId
		{
			get
			{
				return this.snapshotIdField;
			}
			set
			{
				this.snapshotIdField = value;
			}
		}
	}
}
