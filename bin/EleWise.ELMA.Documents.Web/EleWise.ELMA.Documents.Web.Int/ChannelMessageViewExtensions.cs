using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Messages;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class ChannelMessageViewExtensions : IExtensionZone
{
	private const string Zone1 = "EleWise.ELMA.Messages.Web.ChannelMessageView";

	private const string Zone2 = "EleWise.ELMA.Messages.Web.CommentModel.ChannelMessageView";

	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.Messages.Web.ChannelMessageView", "EleWise.ELMA.Messages.Web.CommentModel.ChannelMessageView" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId))
		{
			if (zoneId == "EleWise.ELMA.Messages.Web.ChannelMessageView")
			{
				MvcHtmlString val = html.Display("Message.DocumentAttachments");
				html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val).ToHtmlString());
			}
			MvcHtmlString val2 = html.Display("CommentModel.DocumentAttachments");
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val2).ToHtmlString());
		}
	}
}
