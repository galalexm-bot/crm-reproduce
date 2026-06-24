using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Common;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class CommentViewExtension : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Common.Editors.CommentWithAttachments-BottomRight", "EleWise.ELMA.BPM.Web.Tasks.TaskComment-BottomRight" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId))
		{
			MvcHtmlString val = html.Editor("ActionModel.DocumentAttachments");
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val).ToHtmlString());
		}
	}
}
