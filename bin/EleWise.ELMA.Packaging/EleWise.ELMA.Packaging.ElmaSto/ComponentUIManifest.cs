using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public sealed class ComponentUIManifest : AbstractManifest
{
	public List<InputTypeSignature> Inputs { get; set; }

	public ComponentUIManifest()
	{
		Inputs = new List<InputTypeSignature>();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeProperties()
	{
		return Inputs.Count != 0;
	}
}
