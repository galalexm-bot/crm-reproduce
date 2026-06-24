using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{B637ED43-B940-4124-B1B9-5D5302B5BED1}")]
public class EntityHeadService : IEntityHeadService, ICorePublicService
{
	public const string GuidS = "{B637ED43-B940-4124-B1B9-5D5302B5BED1}";

	public static Guid Guid = new Guid("{B637ED43-B940-4124-B1B9-5D5302B5BED1}");

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public WebData Load(string typeuid, string entityid)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				Type entityType = GetEntityType(result);
				if (entityType != null)
				{
					IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
					if (entityManager != null)
					{
						if (Guid.TryParse(entityid, out var result2))
						{
							return WebData.CreateFromEntity(entityManager.Load(result2) as IEntity, EntityService.PropertyForHeadFilter, EntityService.TablePartForHeadFilter);
						}
						if (long.TryParse(entityid, out var result3))
						{
							return WebData.CreateFromEntity(entityManager.Load(result3) as IEntity, EntityService.PropertyForHeadFilter, EntityService.TablePartForHeadFilter).UpdateVersion();
						}
						throw PublicServiceException.CreateWebFault(SR.T("Идентификатор сущности {0} невозможно привести к типу System.Guid или System.Int64", entityid), 400);
					}
					throw PublicServiceException.CreateWebFault(SR.T("Не найден менеджер сущности для типа {0}", entityType), 404);
				}
				throw PublicServiceException.CreateWebFault(SR.T("Не найден тип сущности по идентификатору {0}", typeuid), 404);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор типа сущности {0} невозможно привести к типу System.Guid", typeuid), 400);
		}
		catch (ObjectNotFoundException ex)
		{
			throw PublicServiceException.CreateWebFault(ex.Message, 404);
		}
		catch (SecurityException ex2)
		{
			throw PublicServiceException.CreateWebFault(ex2.Message, 401);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex4)
		{
			throw PublicServiceException.CreateWebFault(ex4.ToString(), 500);
		}
	}

	public IEnumerable<WebData> Query(string typeuid, string eqlQuery, string sort, int limit = 0, int offset = 0, string filterProviderUid = null, string filterProviderData = null, string filter = null)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				Type entityType = GetEntityType(result);
				if (entityType != null)
				{
					if (ModelHelper.GetEntityManager(entityType) != null)
					{
						Guid? filterProviderUid2 = ((!string.IsNullOrEmpty(filterProviderUid)) ? new Guid?(Guid.Parse(filterProviderUid)) : null);
						return (from entity in EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid2, filterProviderData, filter)
							select WebData.CreateFromEntity(entity, EntityService.PropertyForHeadFilter, EntityService.TablePartForHeadFilter).UpdateVersion()).ToList();
					}
					throw PublicServiceException.CreateWebFault(SR.T("Не найден менеджер сущности для типа {0}", entityType), 404);
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
			throw PublicServiceException.CreateWebFault(ex2.ToString(), 500);
		}
	}

	public IEnumerable<WebData> QuerySimple(string typeuid, string search, string eqlQuery, string sort = null, int limit = 100, string filterProviderUid = null, string filterProviderData = null, string filter = null)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				Type entityType = GetEntityType(result);
				if (entityType != null)
				{
					if (ModelHelper.GetEntityManager(entityType) != null)
					{
						Guid? filterProviderUid2 = ((!string.IsNullOrEmpty(filterProviderUid)) ? new Guid?(Guid.Parse(filterProviderUid)) : null);
						return EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, 0, filterProviderUid2, filterProviderData, filter).Select(delegate(IEntity entity)
						{
							ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.GetType());
							Guid uid = classMetadata.Uid;
							while (classMetadata.TitlePropertyUid == Guid.Empty && classMetadata.BaseClassUid != Guid.Empty)
							{
								classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(classMetadata.BaseClassUid);
							}
							IPropertyMetadata uidProperty = classMetadata.GetUidProperty();
							return new WebData(new Dictionary<string, object>
							{
								{
									"Id",
									entity.GetId()
								},
								{ "TypeUid", uid },
								{
									"Uid",
									(uidProperty != null) ? entity.GetPropertyValue(uidProperty.PropertyUid) : ((object)Guid.Empty)
								},
								{
									"Name",
									(classMetadata.TitlePropertyUid != Guid.Empty) ? entity.GetPropertyValue(classMetadata.GetTitlePropertyUid()) : ""
								}
							}).UpdateVersion();
						}).ToList();
					}
					throw PublicServiceException.CreateWebFault(SR.T("Не найден менеджер сущности для типа {0}", entityType), 404);
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
			throw PublicServiceException.CreateWebFault(ex2.ToString(), 500);
		}
	}

	public string Link(string typeuid, string entityid)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				return UrlExtensions.Entity(new UrlHelper(new RequestContext(HttpContextAccessor.CurrentContext, RouteTable.Routes.GetRouteData(HttpContextAccessor.CurrentContext))), result, entityid);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор типа сущности {0} невозможно привести к типу System.Guid", typeuid), 400);
		}
		catch (ObjectNotFoundException ex)
		{
			throw PublicServiceException.CreateWebFault(ex.Message, 404);
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex3)
		{
			throw PublicServiceException.CreateWebFault(ex3.ToString(), 500);
		}
	}

	private static Type GetEntityType(Guid typeUid)
	{
		return Locator.GetServiceNotNull<PublicMetadataService>().GetTypeByUid(typeUid);
	}
}
