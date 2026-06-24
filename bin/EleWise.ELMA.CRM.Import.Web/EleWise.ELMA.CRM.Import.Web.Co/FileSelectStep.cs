using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Import.Web.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class FileSelectStep : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.CRM.Import.Web.Templates", "EleWise.ELMA.CRM.Import.Web.Description" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId.Equals("EleWise.ELMA.CRM.Import.Web.Templates"))
		{
			RenderPartialExtensions.RenderPartial(html, "~/Modules/EleWise.ELMA.CRM.Import.Web/Views/CrmTemplates.cshtml");
		}
		else if (zoneId.Equals("EleWise.ELMA.CRM.Import.Web.Description"))
		{
			html.get_ViewData().set_Item("EntityType", (object)"Contractor");
			RenderPartialExtensions.RenderPartial(html, "Description");
		}
	}
}
