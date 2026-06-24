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
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 50)]
public class ControlledSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{1A0018EC-22A8-419A-B40A-F9970FDACDF6}");

	public string ImageUrl => "#complete_control.svg";

	public virtual string DisplayName => SR.T("Проконтролировано");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is ITask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		bool res = false;
		SolveTaskHelper.RunWithDebug("ControlledSolveTaskAction.IsVisible", debugMode, delegate
		{
			TaskWorkflowActions serviceNotNull = Locator.GetServiceNotNull<TaskWorkflowActions>();
			res = serviceNotNull.IsAvailableControlledAction(task, Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>());
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
			Status = TaskBaseStatus.CompleteControlled
		};
		SolveTaskHelper.RunWithDebug("ControlledSolveTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/ControlledSolveTaskControls", (object)model);
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
			Status = TaskBaseStatus.CompleteControlled
		};
		if (settings.GetTaskQuickSettings(task.TypeUid))
		{
			return $"{solveTaskActionControlsModel.ActionFunctionName}()";
		}
		return string.Format("refreshPopup('{0}', '{1}')", SolveTaskActionControlsModel.ControlledSolveTaskActionPopup, helper.Url().Action("TaskComment", "Task", (object)new
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
			PostAction = "Controlled",
			PostController = "Task",
			PostArea = "EleWise.ELMA.BPM.Web.Tasks",
			PopupId = SolveTaskActionControlsModel.ControlledSolveTaskActionPopup,
			ActionName = SR.T("Сделано"),
			ObjectId = task.Id,
			ObjectTypeUid = task.TypeUid,
			ShowAttachment = true,
			HtmlPrefix = "Controlled",
			ShowWorkLog = false,
			RedirectUrl = "~/"
		};
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("ControlledSolveTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveTaskActionControlsModel.ControlledSolveTaskActionPopup, (dynamic d) => helper.PopupWindow(SolveTaskActionControlsModel.ControlledSolveTaskActionPopup, SR.T("Сделано"), ""));
	}
}
