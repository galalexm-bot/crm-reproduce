using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class FilterTreeZone : IExtensionZone
{
	private const string ZONE_ID = "EleWise.ELMA.BPM.Web.Common-FilterTree-ContentToolbar";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.BPM.Web.Common-FilterTree-ContentToolbar";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (html.get_ViewData().get_Model() is FilterTreeEditModel)
		{
			RenderPartialExtensions.RenderPartial(html, "FilterTreeContent/FilterTreeToolbar");
		}
	}
}
