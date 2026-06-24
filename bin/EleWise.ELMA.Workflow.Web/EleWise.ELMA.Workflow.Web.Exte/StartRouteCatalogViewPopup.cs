using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Web.Components;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class StartRouteCatalogViewPopup : IExtensionZone
{
	private static readonly List<string> Zones = new List<string> { "StartRouteCatalogViewPopup" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return Zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!Zones.Contains(zoneId) || !(zoneId == "StartRouteCatalogViewPopup") || !(html.get_ViewData().get_Model() is CatalogViewModel model))
		{
			return;
		}
		StartRouteButtonInfo startRouteButtonInfo = ProcessToolbarWorkflow.CreateStartRouteButtonInfoFromList(model);
		if (startRouteButtonInfo != null)
		{
			MvcHtmlString val = html.StartRouteCatalogViewPopup(startRouteButtonInfo);
			if (val != null)
			{
				html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)val).ToHtmlString());
			}
		}
	}
}
