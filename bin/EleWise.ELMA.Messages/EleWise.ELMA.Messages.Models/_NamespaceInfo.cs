using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("8da5bb30-ad37-444c-bd47-457390abf1b0")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "8da5bb30-ad37-444c-bd47-457390abf1b0";

	private static Guid _UID = new Guid("8da5bb30-ad37-444c-bd47-457390abf1b0");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
