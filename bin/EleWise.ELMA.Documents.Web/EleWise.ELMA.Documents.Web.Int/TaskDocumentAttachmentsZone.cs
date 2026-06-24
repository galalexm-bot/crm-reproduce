using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component]
public class TaskDocumentAttachmentsZone : IExtensionZone
{
	private const string AttachmentsZoneId = "TaskDocumentAttachmentsZone";

	private const string AttachmentsSpecifiedZoneId = "TaskDocumentAttachmentsSpecifiedZone";

	private readonly ISecurityService securityService;

	public TaskDocumentAttachmentsZone(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		if (!(zoneId == "TaskDocumentAttachmentsZone"))
		{
			return zoneId == "TaskDocumentAttachmentsSpecifiedZone";
		}
		return true;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "TaskDocumentAttachmentsZone" && html.get_ViewData().get_Model() is IAttachmentsTaskBase attachmentsTaskBase)
		{
			RenderPartialExtensions.RenderPartial(html, "DocumentAttachmentWithCurrentVersionSet", (object)attachmentsTaskBase.DocumentAttachments);
		}
		else if (zoneId == "TaskDocumentAttachmentsSpecifiedZone" && html.get_ViewData().get_Model() is IAttachmentsTaskBase attachmentsTaskBase2)
		{
			RenderPartialExtensions.RenderPartial(html, "DocumentAttachmentWithCurrentVersionSet", (object)((IEnumerable<IDocumentAttachment>)attachmentsTaskBase2.DocumentAttachmentsSpecified).Where((IDocumentAttachment d) => d != null));
		}
	}
}
