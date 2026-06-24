using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 50)]
public class AnswerSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{06DB0FAF-0851-437C-AF80-2A1E03F30836}");

	public string ImageUrl => "#complete.svg";

	public virtual string DisplayName => SR.T("Ответить на вопрос");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is IQuestion;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		return task.IsActive();
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		SolveAnswerControlsModel model = new SolveAnswerControlsModel
		{
			Entity = (IQuestion)task,
			Settings = settings
		};
		SolveTaskHelper.RunWithDebug("AnswerSolveTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/AnswerSolveTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		AnswerModel answerModel = new AnswerModel
		{
			PopupId = SolveAnswerControlsModel.AnswerModelPopup,
			ObjectId = task.Id,
			RedirectUrl = "~/"
		};
		return string.Format("refreshPopup('{0}', '{1}')", SolveAnswerControlsModel.AnswerModelPopup, helper.Url().Action("AnswerCreateForm", "Answer", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			PopupId = answerModel.PopupId,
			PostAction = answerModel.PostAction,
			PostController = answerModel.PostController,
			PostArea = answerModel.PostArea,
			ObjectId = answerModel.ObjectId,
			AnswerId = answerModel.AnswerId,
			RedirectUrl = answerModel.RedirectUrl
		}));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("AnswerSolveTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveAnswerControlsModel.AnswerModelPopup, (dynamic o) => helper.AnswerPopup(new AnswerModel
		{
			PopupId = SolveAnswerControlsModel.AnswerModelPopup
		}));
	}
}
