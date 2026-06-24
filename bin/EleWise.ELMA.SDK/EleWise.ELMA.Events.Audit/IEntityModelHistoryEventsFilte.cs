using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ComponentType.All)]
public interface IEntityModelHistoryEventsFilter
{
	bool IsSupported(IEntity entity, Guid actionUid);

	bool IsSupported(Guid typeUid, long entityId, Guid entityUid, Guid actionUid);
}
