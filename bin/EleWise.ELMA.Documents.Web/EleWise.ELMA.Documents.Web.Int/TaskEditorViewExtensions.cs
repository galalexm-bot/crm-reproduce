using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class TaskEditorViewExtensions : IExtensionZone
{
	private const string ZoneAllAttachments = "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-BottomRight";

	private const string ZoneAttachments = "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-Attachments-BottomRight";

	private static readonly List<string> Zones = new List<string> { "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-BottomRight", "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-Attachments-BottomRight" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return Zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-BottomRight")
		{
			html.get_ViewContext().get_Writer().Write("<h4>");
			html.get_ViewContext().get_Writer().Write(html.Encode(SR.T("Документы")));
			html.get_ViewContext().get_Writer().Write("</h4>");
			MvcHtmlString val = html.Editor("CommentActionModel.DocumentAttachments");
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val).ToHtmlString());
		}
		else if (zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskEditor-Attachments-BottomRight")
		{
			MvcHtmlString val2 = PartialExtensions.Partial(html, "DocumentAttachmentsSpecified");
			html.get_ViewContext().get_Writer().Write(((HtmlString)(object)val2).ToHtmlString());
		}
	}
}
