using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("998a374a-6b3f-45d2-9341-1ac31c260185")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "998a374a-6b3f-45d2-9341-1ac31c260185";

	private static Guid _UID = new Guid("998a374a-6b3f-45d2-9341-1ac31c260185");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Документы");
}
