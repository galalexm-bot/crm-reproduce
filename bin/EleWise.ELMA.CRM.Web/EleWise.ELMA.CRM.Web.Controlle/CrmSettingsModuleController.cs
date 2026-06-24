using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Component(Order = 250)]
public class CrmSettingsModuleController : GlobalSettingsModuleControllerBase<CrmSettings, CrmSettingsModule>
{
	public CrmSettingsModuleController(CrmSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "View", "CrmSettings", (object)new
		{
			area = "EleWise.ELMA.CRM.Web"
		});
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "Edit", "CrmSettings", (object)new
		{
			area = "EleWise.ELMA.CRM.Web"
		});
	}
}
