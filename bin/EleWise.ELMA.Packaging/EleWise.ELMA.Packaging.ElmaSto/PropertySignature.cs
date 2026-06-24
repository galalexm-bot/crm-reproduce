using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public class PropertySignature
{
	public TypeSignature Type { get; set; }

	public string Name { get; set; }

	public Guid Uid { get; set; }

	public PropertySignature()
	{
		Type = new TypeSignature();
	}
}
