using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Enums;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("d19369f3-52c6-4a53-a699-db33809285eb")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "d19369f3-52c6-4a53-a699-db33809285eb";

	private static Guid _UID = new Guid("d19369f3-52c6-4a53-a699-db33809285eb");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
