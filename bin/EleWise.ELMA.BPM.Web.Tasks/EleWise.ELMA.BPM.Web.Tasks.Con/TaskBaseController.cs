using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

public class TaskBaseController : BPMController
{
	[HttpPost]
	[TransactionAction]
	public ActionResult StartWork([NotNull][Bind(Prefix = "StartWork")] CommentWithAttachments commentModel)
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(commentModel.ObjectTypeUid);
		Guid uid = ((entityMetadata.Type == EntityMetadataType.InterfaceImplementation) ? entityMetadata.ImplementationUid : entityMetadata.Uid);
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid, loadImplementation: false);
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		ITaskBase target = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			target = (ITaskBase)manager.Load(commentModel.ObjectId);
		});
		TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.StartWork(commentModel.ObjectId, alertCoexecuters: true, commentModel.ActionModel), target.CastAsRealType().GetType());
		if (commentModel.IsAjax)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		NotifyTaskAction(this, target, SR.T("Начата работа над задачей {0}"));
		if (!string.IsNullOrEmpty(commentModel.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(commentModel.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Request().UrlReferrer.PathAndQuery);
	}

	public static void NotifyTaskAction(BaseController controller, ITaskBase task, string actionThemeFormat)
	{
		if (task != null && actionThemeFormat != null)
		{
			string text = string.Format("<a href='{1}'>{0}</a>", SR.T(task.Subject).HtmlEncode(), ((Controller)controller).get_Url().Entity(task));
			text = ((!actionThemeFormat.Contains("{0}")) ? (actionThemeFormat.HtmlEncode() + " " + text) : string.Format(actionThemeFormat.HtmlEncode(), text));
			controller.Notifier.Information(MvcHtmlString.Create(text));
		}
	}

	public ActionResult ReAssignTaskForm(TaskViewModel model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("ReAssignTask", (object)model);
	}

	public ActionResult TakeControl(long id)
	{
		ITask task = TaskManager.Instance.Load(id);
		((ICollection<EleWise.ELMA.Security.Models.IUser>)task.CurrentControllers).AddIfNotContains(base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		task.Save();
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(task));
	}

	public ActionResult BreakControl(long id)
	{
		ITask task = TaskManager.Instance.Load(id);
		((ICollection<EleWise.ELMA.Security.Models.IUser>)task.CurrentControllers).Remove(base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		task.Save();
		NotifyTaskAction(this, task, SR.T("Снят контроль с задачи {0}"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}
}
