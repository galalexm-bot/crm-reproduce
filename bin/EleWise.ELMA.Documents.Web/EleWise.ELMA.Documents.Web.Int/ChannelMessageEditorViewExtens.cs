using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Messages;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class ChannelMessageEditorViewExtensions : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.Messages.Web.ChannelMessageEditor-BottomRight" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId))
		{
			html.get_ViewContext().get_Writer().Write("<div class=\"channel-message-editor-extension-title\">");
			html.get_ViewContext().get_Writer().Write(html.Encode(SR.T("Документы")));
			html.get_ViewContext().get_Writer().Write("</div>");
			MvcHtmlString val = html.Editor("Message.DocumentAttachments");
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val).ToHtmlString());
		}
	}
}
