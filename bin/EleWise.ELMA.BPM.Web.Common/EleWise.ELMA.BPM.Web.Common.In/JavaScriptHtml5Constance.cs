using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Integration.Views;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class JavaScriptHtml5Constance : IExtensionZone
{
	public const string ZONE_ID = "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter";

	private readonly ISecurityService securityService;

	public JavaScriptHtml5Constance(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter")
		{
			RenderPartialExtensions.RenderPartial(html, "JavaScriptHtml5Constance");
		}
	}
}
