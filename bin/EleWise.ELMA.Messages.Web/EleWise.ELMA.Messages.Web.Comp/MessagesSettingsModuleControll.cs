using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Messages.Web.Components;

[Component(Order = 230)]
public class MessagesSettingsModuleController : GlobalSettingsModuleControllerBase<MessagesSettings, MessagesSettingsModule>
{
	public MessagesSettingsModuleController(MessagesSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "MessagesSettings", (object)new
		{
			area = "EleWise.ELMA.Messages.Web"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "MessagesSettings", (object)new
		{
			area = "EleWise.ELMA.Messages.Web"
		});
	}
}
