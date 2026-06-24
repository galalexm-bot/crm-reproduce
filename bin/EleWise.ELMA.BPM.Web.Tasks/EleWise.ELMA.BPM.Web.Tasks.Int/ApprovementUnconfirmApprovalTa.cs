using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 100)]
public class ApprovementUnconfirmApprovalTaskSolveAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{BE7C8071-3A93-4887-8B48-2EA4DB3C14E5}");

	public string ImageUrl => "#error.svg";

	public virtual string DisplayName => SR.T("Отказать в согласовании");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is IApprovalTask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		return task.IsActive();
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		SolveApprovalTaskActionControlsModel model = new SolveApprovalTaskActionControlsModel
		{
			Entity = (IApprovalTask)task,
			Settings = settings,
			CommentModel = CreateTaskCommentModel(task),
			Approve = false
		};
		SolveTaskHelper.RunWithDebug("ApprovementUnconfirmApprovalTaskSolveAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/ApprovementSolveApprovalTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		CommentWithAttachments commentWithAttachments = CreateTaskCommentModel(task);
		SolveApprovalTaskActionControlsModel solveApprovalTaskActionControlsModel = new SolveApprovalTaskActionControlsModel
		{
			Entity = (IApprovalTask)task,
			Settings = settings,
			CommentModel = commentWithAttachments,
			Approve = false
		};
		if (settings.GetTaskQuickSettings(task.TypeUid))
		{
			return $"{solveApprovalTaskActionControlsModel.ActionFunctionName}()";
		}
		return string.Format("refreshPopup('{0}', '{1}')", SolveApprovalTaskActionControlsModel.ApprovementApprovalTaskPopup, helper.Url().Action("PopupCommentContent", "Comment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			PostAction = commentWithAttachments.PostAction,
			PostController = commentWithAttachments.PostController,
			PostArea = commentWithAttachments.PostArea,
			PopupId = commentWithAttachments.PopupId,
			ActionName = commentWithAttachments.ActionName,
			ObjectId = commentWithAttachments.ObjectId,
			ObjectTypeUid = commentWithAttachments.ObjectTypeUid,
			ShowAttachment = commentWithAttachments.ShowAttachment,
			HtmlPrefix = commentWithAttachments.HtmlPrefix,
			RedirectUrl = commentWithAttachments.RedirectUrl
		}));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("ApprovementUnconfirmApprovalTaskSolveAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveApprovalTaskActionControlsModel.ApprovementApprovalTaskPopup, (dynamic d) => helper.PopupWindow(SolveApprovalTaskActionControlsModel.ApprovementApprovalTaskPopup, SR.T("Отказать в согласовании"), ""));
	}

	protected virtual CommentWithAttachments CreateTaskCommentModel(ITaskBase task)
	{
		return new CommentWithAttachments
		{
			PostAction = "ApprovalRefuse",
			PostController = "Task",
			PostArea = "EleWise.ELMA.BPM.Web.Tasks",
			PopupId = SolveApprovalTaskActionControlsModel.ApprovementApprovalTaskPopup,
			ActionName = SR.T("Отказать в согласовании"),
			ObjectId = task.Id,
			ObjectTypeUid = task.TypeUid,
			RedirectUrl = "~/"
		};
	}
}
