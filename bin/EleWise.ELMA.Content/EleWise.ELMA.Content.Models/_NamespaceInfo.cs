using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("3ed6957c-9b1b-4298-b672-6628017adb5e")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "3ed6957c-9b1b-4298-b672-6628017adb5e";

	private static Guid _UID = new Guid("3ed6957c-9b1b-4298-b672-6628017adb5e");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
