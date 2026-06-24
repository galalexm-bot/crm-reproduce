using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[Component(Order = 250)]
internal class PreviewSettingsModuleController : GlobalSettingsModuleControllerBase<PreviewSettings, PreviewSettingsModule>
{
	public PreviewSettingsModuleController(PreviewSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new PreviewSettings();
		}
		base.Module.Settings.InitInfos();
		return PartialExtensions.Partial(html, "Previews/PreviewSettings", (object)base.Module.Settings);
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new PreviewSettings();
		}
		base.Module.Settings.InitInfos();
		return PartialExtensions.Partial(html, "Previews/PreviewSettingsEdit", (object)base.Module.Settings);
	}
}
