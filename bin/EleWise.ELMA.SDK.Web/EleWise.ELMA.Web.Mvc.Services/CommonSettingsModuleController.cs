using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.Services;

[Component(Order = 10)]
public class CommonSettingsModuleController : GlobalSettingsModuleControllerBase<CommonSettings, CommonSettingsModule>
{
	public CommonSettingsModuleController(CommonSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		if (string.IsNullOrEmpty(base.Module.Settings.SystemDefaultCultureName))
		{
			base.Module.Settings.SystemDefaultCultureName = SR.GetDefaultCulture().Name;
		}
		return PartialExtensions.Partial(html, "DisplayTemplates/CommonSettings", (object)base.Module.Settings);
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "EditorTemplates/CommonSettings", (object)base.Module.Settings);
	}
}
