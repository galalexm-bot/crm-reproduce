using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class FilterTreeActionsView : IExtensionZone
{
	private const string ZONE_ID = "FilterTreeActionsExtensionZone";

	private readonly ISecurityService securityService;

	public FilterTreeActionsView(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "FilterTreeActionsExtensionZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "FilterTreeActionsExtensionZone")
		{
			RenderPartialExtensions.RenderPartial(html, "Filter/FilterTreeActions", html.get_ViewData().get_Model());
		}
	}
}
