using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{18CCDCD2-FC7D-42EE-A647-69E1FC2CE51A}")]
public class BatchOperationService : IBatchOperationService, ICorePublicService
{
	public const string GuidS = "{18CCDCD2-FC7D-42EE-A647-69E1FC2CE51A}";

	public static Guid Guid = new Guid("{18CCDCD2-FC7D-42EE-A647-69E1FC2CE51A}");

	public EntityQueryResponse[] Query(EntityQueryRequest[] requests)
	{
		if (requests == null || requests.Length == 0)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Необходимо указать запросы в теле"), 400);
		}
		List<EntityQueryResponse> list = new List<EntityQueryResponse>();
		EntitySerializationSettings serializationSettings;
		foreach (EntityQueryRequest entityQueryRequest in requests)
		{
			try
			{
				IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				Type entityType = GetEntityType(entityQueryRequest.TypeUid);
				if (entityType != null)
				{
					if (ModelHelper.GetEntityManager(entityType) != null)
					{
						IEnumerable<IEntity> source = EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, entityQueryRequest.EQLQuery, entityQueryRequest.Sort, entityQueryRequest.Limit, entityQueryRequest.Offset, entityQueryRequest.FilterProviderUid, entityQueryRequest.FilterProviderData);
						EntityMetadata entityMetadata = serviceNotNull.GetMetadata(entityQueryRequest.TypeUid) as EntityMetadata;
						serializationSettings = null;
						if (!string.IsNullOrWhiteSpace(entityQueryRequest.Select) && entityMetadata != null)
						{
							serializationSettings = new EntitySerializationSettings
							{
								Mode = EntitySerializationMode.Default,
								PropertySelector = EntitySerializationSelector.CreateFromSelect(entityQueryRequest.Select, entityMetadata)
							};
						}
						Func<IEntity, WebData> selector = ((serializationSettings != null) ? ((Func<IEntity, WebData>)((IEntity entity) => WebData.CreateFromEntity(entity, serializationSettings).UpdateVersion())) : ((Func<IEntity, WebData>)((IEntity entity) => WebData.CreateFromEntity(entity).UpdateVersion())));
						List<WebData> list2 = source.Select(selector).ToList();
						list.Add(new EntityQueryResponse
						{
							Data = list2,
							Count = list2.Count
						});
					}
					else
					{
						list.Add(new EntityQueryResponse
						{
							Exception = new PublicServiceException(SR.T("Не найден менеджер сущности для типа {0}", entityType), 404)
						});
					}
				}
				else
				{
					list.Add(new EntityQueryResponse
					{
						Exception = new PublicServiceException(SR.T("Не найден тип сущности по идентификатору {0}", entityQueryRequest.TypeUid), 404)
					});
				}
			}
			catch (ObjectNotFoundException ex)
			{
				list.Add(new EntityQueryResponse
				{
					Exception = new PublicServiceException(ex.Message, 404)
				});
			}
			catch (SecurityException ex2)
			{
				list.Add(new EntityQueryResponse
				{
					Exception = new PublicServiceException(ex2.Message, 401)
				});
			}
			catch (FaultException exception)
			{
				list.Add(new EntityQueryResponse
				{
					Exception = new PublicServiceException(exception)
				});
			}
			catch (Exception ex3)
			{
				list.Add(new EntityQueryResponse
				{
					Exception = new PublicServiceException(ex3.ToString(), 500)
				});
			}
		}
		return list.ToArray();
	}

	private static Type GetEntityType(Guid typeUid)
	{
		return Locator.GetServiceNotNull<PublicMetadataService>().GetTypeByUid(typeUid);
	}
}
