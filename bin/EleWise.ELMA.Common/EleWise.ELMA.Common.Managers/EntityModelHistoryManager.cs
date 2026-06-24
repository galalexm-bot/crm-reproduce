using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class EntityModelHistoryManager : EntityManager<IEntityModelHistory, long>
{
	private readonly PublicClientCacheTokenManager clientCacheTokenManager;

	private static readonly string ObjectIdPropName = LinqUtils.NameOf((Expression<Func<IEntityModelHistory, object>>)((IEntityModelHistory h) => h.ObjectId));

	private static IEnumerable<IEntityModelHistoryEventsFilter> _filters;

	private static EntityModelHistoryManager _instance;

	private static IEnumerable<IEntityModelHistoryEventsFilter> Filters => _filters ?? (_filters = ComponentManager.Current.GetExtensionPoints<IEntityModelHistoryEventsFilter>());

	public new static EntityModelHistoryManager Instance => _instance ?? (_instance = Locator.GetServiceNotNull<EntityModelHistoryManager>());

	public EntityModelHistoryManager(PublicClientCacheTokenManager clientCacheTokenManager)
	{
		this.clientCacheTokenManager = clientCacheTokenManager;
	}

	public IEntityModelHistory RecordUpdated(IEntity entity)
	{
		return RecordAction(entity, DefaultEntityActions.UpdateGuid);
	}

	internal IEntityModelHistory RecordAction(IEntity entity, Guid actionGuid, bool save = true)
	{
		if (entity is IEntityModelHistory)
		{
			return null;
		}
		if (!(MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata entityMetadata))
		{
			return null;
		}
		object id = entity.GetId();
		if (!(id is long))
		{
			return null;
		}
		EntityPropertyMetadata uidProperty = entityMetadata.GetUidProperty();
		if (uidProperty == null)
		{
			return null;
		}
		if (Filters.Any((IEntityModelHistoryEventsFilter f) => !f.IsSupported(entity, actionGuid)))
		{
			return null;
		}
		IEntityModelHistory entityModelHistory = Create();
		entityModelHistory.ObjectId = (long)id;
		entityModelHistory.ObjectTypeUid = entityMetadata.Uid;
		entityModelHistory.ObjectUid = entity.GetPropertyValue<Guid>(uidProperty.Uid);
		entityModelHistory.ActionTypeUid = actionGuid;
		if (save)
		{
			Save(entityModelHistory);
		}
		return entityModelHistory;
	}

	public IEntityModelHistory RecordDeleted(Guid typeUid, long entityId, Guid entityUid)
	{
		return RecordAction(typeUid, entityId, entityUid, DefaultEntityActions.DeleteGuid);
	}

	public IEntityModelHistory RecordUpdated(Guid typeUid, long entityId, Guid entityUid)
	{
		return RecordAction(typeUid, entityId, entityUid, DefaultEntityActions.UpdateGuid);
	}

	public IEntityModelHistory RecordCreated(Guid typeUid, long entityId, Guid entityUid)
	{
		return RecordAction(typeUid, entityId, entityUid, DefaultEntityActions.CreateGuid);
	}

	private IEntityModelHistory RecordAction(Guid typeUid, long entityId, Guid entityUid, Guid actionUid)
	{
		if (Filters.Any((IEntityModelHistoryEventsFilter f) => !f.IsSupported(typeUid, entityId, entityUid, actionUid)))
		{
			return null;
		}
		IEntityModelHistory entityModelHistory = Create();
		entityModelHistory.ObjectId = entityId;
		entityModelHistory.ObjectTypeUid = typeUid;
		entityModelHistory.ObjectUid = entityUid;
		entityModelHistory.ActionTypeUid = actionUid;
		Save(entityModelHistory);
		return entityModelHistory;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		if (filter is IEntityModelHistoryFilter entityModelHistoryFilter && entityModelHistoryFilter.ObjectTypeUid.HasValue && filter.FilterByHierarchyParent)
		{
			Guid value = entityModelHistoryFilter.ObjectTypeUid.Value;
			entityModelHistoryFilter.ObjectTypeUid = null;
			entityModelHistoryFilter.FilterByHierarchyParent = false;
			base.SetupFilter(criteria, (IEntityFilter)entityModelHistoryFilter);
			if (MetadataLoader.LoadMetadata(value) is ClassMetadata classMetadata)
			{
				Guid[] array = (from c in MetadataLoader.GetChildClasses(classMetadata)
					select c.Uid).Union(new Guid[1] { classMetadata.Uid }).ToArray();
				criteria.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((IEntityModelHistory h) => h.ObjectTypeUid), (ICollection)array));
			}
		}
		else
		{
			base.SetupFilter(criteria, filter);
		}
	}

	public long Count(Guid objectTypeUid, DateTime? from, string eqlQuery = null)
	{
		ICriteria historyCriteria = GetHistoryCriteria(objectTypeUid, from);
		long num = 0L;
		if (!string.IsNullOrWhiteSpace(eqlQuery))
		{
			DetachedCriteria val = ApplyEqlSubcriteria(objectTypeUid, eqlQuery, historyCriteria);
			if (val != null)
			{
				long num2 = clientCacheTokenManager.CountDeleted(objectTypeUid, from, eqlQuery, val);
				num += num2;
			}
		}
		return num + ReturnCount(historyCriteria);
	}

	public IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string eqlQuery = null)
	{
		ICriteria historyCriteria = GetHistoryCriteria(objectTypeUid, from);
		ICollection<IEntityModelHistoryItem> collection = new List<IEntityModelHistoryItem>();
		if (!string.IsNullOrWhiteSpace(eqlQuery))
		{
			DetachedCriteria val = ApplyEqlSubcriteria(objectTypeUid, eqlQuery, historyCriteria);
			if (val != null)
			{
				IEnumerable<IEntityModelHistoryItem> source = clientCacheTokenManager.FindDeleted(objectTypeUid, from, eqlQuery, val);
				collection.AddSequense(source);
			}
		}
		collection.AddSequense(Find(historyCriteria));
		return collection;
	}

	public long Count(Guid objectTypeUid, DateTime? from, string filterKey, IEntityFilter filter)
	{
		ICriteria historyCriteria = GetHistoryCriteria(objectTypeUid, from);
		long num = 0L;
		if (!string.IsNullOrWhiteSpace(filterKey) && filter != null)
		{
			DetachedCriteria val = ApplyFilterSubcriteria(objectTypeUid, filter, historyCriteria);
			if (val != null)
			{
				long num2 = clientCacheTokenManager.CountDeleted(objectTypeUid, from, filterKey, val);
				num += num2;
			}
		}
		return num + ReturnCount(historyCriteria);
	}

	public IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string filterKey, IEntityFilter filter)
	{
		ICriteria historyCriteria = GetHistoryCriteria(objectTypeUid, from);
		ICollection<IEntityModelHistoryItem> collection = new List<IEntityModelHistoryItem>();
		if (!string.IsNullOrWhiteSpace(filterKey) && filter != null)
		{
			DetachedCriteria val = ApplyFilterSubcriteria(objectTypeUid, filter, historyCriteria);
			if (val != null)
			{
				IEnumerable<IEntityModelHistoryItem> source = clientCacheTokenManager.FindDeleted(objectTypeUid, from, filterKey, val);
				collection.AddSequense(source);
			}
		}
		collection.AddSequense(Find(historyCriteria));
		return collection;
	}

	private ICriteria GetHistoryCriteria(Guid objectTypeUid, DateTime? from)
	{
		IEntityModelHistoryFilter filter = EntityModelHistoryFilter(objectTypeUid);
		ICriteria val = CreateCriteria(null, base.ImplementationType);
		SetupFilter(val, filter);
		DateTimeRange dateTimeRange = GetDateTimeRange(from, null);
		if (dateTimeRange.From.HasValue)
		{
			val.Add(GetDateRangeCriterion(dateTimeRange));
		}
		return val.SetCacheable(true);
	}

	private static DateTimeRange GetDateTimeRange(DateTime? from, DateTime? to)
	{
		return DateTimeRangeDescriptor.GetRangeForCriteria(from, to);
	}

	private ICriterion GetDateRangeCriterion(DateTimeRange range)
	{
		ICriterion val = null;
		ICriterion val2 = null;
		if (range.From.HasValue)
		{
			val = (ICriterion)(object)Restrictions.Ge((IProjection)(object)ProjectionFor((IEntityModelHistory h) => h.CreationDate), (object)range.From);
		}
		if (range.To.HasValue)
		{
			val2 = (ICriterion)(object)Restrictions.Le((IProjection)(object)ProjectionFor((IEntityModelHistory h) => h.CreationDate), (object)range.To);
		}
		if (val != null && val2 != null)
		{
			return (ICriterion)(object)Restrictions.And(val, val2);
		}
		return val ?? val2;
	}

	private static IEntityModelHistoryFilter EntityModelHistoryFilter(Guid objectTypeUid)
	{
		IEntityModelHistoryFilter entityModelHistoryFilter = InterfaceActivator.Create<IEntityModelHistoryFilter>();
		entityModelHistoryFilter.ObjectTypeUid = objectTypeUid;
		entityModelHistoryFilter.FilterByHierarchyParent = true;
		return entityModelHistoryFilter;
	}

	private static DetachedCriteria ApplyEqlSubcriteria(Guid objectTypeUid, string eqlQuery, ICriteria criteria)
	{
		Type entityType = ModelHelper.GetEntityType(objectTypeUid);
		IEntityFilter entityFilter = (IEntityFilter)InterfaceActivator.Create(ModelHelper.GetEntityFilterType(entityType));
		entityFilter.Query = eqlQuery;
		return ApplyFilterSubcriteria(entityType, entityFilter, criteria);
	}

	private static DetachedCriteria ApplyFilterSubcriteria(Guid objectTypeUid, IEntityFilter filter, ICriteria criteria)
	{
		return ApplyFilterSubcriteria(ModelHelper.GetEntityType(objectTypeUid), filter, criteria);
	}

	private static DetachedCriteria ApplyFilterSubcriteria(Type entityType, IEntityFilter filter, ICriteria criteria)
	{
		DetachedCriteria val = ModelHelper.GetEntityManager(entityType).CreateDetachedCriteria(FetchOptions.All, entityType, "sq", filter);
		if (val != null)
		{
			val.SetProjection((IProjection)(object)Projections.Id());
			criteria.Add((ICriterion)(object)Subqueries.PropertyIn(ObjectIdPropName, val));
		}
		return val;
	}
}
