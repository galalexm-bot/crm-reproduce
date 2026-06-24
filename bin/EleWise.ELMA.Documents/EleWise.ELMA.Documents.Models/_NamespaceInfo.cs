using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("cddf7c29-0900-450c-bfc2-66afba6c3913")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "cddf7c29-0900-450c-bfc2-66afba6c3913";

	private static Guid _UID = new Guid("cddf7c29-0900-450c-bfc2-66afba6c3913");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
