using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.Services;

[Service]
public class EntityModelHistoryService : IEntityModelHistoryService
{
	private EntityModelHistoryManager Manager { get; set; }

	public EntityModelHistoryService(EntityModelHistoryManager manager)
	{
		Manager = manager;
	}

	public long Count(Guid objectTypeUid, DateTime? from, string eqlQuery = null)
	{
		return Manager.Count(objectTypeUid, from, eqlQuery);
	}

	public IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string eqlQuery = null)
	{
		return Manager.Find(objectTypeUid, from, eqlQuery);
	}

	public long Count(Guid objectTypeUid, DateTime? from, string filterKey, IEntityFilter filter)
	{
		return Manager.Count(objectTypeUid, from, filterKey, filter);
	}

	public IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string filterKey, IEntityFilter filter)
	{
		return Manager.Find(objectTypeUid, from, filterKey, filter);
	}
}
