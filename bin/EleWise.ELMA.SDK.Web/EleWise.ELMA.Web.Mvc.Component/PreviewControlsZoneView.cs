using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
internal class PreviewControlsZoneView : IExtensionZone
{
	private const string ZONE_ID = "BeforeContentZone";

	private readonly ISecurityService securityService;

	public PreviewControlsZoneView(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "BeforeContentZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "BeforeContentZone")
		{
			RenderPartialExtensions.RenderPartial(html, "Previews/PreviewPopupButtonViews");
		}
	}
}
