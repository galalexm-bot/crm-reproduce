using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics;

public enum ClearStatisticsPeriod
{
	[DisplayName(typeof(__ClearStatisticsPeriodLocalization), "Never")]
	Never,
	[DisplayName(typeof(__ClearStatisticsPeriodLocalization), "AfterFirstReportAtDay")]
	AfterFirstReportAtDay,
	[DisplayName(typeof(__ClearStatisticsPeriodLocalization), "AfterEveryReport")]
	AfterEveryReport
}
