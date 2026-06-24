using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("c5dac72c-a629-49bf-a0ad-4175b4169afc")]
[DisplayName("SR.M('Корректировка Сроков')")]
[DefaultValueUid("ee70173a-f01d-4c2f-82d8-f7c7e0ec8731")]
public enum TaskDateCorrection
{
	[Uid("ee70173a-f01d-4c2f-82d8-f7c7e0ec8731")]
	[DisplayName("SR.M('Без смещения')")]
	None,
	[Uid("730e1b55-2d7e-424d-aa26-8f7ca36bbf63")]
	[DisplayName("SR.M('Первый рабочий день')")]
	FirstAvailable,
	[Uid("7e9fd0f8-f7e0-4abd-ba76-40be545ff79b")]
	[DisplayName("SR.M('Сохранять длительность')")]
	KeepDuration
}
