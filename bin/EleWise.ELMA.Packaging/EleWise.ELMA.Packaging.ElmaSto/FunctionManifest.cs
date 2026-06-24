using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public sealed class FunctionManifest : AbstractManifest
{
	public TypeSignature ReturnType { get; set; }

	public TypeSignature ParameterType { get; set; }
}
