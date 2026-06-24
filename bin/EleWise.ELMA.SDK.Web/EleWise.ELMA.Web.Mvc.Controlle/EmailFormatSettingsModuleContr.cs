using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging.EmailFormat;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[Component(Order = 300)]
internal class EmailFormatSettingsModuleController : GlobalSettingsModuleControllerBase<EmailFormatSettings, EmailFormatSettingsModule>
{
	public EmailFormatSettingsModuleController(EmailFormatSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new EmailFormatSettings();
		}
		base.Module.Settings.Init();
		return PartialExtensions.Partial(html, "EmailFormats/EmailFormatSettings", (object)base.Module.Settings);
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		if (base.Module.Settings == null)
		{
			base.Module.Settings = new EmailFormatSettings();
		}
		base.Module.Settings.Init();
		return PartialExtensions.Partial(html, "EmailFormats/EmailFormatSettingsEdit", (object)base.Module.Settings);
	}
}
