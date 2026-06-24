using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Export;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("d33303f2-cae4-4ba5-85b8-b4b2c26c30da")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "d33303f2-cae4-4ba5-85b8-b4b2c26c30da";

	private static Guid _UID = new Guid("d33303f2-cae4-4ba5-85b8-b4b2c26c30da");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Экспорт календаря");
}
