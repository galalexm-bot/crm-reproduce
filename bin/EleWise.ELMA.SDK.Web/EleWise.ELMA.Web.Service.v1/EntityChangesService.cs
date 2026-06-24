using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{6C00E040-A273-415E-B048-6632821B8DDD}")]
public class EntityChangesService : IEntityChangesService, ICorePublicService
{
	public const string GuidS = "{6C00E040-A273-415E-B048-6632821B8DDD}";

	public static Guid Guid = new Guid("{6C00E040-A273-415E-B048-6632821B8DDD}");

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public bool IsSupported(string typeuid)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var typeUid))
			{
				if (Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid) != null)
				{
					return (from l in ComponentManager.Current.GetExtensionPoints<IEntityChangesLoader>()
						where l.IsTypeSupported(typeUid)
						select l).ToArray().Any();
				}
				throw PublicServiceException.CreateWebFault(SR.T("Не найден тип сущности по идентификатору {0}", typeuid), 404);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор типа сущности {0} невозможно привести к типу System.Guid", typeuid), 400);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.ToString(), 500);
		}
	}

	public EntityChangesResponse Changes(string typeuid, DateTime fromServerTime, string eqlQuery)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var typeUid))
			{
				if (Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid) != null)
				{
					IEntityChangesLoader[] source = (from l in ComponentManager.Current.GetExtensionPoints<IEntityChangesLoader>()
						where l.IsTypeSupported(typeUid)
						select l).ToArray();
					if (!source.Any())
					{
						throw PublicServiceException.CreateWebFault(SR.T("Не найдено ни одного счетчика изменений для типа {0}", typeuid), 501);
					}
					return ReturnChangesResponse(source.SelectMany((IEntityChangesLoader l) => l.LoadChanges(typeUid, fromServerTime, eqlQuery)).ToArray(), typeUid, fromServerTime, eqlQuery);
				}
				throw PublicServiceException.CreateWebFault(SR.T("Не найден тип сущности по идентификатору {0}", typeuid), 404);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор типа сущности {0} невозможно привести к типу System.Guid", typeuid), 400);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public bool ChangesCommit(Guid id)
	{
		try
		{
			EntityChangesResponse entityChangesResponse = PopFromCache(id);
			if (entityChangesResponse != null)
			{
				return CommitRequestData(entityChangesResponse);
			}
			return false;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	public bool Sync(EntityChangesSyncRequest changes)
	{
		try
		{
			IPublicCacheService serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
			Guid guidToken = APIRouteProvider.GetGuidToken("AuthToken");
			return serviceNotNull.SyncCache(guidToken, Guid.Parse(changes.TypeUid), changes.Now, changes.List, changes.EQL);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			Logger.Error(ex2);
			throw PublicServiceException.CreateWebFault(ex2.Message, 500);
		}
	}

	private static bool CommitRequestData(EntityChangesResponse responseData)
	{
		IPublicCacheService serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
		Guid guidToken = APIRouteProvider.GetGuidToken("AuthToken");
		return serviceNotNull.UpdateCache(guidToken, responseData.TypeUid, responseData.FromDate, responseData.Updated, responseData.Deleted, responseData.EQL);
	}

	private static EntityChangesResponse ReturnChangesResponse(IEnumerable<IEntityModelHistoryItem> allEntities, Guid typeUid, DateTime fromServerTime, string eqlQuery)
	{
		EntityChangesResponse obj = new EntityChangesResponse
		{
			Now = DateTime.Now,
			TypeUid = typeUid,
			EQL = eqlQuery,
			FromDate = fromServerTime
		};
		IGrouping<long, IEntityModelHistoryItem>[] source = (from h in allEntities
			group h by h.ObjectId).ToArray();
		IGrouping<long, IEntityModelHistoryItem>[] deleted = source.Where((IGrouping<long, IEntityModelHistoryItem> g) => g.Any((IEntityModelHistoryItem h) => h.ActionTypeUid == DefaultEntityActions.DeleteGuid)).ToArray();
		IGrouping<long, IEntityModelHistoryItem>[] source2 = source.Where((IGrouping<long, IEntityModelHistoryItem> g) => !deleted.Contains(g)).ToArray();
		obj.Deleted = deleted.Select((IGrouping<long, IEntityModelHistoryItem> items) => items.Key).ToArray();
		obj.Updated = source2.Select((IGrouping<long, IEntityModelHistoryItem> items) => items.Key).ToArray();
		return AddToCache(obj);
	}

	private static EntityChangesResponse AddToCache(EntityChangesResponse response)
	{
		Guid id = (response.Id = ((response.Id == Guid.Empty) ? Guid.NewGuid() : response.Id));
		Locator.GetServiceNotNull<ICacheService>().Insert(GetCacheKey(id), response, TimeSpan.FromHours(8.0));
		return response;
	}

	private EntityChangesResponse PopFromCache(Guid id)
	{
		return Locator.GetServiceNotNull<ICacheService>().Get<EntityChangesResponse>(GetCacheKey(id));
	}

	private static string GetCacheKey(Guid id)
	{
		return "EntityChangesService_ResponseCache_" + id;
	}
}
