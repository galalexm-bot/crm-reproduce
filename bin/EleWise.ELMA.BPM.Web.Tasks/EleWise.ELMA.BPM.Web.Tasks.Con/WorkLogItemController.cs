using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[WorkLogPermission]
[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
public class WorkLogItemController : BPMController<IWorkLogItem, long>
{
	protected IUser CurrentUser => base.AuthenticationService.GetCurrentUser<IUser>();

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	public WorkLogItemManager WorkLogItemManager { get; set; }

	public WorkLogManager WorkLogManager { get; set; }

	public new IUnitOfWorkManager UnitOfWorkManager { get; set; }

	protected static WorkLogSettings Settings()
	{
		return Locator.GetServiceNotNull<WorkLogSettingsModule>().Settings;
	}

	public static void NotifyTaskAction(BaseController controller, IWorkLogItem workLogItem, string actionThemeFormat)
	{
		if (workLogItem != null && actionThemeFormat != null)
		{
			string text = string.Format("<a href='{1}'>{0}</a>", WorkLogExtensionHelper.GetObjectDisplayName(workLogItem.ObjectId, workLogItem.ObjectUID).HtmlEncode(), ((Controller)controller).get_Url().Entity(workLogItem));
			text = ((!actionThemeFormat.Contains("{0}")) ? (actionThemeFormat.HtmlEncode() + " " + text) : string.Format(actionThemeFormat.HtmlEncode(), text));
			controller.Notifier.Information(MvcHtmlString.Create(text));
		}
	}

	public void NotifyTaskAction(IWorkLogItem workLogItem, string actionThemeFormat)
	{
		NotifyTaskAction(this, workLogItem, actionThemeFormat);
	}

	[EntityLink]
	public ActionResult Index(long id)
	{
		((Controller)(object)this).SetCurrentMenuItem("workLogReport-menu");
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(id);
		object obj = ((ControllerBase)this).get_TempData().get_Item("EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogItem.ReAssign");
		((ControllerBase)this).get_TempData().Remove("EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogItem.ReAssign");
		if (!WorkLogItemManager.CanView(workLogItem))
		{
			if (obj != null)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "WorkLogApproveReport");
			}
			throw new SecurityException(SR.T("Нет прав на просмотр трудозатрат"));
		}
		WorkLogItemViewModel workLogItemViewModel = new WorkLogItemViewModel(workLogItem);
		return (ActionResult)(object)((Controller)this).View("View", (object)workLogItemViewModel);
	}

	public ActionResult WorkLogItemEditPopup(long id, string popupId, string callBackScript, string callBackScriptParam = null)
	{
		WorkLogItemEditModel workLogItemEditModel = CreateWorkLogItemEditModel(id, delegate(WorkLogItemEditModel m)
		{
			m.PopupId = popupId;
			m.CallBackScript = callBackScript;
			m.CallBackScriptParam = callBackScriptParam;
		});
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogItemEditModel);
	}

	public ActionResult WorkLogItemEditor(long id, string popupId)
	{
		WorkLogItemEditModel workLogItemEditModel = CreateWorkLogItemEditModel(id, delegate(WorkLogItemEditModel m)
		{
			m.PopupId = popupId;
		});
		return (ActionResult)(object)((Controller)this).PartialView((object)workLogItemEditModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult WorkLogItemEditPopup(WorkLogItemEditModel model)
	{
		IWorkLogItem entity = model.Entity;
		string text = "";
		string url = "";
		if (entity != null)
		{
			if (!WorkLogItemManager.CanEdit(entity))
			{
				((Controller)this).get_Response().StatusCode = 400;
				throw new SecurityException(SR.T("Нет прав на редактирование трудозатрат"));
			}
			entity.FactWorkTime = model.FactWorkTime;
			entity.WorkLogActivity = model.Activity;
			if (WorkLogSettingsHelper.GetSettings().DisableOvertime)
			{
				List<string> list = WorkLogHelper.WorkLogItemDraftOvertime(entity, includeDraft: false);
				if (list != null && list.Count > 0)
				{
					string text2 = string.Join("\r\n", list.Where((string s) => !string.IsNullOrEmpty(s)));
					if (!string.IsNullOrEmpty(text2))
					{
						UnitOfWorkManager.RevertEntityChangesOnCommit("", entity);
						text = text2;
						url = ((Controller)this).get_Url().Action("WorkLogItemEditor", (object)new
						{
							id = entity.Id,
							popupId = model.PopupId
						});
					}
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				WorkLogItemSave(entity);
				if (model.WorkLogId.HasValue)
				{
					WorkLogManager.SetWorkLogLink(new long[1] { model.WorkLogId.Value }, entity, entity.ObjectId);
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			error = text,
			url = url
		});
	}

	public ActionResult WorkLogObject(long objectId, Guid objectUID)
	{
		return (ActionResult)(object)((Controller)this).PartialView("WorkLogReport/Partial/WorkLogObject", (object)WorkLogExtensionHelper.LoadObject(objectId, objectUID));
	}

	public ActionResult Edit(long id)
	{
		return (ActionResult)(object)((Controller)this).View("Edit", (object)CreateWorkLogItemEditModel(id));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Edit(WorkLogItemEditModel model)
	{
		if (!WorkLogItemManager.CanEdit(model.Entity))
		{
			throw new SecurityException(SR.T("Нет прав на редактирование трудозатрат"));
		}
		IWorkLogItem entity = model.Entity;
		entity.FactWorkTime = model.FactWorkTime;
		entity.WorkLogActivity = model.Activity;
		if (WorkLogSettingsHelper.GetSettings().DisableOvertime)
		{
			List<string> list = WorkLogHelper.WorkLogItemDraftOvertime(entity);
			if (list != null && list.Count > 0)
			{
				string text = string.Join("<br />", list.Where((string s) => !string.IsNullOrEmpty(s)));
				if (!string.IsNullOrEmpty(text))
				{
					base.Notifier.Error(text);
					((Controller)this).get_ModelState().Remove("FactWorkTime");
					UnitOfWorkManager.RevertEntityChangesOnCommit("", entity);
					return (ActionResult)(object)((Controller)this).RedirectToAction("Edit", (object)new
					{
						id = model.Entity.Id
					});
				}
			}
		}
		WorkLogItemSave(entity);
		if (model.WorkLogId.HasValue)
		{
			WorkLogManager.SetWorkLogLink(new long[1] { model.WorkLogId.Value }, entity, entity.ObjectId);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = model.Entity.Id
		});
	}

	private void WorkLogItemSave(IWorkLogItem workLogItem)
	{
		workLogItem.Save();
		if (!workLogItem.IsNew() && workLogItem.IsDirty() && workLogItem.Status != WorkLogItemStatus.Draft)
		{
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, workLogItem, "44fceaea-f9fd-4e28-a834-c247a015242f");
			entityActionEventArgs.ExtendedProperties.Add("ReportNotificationsChangeEnabled", Settings().ReportNotificationsChangeEnabled);
			EntityActionHandler.ActionExecuted(entityActionEventArgs);
			NotifyTaskAction(workLogItem, SR.T("Трудозатраты изменены {0}"));
		}
	}

	[TransactionAction]
	public ActionResult Delete(long id, string returnUrl)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(id);
		if (workLogItem != null && WorkLogItemManager.Instance.CanDelete(workLogItem))
		{
			workLogItem.Delete();
		}
		return (ActionResult)(object)((Controller)this).Redirect((!string.IsNullOrEmpty(returnUrl)) ? returnUrl : ((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[TransactionAction]
	public ActionResult ApprovalConfirm([Bind(Prefix = "WorkLogItemConfirmPopup")] WorkLogItemApprovalConfirmModel commentModel)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(commentModel.ObjectId);
		if (workLogItem != null && commentModel.ApprovalWorkTime.HasValue && WorkLogItemManager.Instance.CanApprove(workLogItem))
		{
			WorkLogItemManager.Instance.ApprovalConfirm(workLogItem, commentModel.ApprovalWorkTime.Value, commentModel.ActionModel);
			WorkLogItemManager.Instance.AddApprovalComment(workLogItem, WorkLogItemStatus.Confirm, commentModel.ActionModel);
			NotifyTaskAction(workLogItem, SR.T("Трудозатраты согласованы {0}"));
		}
		if (!string.IsNullOrEmpty(commentModel.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(commentModel.RedirectUrl);
		}
		if (workLogItem == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "WorkLogApproveReport");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = workLogItem.Id
		});
	}

	[TransactionAction]
	public ActionResult ApprovalUnConfirm([Bind(Prefix = "WorkLogItemUnConfirmPopup")] WorkLogItemApprovalConfirmModel commentModel)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(commentModel.ObjectId);
		if (workLogItem != null && WorkLogItemManager.Instance.CanApprove(workLogItem))
		{
			WorkLogItemManager.Instance.ApprovalUnConfirm(workLogItem);
			WorkLogItemManager.Instance.AddApprovalComment(workLogItem, WorkLogItemStatus.Unconfirm, commentModel.ActionModel);
			NotifyTaskAction(workLogItem, SR.T("Трудозатраты отклонены {0}"));
		}
		if (!string.IsNullOrEmpty(commentModel.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(commentModel.RedirectUrl);
		}
		if (workLogItem == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "WorkLogApproveReport");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = workLogItem.Id
		});
	}

	[TransactionAction]
	public ActionResult ApprovalPartialConfirm([Bind(Prefix = "WorkLogItemConfirmPopup")] WorkLogItemApprovalConfirmModel commentModel)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(commentModel.ObjectId);
		if (workLogItem != null && WorkLogItemManager.Instance.CanApprove(workLogItem))
		{
			if (commentModel.ApprovalWorkTime.Value > 0L)
			{
				Pair<IWorkLogItem, IWorkLogItem> pair = WorkLogItemManager.Instance.Divide(workLogItem, commentModel.ApprovalWorkTime.Value);
				WorkLogItemManager.Instance.ApprovalConfirm(pair.First, commentModel.ApprovalWorkTime.Value);
				WorkLogItemManager.Instance.ApprovalUnConfirm(pair.Second);
				WorkLogItemManager.Instance.AddApprovalComment(new List<IWorkLogItem> { pair.First }, new List<IWorkLogItem> { pair.Second }, WorkLogItemStatus.Confirm, commentModel.ActionModel);
				string text = string.Format("{0} <a href='{2}'>{1}</a>. ", SR.T("Трудозатраты согласованы ").HtmlEncode(), WorkLogExtensionHelper.GetObjectDisplayName(pair.First.ObjectId, pair.First.ObjectUID).HtmlEncode(), ((Controller)this).get_Url().Entity(pair.First));
				text += string.Format("{0} <a href='{2}'>{1}</a>", SR.T("Трудозатраты отклонены ").HtmlEncode(), WorkLogExtensionHelper.GetObjectDisplayName(pair.Second.ObjectId, pair.Second.ObjectUID).HtmlEncode(), ((Controller)this).get_Url().Entity(pair.Second));
				base.Notifier.Information(MvcHtmlString.Create(text));
			}
			else
			{
				WorkLogItemManager.Instance.ApprovalUnConfirm(workLogItem);
				WorkLogItemManager.Instance.AddApprovalComment(workLogItem, WorkLogItemStatus.Unconfirm, commentModel.ActionModel);
				NotifyTaskAction(workLogItem, SR.T("Трудозатраты отклонены {0}"));
			}
		}
		if (!string.IsNullOrEmpty(commentModel.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(commentModel.RedirectUrl);
		}
		if (workLogItem == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "WorkLogApproveReport");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = workLogItem.Id
		});
	}

	public ActionResult ReAssignWorkLogItemPopup(string popupId, string workLogItems)
	{
		ReAssignWorkLogItemModel reAssignWorkLogItemModel = new ReAssignWorkLogItemModel
		{
			PopupId = popupId,
			WorkLogItems = workLogItems
		};
		List<IWorkLogItem> source = (from m in base.Manager.FindByIdArray(reAssignWorkLogItemModel.GetWorkLogItemIds().ToArray())
			where WorkLogItemManager.Instance.CanReAssign(m)
			select m).ToList();
		reAssignWorkLogItemModel.SetWorkLogItemIds(source.Select((IWorkLogItem m) => m.Id).ToList());
		if ((from m in source
			group m by m.Harmonizator.Id).Count() == 1)
		{
			reAssignWorkLogItemModel.Harmonizator = source.First().Harmonizator;
		}
		return (ActionResult)(object)((Controller)this).PartialView("ReAssignWorkLogItem", (object)reAssignWorkLogItemModel);
	}

	[TransactionAction]
	public ActionResult ReAssign(ReAssignWorkLogItemModel model)
	{
		ICollection<IWorkLogItem> collection = base.Manager.FindByIdArray(model.GetWorkLogItemIds().ToArray());
		bool reportNotificationsChangeEnabled = Settings().ReportNotificationsChangeEnabled;
		foreach (IWorkLogItem item in collection.Where((IWorkLogItem workLogItem) => workLogItem != null && model.Harmonizator != null && WorkLogItemManager.Instance.CanReAssign(workLogItem) && workLogItem.Harmonizator.Id != model.Harmonizator.Id))
		{
			WorkLogItemManager.Instance.ReAssign(item, model.Harmonizator, model.ActionModel);
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, item, "823cc9ce-1ca4-4ee2-a7a0-872054d4f986");
			if (model.ActionModel != null)
			{
				CommentActionHandler.ProcessEventArgs(entityActionEventArgs, model.ActionModel);
			}
			entityActionEventArgs.ExtendedProperties.Add("ReportNotificationsChangeEnabled", reportNotificationsChangeEnabled);
			EntityActionHandler.ActionExecuted(entityActionEventArgs);
			CommentActionHandler.Process(item, model.ActionModel);
		}
		if (collection.Count == 1)
		{
			NotifyTaskAction(collection.First(), SR.T("Согласующий трудозатрат переназначен {0}"));
		}
		else
		{
			base.Notifier.Information(SR.T("Согласующий трудозатрат переназначен"));
		}
		((ControllerBase)this).get_TempData().set_Item("EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogItem.ReAssign", (object)true);
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		if (collection.Count != 1)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "WorkLogApproveReport");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = collection.First().Id
		});
	}

	[TransactionAction]
	public ActionResult StatusChangeToConfirm([Bind(Prefix = "statusChangeConfirmPopup")] WorkLogItemApprovalConfirmModel model)
	{
		return StatusChange(model, WorkLogItemStatus.Confirm);
	}

	[TransactionAction]
	public ActionResult StatusChangeToUnconfirm([Bind(Prefix = "statusChangeUnConfirmPopup")] WorkLogItemApprovalConfirmModel model)
	{
		return StatusChange(model, WorkLogItemStatus.Unconfirm);
	}

	[TransactionAction]
	public ActionResult StatusChangeToReopen([Bind(Prefix = "statusChangeReopenPopup")] WorkLogItemApprovalConfirmModel model)
	{
		ActionResult result = StatusChange(model, WorkLogItemStatus.New);
		if (model.Harmonizator != null && model.ChangeHarmonizator)
		{
			HarmonizatorChange(model);
		}
		return result;
	}

	private ActionResult StatusChange(WorkLogItemApprovalConfirmModel model, WorkLogItemStatus status)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(model.ObjectId);
		if (workLogItem != null)
		{
			if (model.CanChangeWorkLogActivity && model.WorkLogActivity != null)
			{
				workLogItem.WorkLogActivity = model.WorkLogActivity;
			}
			WorkLogItemManager.Instance.ChangeStatus(workLogItem, status);
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, workLogItem, "e71c3a9e-e121-4c1b-a7b7-93e90eac242d");
			if (model.ActionModel != null)
			{
				CommentActionHandler.ProcessEventArgs(entityActionEventArgs, model.ActionModel);
			}
			entityActionEventArgs.ExtendedProperties.Add("ReportNotificationsChangeEnabled", Settings().ReportNotificationsChangeEnabled);
			EntityActionHandler.ActionExecuted(entityActionEventArgs);
			CommentActionHandler.Process(workLogItem, model.ActionModel);
			NotifyTaskAction(workLogItem, SR.T("Статус трудозатрат изменён {0}"));
		}
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
		{
			id = model.ObjectId
		});
	}

	private void HarmonizatorChange(WorkLogItemApprovalConfirmModel model)
	{
		bool reportNotificationsChangeEnabled = Settings().ReportNotificationsChangeEnabled;
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(model.ObjectId);
		if (workLogItem != null)
		{
			WorkLogItemManager.Instance.ReAssign(workLogItem, model.Harmonizator, model.ActionModel);
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, workLogItem, "823cc9ce-1ca4-4ee2-a7a0-872054d4f986");
			if (model.ActionModel != null)
			{
				CommentActionHandler.ProcessEventArgs(entityActionEventArgs, model.ActionModel);
			}
			entityActionEventArgs.ExtendedProperties.Add("ReportNotificationsChangeEnabled", reportNotificationsChangeEnabled);
			EntityActionHandler.ActionExecuted(entityActionEventArgs);
			CommentActionHandler.Process(workLogItem, model.ActionModel);
			NotifyTaskAction(workLogItem, SR.T("Согласующий трудозатрат переназначен"));
		}
	}

	private WorkLogItemEditModel CreateWorkLogItemEditModel(long id, Action<WorkLogItemEditModel> init = null)
	{
		IWorkLogItem workLogItem = base.Manager.LoadOrNull(id);
		if (workLogItem == null)
		{
			throw new SecurityException(SR.T("Не найдены трудозатраты"));
		}
		if (!WorkLogItemManager.CanEdit(workLogItem))
		{
			throw new SecurityException(SR.T("Нет прав на редактирование трудозатрат"));
		}
		WorkLogItemEditModel workLogItemEditModel = new WorkLogItemEditModel
		{
			Entity = workLogItem,
			FactWorkTime = workLogItem.FactWorkTime,
			Activity = workLogItem.WorkLogActivity
		};
		init?.Invoke(workLogItemEditModel);
		return workLogItemEditModel;
	}
}
