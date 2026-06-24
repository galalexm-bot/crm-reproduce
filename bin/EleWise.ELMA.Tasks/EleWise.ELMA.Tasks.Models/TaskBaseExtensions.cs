using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Models;

public static class TaskBaseExtensions
{
	private static IAuthenticationService _authenticationService;

	private static TaskWorkflowActions _taskWorkflowActions;

	private static Func<TaskBaseStatus[]> getActiveTaskStatusesCached = MetadataLoader.UseCachingForFunc(() => GetActiveTaskStatuses());

	private static IAuthenticationService AuthenticationService => _authenticationService ?? (_authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	private static TaskWorkflowActions TaskWorkflowActions => _taskWorkflowActions ?? (_taskWorkflowActions = Locator.GetServiceNotNull<TaskWorkflowActions>());

	public static TaskBaseStatus[] ActiveTaskStatuses => getActiveTaskStatusesCached();

	[Obsolete("Устаревший, используйте CloseStatuses", true)]
	public static TaskBaseStatus[] CompleteStatuses => new TaskBaseStatus[5]
	{
		TaskBaseStatus.Complete,
		TaskBaseStatus.Incomplete,
		TaskBaseStatus.WasClosed,
		TaskBaseStatus.CompleteControlled,
		TaskBaseStatus.IncompleteControlled
	};

	public static TaskBaseStatus[] CloseStatuses => new TaskBaseStatus[8]
	{
		TaskBaseStatus.WasClosed,
		TaskBaseStatus.Complete,
		TaskBaseStatus.Incomplete,
		TaskBaseStatus.CompleteNeedControl,
		TaskBaseStatus.IncompleteNeedControl,
		TaskBaseStatus.CompleteControlled,
		TaskBaseStatus.IncompleteControlled,
		TaskBaseStatus.RefuseApproval
	};

	public static TaskBaseStatus[] CurrentControlStatuses => new TaskBaseStatus[4]
	{
		TaskBaseStatus.NewOrder,
		TaskBaseStatus.InProgress,
		TaskBaseStatus.Read,
		TaskBaseStatus.RefuseApproval
	};

	public static TaskBaseStatus[] ControlStatuses => new TaskBaseStatus[3]
	{
		TaskBaseStatus.CompleteNeedControl,
		TaskBaseStatus.IncompleteNeedControl,
		TaskBaseStatus.RefuseApproval
	};

	public static TaskBaseStatus[] ControlAllStatuses => new TaskBaseStatus[5]
	{
		TaskBaseStatus.CompleteNeedControl,
		TaskBaseStatus.IncompleteNeedControl,
		TaskBaseStatus.RefuseApproval,
		TaskBaseStatus.CompleteControlled,
		TaskBaseStatus.IncompleteControlled
	};

	private static TaskBaseStatus[] GetActiveTaskStatuses()
	{
		return ((EnumMetadata)MetadataLoader.LoadMetadata(typeof(TaskBaseStatus))).Values.Select((EnumValueMetadata v) => v.EnumValue).Cast<TaskBaseStatus>().Except(CloseStatuses)
			.ToArray();
	}

	public static bool IsActive(this ITaskBase task)
	{
		Contract.ArgumentNotNull(task, "task");
		return !CloseStatuses.Contains(task.Status);
	}

	public static bool CanExecute(this ITaskBase task)
	{
		Contract.ArgumentNotNull(task, "task");
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		return TaskWorkflowActions.IsAvailableCompleted(task, currentUser);
	}

	public static bool IsComplete(this ITaskBase task)
	{
		Contract.ArgumentNotNull(task, "task");
		return CloseStatuses.Contains(task.Status);
	}
}
