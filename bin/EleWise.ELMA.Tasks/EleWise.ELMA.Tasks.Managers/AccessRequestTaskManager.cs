using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class AccessRequestTaskManager : TaskBaseManager<IAccessRequestTask>
{
	private static AccessRequestTaskManager accessRequestTaskManager;

	private IEnumerable<IEntityPermissionAccessRequestProvider> accessRequestProviders;

	private IPermissionManagmentService permissionManagmentService;

	[NotNull]
	public new static AccessRequestTaskManager Instance => accessRequestTaskManager ?? (accessRequestTaskManager = Locator.GetServiceNotNull<AccessRequestTaskManager>());

	private IEnumerable<IEntityPermissionAccessRequestProvider> AccessRequestProviders => accessRequestProviders ?? (accessRequestProviders = Locator.GetServiceNotNull<IEnumerable<IEntityPermissionAccessRequestProvider>>());

	private IPermissionManagmentService PermissionManagmentService => permissionManagmentService ?? (permissionManagmentService = Locator.GetServiceNotNull<IPermissionManagmentService>());

	public IEnumerable<Permission> GetAccessRequestPermissions(IAccessRequestTask task)
	{
		Contract.ArgumentNotNull(task, "task");
		return GetAccessRequestPermissions(task.AccessRequestPermissionGuids);
	}

	internal IEnumerable<Permission> GetAccessRequestPermissions(IEnumerable<Guid> permissionUids)
	{
		if (permissionUids == null || !permissionUids.Any())
		{
			return Enumerable.Empty<Permission>();
		}
		return from p in PermissionManagmentService.GetPermissions()
			where permissionUids.Contains(p.Id)
			select p;
	}

	internal IEntityPermissionAccessRequestProvider GetEntityPermissionAccessRequestProvider(IAccessRequestTask task)
	{
		ReferenceOnEntity entityReference = task.EntityReference;
		if (entityReference == null)
		{
			return null;
		}
		return GetEntityPermissionAccessRequestProvider(entityReference.ObjectTypeUId);
	}

	internal IEntityPermissionAccessRequestProvider GetEntityPermissionAccessRequestProvider(Guid entityTypeUid)
	{
		return AccessRequestProviders.FirstOrDefault((IEntityPermissionAccessRequestProvider p) => p.CanUse(entityTypeUid));
	}

	internal bool IsAvailableClose(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		if (task.IsNew())
		{
			return false;
		}
		if (TaskBaseExtensions.CloseStatuses.Contains(task.Status))
		{
			return false;
		}
		if (task.CreationAuthor != user && !base.UserManager.IsSubordinateUser(user, task.CreationAuthor))
		{
			return TaskBaseManager<IAccessRequestTask>.AccessToAllTasks(user);
		}
		return true;
	}

	internal bool IsAvailableComplete(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableCompleted(task, user);
	}

	internal bool IsAvailableInComplete(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableInCompleted(task, user);
	}

	internal bool IsAvailableStartWork(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableStartWork(task, user);
	}

	internal bool IsAvailableReAssign(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableReAssign(task, user);
	}

	internal bool IsAvailableEdit(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableEdit(task, user);
	}

	internal bool IsAvailableCreateSubtask(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableCreateSubtask(task, user);
	}

	internal bool IsAvailableDateChange(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		return base.TaskWorkflowActions.IsAvailableDateChange(task, user);
	}

	internal bool HasGrantAccessPermission(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		Contract.ArgumentNotNull(task, "task");
		Contract.ArgumentNotNull(user, "user");
		IEntityPermissionAccessRequestProvider entityPermissionAccessRequestProvider = GetEntityPermissionAccessRequestProvider(task);
		if (entityPermissionAccessRequestProvider == null)
		{
			return false;
		}
		ReferenceOnEntity entityReference = task.EntityReference;
		if (entityReference == null)
		{
			return false;
		}
		long userId = user.Id;
		return entityPermissionAccessRequestProvider.GetAdmins(entityReference.ObjectTypeUId, entityReference.ObjectId).Any((EleWise.ELMA.Security.Models.IUser a) => userId.Equals(a.Id));
	}

	[Transaction]
	[ActionMethod("fd199150-2243-4b23-b13b-a33cf3137c51")]
	public virtual IAccessRequestTask Close(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask != null && CanClose(taskId, actionModel, alert))
		{
			ApplyCommentActionModel(accessRequestTask, actionModel);
			accessRequestTask.Status = TaskBaseStatus.WasClosed;
			Save(accessRequestTask);
			RaiseCommentActionEvent(null, accessRequestTask, "fd199150-2243-4b23-b13b-a33cf3137c51", actionModel, alert);
		}
		return accessRequestTask;
	}

	[ActionCheck("fd199150-2243-4b23-b13b-a33cf3137c51")]
	public virtual bool CanClose(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		if (ContextVars.TryGetValue<bool>("DisableActionCheck", out var value) && value)
		{
			return true;
		}
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask != null)
		{
			return IsAvailableClose(accessRequestTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Transaction]
	[ActionMethod("15dd5df9-407f-47c5-91d6-67ee2f038e18")]
	public virtual IAccessRequestTask ApproveAccessRequest(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask != null && CanApprove(taskId, actionModel, alert))
		{
			(GetEntityPermissionAccessRequestProvider(accessRequestTask) ?? throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"))).GrantAccess(accessRequestTask.EntityReference.Object, accessRequestTask.AccessRequestPermissions, accessRequestTask.CreationAuthor);
			ApplyCommentActionModel(accessRequestTask, actionModel);
			accessRequestTask.AccessRequestApproved = true;
			Complete(accessRequestTask);
			RaiseCommentActionEvent(null, accessRequestTask, "15dd5df9-407f-47c5-91d6-67ee2f038e18", actionModel, alert);
		}
		return accessRequestTask;
	}

	[ActionCheck("15dd5df9-407f-47c5-91d6-67ee2f038e18")]
	public virtual bool CanApprove(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask task = LoadOrNull(taskId);
		return CanComplete(task);
	}

	[Transaction]
	[ActionMethod("efef3b7c-b5d2-4739-8524-5fc5e192d5c3")]
	public virtual IAccessRequestTask RefuseAccessRequest(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask != null && CanRefuse(taskId, actionModel, alert))
		{
			ApplyCommentActionModel(accessRequestTask, actionModel);
			accessRequestTask.AccessRequestApproved = false;
			Complete(accessRequestTask);
			RaiseCommentActionEvent(null, accessRequestTask, "efef3b7c-b5d2-4739-8524-5fc5e192d5c3", actionModel, alert);
		}
		return accessRequestTask;
	}

	[ActionCheck("efef3b7c-b5d2-4739-8524-5fc5e192d5c3")]
	public virtual bool CanRefuse(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask task = LoadOrNull(taskId);
		return CanComplete(task);
	}

	private IAccessRequestTask Complete(IAccessRequestTask task)
	{
		if (task != null)
		{
			task.Status = TaskBaseStatus.Complete;
			Save(task);
		}
		return task;
	}

	private bool CanComplete(IAccessRequestTask task)
	{
		if (task == null)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		CheckComplete(task, currentUser);
		if (!HasGrantAccessPermission(task, currentUser))
		{
			throw new ElmaInvalidOperationException(SR.T("Вы не можете выдать запрашиваемые права доступа", task.EndWorkDate, task.Subject));
		}
		return base.TaskWorkflowActions.IsAvailableCompleted(task, currentUser);
	}

	[Transaction]
	[ActionMethod("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual IAccessRequestTask Incomplete(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask != null && CanIncomplete(taskId, actionModel, alert))
		{
			ApplyCommentActionModel(accessRequestTask, actionModel);
			accessRequestTask.Status = TaskBaseStatus.Incomplete;
			Save(accessRequestTask);
			RaiseCommentActionEvent(null, accessRequestTask, "9a8806b0-8e5a-4f46-868f-9a1604d4ebce", actionModel, alert);
		}
		return accessRequestTask;
	}

	[ActionCheck("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual bool CanIncomplete(long taskId, ICommentActionModel actionModel = null, bool alert = false)
	{
		IAccessRequestTask accessRequestTask = LoadOrNull(taskId);
		if (accessRequestTask == null)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		CheckComplete(accessRequestTask, currentUser);
		return base.TaskWorkflowActions.IsAvailableInCompleted(accessRequestTask, currentUser);
	}

	private void CheckComplete(IAccessRequestTask task, EleWise.ELMA.Security.Models.IUser user)
	{
		string text = "";
		if (!task.EndWorkDate.HasValue && !TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true))
		{
			text = SR.T("Задача \"{1}\" назначена на: {0}", task.Executor.GetShortName(), task.Subject);
		}
		else if (task.EndWorkDate.HasValue && task.IsComplete())
		{
			text = SR.T("Задача \"{1}\" завершена {0:dd MMMM yyyy} в {0:HH:mm}", task.EndWorkDate, task.Subject);
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new ElmaInvalidOperationException(text);
		}
	}
}
