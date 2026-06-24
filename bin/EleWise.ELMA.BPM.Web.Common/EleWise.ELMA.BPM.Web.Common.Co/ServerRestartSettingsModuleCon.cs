using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[Component(Order = 200)]
public class ServerRestartSettingsModuleController : GlobalSettingsModuleControllerBase<ServerRestartSettings, ServerRestartSettingsModule>
{
	public ServerRestartSettingsModuleController(ServerRestartSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "ServerRestart", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "ServerRestart", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}
}
