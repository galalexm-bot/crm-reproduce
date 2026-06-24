using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public sealed class SaveAjaxTaskCreateToolbarButtonItem : ActionToolbarItem
{
	public const string BUTTON_GUID = "Tasks_SaveInAjaxActionToolbarButton";

	public SaveAjaxTaskCreateToolbarButtonItem(HtmlHelper htmlHelper)
		: base("Tasks_SaveInAjaxActionToolbarButton")
	{
		TaskModel taskModel = htmlHelper.get_ViewData().get_Model() as TaskModel;
		string arg = "TaskForm";
		if (taskModel != null && !string.IsNullOrWhiteSpace(taskModel.FormId))
		{
			arg = taskModel.FormId;
		}
		Text = SR.Save;
		IconUrl = "#save.svg";
		Click = $"onSaveTask($('form#{arg}')); return false;";
		IsMainAction = true;
		Visible = false;
		if (htmlHelper.get_ViewData().get_Model() is TaskModel taskModel2)
		{
			Visible = taskModel2.AjaxPopup;
		}
	}
}
