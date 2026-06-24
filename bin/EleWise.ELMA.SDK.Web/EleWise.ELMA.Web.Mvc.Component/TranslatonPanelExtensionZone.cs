using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class TranslatonPanelExtensionZone : IExtensionZone
{
	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "BeforeContentZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!(zoneId != "BeforeContentZone"))
		{
			html.get_ViewContext().get_Writer().WriteLine(html.TranslationPanel());
		}
	}
}
