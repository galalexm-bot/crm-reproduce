using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public abstract class AbstractManifest
{
	public Guid HeaderUid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }
}
