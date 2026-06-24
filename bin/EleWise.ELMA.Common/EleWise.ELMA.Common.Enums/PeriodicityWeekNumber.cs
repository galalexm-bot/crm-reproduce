using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.Enums;

public enum PeriodicityWeekNumber
{
	[DisplayName("SR.M('Первый')")]
	First,
	[DisplayName("SR.M('Второй')")]
	Second,
	[DisplayName("SR.M('Третий')")]
	Third,
	[DisplayName("SR.M('Четвёртый')")]
	Fourth,
	[DisplayName("SR.M('Последний')")]
	Last
}
