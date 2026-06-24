using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public sealed class CreateTaskToobarButton : ActionToolbarItem
{
	public const string GUID = "Tasks_CreateTaskToobarButton";

	public const string CREATETASK_GUID = "Tasks_CreateTaskToobarButton_Task";

	public const string CREATEPERIOD_GUID = "Tasks_CreateTaskToobarButton_Period";

	public CreateTaskToobarButton(HtmlHelper htmlHelper)
		: base("Tasks_CreateTaskToobarButton")
	{
		IsMainAction = true;
		UrlHelper val = htmlHelper.Url();
		Text = SR.T("Создать");
		IconUrl = "#add.svg";
		Items.Add(new ActionToolbarItem("Tasks_CreateTaskToobarButton_Task")
		{
			Text = SR.T("Задачу"),
			IconUrl = "#add_task.svg",
			ToolTip = SR.T("<b>Создать задачу</b><br>Выберите исполнителя и укажите что нужно сделать"),
			Url = val.Action("Create", "Task", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		});
	}
}
