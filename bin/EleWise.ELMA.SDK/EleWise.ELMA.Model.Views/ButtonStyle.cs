using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views;

[Description("SR.M('Возможные цвета кнопок переходов ')")]
[DefaultValueUid("1ab66bd0-81c1-4025-a7d1-926e73bacabf")]
[Uid("dd959698-9048-457e-9f20-08772dbb154f")]
[DisplayName("SR.M('ButtonStyle')")]
[MetadataType(typeof(EnumMetadata))]
public enum ButtonStyle
{
	[Description("SR.M('Цвет по умолчанию')")]
	[Uid("1ab66bd0-81c1-4025-a7d1-926e73bacabf")]
	[DisplayName("SR.M('Default')")]
	Default,
	[Description("SR.M('Синий')")]
	[DisplayName("SR.M('Blue')")]
	[Uid("40e99bfc-de47-4b22-9f1c-0cb8d1f4ff78")]
	Blue,
	[DisplayName("SR.M('Green')")]
	[Uid("1fb69293-9026-4a40-8101-f9eb7392af18")]
	Green,
	[DisplayName("SR.M('Yellow')")]
	[Uid("8f309546-9101-4d89-b6bb-67178081e1ba")]
	Yellow,
	[DisplayName("SR.M('Red')")]
	[Uid("7d30b957-1e03-4d6c-9618-2b65092665a4")]
	Red,
	[DisplayName("SR.M('metroGray')")]
	[Uid("2f06869e-4d3d-4e44-80b3-6a5b71f0809b")]
	MetroGray,
	[DisplayName("SR.M('Simple')")]
	[Uid("bb14e0ea-1090-4dfa-bbbd-1d7dc7bb8843")]
	Simple,
	[DisplayName("SR.M('Главный')")]
	[Uid("8c96b261-e207-415c-95ef-7e1b725262ee")]
	Main
}
