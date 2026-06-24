using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Events.Audit;

public interface IEntityActionHistoryLoader
{
	IEnumerable<EntityActionEventArgs> LoadHistory([NotNull] IEntity<long> entity);

	IEnumerable<EntityActionEventArgs> LoadHistory(Guid actionObject, long? objectId, Guid? actionType = null);

	IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject);

	IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject, Guid actionTypeUid, long? objectId = null);

	IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid);
}
