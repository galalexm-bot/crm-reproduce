using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.Web.Extensions;

[Component]
public class DocumentAttachmentTemplateInputExtension : IAttachmentTemplateInputExtension
{
	public static string HtmlAttributeString = "documentAttachmentId";

	public string HtmlAttribute => HtmlAttributeString;

	public void AddAttachment(ICommentActionModel commentModel, long attachmentId)
	{
		IDocumentAttachment documentAttachment = AbstractNHEntityManager<IDocumentAttachment, long>.Instance.LoadOrNull(attachmentId);
		ICommentWithDocumentsActionModel commentWithDocumentsActionModel = commentModel as ICommentWithDocumentsActionModel;
		if (documentAttachment != null && commentWithDocumentsActionModel != null)
		{
			if (commentWithDocumentsActionModel.DocumentAttachments == null)
			{
				commentWithDocumentsActionModel.DocumentAttachments = new List<IDocumentAttachment>();
			}
			if (commentWithDocumentsActionModel.DocumentAttachments.All((IDocumentAttachment a) => a.Id != documentAttachment.Id))
			{
				commentWithDocumentsActionModel.DocumentAttachments.Add(documentAttachment);
			}
		}
	}
}
