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

[Component(Order = 110)]
public class CreateSubtaskTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{5E65B013-8AA2-44EC-8480-BD7C025D878B}");

	public string ImageUrl => "#sub_task.svg";

	public virtual string DisplayName => SR.T("Создать подзадачу");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return task is ITask;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		return task.IsActive();
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		CreateSubTaskActionControlsModel model = new CreateSubTaskActionControlsModel
		{
			Entity = (ITask)task,
			Settings = settings
		};
		SolveTaskHelper.RunWithDebug("CreateSubtaskTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/CreateSubTaskSolveTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return string.Format("refreshPopup('{0}', '{1}')", CreateSubTaskActionControlsModel.CreateSubTaskActionPopup, helper.Url().Action("SubTaskPopup", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			parentId = task.Id,
			popupId = CreateSubTaskActionControlsModel.CreateSubTaskActionPopup,
			returnUrl = "~/"
		}));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("CreateSubtaskTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(CreateSubTaskActionControlsModel.CreateSubTaskActionPopup, (dynamic d) => helper.PopupWindow(CreateSubTaskActionControlsModel.CreateSubTaskActionPopup, SR.T("Выберите поля, которые необходимо перенести в подзадачу"), "", 450));
	}
}
