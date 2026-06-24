using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.Audit.History;

[Component]
internal sealed class DiscussionHistoryInverseCollector : IEntityHistoryInverseCollector
{
	public bool CanUse(IEntity entity)
	{
		return entity is IDiscussionObject;
	}

	public IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity)
	{
		if (entity is IDiscussionObject discussionObject)
		{
			return new InverseRelatedEntityModel[1]
			{
				new InverseRelatedEntityModel(discussionObject.ObjectId, discussionObject.ObjectType)
			};
		}
		return Enumerable.Empty<InverseRelatedEntityModel>();
	}
}
