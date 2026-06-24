using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public sealed class DataClassManifest : AbstractManifest
{
	public List<PropertySignature> Properties { get; set; }

	public DataClassManifest()
	{
		Properties = new List<PropertySignature>();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeProperties()
	{
		return Properties.Count != 0;
	}
}
