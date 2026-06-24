using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentBaseTasksHistoryInverseCollector : IEntityHistoryInverseCollector
{
	public bool CanUse(IEntity entity)
	{
		return entity is IAttachmentsTaskBase;
	}

	public IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity)
	{
		if (entity is IAttachmentsTaskBase attachmentsTaskBase)
		{
			return (from i in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments
				where i?.Document != null
				select new InverseRelatedEntityModel(i.Document.Id, i.Document.TypeUid)).Union(from i in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified
				where i?.Document != null
				select new InverseRelatedEntityModel(i.Document.Id, i.Document.TypeUid));
		}
		return Enumerable.Empty<InverseRelatedEntityModel>();
	}
}
