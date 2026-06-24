using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit.History;

[Component]
internal sealed class QuestionHistoryInverseCollector : IEntityHistoryInverseCollector
{
	public bool CanUse(IEntity entity)
	{
		return entity is IQuestion;
	}

	public IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity)
	{
		if (entity is IQuestion question)
		{
			ReferenceOnEntity refObject = question.RefObject;
			if (refObject != null)
			{
				return new InverseRelatedEntityModel[1]
				{
					new InverseRelatedEntityModel(refObject.ObjectId, refObject.ObjectTypeUId)
				};
			}
		}
		return Enumerable.Empty<InverseRelatedEntityModel>();
	}
}
