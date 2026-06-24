using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Integration.Views;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class DocumentAttachmentsForCopiedScripts : IExtensionZone
{
	public const string ZONE_ID = "EleWise.ELMA.BPM.Web.Tasks.TaskComment-AttachmentsForCopied.ExtAttachmentsScripts";

	private readonly ISecurityService securityService;

	public DocumentAttachmentsForCopiedScripts(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskComment-AttachmentsForCopied.ExtAttachmentsScripts";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskComment-AttachmentsForCopied.ExtAttachmentsScripts")
		{
			RenderPartialExtensions.RenderPartial(html, "DocumentAttachmentsForCopiedScripts");
		}
	}
}
