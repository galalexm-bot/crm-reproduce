using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Documents.Web.Extensions;

public static class DocumentExtension
{
	public static ActionButton DocumentActionButton(IDocument document, string imageUrl, string prefix = "")
	{
		if (document == null)
		{
			return null;
		}
		return DocumentActionButton(document.Id, (document.CurrentVersion != null) ? new long?(document.CurrentVersion.Id) : null, imageUrl, prefix);
	}

	public static ActionButton DocumentActionButton(long documentId, long? versionId, string imageUrl, string prefix)
	{
		return new ActionButton
		{
			IconUrl = imageUrl,
			Attributes = new
			{
				@class = "DocumentPreviewSelectorButton",
				documentId = documentId,
				versionId = versionId,
				prefix = prefix,
				tooltiptext = SR.T("Действия")
			}
		};
	}

	public static IDocumentVersion GetCurrentVersion(this IDocument document)
	{
		if (document.CurrentVersion != null && document.CurrentVersion.Document == null)
		{
			return null;
		}
		return document.CurrentVersion;
	}
}
