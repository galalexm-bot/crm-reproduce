using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentVersionsHistoryInverseCollector : IEntityHistoryInverseCollector
{
	public bool CanUse(IEntity entity)
	{
		return entity is IDocumentVersion;
	}

	public IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity)
	{
		if (entity is IDocumentVersion documentVersion)
		{
			IDocument document = documentVersion.Document;
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
