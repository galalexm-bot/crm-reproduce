using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.BPM.Web.Security.Components.FilterProviders;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

public class AccessRequestTaskController : BPMController<IAccessRequestTask, long>
{
	private IEnumerable<IEntityPermissionAccessRequestRenderer> accessRequestRenderers;

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public ICommentActionHandler CommentActionHandler { get; set; }

	public IEntityActionHandler EntityActionHandler { get; set; }

	public ICheckAnyAttachmentService CheckAnyAttachmentService { get; set; }

	public AccessRequestTaskManager AccessRequestTaskManager { get; set; }

	private IEnumerable<IEntityPermissionAccessRequestRenderer> AccessRequestRenderers => accessRequestRenderers ?? (accessRequestRenderers = Locator.GetServiceNotNull<IEnumerable<IEntityPermissionAccessRequestRenderer>>());

	[EntityLink]
	public ActionResult Execute(IAccessRequestTask task)
	{
		base.ViewTitle = SR.T(task.Subject);
		IUser currentUser = GetCurrentUser();
		ReferenceOnEntity entityReference = task.EntityReference;
		IEntityPermissionAccessRequestProvider provider = AccessRequestTaskManager.GetEntityPermissionAccessRequestProvider(task);
		IEntityPermissionAccessRequestRenderer entityPermissionAccessRequestRenderer = AccessRequestRenderers.FirstOrDefault((IEntityPermissionAccessRequestRenderer r) => r.CanRender(provider));
		AccessRequestTaskViewModel accessRequestTaskViewModel = new AccessRequestTaskViewModel
		{
			Entity = task,
			IsAvailableEdit = AccessRequestTaskManager.IsAvailableEdit(task, currentUser),
			IsAvailableCreateSubtask = AccessRequestTaskManager.IsAvailableCreateSubtask(task, currentUser),
			IsAvailableStartWork = AccessRequestTaskManager.IsAvailableStartWork(task, currentUser),
			IsAvailableCompleted = AccessRequestTaskManager.IsAvailableComplete(task, currentUser),
			IsAvailableInCompleted = AccessRequestTaskManager.IsAvailableInComplete(task, currentUser),
			IsAvailableReAssign = AccessRequestTaskManager.IsAvailableReAssign(task, currentUser),
			IsAvailableClose = AccessRequestTaskManager.IsAvailableClose(task, currentUser),
			IsAvailableDateChange = AccessRequestTaskManager.IsAvailableDateChange(task, currentUser),
			HasGrantAccessPermission = AccessRequestTaskManager.HasGrantAccessPermission(task, currentUser),
			ExecutorFilterProvider = PermissionAdminsFilterProvider.UID,
			ExecutorFilterData = $"{entityReference.ObjectTypeUId};{entityReference.ObjectId}",
			Permissions = JsonConvert.SerializeObject((object)task.AccessRequestPermissionGuids),
			AnyFile = CheckAnyAttachmentService.CheckAnyFile(task.TypeUid, task),
			AnyAttachment = CheckAnyAttachmentService.CheckAnyAttachments(task.TypeUid, task),
			AnyAttachmentSpecified = CheckAnyAttachmentService.CheckAnyAttachmentsSpecified(task.TypeUid, task),
			EntityPermissionAccessRequestRenderer = entityPermissionAccessRequestRenderer
		};
		SetAsReadForFeed(task);
		return (ActionResult)(object)((Controller)this).View((object)accessRequestTaskViewModel);
	}

	public ActionResult Create(Guid typeUid, long entityId)
	{
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(typeUid);
		if (typeByUidOrNull == null)
		{
			throw new TypeNotFoundException(typeUid);
		}
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUidOrNull);
		if (manager == null)
		{
			throw new ServiceNotFoundException(SR.T("Менеджер сущности \"{0}\"", typeByUidOrNull.FullName));
		}
		IEntity entity = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			entity = manager.LoadOrNull(entityId) as IEntity;
		});
		if (entity == null)
		{
			throw new ObjectNotFoundException((MetadataLoader.LoadMetadata(typeByUidOrNull, inherit: false, loadImplementation: false) is EntityMetadata entityMetadata) ? entityMetadata.DisplayName : typeByUidOrNull.FullName, entityId);
		}
		IEntityPermissionAccessRequestProvider entityPermissionAccessRequestProvider = AccessRequestTaskManager.GetEntityPermissionAccessRequestProvider(typeUid);
		if (entityPermissionAccessRequestProvider == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"));
		}
		IEntityPermissionAccessRequestRenderer entityPermissionAccessRequestRenderer = AccessRequestRenderers.FirstOrDefault((IEntityPermissionAccessRequestRenderer r) => r.CanRender(entityPermissionAccessRequestProvider));
		AccessRequestTaskModel accessRequestTaskModel = new AccessRequestTaskModel
		{
			TypeUid = typeUid,
			EntityId = entityId,
			HasPastPermission = base.SecurityService.HasPermission(GetCurrentUser(), PermissionProvider.CreatePastTaskPermission),
			Header = entityPermissionAccessRequestProvider.GetCreatingTaskHeader(entity),
			Subject = entityPermissionAccessRequestProvider.GetTaskSubject(entity),
			CanEditPermissions = true,
			ExecutorFilterProvider = PermissionAdminsFilterProvider.UID,
			ExecutorFilterData = $"{typeUid};{entityId}",
			EntityPermissionAccessRequestRenderer = entityPermissionAccessRequestRenderer
		};
		return (ActionResult)(object)((Controller)this).View((object)accessRequestTaskModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Create(AccessRequestTaskModel model)
	{
		IAccessRequestTask accessRequestTask = InitializeTask(model);
		accessRequestTask.Save();
		TaskBaseController.NotifyTaskAction(this, accessRequestTask, SR.T("Создана новая задача"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	public ActionResult Edit(IAccessRequestTask task)
	{
		IUser currentUser = GetCurrentUser();
		if (!AccessRequestTaskManager.IsAvailableEdit(task, currentUser))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)new
			{
				id = task.Id
			});
		}
		ReferenceOnEntity entityReference = task.EntityReference;
		Guid objectTypeUId = entityReference.ObjectTypeUId;
		long objectId = entityReference.ObjectId;
		IEntityPermissionAccessRequestProvider entityPermissionAccessRequestProvider = AccessRequestTaskManager.GetEntityPermissionAccessRequestProvider(task);
		if (entityPermissionAccessRequestProvider == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"));
		}
		IEntityPermissionAccessRequestRenderer entityPermissionAccessRequestRenderer = AccessRequestRenderers.FirstOrDefault((IEntityPermissionAccessRequestRenderer r) => r.CanRender(entityPermissionAccessRequestProvider));
		AccessRequestTaskModel accessRequestTaskModel = new AccessRequestTaskModel(task)
		{
			CanEditPermissions = task.CreationAuthor.Equals(currentUser),
			HasPastPermission = base.SecurityService.HasPermission(currentUser, PermissionProvider.CreatePastTaskPermission),
			ExecutorFilterProvider = PermissionAdminsFilterProvider.UID,
			ExecutorFilterData = $"{objectTypeUId};{objectId}",
			EntityPermissionAccessRequestRenderer = entityPermissionAccessRequestRenderer
		};
		return (ActionResult)(object)((Controller)this).View((object)accessRequestTaskModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Save(AccessRequestTaskModel model)
	{
		if (AccessRequestTaskManager.IsAvailableEdit(model.Entity, GetCurrentUser()))
		{
			IAccessRequestTask accessRequestTask = InitializeTask(model);
			accessRequestTask.Status = TaskBaseStatus.NewOrder;
			AccessRequestTaskManager.Save(accessRequestTask);
			EntityActionEventArgs e = new EntityActionEventArgs(null, accessRequestTask, "ef34b63c-a9f6-4136-8e80-505a8e728baa");
			CommentActionHandler.ProcessEventArgs(e, model.CommentActionModel);
			EntityActionHandler.ActionExecuted(e);
		}
		else if (base.UnitOfWorkManager != null)
		{
			base.UnitOfWorkManager.RollbackCurrent(string.Empty);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)new
		{
			id = model.Entity.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Close([Bind(Prefix = "Close")] TaskCommentModel commentModel)
	{
		Contract.ArgumentNotNull(commentModel, "commentModel");
		IAccessRequestTask task = AccessRequestTaskManager.InvokeAction((AccessRequestTaskManager m) => m.Close(commentModel.ObjectId, commentModel.ActionModel), commentModel.Object.GetType());
		NotifyTaskAction(task, SR.T("Задача {0} закрыта"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult InComplete([NotNull][Bind(Prefix = "InComplete")] TaskCommentModel commentModel)
	{
		Contract.ArgumentNotNull(commentModel, "commentModel");
		IAccessRequestTask task = AccessRequestTaskManager.InvokeAction((AccessRequestTaskManager m) => m.Incomplete(commentModel.ObjectId, commentModel.ActionModel), commentModel.Object.GetType());
		NotifyTaskAction(task, SR.T("Задачу {0} невозможно выполнить"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult StartWork([NotNull][Bind(Prefix = "StartWork")] TaskCommentModel commentModel)
	{
		Contract.ArgumentNotNull(commentModel, "commentModel");
		IAccessRequestTask accessRequestTask = AccessRequestTaskManager.InvokeAction((AccessRequestTaskManager m) => m.StartWork(commentModel.ObjectId, alertCoexecuters: false, commentModel.ActionModel), commentModel.Object.GetType());
		NotifyTaskAction(accessRequestTask, SR.T("Начата работа над задачей {0}"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)new
		{
			id = accessRequestTask.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SavePermissions(long taskId, string permissions)
	{
		try
		{
			IAccessRequestTask obj = AccessRequestTaskManager.LoadOrNull(taskId) ?? throw new ObjectNotFoundException(InterfaceActivator.TypeOf<IAccessRequestTask>().FullName, taskId);
			obj.AccessRequestPermissionGuids = JsonConvert.DeserializeObject<List<Guid>>(permissions);
			obj.Save();
			return SuccessJson();
		}
		catch (Exception ex)
		{
			return ErrorJson(ex.Message);
		}
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Approve(CommentWithAttachments model)
	{
		Contract.ArgumentNotNull(model, "model");
		IAccessRequestTask accessRequestTask = Complete(model, confirm: true);
		NotifyTaskAction(accessRequestTask, SR.T("Задача {0} выполнена. Запрашиваемый доступ предоставлен"));
		if (!model.RedirectUrl.IsNullOrWhiteSpace())
		{
			((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)new
		{
			id = accessRequestTask.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Refuse(CommentWithAttachments model)
	{
		Contract.ArgumentNotNull(model, "model");
		IAccessRequestTask accessRequestTask = Complete(model, confirm: false);
		NotifyTaskAction(accessRequestTask, SR.T("Задача {0} выполнена. В предоставлении доступа отказано"));
		if (!model.RedirectUrl.IsNullOrWhiteSpace())
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)new
		{
			id = accessRequestTask.Id
		});
	}

	private IAccessRequestTask InitializeTask(AccessRequestTaskModel model)
	{
		Contract.ArgumentNotNull(model, "model");
		Contract.ArgumentNotNull(model.Entity, "model.Entity");
		IAccessRequestTask entity = model.Entity;
		entity.Subject = model.Subject;
		entity.AccessRequestPermissionGuids = JsonConvert.DeserializeObject<List<Guid>>(model.Permissions);
		if (entity.IsNew())
		{
			entity.CreationAuthor = GetCurrentUser();
			entity.CreationDate = DateTime.Now;
		}
		entity.StartDate = model.StartDate.NormalizeStartDate(model.StartDate.IsStartDamperTimeBySeconds());
		entity.EndDate = model.EndDate.NormalizeEndDate(model.EndDate.IsEndDamperTimeBySeconds());
		entity.EntityReference = new ReferenceOnEntity(model.EntityId, model.TypeUid);
		CommentActionHandler.Process(entity, model.CommentActionModel);
		return entity;
	}

	private void NotifyTaskAction(ITaskBase task, string actionThemeFormat)
	{
		TaskBaseController.NotifyTaskAction(this, task, actionThemeFormat);
	}

	private IAccessRequestTask Complete(CommentWithAttachments commentModel, bool confirm)
	{
		Contract.ArgumentNotNull(commentModel, "commentModel");
		if (!confirm)
		{
			return AccessRequestTaskManager.InvokeAction((AccessRequestTaskManager m) => m.RefuseAccessRequest(commentModel.ObjectId, commentModel.ActionModel), commentModel.Object.GetType());
		}
		return AccessRequestTaskManager.InvokeAction((AccessRequestTaskManager m) => m.ApproveAccessRequest(commentModel.ObjectId, commentModel.ActionModel), commentModel.Object.GetType());
	}
}
