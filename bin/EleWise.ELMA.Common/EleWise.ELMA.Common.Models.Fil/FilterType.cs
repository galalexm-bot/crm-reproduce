using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models.Filters;

[MetadataType(typeof(EnumMetadata))]
[Uid("db6d55c0-31b4-4594-97f9-4adb599bc8d9")]
[DisplayName(typeof(__Resources_FilterType), "DisplayName")]
public enum FilterType
{
	[Uid("aef5c2b1-1bc2-49e8-a186-657a48e1f88e")]
	[DisplayName(typeof(__Resources_FilterType), "P_SharedFilter_DisplayName")]
	SharedFilter,
	[Uid("a77d613b-447f-4015-9f1a-85fe6a756ea7")]
	[DisplayName(typeof(__Resources_FilterType), "P_MyFilter_DisplayName")]
	MyFilter,
	[Uid("6d45eb62-e5e9-427a-8507-e2142508b75a")]
	[DisplayName(typeof(__Resources_FilterType), "P_SystemFilter_DisplayName")]
	SystemFilter,
	[Uid("62a3aa91-77a1-41b0-9ed9-bfb37457437d")]
	[DisplayName(typeof(__Resources_FilterType), "P_FavoriteFilter_DisplayName")]
	FavoriteFilter
}
