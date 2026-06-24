using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("48eae658-7a44-468b-8589-2de16a00b190")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "48eae658-7a44-468b-8589-2de16a00b190";

	private static Guid _UID = new Guid("48eae658-7a44-468b-8589-2de16a00b190");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
