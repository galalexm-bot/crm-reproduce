using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.Constants;
using EleWise.ELMA.History.Enums;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.History.Services;

[Service]
internal sealed class HistoryService : IHistoryService
{
	private readonly EntityActionHistoryManager historyManager;

	private readonly ILogger logger;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly ISecurityService securityService;

	private readonly ICacheService cacheService;

	private readonly IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository;

	private readonly IEventSerializationService eventSerializationService;

	private readonly IEnumerable<IEntityActionHistoryCollectorRelated> entityActionHistoryCollectorsRelated;

	private readonly IEnumerable<IEntityHistoryCollectorCacheble> entityRelatedObjectsCollector;

	private readonly IEnumerable<IEntityHistoryInverseCollector> entityHistoryInverseCollectors;

	[Obsolete]
	private readonly IEnumerable<IEntityActionHistoryCollector> entityActionHistoryCollectors;

	private readonly IEnumerable<IHistoryCacheEnabledExtension> historyEnabledExtensions;

	public IHistoryRepository HistoryRepository { get; set; }

	public HistoryService(EntityActionHistoryManager historyManager, ILogger logger, IMetadataRuntimeService metadataRuntimeService, ISecurityService securityService, ICacheService cacheService, IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository, IEventSerializationService eventSerializationService, IEnumerable<IEntityActionHistoryCollectorRelated> entityActionHistoryCollectorsRelated, IEnumerable<IEntityHistoryInverseCollector> entityHistoryInverseCollectors, IEnumerable<IEntityActionHistoryCollector> entityActionHistoryCollectors, IEnumerable<IEntityHistoryCollectorCacheble> entityRelatedObjectsCollector, IEnumerable<IHistoryCacheEnabledExtension> historyEnabledExtensions)
	{
		this.historyManager = historyManager;
		this.logger = logger;
		this.metadataRuntimeService = metadataRuntimeService;
		this.securityService = securityService;
		this.cacheService = cacheService;
		this.historyUpdateQueueItemRepository = historyUpdateQueueItemRepository;
		this.eventSerializationService = eventSerializationService;
		this.entityActionHistoryCollectorsRelated = entityActionHistoryCollectorsRelated;
		this.entityHistoryInverseCollectors = entityHistoryInverseCollectors;
		this.entityActionHistoryCollectors = entityActionHistoryCollectors;
		this.entityRelatedObjectsCollector = entityRelatedObjectsCollector;
		this.historyEnabledExtensions = historyEnabledExtensions;
	}

	public void CacheObjectHistory(long objectId, Guid objectTypeUid, long? lastActionDate)
	{
		if (HistoryRepository == null || !NeedCacheHistory(objectTypeUid))
		{
			return;
		}
		securityService.RunWithElevatedPrivilegies(delegate
		{
			Type typeByUid = metadataRuntimeService.GetTypeByUid(objectTypeUid);
			List<IEntityActionHistoryCollectorRelated> collectorsRelated = entityActionHistoryCollectorsRelated.Where((IEntityActionHistoryCollectorRelated collector) => collector.CanUse(objectId, objectTypeUid)).ToList();
			List<IEntityHistoryCollectorCacheble> source = entityRelatedObjectsCollector.Where((IEntityHistoryCollectorCacheble collector) => collector.CanUse(objectId, objectTypeUid)).ToList();
			IEnumerable<HistoryCollectorRelatedModel> seed = Enumerable.Empty<HistoryCollectorRelatedModel>();
			seed = source.Aggregate(seed, (IEnumerable<HistoryCollectorRelatedModel> current, IEntityHistoryCollectorCacheble collector) => current.Union(collector.RelatedObjects(objectId, objectTypeUid)));
			IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> enumerable = Enumerable.Empty<RelatedEntityActionHistoryUnitOfWorkModel>();
			if (seed.Any() || (objectId > 0 && !objectTypeUid.Equals(Guid.Empty)))
			{
				string text = "HistoryObject";
				HistoryRepository.CheckEntityHistoryTable(text);
				int? firstResult = null;
				int setting = SR.GetSetting("EntityHistoryPanel.LoadHistoryMaxResult", 10);
				bool value = false;
				int num = 0;
				if (entityActionHistoryCollectors.Any())
				{
					logger.Warn(SR.T("В системе задействованы устаревшие сборщики истории: {0}", string.Join(",", entityActionHistoryCollectors.Select((IEntityActionHistoryCollector a) => a.ToString()))));
				}
				enumerable = historyManager.GetNextUnitOfWorks(objectTypeUid, objectId, seed, firstResult, setting, value, lastActionDate, num);
				DataTable dataTable = CreateHistoryDataTable();
				while (enumerable.Any())
				{
					IEnumerable<EntityActionEventArgs> relatedEvents;
					IEnumerable<EntityActionEventArgs> eventList = LoadOldHistory(enumerable, collectorsRelated, seed, objectId, objectTypeUid, typeByUid, value, out relatedEvents);
					AddTableRowsFromEvents(dataTable, eventList, isRelatedEvent: false);
					AddTableRowsFromEvents(dataTable, relatedEvents, isRelatedEvent: true);
					HistoryRepository.CacheHistoryPart(text, dataTable);
					dataTable.Rows.Clear();
					RelatedEntityActionHistoryUnitOfWorkModel relatedEntityActionHistoryUnitOfWorkModel = enumerable.Last();
					long ticks = relatedEntityActionHistoryUnitOfWorkModel.ActionDate.Ticks;
					enumerable = historyManager.GetNextUnitOfWorks(objectTypeUid, objectId, seed, (int?)relatedEntityActionHistoryUnitOfWorkModel.Id, setting, value, ticks, (lastActionDate == ticks) ? num : 0);
				}
				dataTable.Dispose();
				HistoryRepository.BulkInsertHistoryRelatedObjects(objectId, objectTypeUid, seed.Select((HistoryCollectorRelatedModel r) => new KeyValuePair<long, Guid>(r.EntityId, r.EntityTypeUid)).Distinct());
			}
		});
	}

	public void UpdateTables(long objectId, Guid objectTypeUid, IEntity entity)
	{
		if (HistoryRepository == null || entity == null)
		{
			return;
		}
		IEnumerable<InverseRelatedEntityModel> enumerable = entityHistoryInverseCollectors.Where((IEntityHistoryInverseCollector c) => c.CanUse(entity)).SelectMany((IEntityHistoryInverseCollector c) => c.RelatedTo(entity)).Union(new InverseRelatedEntityModel[1]
		{
			new InverseRelatedEntityModel(objectId, objectTypeUid)
		})
			.Distinct();
		if (!enumerable.Any((InverseRelatedEntityModel obj) => NeedCacheHistory(obj.TypeUid)))
		{
			return;
		}
		historyUpdateQueueItemRepository.BulkInsertQueueItems(enumerable, forDelete: true);
		foreach (InverseRelatedEntityModel item in enumerable)
		{
			cacheService.Insert(HistoryUpdateQueueItemRepository.CacheKey(item.Id, item.TypeUid), HistoryUpdatingStatus.InProgress, "HistoryCacheRegion", TimeSpan.FromMinutes(HistoryConst.HistoryCacheStatusDuration));
		}
	}

	public void DeleteRecord(long objectId, Guid objectTypeUid)
	{
		HistoryRepository.ClearObserverTable(objectId, objectTypeUid);
		cacheService.Remove(HistoryUpdateQueueItemRepository.CacheKey(objectId, objectTypeUid), "HistoryCacheRegion");
	}

	public IEnumerable<InverseRelatedEntityModel> DeleteRecordsByType(Guid objectTypeUid)
	{
		IEnumerable<InverseRelatedEntityModel> enumerable = HistoryRepository.ClearObserverTableByType(objectTypeUid).Distinct();
		foreach (InverseRelatedEntityModel item in enumerable)
		{
			cacheService.Remove(HistoryUpdateQueueItemRepository.CacheKey(item.Id, item.TypeUid), "HistoryCacheRegion");
		}
		return enumerable;
	}

	public EntityHistoryModel GetHistoryModel(long objectId, Guid objectTypeUid, bool? orderDesc, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		if (HistoryRepository != null && NeedCacheHistory(objectTypeUid))
		{
			try
			{
				switch (cacheService.GetOrAdd(HistoryUpdateQueueItemRepository.CacheKey(objectId, objectTypeUid), () => GetUpdatingStatus(objectId, objectTypeUid), "HistoryCacheRegion", TimeSpan.FromMinutes(HistoryConst.HistoryCacheStatusDuration)))
				{
				case HistoryUpdatingStatus.Finished:
					return GetHistoryModelInternal(objectId, objectTypeUid, orderDesc, firstResult, maxResults, lastActionDate, packageIndex);
				case HistoryUpdatingStatus.NotStarted:
					historyUpdateQueueItemRepository.InsertQueueItem(objectId, objectTypeUid, forDelete: false);
					break;
				}
			}
			catch (Exception exception)
			{
				logger.Error(SR.T("Ошибка загрузки истории"), exception);
			}
		}
		return GetOldHistoryModelInternal(objectId, objectTypeUid, orderDesc, firstResult, maxResults, lastActionDate, packageIndex);
	}

	private void AddTableRowsFromEvents(DataTable table, IEnumerable<EntityActionEventArgs> eventList, bool isRelatedEvent)
	{
		foreach (EntityActionEventArgs @event in eventList)
		{
			if (@event.ExtendedProperties.ContainsKey("EntityActionHistory_Id") && @event.ExtendedProperties.ContainsKey("EntityActionHistory_Uid"))
			{
				IEntity entity = @event.New ?? @event.Old;
				table.Rows.Add((long)@event.ExtendedProperties["EntityActionHistory_Id"], (Guid)@event.ExtendedProperties["EntityActionHistory_Uid"], $"{(long?)entity.GetId()}_{InterfaceActivator.UID(entity.GetType())}", eventSerializationService.Serialize(@event), @event.ActionDate, Guid.Empty, 0, Guid.Empty, Guid.Empty, @event.UnitOfWorkUid, isRelatedEvent);
			}
		}
	}

	private DataTable CreateHistoryDataTable()
	{
		return new DataTable
		{
			Columns = 
			{
				{
					"Id",
					typeof(long)
				},
				{
					"Uid",
					typeof(Guid)
				},
				{
					"Object",
					typeof(string)
				},
				{
					"Model",
					typeof(string)
				},
				{
					"ActionDate",
					typeof(DateTime)
				},
				{
					"ActionTypeUid",
					typeof(Guid)
				},
				{
					"CreationAuthor",
					typeof(long)
				},
				{
					"EventArgsUid",
					typeof(Guid)
				},
				{
					"SessionUid",
					typeof(Guid)
				},
				{
					"UnitOfWorkUid",
					typeof(Guid)
				},
				{
					"IsRelatedEvent",
					typeof(bool)
				}
			}
		};
	}

	[Obsolete]
	private IEnumerable<EntityActionEventArgs> CollectOldHistory(long objectId, Guid objectTypeUid, IEnumerable<Guid> unitOfWorks)
	{
		IEnumerable<EntityActionEventArgs> seed = Enumerable.Empty<EntityActionEventArgs>();
		seed = entityActionHistoryCollectors.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollector collector) => current.Union(collector.CollectHistory(objectId, objectTypeUid)));
		return seed.Where((EntityActionEventArgs a) => unitOfWorks.Any((Guid uow) => uow.Equals(a.UnitOfWorkUid)));
	}

	private bool NeedCacheHistory(Guid objectTypeUid)
	{
		if (!(metadataRuntimeService.GetMetadata(objectTypeUid) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		return baseClasses.Any((ClassMetadata c) => historyEnabledExtensions.Any((IHistoryCacheEnabledExtension e) => e.BaseObjectTypeUid.Equals(c.Uid)));
	}

	private HistoryUpdatingStatus GetUpdatingStatus(long objectId, Guid objectTypeUid)
	{
		if (historyUpdateQueueItemRepository.HisotoryObjectUpdateInQueue(objectId, objectTypeUid))
		{
			return HistoryUpdatingStatus.InProgress;
		}
		return HistoryRepository.GetUpdatingStatus(objectId, objectTypeUid);
	}

	private EntityHistoryModel GetHistoryModelInternal(long objectId, Guid objectTypeUid, bool? orderDesc, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		metadataRuntimeService.GetTypeByUid(objectTypeUid);
		IEnumerable<EntityActionEventTuple> eventTuples = Enumerable.Empty<EntityActionEventTuple>();
		IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> enumerable = Enumerable.Empty<RelatedEntityActionHistoryUnitOfWorkModel>();
		if (objectId > 0 && !objectTypeUid.Equals(Guid.Empty))
		{
			bool flag = orderDesc.HasValue && orderDesc.Value;
			DateTime? lastActionDate2 = null;
			if (lastActionDate.HasValue)
			{
				lastActionDate2 = new DateTime(lastActionDate.Value).AddSeconds(flag ? 1 : (-1));
			}
			enumerable = GetNextUnitOfWorks(objectId, objectTypeUid, firstResult, maxResults, flag, lastActionDate2, packageIndex ?? 0, disableApplicationServerFilter: false);
			if (enumerable.Any())
			{
				eventTuples = HistoryRepository.LoadCachedHistory(objectId, objectTypeUid, enumerable.Select((RelatedEntityActionHistoryUnitOfWorkModel a) => a.UnitOfWorkUid), orderDesc.HasValue && orderDesc.Value);
			}
		}
		return new EntityHistoryModel
		{
			EventTuples = eventTuples,
			UnitOfWorks = enumerable
		};
	}

	private IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetNextUnitOfWorks(long objectId, Guid objectTypeUid, long? firstResult, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex, bool disableApplicationServerFilter)
	{
		IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> unitOfWorks = HistoryRepository.GetUnitOfWorks(objectId, objectTypeUid, maxResults, orderDesc, lastActionDate, packageIndex);
		if (!firstResult.HasValue || disableApplicationServerFilter || !unitOfWorks.Any())
		{
			return unitOfWorks;
		}
		bool flag = false;
		List<RelatedEntityActionHistoryUnitOfWorkModel> list = new List<RelatedEntityActionHistoryUnitOfWorkModel>();
		foreach (RelatedEntityActionHistoryUnitOfWorkModel item in unitOfWorks)
		{
			if (flag)
			{
				list.Add(item);
			}
			if (item.Id == firstResult)
			{
				flag = true;
			}
		}
		if (list.Any() || unitOfWorks.Count() < maxResults)
		{
			return list;
		}
		return GetNextUnitOfWorks(objectId, objectTypeUid, firstResult, maxResults, orderDesc, lastActionDate, packageIndex + 1, flag);
	}

	private EntityHistoryModel GetOldHistoryModelInternal(long objectId, Guid objectTypeUid, bool? orderDesc, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null)
	{
		Type typeByUid = metadataRuntimeService.GetTypeByUid(objectTypeUid);
		List<IEntityActionHistoryCollectorRelated> list = entityActionHistoryCollectorsRelated.Where((IEntityActionHistoryCollectorRelated collector) => collector.CanUse(objectId, objectTypeUid)).ToList();
		IEnumerable<HistoryCollectorRelatedModel> seed = Enumerable.Empty<HistoryCollectorRelatedModel>();
		seed = list.Aggregate(seed, (IEnumerable<HistoryCollectorRelatedModel> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.RelatedObjects(objectId, objectTypeUid)));
		IEnumerable<EntityActionEventArgs> eventList = null;
		IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> enumerable = Enumerable.Empty<RelatedEntityActionHistoryUnitOfWorkModel>();
		if (seed.Any() || (objectId > 0 && !objectTypeUid.Equals(Guid.Empty)))
		{
			enumerable = historyManager.GetNextUnitOfWorks(objectTypeUid, objectId, seed, firstResult, maxResults, orderDesc, lastActionDate, packageIndex);
			eventList = LoadOldHistory(enumerable, list, seed, objectId, objectTypeUid, typeByUid, orderDesc, out var _);
		}
		return new EntityHistoryModel
		{
			EventList = eventList,
			UnitOfWorks = enumerable
		};
	}

	private IEnumerable<EntityActionEventArgs> LoadOldHistory(IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> nextUnitOfWorks, IEnumerable<IEntityActionHistoryCollectorRelated> collectorsRelated, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, long objectId, Guid objectTypeUid, Type actionObjectType, bool? orderDesc, out IEnumerable<EntityActionEventArgs> relatedEvents)
	{
		IEnumerable<EntityActionEventArgs> relatedEventList = historyManager.LoadActionHistory(nextUnitOfWorks, objectId, objectTypeUid);
		IEnumerable<EntityActionEventArgs> seed = relatedEventList.Where((EntityActionEventArgs a) => a.EntityType == actionObjectType && (long)a.New.GetId() == objectId);
		seed = collectorsRelated.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.CollectHistory(objectId, objectTypeUid, relatedEventList, relatedObjects)));
		IEnumerable<Guid> unitOfWorks = seed.Select((EntityActionEventArgs a) => a.UnitOfWorkUid);
		seed = seed.Union(CollectOldHistory(objectId, objectTypeUid, unitOfWorks));
		relatedEvents = relatedEventList.Except(seed);
		if (orderDesc.HasValue && orderDesc.Value)
		{
			return seed.OrderByDescending((EntityActionEventArgs e) => e.ActionDate);
		}
		return seed.OrderBy((EntityActionEventArgs e) => e.ActionDate);
	}
}
