using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("b7cb3369-f04c-418e-a311-1baedc11fcb6")]
[DisplayName("SR.M('Периодичность')")]
[Description("SR.M('Периодичность повторения')")]
[DefaultValueUid("e1e582da-461d-4bec-807b-9c10f93ffeab")]
public enum Periodicity
{
	[Uid("e1e582da-461d-4bec-807b-9c10f93ffeab")]
	[DisplayName("SR.M('По рабочим дням (с учетом рабочего календаря)')")]
	WorkingDays = 1,
	[Uid("b85ade11-0a23-47ea-adbb-a50422367d9c")]
	[DisplayName("SR.M('По дням')")]
	Daily,
	[Uid("a10a45f3-9f06-466e-8d4c-ef285534fde7")]
	[DisplayName("SR.M('По неделям')")]
	Weekly,
	[Uid("160f18d0-4cb2-4cff-8257-2d4ef946c45f")]
	[DisplayName("SR.M('По месяцам')")]
	Monthly,
	[Uid("9c4ba74b-1759-41ca-a148-7a015f7c6276")]
	[DisplayName("SR.M('По кварталам')")]
	Quarterly,
	[Uid("72258c79-4f14-4d12-b9d1-76606edf9863")]
	[DisplayName("SR.M('По годам')")]
	Yearly
}
