using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Tasks;

public enum GroupTasksType
{
	[DisplayName(typeof(WorkLogSettings_SR), "P_GroupTasksType_None")]
	None,
	[DisplayName(typeof(WorkLogSettings_SR), "P_GroupTasksType_Days")]
	Days,
	[DisplayName(typeof(WorkLogSettings_SR), "P_GroupTasksType_Weeks")]
	Weeks
}
