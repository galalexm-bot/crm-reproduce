using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 50)]
public class CompleteSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{7FFE7ED7-EF29-423B-B350-46F983CBD681}");

	public string ImageUrl => "#complete.svg";

	public virtual string DisplayName => SR.T("Сделано");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is ITask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		bool res = false;
		SolveTaskHelper.RunWithDebug("CompleteSolveTaskAction.IsVisible", debugMode, delegate
		{
			TaskWorkflowActions serviceNotNull = Locator.GetServiceNotNull<TaskWorkflowActions>();
			res = serviceNotNull.IsAvailableCompleted(task, Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>());
		});
		return res;
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		SolveTaskActionControlsModel model = new SolveTaskActionControlsModel
		{
			Entity = (ITask)task,
			Settings = settings,
			CommentModel = CreateTaskCommentModel(task),
			Status = TaskBaseStatus.Complete
		};
		SolveTaskHelper.RunWithDebug("CompleteSolveTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/CompleteSolveTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		TaskCommentModel taskCommentModel = CreateTaskCommentModel(task);
		SolveTaskActionControlsModel solveTaskActionControlsModel = new SolveTaskActionControlsModel
		{
			Entity = (ITask)task,
			Settings = settings,
			CommentModel = taskCommentModel,
			Status = TaskBaseStatus.Complete
		};
		if (settings.GetTaskQuickSettings(task.TypeUid))
		{
			return $"{solveTaskActionControlsModel.ActionFunctionName}()";
		}
		return string.Format("refreshPopup('{0}', '{1}')", SolveTaskActionControlsModel.CompleteSolveTaskActionPopup, helper.Url().Action("TaskComment", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			PostAction = taskCommentModel.PostAction,
			PostController = taskCommentModel.PostController,
			PostArea = taskCommentModel.PostArea,
			PopupId = taskCommentModel.PopupId,
			ActionName = taskCommentModel.ActionName,
			ObjectId = taskCommentModel.ObjectId,
			ObjectTypeUid = taskCommentModel.ObjectTypeUid,
			ShowAttachment = taskCommentModel.ShowAttachment,
			HtmlPrefix = taskCommentModel.HtmlPrefix,
			ShowWorkLog = taskCommentModel.ShowWorkLog,
			RedirectUrl = taskCommentModel.RedirectUrl
		}));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	protected virtual TaskCommentModel CreateTaskCommentModel(ITaskBase task)
	{
		return new TaskCommentModel
		{
			PostAction = "DoCompleted",
			PostController = "Task",
			PostArea = "EleWise.ELMA.BPM.Web.Tasks",
			PopupId = SolveTaskActionControlsModel.CompleteSolveTaskActionPopup,
			ActionName = SR.T("Сделано"),
			ObjectId = task.Id,
			ObjectTypeUid = task.TypeUid,
			ShowAttachment = true,
			HtmlPrefix = "DoCompleted",
			ShowWorkLog = WorkLogSettingsHelper.WorkLogEnabled(),
			RedirectUrl = "~/"
		};
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("CompleteSolveTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveTaskActionControlsModel.CompleteSolveTaskActionPopup, (dynamic d) => helper.PopupWindow(SolveTaskActionControlsModel.CompleteSolveTaskActionPopup, SR.T("Сделано"), ""));
	}
}
