using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("0c1f2fb8-a7f4-4809-b7e2-43f2853a555d")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "0c1f2fb8-a7f4-4809-b7e2-43f2853a555d";

	private static Guid _UID = new Guid("0c1f2fb8-a7f4-4809-b7e2-43f2853a555d");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Содержимое");
}
