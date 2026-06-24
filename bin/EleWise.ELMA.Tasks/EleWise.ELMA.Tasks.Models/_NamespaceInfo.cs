using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("3c459c09-edb1-4b20-969a-beb28008f0ee")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "3c459c09-edb1-4b20-969a-beb28008f0ee";

	private static Guid _UID = new Guid("3c459c09-edb1-4b20-969a-beb28008f0ee");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
