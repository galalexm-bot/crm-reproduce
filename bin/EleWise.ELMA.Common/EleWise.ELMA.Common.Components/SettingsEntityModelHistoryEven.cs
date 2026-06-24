using System;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class SettingsEntityModelHistoryEventsFilter : IEntityModelHistoryEventsFilter
{
	private IEntityHistoryRestrictionService entityHistoryRestrictionService;

	public SettingsEntityModelHistoryEventsFilter(IEntityHistoryRestrictionService service)
	{
		entityHistoryRestrictionService = service;
	}

	public bool IsSupported(IEntity entity, Guid actionUid)
	{
		Guid typeUid = InterfaceActivator.UID(entity.GetType());
		return entityHistoryRestrictionService.IsSupported(typeUid, actionUid);
	}

	public bool IsSupported(Guid typeUid, long entityId, Guid entityUid, Guid actionUid)
	{
		return entityHistoryRestrictionService.IsSupported(typeUid, actionUid);
	}
}
