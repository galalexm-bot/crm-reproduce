using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components.WorkLog;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogItemSearchQueryBuilder
{
	private readonly ISession session;

	private readonly IWorkLogObjectSearchFilter filter;

	private readonly WorkLogSearchProviderBase searchProvider;

	public WorkLogItemSearchQueryBuilder(ISession session, IWorkLogObjectSearchFilter filter, WorkLogSearchProviderBase searchProvider = null)
	{
		this.session = session;
		this.filter = filter;
		this.searchProvider = searchProvider;
	}

	public ISQLQuery CreateObjectQuery<T>(bool isObjectSearch = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		EleWise.ELMA.Helpers.SqlQueryBuilder sqlQueryBuilder = new EleWise.ELMA.Helpers.SqlQueryBuilder(session);
		List<WorkLogItemSearchGroup> list = new List<WorkLogItemSearchGroup>();
		foreach (IWorkLogExtension item in from e in WorkLogExtensionHelper.ExtensionList()
			where e.BaseObjectUid != Guid.Empty
			select e)
		{
			foreach (Guid objectTypeUid in item.EnabledObjectTypes())
			{
				if (ModelHelper.GetEntityType(objectTypeUid) == null)
				{
					continue;
				}
				List<IWorkLogObjectSearchExtension> list2 = (from e in GetWorkLogItemSearchExtensions()
					where e.ObjectTypeUids.Contains(objectTypeUid)
					select e).ToList();
				if (!list2.Any())
				{
					list2 = new List<IWorkLogObjectSearchExtension>
					{
						new DefaultWorkLogObjectSearch(ModelHelper.GetEntityType(item.BaseObjectUid), objectTypeUid)
					};
				}
				if (CheckFilterForObject(list2, objectTypeUid))
				{
					WorkLogItemSearchGroup newGroup = new WorkLogItemSearchGroup(item.BaseObjectUid, new List<Guid> { objectTypeUid }, list2);
					WorkLogItemSearchGroup workLogItemSearchGroup = list.FirstOrDefault((WorkLogItemSearchGroup g) => g.CanGrouping(newGroup));
					if (workLogItemSearchGroup != null)
					{
						workLogItemSearchGroup.ObjectTypeUids.Add(objectTypeUid);
					}
					else
					{
						list.Add(newGroup);
					}
				}
			}
		}
		foreach (WorkLogItemSearchGroup item2 in list)
		{
			List<Guid> objectTypeUids = item2.ObjectTypeUids;
			Guid baseObjectTypeUid = GetBaseTypeUid(objectTypeUids);
			List<IWorkLogObjectSearchExtension> list3 = (isObjectSearch ? item2.WorkLogObjectSearchExtensions.Where((IWorkLogObjectSearchExtension e) => !(e is IWorkLogObjectSearchPermissionExtension workLogObjectSearchPermissionExtension) || workLogObjectSearchPermissionExtension.HasPermission(baseObjectTypeUid)).ToList() : item2.WorkLogObjectSearchExtensions);
			if (!list3.Any())
			{
				continue;
			}
			IEntityFilter filterEntity = CreateEntityFilter(list3, baseObjectTypeUid, isObjectSearch);
			if (searchProvider != null)
			{
				searchProvider.UpdateFilter(filterEntity);
			}
			string defaultCriteriaAlias;
			IEntityManager manager = GetManager(baseObjectTypeUid, out defaultCriteriaAlias);
			if (manager != null)
			{
				ICriteria val = CreateCriteria(filterEntity, manager, baseObjectTypeUid, objectTypeUids, list3, defaultCriteriaAlias);
				ICriteria criteria = ((searchProvider == null) ? val : searchProvider.TransformPartCriteria(session, val, baseObjectTypeUid, objectTypeUids, filter));
				string text = sqlQueryBuilder.AddPartQuery(criteria);
				if (searchProvider != null)
				{
					text = searchProvider.WorkLogItemSearchPreAppendPartQuery(text, sqlQueryBuilder.GetAliaseIdentifier(criteria, defaultCriteriaAlias), baseObjectTypeUid);
				}
				if (stringBuilder.Length != 0)
				{
					stringBuilder.Append("\r\nUNION ALL\r\n");
				}
				stringBuilder.Append(text);
			}
		}
		string text2 = stringBuilder.ToString();
		if (searchProvider != null && !string.IsNullOrEmpty(text2))
		{
			text2 = searchProvider.AfterCreateQuery(text2);
		}
		if (string.IsNullOrEmpty(text2))
		{
			return null;
		}
		return sqlQueryBuilder.Build<T>(text2);
	}

	private static IEntityManager GetManager(Guid objectTypeUid, out string defaultCriteriaAlias)
	{
		Type entityType = ModelHelper.GetEntityType(objectTypeUid);
		defaultCriteriaAlias = "this";
		IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
		if (entityManagerOrNull == null)
		{
			return null;
		}
		string text = "";
		PropertyInfo property = entityManagerOrNull.GetType().GetProperty("Manager", BindingFlags.Instance | BindingFlags.NonPublic);
		if (property != null)
		{
			object value = property.GetValue(entityManagerOrNull, null);
			PropertyInfo property2 = value.GetType().GetProperty("DefaultCriteriaAlias", BindingFlags.Instance | BindingFlags.NonPublic);
			if (property2 != null)
			{
				text = (string)property2.GetValue(value, null);
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			defaultCriteriaAlias = text;
		}
		return entityManagerOrNull;
	}

	private ICriteria CreateCriteria(IEntityFilter filterEntity, IEntityManager manager, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IEnumerable<IWorkLogObjectSearchExtension> searchExtensions, string defaultCriteriaAlias)
	{
		Type entityType = ModelHelper.GetEntityType(baseObjectTypeUid);
		ICriteria criteria = session.CreateCriteria(entityType, defaultCriteriaAlias);
		new NestedScopeComponents<IEntityManagerBehavior>(ServiceScope.Shell).Value.ForEach(delegate(IEntityManagerBehavior b)
		{
			b.OnCreateCriteria(criteria, filterEntity);
		});
		manager.SetupFilter(criteria, filterEntity);
		if (MetadataLoader.LoadMetadata(entityType) is EntityMetadata entityMetadata && (entityMetadata.BaseClassUid != Guid.Empty || MetadataLoader.GetChildClasses(entityMetadata).Count > 0))
		{
			string criteriaTypeUidPropertyName = NHibernateHelper.GetCriteriaTypeUidPropertyName(entityType);
			criteria.Add((ICriterion)(object)Restrictions.In(criteriaTypeUidPropertyName, (ICollection)objectTypeUids));
		}
		foreach (IWorkLogObjectSearchExtension searchExtension in searchExtensions)
		{
			searchExtension.SetupCriteria(criteria, filter);
		}
		return criteria;
	}

	private Guid GetBaseTypeUid(List<Guid> objectTypeUids)
	{
		if (objectTypeUids.Count == 1)
		{
			return objectTypeUids[0];
		}
		Dictionary<Guid, List<Guid>> dictionaryUids = objectTypeUids.ToDictionary((Guid objectTypeUid) => objectTypeUid, (Guid objectTypeUid) => GetParentsTypeUids(objectTypeUid));
		Guid result = Guid.Empty;
		foreach (Guid objectTypeUid2 in objectTypeUids)
		{
			foreach (Guid guid in dictionaryUids[objectTypeUid2])
			{
				if (objectTypeUids.Where((Guid typeUid) => typeUid != objectTypeUid2).Any((Guid typeUid) => !dictionaryUids[typeUid].Contains(guid)))
				{
					return result;
				}
				result = guid;
			}
		}
		return result;
	}

	private List<Guid> GetParentsTypeUids(Guid objectTypeUid, List<Guid> listTypes = null)
	{
		if (listTypes == null)
		{
			listTypes = new List<Guid> { objectTypeUid };
		}
		if (!(MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(objectTypeUid).BaseType) is EntityMetadata entityMetadata))
		{
			return listTypes;
		}
		listTypes.Insert(0, entityMetadata.Uid);
		return GetParentsTypeUids(entityMetadata.Uid, listTypes);
	}

	private IEntityFilter CreateEntityFilter(IEnumerable<IWorkLogObjectSearchExtension> searchExtensions, Guid objectTypeUid, bool disableSoftDeletable)
	{
		IEntityFilter entityFilter = CreateFilter(MetadataLoader.GetFilterType(objectTypeUid));
		entityFilter.DisableSoftDeletable = disableSoftDeletable;
		if (filter != null)
		{
			if (!searchProvider.DisibleSearchString)
			{
				entityFilter.SearchString = filter.SearchString;
			}
			{
				foreach (IWorkLogObjectSearchExtension searchExtension in searchExtensions)
				{
					searchExtension.SetupFilter(entityFilter, filter);
				}
				return entityFilter;
			}
		}
		return entityFilter;
	}

	private bool CheckFilterForObject(IEnumerable<IWorkLogObjectSearchExtension> searchExtensions, Guid objectTypeUid)
	{
		if (filter != null)
		{
			if (searchExtensions == null)
			{
				return false;
			}
			if (filter.EntityType.HasValue && !GetChildClassesUids(filter.EntityType.Value).Contains(objectTypeUid))
			{
				return false;
			}
			if (!(MetadataLoader.LoadMetadata(filter.GetType()) is ClassMetadata classMetadata))
			{
				return false;
			}
			bool result = true;
			{
				foreach (PropertyMetadata propertyMetadata in classMetadata.Properties)
				{
					if (propertyMetadata.DeclaringType.IsInterface && !searchExtensions.Any((IWorkLogObjectSearchExtension e) => e.Properties.Contains(propertyMetadata.Name)))
					{
						PropertyInfo reflectionProperty = propertyMetadata.DeclaringType.GetReflectionProperty(propertyMetadata.Name);
						object value = reflectionProperty.GetValue(filter, null);
						if (!Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid).IsEmpty(propertyMetadata, value) && (searchProvider == null || !searchProvider.CanPropertyFilter(reflectionProperty)))
						{
							return false;
						}
					}
				}
				return result;
			}
		}
		return true;
	}

	[ContextCache]
	protected virtual List<Guid> GetChildClassesUids(Guid entityTypeUid)
	{
		Type entityType = ModelHelper.GetEntityType(entityTypeUid);
		List<Guid> list = new List<Guid>();
		list.Add(entityTypeUid);
		ClassMetadata metadata = InterfaceActivator.LoadMetadata(entityType) as ClassMetadata;
		list.AddRange(from m in MetadataLoader.GetChildClasses(metadata)
			select m.Uid);
		return list;
	}

	private static IEntityFilter CreateFilter(Type type, int levels = 1)
	{
		if (levels < 0)
		{
			return null;
		}
		if (type == null)
		{
			return new Filter();
		}
		IEntityFilter entityFilter = (IEntityFilter)InterfaceActivator.Create(type);
		while (type != null)
		{
			foreach (PropertyMetadata property in ((ClassMetadata)MetadataLoader.LoadMetadata(type, inherit: false, loadImplementation: false)).Properties)
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(property.Name);
				if (typeof(IEntityFilter).IsAssignableFrom(reflectionProperty.PropertyType))
				{
					reflectionProperty.SetValue(entityFilter, CreateFilter(reflectionProperty.PropertyType, levels - 1), null);
				}
			}
			type = type.BaseType;
		}
		return entityFilter;
	}

	private static IEnumerable<IWorkLogObjectSearchExtension> GetWorkLogItemSearchExtensions()
	{
		return ComponentManager.Current.GetExtensionPoints<IWorkLogObjectSearchExtension>().ToList();
	}
}
