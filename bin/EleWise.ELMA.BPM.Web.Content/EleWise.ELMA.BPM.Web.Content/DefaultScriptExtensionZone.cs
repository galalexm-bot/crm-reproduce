using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Content;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class DefaultScriptExtensionZone : IExtensionZone
{
	private const string ZONE_ID = "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter")
		{
			html.get_ViewContext().get_Writer().WriteLine();
			html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)html.Script(html.Url().Content("~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/tiny_mce_gzip.js"))).ToHtmlString());
		}
	}
}
