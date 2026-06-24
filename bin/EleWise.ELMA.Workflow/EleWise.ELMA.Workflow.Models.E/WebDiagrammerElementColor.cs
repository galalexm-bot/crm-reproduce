using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models.Enums;

[DefaultValueUid("ddd69c8d-6b3c-4a84-b006-896e91e0f829")]
[ShowInDesigner(false)]
[Uid("596e78dd-c440-498c-b578-c6af5f4d4c47")]
[MetadataType(typeof(EnumMetadata))]
[ShowInTypeTree(false)]
[DisplayName("SR.M('Цвет элемента веб-диаграммера')")]
public enum WebDiagrammerElementColor
{
	[DisplayName("SR.M('Синий')")]
	[Uid("ddd69c8d-6b3c-4a84-b006-896e91e0f829")]
	Blue,
	[Uid("ebde56d4-64d3-412c-af04-7adab7466f0d")]
	[DisplayName("SR.M('Красный')")]
	Red,
	[Uid("8fceb88e-96f0-416c-97a1-dcb9d6ca4c25")]
	[DisplayName("SR.M('Зеленый')")]
	Green,
	[Uid("9c74ba3a-ef11-4e77-a247-d873b70e1f8a")]
	[DisplayName("SR.M('Желтый')")]
	Yellow,
	[Uid("5766c453-634b-4cfa-a00b-d39d857f64a0")]
	[DisplayName("SR.M('Голубой')")]
	Cyan,
	[DisplayName("SR.M('Фиолетовый')")]
	[Uid("30eb8e42-d3a9-4bca-8d3a-ad40a353ec02")]
	Purple,
	[Uid("b1415f8b-d55e-4d28-a37c-b77d0051fdba")]
	[DisplayName("SR.M('Оранжевый')")]
	Orange,
	[Uid("fe368356-ebc0-4b57-8966-f2b6b4c69cb5")]
	[DisplayName("SR.M('Серый')")]
	Gray,
	[Uid("7d7ea89d-ba75-4534-ac1e-7e1ba1bb706a")]
	[DisplayName("SR.M('Белый')")]
	White,
	[Uid("65fc5fe1-9bcb-4ce5-8278-1163da66e6e4")]
	[DisplayName("SR.M('Коричневый')")]
	Brown
}
