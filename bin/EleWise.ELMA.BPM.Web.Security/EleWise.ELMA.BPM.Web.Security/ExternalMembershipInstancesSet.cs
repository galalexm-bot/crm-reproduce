using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[Component(Order = 200)]
internal class ExternalMembershipInstancesSettingsModuleController : GlobalSettingsModuleControllerBase<ExternalMembershipInstancesSettings, ExternalMembershipInstancesSettingsModule>
{
	public override bool Editable => false;

	public ExternalMembershipInstancesSettingsModuleController(ExternalMembershipInstancesSettingsModule module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return ChildActionExtensions.Action(html, "ListEdit", "ExternalMembership", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}
}
