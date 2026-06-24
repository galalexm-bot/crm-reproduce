using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.RPA.Services;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.RPA.Web.Controllers;

[Component(Order = 200)]
internal sealed class RPAClientSettingsModuleController : GlobalSettingsModuleControllerBase<RPAClientSettings, RPAClientSettingsModule>
{
	public RPAClientSettingsModuleController(RPAClientSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "RPAClientSettings", (object)new
		{
			area = "EleWise.ELMA.RPA.Web"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "RPAClientSettings", (object)new
		{
			area = "EleWise.ELMA.RPA.Web"
		});
	}
}
