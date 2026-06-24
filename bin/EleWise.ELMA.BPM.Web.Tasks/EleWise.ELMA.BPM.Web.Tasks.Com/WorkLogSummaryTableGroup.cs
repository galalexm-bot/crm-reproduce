using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public enum WorkLogSummaryTableGroup
{
	[DisplayName(typeof(WorkLogSummaryTableGroup_SR), "P_Group_Activity")]
	Activity,
	[DisplayName(typeof(WorkLogSummaryTableGroup_SR), "P_Group_User")]
	User
}
