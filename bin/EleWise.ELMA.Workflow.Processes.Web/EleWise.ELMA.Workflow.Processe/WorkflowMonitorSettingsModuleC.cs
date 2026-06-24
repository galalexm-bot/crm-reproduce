using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Component(Order = 100)]
public class WorkflowMonitorSettingsModuleController : GlobalSettingsModuleControllerBase<WorkflowMonitorSettings, WorkflowMonitorSettingsModule>
{
	public WorkflowMonitorSettingsModuleController(WorkflowMonitorSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "EditSettings", "MonitorAdmin", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		});
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "DisplaySettings", "MonitorAdmin", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		});
	}
}
