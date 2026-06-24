using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[Uid("d0ae05a6-7176-46cc-86df-fcdccedda458")]
[MetadataType(typeof(EnumMetadata))]
[ShowInDesigner(false)]
[ShowInTypeTree(false)]
[DisplayName("SR.M('Вид отображения значения типа \"Структура обмена данными\"')")]
[DefaultValueUid("8c69f6ef-9ea7-4ae7-be24-ec4bcde7ae8f")]
public enum DataClassDisplayType
{
	[Uid("8c69f6ef-9ea7-4ae7-be24-ec4bcde7ae8f")]
	[DisplayName("SR.M('Стандартный')")]
	Standard,
	[DisplayName("SR.M('Табличный')")]
	[Uid("e5dc514f-d980-4dd0-9bef-ed7f88934044")]
	Table
}
