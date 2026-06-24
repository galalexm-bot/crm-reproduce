using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentLinksHistoryInverseCollector : IEntityHistoryInverseCollector
{
	public bool CanUse(IEntity entity)
	{
		return entity is IDocumentLink;
	}

	public IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity)
	{
		if (entity is IDocumentLink documentLink)
		{
			IDocument document = documentLink.Document;
			if (document != null)
			{
				return new InverseRelatedEntityModel[1]
				{
					new InverseRelatedEntityModel(document.Id, document.TypeUid)
				};
			}
		}
		return Enumerable.Empty<InverseRelatedEntityModel>();
	}
}
