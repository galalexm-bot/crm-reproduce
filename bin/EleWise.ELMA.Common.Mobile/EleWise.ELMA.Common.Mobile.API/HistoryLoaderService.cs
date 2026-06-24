using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Mobile.API.Internal.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Common.Mobile.API.Internal;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("3852E286-0C10-43F6-91DA-B5E9EBE3BC47")]
internal class HistoryLoaderService : IHistoryLoaderService, IInternalAPIWebService
{
	private const string GuidS = "3852E286-0C10-43F6-91DA-B5E9EBE3BC47";

	private IMetadataRuntimeService metadataRuntimeService;

	private EntityActionHistoryManager historyManager;

	private IEnumerable<IEntityActionHistoryCollectorRelated> entityActionHistoryCollectorsRelated;

	private IEnumerable<IEntityActionHistoryCollector> entityActionHistoryCollectors;

	private IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	private EntityActionHistoryManager HistoryManager => historyManager ?? (historyManager = EntityActionHistoryManager.Instance);

	private IEnumerable<IEntityActionHistoryCollectorRelated> EntityActionHistoryCollectorsRelated => entityActionHistoryCollectorsRelated ?? (entityActionHistoryCollectorsRelated = Locator.GetServiceNotNull<IEnumerable<IEntityActionHistoryCollectorRelated>>());

	private IEnumerable<IEntityActionHistoryCollector> EntityActionHistoryCollectors => entityActionHistoryCollectors ?? (entityActionHistoryCollectors = Locator.GetServiceNotNull<IEnumerable<IEntityActionHistoryCollector>>());

	public WebData Load(string typeUid, string entityId, GetEntityHistoryRequest historyRequest)
	{
		if (!Guid.TryParse(typeUid, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат типа объекта, должен быть Guid"), 400);
		}
		if (!long.TryParse(entityId, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат типа объекта, должен быть long"), 400);
		}
		return Load(result, result2, historyRequest);
	}

	public WebData Load(Guid typeUid, long entityId, IGetEntityHistoryRequest historyRequest)
	{
		if (historyRequest == null)
		{
			historyRequest = new GetEntityHistoryRequest();
		}
		Pair<IEnumerable<EntityActionEventArgs>, IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel>> entityHistory = GetEntityHistory(entityId, typeUid, historyRequest.OrderDesc, historyRequest.FirstResult, historyRequest.MaxResults, historyRequest.LastActionDate, historyRequest.PackageIndex);
		WebData[] dataArray = entityHistory.First.Select(GetWebDataFromEvent).ToArray();
		WebData webData = new WebData();
		webData.Items = new WebDataItem[2]
		{
			new WebDataItem
			{
				Name = "Info",
				Data = GetAdditionalData(entityHistory.Second, historyRequest.PackageIndex, historyRequest.LastActionDate)
			},
			new WebDataItem
			{
				Name = "History",
				DataArray = dataArray
			}
		};
		return webData.UpdateVersion();
	}

	private Pair<IEnumerable<EntityActionEventArgs>, IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel>> GetEntityHistory(long objectId, Guid objectTypeUid, bool? orderDesc, int? firstResult, int? maxResults, long? lastActionDate, int? packageIndex)
	{
		Type actionObjectType = MetadataRuntimeService.GetTypeByUid(objectTypeUid);
		IEnumerable<IEntityActionHistoryCollectorRelated> source = EntityActionHistoryCollectorsRelated.Where((IEntityActionHistoryCollectorRelated collector) => collector.CanUse(objectId, objectTypeUid));
		IEnumerable<HistoryCollectorRelatedModel> relatedObjects = Enumerable.Empty<HistoryCollectorRelatedModel>();
		relatedObjects = source.Aggregate(relatedObjects, (IEnumerable<HistoryCollectorRelatedModel> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.RelatedObjects(objectId, objectTypeUid)));
		if (!lastActionDate.HasValue && orderDesc.HasValue && orderDesc.Value)
		{
			lastActionDate = DateTime.Now.Ticks;
		}
		IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> nextUnitOfWorks = HistoryManager.GetNextUnitOfWorks(objectTypeUid, objectId, relatedObjects, firstResult, maxResults, orderDesc, lastActionDate, packageIndex);
		IEnumerable<EntityActionEventArgs> relatedEventList = HistoryManager.LoadHistoryRelated(nextUnitOfWorks);
		IEnumerable<EntityActionEventArgs> seed = relatedEventList.Where((EntityActionEventArgs a) => a.EntityType == actionObjectType && (long)a.New.GetId() == objectId);
		seed = source.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollectorRelated collector) => current.Union(collector.CollectHistory(objectId, objectTypeUid, relatedEventList, relatedObjects)));
		IEnumerable<Guid> unitOfWorks = seed.Select((EntityActionEventArgs a) => a.UnitOfWorkUid);
		seed = seed.Union(CollectOldHistory(objectId, objectTypeUid, unitOfWorks));
		seed = ((!orderDesc.HasValue || !orderDesc.Value) ? seed.OrderBy((EntityActionEventArgs e) => e.ActionDate) : seed.OrderByDescending((EntityActionEventArgs e) => e.ActionDate));
		return new Pair<IEnumerable<EntityActionEventArgs>, IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel>>(seed, nextUnitOfWorks);
	}

	private WebData GetWebDataFromEvent(EntityActionEventArgs @event)
	{
		return new WebData(new Dictionary<string, object>
		{
			{
				"Action",
				(@event.Action != null) ? GetWebDataFromAuditAction(@event.Action) : null
			},
			{
				"Object",
				(@event.Object != null) ? GetWebDataFromAuditObject(@event.Object) : null
			},
			{
				"Old",
				(@event.Old != null) ? WebData.CreateFromEntity(@event.Old) : null
			},
			{
				"New",
				(@event.New != null) ? WebData.CreateFromEntity(@event.New) : null
			},
			{
				"ActionAuthor",
				(@event.ActionAuthor != null) ? WebData.CreateFromEntity(@event.ActionAuthor as IEntity) : null
			},
			{ "ActionDate", @event.ActionDate },
			{
				"ExtendedProperties",
				new WebData(@event.ExtendedProperties)
			}
		});
	}

	private WebData GetWebDataFromAuditAction(IAuditAction auditAction)
	{
		return new WebData(new Dictionary<string, object>
		{
			{ "Uid", auditAction.Uid },
			{ "Name", auditAction.Name },
			{ "DisplayName", auditAction.DisplayName },
			{ "Description", auditAction.Description }
		});
	}

	private WebData GetWebDataFromAuditObject(IAuditObject auditObject)
	{
		return new WebData(new Dictionary<string, object>
		{
			{ "Uid", auditObject.Uid },
			{
				"TypeUid",
				auditObject.Type.Uid
			},
			{
				"Parent",
				(auditObject.Parent != null) ? GetWebDataFromAuditObject(auditObject.Parent) : null
			},
			{ "Name", auditObject.Name },
			{ "DisplayName", auditObject.DisplayName }
		});
	}

	private WebData GetAdditionalData(IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> unitOfWorks, int? packageIndex = null, long? lastActionDate = null)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (unitOfWorks.Any())
		{
			RelatedEntityActionHistoryUnitOfWorkModel relatedEntityActionHistoryUnitOfWorkModel = unitOfWorks.Last();
			if (relatedEntityActionHistoryUnitOfWorkModel != null)
			{
				long ticks = relatedEntityActionHistoryUnitOfWorkModel.ActionDate.Ticks;
				dictionary["lastPackage"] = false;
				dictionary["lastId"] = relatedEntityActionHistoryUnitOfWorkModel.Id;
				dictionary["lastActionDate"] = ticks;
				dictionary["packageIndex"] = ((lastActionDate == ticks) ? packageIndex : new int?(0));
			}
		}
		else
		{
			dictionary["lastPackage"] = true;
		}
		return new WebData(dictionary);
	}

	[Obsolete]
	private IEnumerable<EntityActionEventArgs> CollectOldHistory(long id, Guid actionObject, IEnumerable<Guid> unitOfWorks)
	{
		IEnumerable<EntityActionEventArgs> seed = Enumerable.Empty<EntityActionEventArgs>();
		seed = EntityActionHistoryCollectors.Aggregate(seed, (IEnumerable<EntityActionEventArgs> current, IEntityActionHistoryCollector collector) => current.Union(collector.CollectHistory(id, actionObject)));
		return seed.Where((EntityActionEventArgs a) => unitOfWorks.Any((Guid ofw) => ofw.Equals(a.UnitOfWorkUid)));
	}
}
