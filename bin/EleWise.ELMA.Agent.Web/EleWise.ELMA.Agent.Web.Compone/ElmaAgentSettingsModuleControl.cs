using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Agent.Web.Components;

[Component(Order = 310)]
internal sealed class ElmaAgentSettingsModuleController : GlobalSettingsModuleControllerBase<ElmaAgentSettings, ElmaAgentSettingsModule>
{
	public override bool Editable => false;

	public ElmaAgentSettingsModuleController(ElmaAgentSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Index", "ELMAAgentSettings", (object)new
		{
			area = "EleWise.ELMA.Agent.Web"
		});
	}
}
