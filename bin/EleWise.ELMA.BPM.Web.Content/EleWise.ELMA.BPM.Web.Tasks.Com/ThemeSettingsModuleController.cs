using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Content;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Obsolete("Не используется", true)]
public class ThemeSettingsModuleController : GlobalSettingsModuleControllerBase<ThemeSettings, ThemeSettingsModule>
{
	public ThemeSettingsModuleController(ThemeSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "ThemeSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "ThemeSettings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		});
	}
}
