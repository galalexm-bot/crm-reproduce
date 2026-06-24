using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Events.Audit;

[DeveloperApi(DeveloperApiType.Service)]
public interface IEntityActionHistoryEventService
{
	void Initialize();

	TEventArgs Create<TEventArgs>(IEntity entity, Guid objectUid, Guid actionUid, Guid eventArgsUid) where TEventArgs : class, IEntityHistoryEventArgs;

	Type GetEventArgsType(Guid eventArgsUid);
}
