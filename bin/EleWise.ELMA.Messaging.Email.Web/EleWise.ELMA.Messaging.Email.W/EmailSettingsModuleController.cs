using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Messaging.Email.Web;

[Component(Order = 200)]
public class EmailSettingsModuleController : GlobalSettingsModuleControllerBase<EmailSettings, EmailSettingsModule>
{
	public EmailSettingsModuleController(EmailSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "EmailSettings", (object)new
		{
			area = "EleWise.ELMA.Messaging.Email.Web"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "EmailSettings", (object)new
		{
			area = "EleWise.ELMA.Messaging.Email.Web"
		});
	}
}
