using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public enum WorkLogSummaryTableMode
{
	[DisplayName(typeof(WorkLogSummaryTableMode_SR), "P_Mode_CurrentWeek")]
	CurrentWeek,
	[DisplayName(typeof(WorkLogSummaryTableMode_SR), "P_Mode_LastWeek")]
	LastWeek,
	[DisplayName(typeof(WorkLogSummaryTableMode_SR), "P_Mode_CurrentMonth")]
	CurrentMonth,
	[DisplayName(typeof(WorkLogSummaryTableMode_SR), "P_Mode_LastMonth")]
	LastMonth
}
