using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

[Serializable]
[DataContract]
[XmlType(Namespace = "ModuleManifest")]
public class TypeSignature
{
	public Guid TypeUid { get; set; }

	public Guid SubTypeUid { get; set; }

	[DefaultValue(false)]
	public bool Nullable { get; set; }

	[DefaultValue(RelationType.OneToOne)]
	public RelationType RelationType { get; set; }

	public TypeSignature()
	{
		RelationType = RelationType.OneToOne;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTypeUid()
	{
		return TypeUid != Guid.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSubTypeUid()
	{
		return SubTypeUid != Guid.Empty;
	}
}
