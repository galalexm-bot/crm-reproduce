using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public class InputTypeSignature : TypeSignature
{
	[DefaultValue(null)]
	public string Name { get; set; }

	[DefaultValue(false)]
	public bool Required { get; set; }
}
