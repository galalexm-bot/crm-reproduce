using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models.Filters;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("15757587-9ea9-43d6-b192-e4613d84d541")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "15757587-9ea9-43d6-b192-e4613d84d541";

	private static Guid _UID = new Guid("15757587-9ea9-43d6-b192-e4613d84d541");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Фильтры");
}
