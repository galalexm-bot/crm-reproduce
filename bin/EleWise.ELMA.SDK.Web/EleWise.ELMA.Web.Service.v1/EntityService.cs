using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.UserDefinedList;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{FAF9318B-FF81-471B-B8D1-0913B30DD87F}")]
public class EntityService : IEntityService, ICorePublicService
{
	public const string GuidS = "{FAF9318B-FF81-471B-B8D1-0913B30DD87F}";

	public static Guid Guid = new Guid("{FAF9318B-FF81-471B-B8D1-0913B30DD87F}");

	private static IEnumerable<IUserDefinedListExecutionHandler> userDefinedListExecutionHandler;

	internal static readonly Func<PropertyMetadata, bool> PropertyForHeadFilter = delegate(PropertyMetadata p)
	{
		if (p.IsSystem)
		{
			return true;
		}
		bool visible = p.ViewSettings.GetForView(ViewType.List).Visible;
		bool flag = true;
		if (p.Settings is EntitySettings entitySettings)
		{
			flag = entitySettings.RelationType == RelationType.OneToOne;
		}
		return visible && flag;
	};

	internal static readonly Func<ITablePartMetadata, bool> TablePartForHeadFilter = (ITablePartMetadata p) => false;

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	private static IEnumerable<IUserDefinedListExecutionHandler> UserDefinedListExecutionHandler => userDefinedListExecutionHandler ?? (userDefinedListExecutionHandler = Locator.GetServiceNotNull<IEnumerable<IUserDefinedListExecutionHandler>>());

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
						EntitySerializationSettings settings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						if (Guid.TryParse(entityid, out var result2))
						{
							return WebData.CreateFromEntity(entityManager.Load(result2) as IEntity, settings).UpdateVersion();
						}
						if (long.TryParse(entityid, out var result3))
						{
							return WebData.CreateFromEntity(entityManager.Load(result3) as IEntity, settings).UpdateVersion();
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

	public WebData LoadTree(string typeuid, string entityid, string select)
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
						EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
						EntitySerializationSettings settings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						if (!string.IsNullOrWhiteSpace(select) && entityMetadata != null)
						{
							settings = new EntitySerializationSettings
							{
								CheckPropertyPermissions = true,
								Mode = EntitySerializationMode.Default,
								PropertySelector = EntitySerializationSelector.CreateFromSelect(select, entityMetadata)
							};
						}
						if (Guid.TryParse(entityid, out var result2))
						{
							return WebData.CreateFromEntity(entityManager.Load(result2) as IEntity, settings).UpdateVersion();
						}
						if (long.TryParse(entityid, out var result3))
						{
							return WebData.CreateFromEntity(entityManager.Load(result3) as IEntity, settings).UpdateVersion();
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

	public WebData LoadTreeWithDependencies(string typeuid, string entityid, string select, EntityTypeSerializationSettings[] entityTypeSerializationSettings)
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
						EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						bool flag = entityTypeSerializationSettings != null && entityTypeSerializationSettings.Length != 0;
						bool flag2 = !string.IsNullOrWhiteSpace(select);
						if (flag || flag2)
						{
							entitySerializationSettings = new EntitySerializationSettings
							{
								CheckPropertyPermissions = true,
								Mode = EntitySerializationMode.Default
							};
							if (flag)
							{
								IEnumerable<EntityTypeSerializationSettings> source = entityTypeSerializationSettings.Where((EntityTypeSerializationSettings a) => a.Properties != null && a.Properties.Count > 0);
								entitySerializationSettings.TypePropertySelector = source.ToDictionary((EntityTypeSerializationSettings a) => a.TypeUid, delegate(EntityTypeSerializationSettings d)
								{
									EntityMetadata entityMd2 = MetadataLoader.LoadMetadata(d.TypeUid) as EntityMetadata;
									List<string> properties = d.Properties;
									if (!properties.Contains("Uid"))
									{
										properties.Add("Uid");
									}
									return EntitySerializationSelector.CreateFromSelect(string.Join(",", properties), entityMd2);
								});
								entitySerializationSettings.WriteReferences = true;
							}
							if (flag2 && MetadataLoader.LoadMetadata(entityType) is EntityMetadata entityMd)
							{
								entitySerializationSettings.PropertySelector = EntitySerializationSelector.CreateFromSelect(select, entityMd);
							}
						}
						if (Guid.TryParse(entityid, out var result2))
						{
							return WebData.CreateFromEntity(entityManager.Load(result2) as IEntity, entitySerializationSettings).UpdateVersion();
						}
						if (long.TryParse(entityid, out var result3))
						{
							return WebData.CreateFromEntity(entityManager.Load(result3) as IEntity, entitySerializationSettings).UpdateVersion();
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

	public long Count(string typeuid, string eqlQuery, string filterProviderUid = null, string filterProviderData = null, string filter = null)
	{
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				Type entityType = GetEntityType(result);
				if (entityType != null)
				{
					Guid? filterProviderUid2 = ((!string.IsNullOrEmpty(filterProviderUid)) ? new Guid?(Guid.Parse(filterProviderUid)) : null);
					return EntityQueryHelper.CountAllEntitiesWithFilter(entityType, eqlQuery, filterProviderUid2, filterProviderData, filter);
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

	public IEnumerable<WebData> Query(string typeuid, string eqlQuery, string sort, int limit = 0, int offset = 0, string filterProviderUid = null, string filterProviderData = null, string filter = null, bool loadDisplayName = false)
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
						IEnumerable<IEntity> source = EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid2, filterProviderData, filter);
						EntitySerializationSettings serializationSettings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						return source.Select((IEntity entity) => WebData.CreateFromEntity(entity, serializationSettings, loadDisplayName).UpdateVersion()).ToList();
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

	public IEnumerable<WebData> QueryTree(string typeuid, string eqlQuery, string select, string sort, int limit = 0, int offset = 0, string filterProviderUid = null, string filterProviderData = null, string filter = null)
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
						IEnumerable<IEntity> source = EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid2, filterProviderData, filter);
						EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
						EntitySerializationSettings serializationSettings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						if (!string.IsNullOrWhiteSpace(select) && entityMetadata != null)
						{
							serializationSettings = new EntitySerializationSettings
							{
								CheckPropertyPermissions = true,
								Mode = EntitySerializationMode.Default,
								PropertySelector = EntitySerializationSelector.CreateFromSelect(select, entityMetadata)
							};
						}
						return source.Select((IEntity entity) => WebData.CreateFromEntity(entity, serializationSettings).UpdateVersion()).ToList();
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

	public IEnumerable<WebData> QueryTreeWithDependencies(string typeuid, string eqlQuery, string select, EntityTypeSerializationSettings[] entityTypeSerializationSettings, string sort, int limit = 0, int offset = 0, string filterProviderUid = null, string filterProviderData = null, string filter = null)
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
						IEnumerable<IEntity> source = EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid2, filterProviderData, filter);
						EntitySerializationSettings serializationSettings = new EntitySerializationSettings
						{
							CheckPropertyPermissions = true
						};
						bool flag = entityTypeSerializationSettings != null && entityTypeSerializationSettings.Length != 0;
						bool flag2 = !string.IsNullOrWhiteSpace(select);
						if (flag || flag2)
						{
							serializationSettings = new EntitySerializationSettings
							{
								CheckPropertyPermissions = true,
								Mode = EntitySerializationMode.Default
							};
							if (flag)
							{
								IEnumerable<EntityTypeSerializationSettings> source2 = entityTypeSerializationSettings.Where((EntityTypeSerializationSettings a) => a.Properties != null && a.Properties.Count > 0);
								serializationSettings.TypePropertySelector = source2.ToDictionary((EntityTypeSerializationSettings a) => a.TypeUid, delegate(EntityTypeSerializationSettings d)
								{
									EntityMetadata entityMd2 = MetadataLoader.LoadMetadata(d.TypeUid) as EntityMetadata;
									List<string> properties = d.Properties;
									if (!properties.Contains("Uid"))
									{
										properties.Add("Uid");
									}
									return EntitySerializationSelector.CreateFromSelect(string.Join(",", properties), entityMd2);
								});
								serializationSettings.WriteReferences = true;
							}
							if (flag2 && MetadataLoader.LoadMetadata(entityType) is EntityMetadata entityMd)
							{
								serializationSettings.PropertySelector = EntitySerializationSelector.CreateFromSelect(select, entityMd);
							}
						}
						return source.Select((IEntity entity) => WebData.CreateFromEntity(entity, serializationSettings).UpdateVersion()).ToList();
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

	public IEnumerable<WebData> UserDefinedListQuery(Guid userDefinedListUid, Guid modelSubTypeUid)
	{
		try
		{
			IEnumerable<object> enumerable = (UserDefinedListExecutionHandler.FirstOrDefault() ?? throw PublicServiceException.CreateWebFault(SR.T("Не найдена реализация для исполнения скрипта"), 404)).ExecuteGetUserDefinedList(modelSubTypeUid, userDefinedListUid);
			SerializableList<WebData> serializableList = new SerializableList<WebData>();
			foreach (object item in enumerable)
			{
				IEnumerable<KeyValuePair<string, object>> obj = item as IEnumerable<KeyValuePair<string, object>>;
				SerializableList<KeyValuePair<string, object>> serializableList2 = new SerializableList<KeyValuePair<string, object>>();
				foreach (KeyValuePair<string, object> item2 in obj)
				{
					object value = item2.Value;
					if (value is ICollection<KeyValuePair<string, object>>)
					{
						serializableList2.Add(new KeyValuePair<string, object>(item2.Key, new WebData(value as ICollection<KeyValuePair<string, object>>).UpdateVersion()));
					}
					else
					{
						serializableList2.Add(item2);
					}
				}
				serializableList.Add(new WebData(serializableList2).UpdateVersion());
			}
			return serializableList;
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

	public string Insert(string typeuid, WebData entityData)
	{
		if (entityData == null || entityData.Items == null || entityData.Items.Length == 0)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Необходимо передать входные данные для выполнения метода"), 400);
		}
		Type type = null;
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				type = GetEntityType(result);
				if (type != null)
				{
					if (ModelHelper.GetEntityManager(type) != null)
					{
						if (new EntityJsonSerializer().ConvertFromSerializable(entityData.ToDictionary(), type) is IEntity entity)
						{
							if (!entity.IsNew())
							{
								throw PublicServiceException.CreateWebFault(SR.T("Невозможно сохранить объект, т.к. идентификатор уже задан. Используйте для обновления метод Update"), 400);
							}
							entity.Save();
							return entity.GetId().ToString();
						}
						throw PublicServiceException.CreateWebFault(SR.T("Невозможно построить объект типа {0} по входным данным", type), 400);
					}
					throw PublicServiceException.CreateWebFault(SR.T("Не найден менеджер сущности для типа {0}", type), 404);
				}
				throw PublicServiceException.CreateWebFault(SR.T("Не найден тип сущности по идентификатору {0}", typeuid), 404);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор типа сущности {0} невозможно привести к типу System.Guid", typeuid), 400);
		}
		catch (ElmaInvalidOperationException innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Невозможно сохранить объект типа {0}.", type), new Exception("", innerException), 401);
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

	public string Update(string typeuid, string entityid, WebData entityData)
	{
		if (entityData == null || entityData.Items == null || entityData.Items.Length == 0)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Необходимо передать входные данные для выполнения метода"), 400);
		}
		Type type = null;
		try
		{
			if (Guid.TryParse(typeuid, out var result))
			{
				type = GetEntityType(result);
				if (type != null)
				{
					IEntityManager entityManager = ModelHelper.GetEntityManager(type);
					if (entityManager != null)
					{
						IEntity entity = null;
						if (Guid.TryParse(entityid, out var result2))
						{
							entity = entityManager.Load(result2) as IEntity;
						}
						if (entity == null && long.TryParse(entityid, out var result3))
						{
							entity = entityManager.Load(result3) as IEntity;
						}
						if (entity != null)
						{
							if (new EntityJsonSerializer().ConvertFromSerializable(entity, entityData.ToDictionary()) is IEntity entity2)
							{
								entityManager.Save(entity2);
								return entity2.GetId().ToString();
							}
							throw PublicServiceException.CreateWebFault(SR.T("Невозможно обновить объект типа {0} по входным данным", type), 400);
						}
						throw PublicServiceException.CreateWebFault(SR.T("Идентификатор сущности {0} невозможно привести к типу System.Guid или System.Int64", entityid), 400);
					}
					throw PublicServiceException.CreateWebFault(SR.T("Не найден менеджер сущности для типа {0}", type), 404);
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
		catch (ElmaInvalidOperationException innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Невозможно обновить объект типа {0}.", type), new Exception("", innerException), 401);
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

	public bool IsBaseOrChildEntityType(string typeUid, string baseTypeUid)
	{
		if (!Guid.TryParse(baseTypeUid, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Uid типа сущности baseTypeUid='{0}' невозможно привести к типу System.Guid", baseTypeUid), 400);
		}
		if (!Guid.TryParse(typeUid, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Uid типа сущности typeUid='{0}' невозможно привести к типу System.Guid", typeUid), 400);
		}
		return MetadataLoader.IsBaseOrChildClass(result, result2);
	}

	private static Type GetEntityType(Guid typeUid)
	{
		return Locator.GetServiceNotNull<PublicMetadataService>().GetTypeByUid(typeUid);
	}
}
