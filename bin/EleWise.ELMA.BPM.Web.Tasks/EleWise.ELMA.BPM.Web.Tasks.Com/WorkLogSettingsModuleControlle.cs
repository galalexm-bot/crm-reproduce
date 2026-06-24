using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 200)]
public class WorkLogSettingsModuleController : GlobalSettingsModuleControllerBase<WorkLogSettings, WorkLogSettingsModule>
{
	public WorkLogSettingsModuleController(WorkLogSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "WorkLogSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "WorkLogSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		});
	}
}
