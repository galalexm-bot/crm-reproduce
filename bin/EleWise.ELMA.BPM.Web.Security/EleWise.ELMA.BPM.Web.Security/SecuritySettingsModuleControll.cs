using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[Component(Order = 190)]
public class SecuritySettingsModuleController : GlobalSettingsModuleControllerBase<SecuritySettings, SecuritySettingsModule>
{
	public override bool Editable => true;

	public SecuritySettingsModuleController(SecuritySettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "SecuritySettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "SecuritySettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}
}
