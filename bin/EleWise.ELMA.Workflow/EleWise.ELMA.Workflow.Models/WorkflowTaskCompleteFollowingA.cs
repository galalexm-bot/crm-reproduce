using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.Models;

public enum WorkflowTaskCompleteFollowingAction
{
	[DisplayName(typeof(TaskCompleteFollowingAction_SR), "DoNothing_SR")]
	DoNothing,
	[DisplayName(typeof(TaskCompleteFollowingAction_SR), "RedirectToProcess_SR")]
	RedirectToProcess,
	[DisplayName(typeof(TaskCompleteFollowingAction_SR), "RedirectToTaskList_SR")]
	RedirectToTaskList,
	[DisplayName(typeof(TaskCompleteFollowingAction_SR), "RedirectToHome_SR")]
	RedirectToHome
}
