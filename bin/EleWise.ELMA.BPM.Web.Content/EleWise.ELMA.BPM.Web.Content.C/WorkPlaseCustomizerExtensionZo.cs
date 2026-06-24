using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class WorkPlaseCustomizerExtensionZone : IExtensionZone
{
	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "BeforeContentZone";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!(zoneId != "BeforeContentZone"))
		{
			html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)ChildActionExtensions.Action(html, "Customizer", "WorkPlace", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			})).ToHtmlString());
		}
	}
}
