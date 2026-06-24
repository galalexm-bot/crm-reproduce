using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("f32d721f-ce13-4377-af77-71d8a1a6a5e7")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "f32d721f-ce13-4377-af77-71d8a1a6a5e7";

	private static Guid _UID = new Guid("f32d721f-ce13-4377-af77-71d8a1a6a5e7");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Календарь и события");
}
