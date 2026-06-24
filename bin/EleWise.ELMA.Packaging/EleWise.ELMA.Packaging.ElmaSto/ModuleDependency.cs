using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public sealed class ModuleDependency
{
	public Guid ModuleUid { get; set; }

	public string DisplayName { get; set; }
}
