using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.History.Models;

internal sealed class EntityHistoryModel
{
	public IEnumerable<EntityActionEventArgs> EventList { get; set; }

	public IEnumerable<EntityActionEventTuple> EventTuples { get; set; }

	public IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> UnitOfWorks { get; set; }
}
