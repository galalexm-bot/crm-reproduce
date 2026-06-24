using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class DocumentDTOManager : DTOManager, IDocumentDTOManager, IConfigurationService
{
	public virtual bool IsDocumentExists(long id)
	{
		return DocumentManager.Instance.LoadOrNull(id) != null;
	}

	public virtual string GetDoсumentName(long id)
	{
		return DocumentManager.Instance.LoadOrNull(id)?.Name;
	}

	public virtual string GetCurrentVersionFileId(long documentId)
	{
		IDocument document = DocumentManager.Instance.LoadOrNull(documentId);
		if (document == null || document.CurrentVersion == null || document.CurrentVersion.File == null)
		{
			return string.Empty;
		}
		return document.CurrentVersion.File.Id;
	}
}
