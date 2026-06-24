using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("bdce4639-4958-46ff-90c8-da3e50e96538")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "bdce4639-4958-46ff-90c8-da3e50e96538";

	private static Guid _UID = new Guid("bdce4639-4958-46ff-90c8-da3e50e96538");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Сообщения");
}
