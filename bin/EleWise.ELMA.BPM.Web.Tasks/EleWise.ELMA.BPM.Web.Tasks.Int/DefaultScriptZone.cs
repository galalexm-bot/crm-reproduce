using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration;

[Component(EnableInterceptiors = false, InjectProerties = false)]
public class DefaultScriptZone : IExtensionZone
{
	private const string ZoneId = "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if ("EleWise.ELMA.SDK.Web.DefaultScripts.ZoneAfter" == zoneId)
		{
			html.get_ViewContext().get_Writer().WriteLine();
			html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)PartialExtensions.Partial(html, "WorkLogActivity/WorkLogActivityInfoDefaultScript")).ToHtmlString());
		}
	}
}
