using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("7948686f-a7ba-4c8a-a937-ec02fb90e693")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "7948686f-a7ba-4c8a-a937-ec02fb90e693";

	private static Guid _UID = new Guid("7948686f-a7ba-4c8a-a937-ec02fb90e693");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
