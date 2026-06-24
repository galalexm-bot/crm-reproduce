using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

[Service]
public class TaskWorkflowActions
{
	private IEnumerable<ICanScheduleTask> _canScheduleTasks;

	private const string IsAvailableCompletedCacheKey = "TaskWorkflowActions_IsAvailableCompleted";

	[NotNull]
	public TaskBaseManager TaskBaseManager => Locator.GetServiceNotNull<TaskBaseManager>();

	public IEnumerable<ICanScheduleTask> CanScheduleTasks => _canScheduleTasks ?? (_canScheduleTasks = ComponentManager.Current.GetExtensionPoints<ICanScheduleTask>());

	public bool IsAvailableControlledAction(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			if (task.Status == TaskBaseStatus.WasClosed)
			{
				if (task.CreationAuthor != user)
				{
					return UserManager.Instance.IsSubordinateUser(user, task.CreationAuthor);
				}
				return true;
			}
			return false;
		}
		if (task.Status != TaskBaseStatus.CompleteNeedControl && task.Status != TaskBaseStatus.IncompleteNeedControl && task.Status != TaskBaseStatus.RefuseApproval)
		{
			return false;
		}
		if (task is ITask && !TaskManager.IsUserControlsTask(user, (ITask)task))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableEdit(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task.Status != TaskBaseStatus.NewOrder && task.Status != TaskBaseStatus.Read && task.Status != TaskBaseStatus.InProgress && task.Status != TaskBaseStatus.OnApprovalExecutor && task.Status != TaskBaseStatus.RefuseApprovalExecutor)
		{
			return false;
		}
		if (task.CreationAuthor != user && !UserManager.Instance.IsSubordinateUser(user, task.CreationAuthor) && !TaskBaseManager<ITaskBase>.AccessToAllTasks(user))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableApproval(ITaskBase task, IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (!(task is IApprovalTask approvalTask) || approvalTask.ParentTask == null)
		{
			return false;
		}
		if (approvalTask.ApprovalStatus != 0)
		{
			return false;
		}
		if (!TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableCreateSubtask(ITaskBase task, IUser user)
	{
		if (task == null || HasOnlyWatchPermission(task, user))
		{
			return false;
		}
		return !TaskBaseExtensions.CloseStatuses.Contains(task.Status);
	}

	public bool IsAvailableCreateApproval(ITaskBase task, IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (!(task is ITask))
		{
			return false;
		}
		if (((ITask)task).IsTemplate)
		{
			return false;
		}
		if (!(task.Status == TaskBaseStatus.NewOrder) && !(task.Status == TaskBaseStatus.Read) && !(task.Status == TaskBaseStatus.InProgress) && !(task.Status == TaskBaseStatus.RefuseApprovalExecutor))
		{
			return false;
		}
		if (!TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true) && task.CreationAuthor != null && task.CreationAuthor.Id != user.Id)
		{
			return false;
		}
		if (((IEnumerable<ITaskBase>)task.ChildTasks).Any((ITaskBase t) => t is IApprovalTask && ((IApprovalTask)t).ApprovalStatus == ApprovalStatus.None))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableCompleted(ITaskBase task, IUser user)
	{
		if (task != null)
		{
			try
			{
				return TaskBaseManager.GetImplManager(task.TypeUid).CanComplete(task, user);
			}
			catch (Exception message)
			{
				Logger.Log.Warn(message);
			}
		}
		return false;
	}

	public bool IsAvailableInCompleted(ITaskBase task, IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (SR.GetSetting("Task.CanCompleteApprovalExecutorTasks", defaultValue: false))
		{
			if (!(task.Status == TaskBaseStatus.NewOrder) && !(task.Status == TaskBaseStatus.Read) && !(task.Status == TaskBaseStatus.InProgress) && !(task.Status == TaskBaseStatus.OnApprovalExecutor) && !(task.Status == TaskBaseStatus.RefuseApprovalExecutor))
			{
				return false;
			}
		}
		else if (!(task.Status == TaskBaseStatus.NewOrder) && !(task.Status == TaskBaseStatus.Read) && !(task.Status == TaskBaseStatus.InProgress) && !(task.Status == TaskBaseStatus.RefuseApprovalExecutor))
		{
			return false;
		}
		if (!TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableStartWork(ITaskBase task, IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (SR.GetSetting("Task.CanCompleteApprovalExecutorTasks", defaultValue: false))
		{
			if (task.Status != TaskBaseStatus.NewOrder && task.Status != TaskBaseStatus.Read && task.Status != TaskBaseStatus.OnApprovalExecutor && task.Status != TaskBaseStatus.RefuseApprovalExecutor)
			{
				return false;
			}
		}
		else if (task.Status != TaskBaseStatus.NewOrder && task.Status != TaskBaseStatus.Read && task.Status != TaskBaseStatus.RefuseApprovalExecutor)
		{
			return false;
		}
		if (!TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableReAssign(ITaskBase task, IUser user)
	{
		if (task != null)
		{
			try
			{
				bool? flag = TaskBaseManager.GetImplManager(task.TypeUid).CanStartReAssign(task, user);
				if (flag.HasValue)
				{
					return flag.Value;
				}
			}
			catch (Exception message)
			{
				Logger.Log.Warn(message);
			}
		}
		return false;
	}

	public bool IsAvailableClose(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (TaskBaseExtensions.CloseStatuses.Contains(task.Status))
		{
			return false;
		}
		if (task is ITask && !TaskManager.IsUserControlsTask(user, (ITask)task, checkCreateAuthor: true))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableDateChange(ITaskBase task)
	{
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		return IsAvailableDateChange(task, currentUser);
	}

	public bool IsAvailableDateChange(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (TaskBaseExtensions.CloseStatuses.Contains(task.Status))
		{
			return false;
		}
		if (task is ITask)
		{
			if (!TaskManager.IsUserControlsTask(user, (ITask)task, checkCreateAuthor: true))
			{
				return false;
			}
		}
		else if (task.CreationAuthor != user && !UserManager.Instance.IsSubordinateUser(user, task.CreationAuthor) && !TaskBaseManager<ITaskBase>.AccessToAllTasks(user))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableChangeControl(ITaskBase task, IUser user)
	{
		if (!TaskControlSettingsHelper.AllowChangeControl())
		{
			return false;
		}
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (task.Status == TaskBaseStatus.WasClosed || task.Status == TaskBaseStatus.CompleteControlled || task.Status == TaskBaseStatus.IncompleteControlled)
		{
			return false;
		}
		if (task is ITask && !TaskManager.IsUserControlsTask(user, (ITask)task, checkCreateAuthor: true))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableCopy(ITaskBase task)
	{
		if (task != null)
		{
			try
			{
				bool? flag = TaskBaseManager.GetImplManager(task.TypeUid).IsAvailableCopy(task);
				if (flag.HasValue)
				{
					return flag.Value;
				}
			}
			catch (Exception message)
			{
				Logger.Log.Warn(message);
			}
		}
		return false;
	}

	public bool IsAvailableTakeCurrentControl(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (task.Status == TaskBaseStatus.WasClosed || task.Status == TaskBaseStatus.CompleteControlled || task.Status == TaskBaseStatus.IncompleteControlled)
		{
			return false;
		}
		if (task is ITask && (((ICollection<IUser>)((ITask)task).CurrentControllers).Contains(user) || task.CreationAuthor.Id == user.Id))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableBreakCurrentControl(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (task.Status == TaskBaseStatus.WasClosed || task.Status == TaskBaseStatus.CompleteControlled || task.Status == TaskBaseStatus.IncompleteControlled)
		{
			return false;
		}
		if (task is ITask && (!((ICollection<IUser>)((ITask)task).CurrentControllers).Contains(user) || task.CreationAuthor.Id == user.Id))
		{
			return false;
		}
		return true;
	}

	public bool IsAvailableDeleteWatches(ITaskBase task, IUser user)
	{
		if (task == null || user == null || task.IsNew())
		{
			return false;
		}
		if (((IEnumerable<ITaskBasePermission>)task.Permissions).Any((ITaskBasePermission p) => p.User == user && p.TypeRole != "Watcher"))
		{
			return true;
		}
		IEnumerable<IUser> subordinateUsers = from p in (IEnumerable<ITaskBasePermission>)task.Permissions
			where p.TypeRole != "Watcher" && p.AllowChief && p.User != null
			select p.User;
		if (!UserManager.Instance.IsSubordinateUsers(user, subordinateUsers))
		{
			return TaskBaseManager<ITaskBase>.AccessToAllTasks(user);
		}
		return true;
	}

	public bool IsAvaliableMarkRead(ITaskBase task, IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (task.Status == TaskBaseStatus.NewOrder)
		{
			return task.Executor == user;
		}
		return false;
	}

	public bool IsAvailableSchedule(ITaskBase task, IUser user)
	{
		if (task == null || task.NotShowInLists)
		{
			return false;
		}
		if (user != null && (task.IsActive() || task.Status == TaskBaseStatus.OnApprovalExecutor) && task.Executor != null && user.Id == task.Executor.Id)
		{
			if (CanScheduleTasks != null && CanScheduleTasks.Any())
			{
				return CanScheduleTasks.All((ICanScheduleTask c) => c.CanSchedule(task));
			}
			return true;
		}
		return false;
	}

	public bool IsAvailableWorkLog(ITaskBase task, IUser user)
	{
		if (WorkLogSettingsHelper.WorkLogEnabled())
		{
			return !HasOnlyWatchPermission(task, user);
		}
		return false;
	}

	private bool HasOnlyWatchPermission(ITaskBase task, IUser user)
	{
		bool flag = ((IEnumerable<ITaskBasePermission>)task.Permissions).Any((ITaskBasePermission p) => p.User == user && p.TypeRole != "Watcher");
		if (!flag)
		{
			flag = ((IEnumerable<ITaskBasePermission>)task.Permissions).Any((ITaskBasePermission p) => p.User != null && p.AllowChief && UserManager.Instance.IsSubordinateUser(user, p.User));
		}
		if (WatchManager.Instance.IsWatchExsist(task.TypeUid, task.Id, user))
		{
			return !flag;
		}
		return false;
	}
}
