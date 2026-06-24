using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class UpdateHistoryCacheAfterConvertDocument : IConvertDocumentAfterProcessing
{
	public IHistoryRepository HistoryRepository { get; set; }

	public int DoAfterProcessing(IDocument document, Guid newTypeUid)
	{
		if (HistoryRepository != null && document != null && !document.TypeUid.Equals(newTypeUid))
		{
			HistoryRepository.UpdateCachedHistoryObjects(document.Id, document.TypeUid, newTypeUid);
			return 1;
		}
		return 0;
	}
}
