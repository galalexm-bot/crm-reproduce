using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 210)]
public class TasksSettingsModuleController : GlobalSettingsModuleControllerBase<TasksSettings, TasksSettingsModule>
{
	public TasksSettingsModuleController(TasksSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "TasksSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "TasksSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}
}
