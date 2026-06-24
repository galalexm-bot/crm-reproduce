using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class LastObjectInfoManager : EntityManager<ILastObjectInfo, long>
{
	public const string RootCacheKey = "LASTOBJECTINFO";

	public new static LastObjectInfoManager Instance => Locator.GetServiceNotNull<LastObjectInfoManager>();

	public ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is ILastObjectInfoFilter lastObjectInfoFilter))
		{
			return;
		}
		IEnumerable<ILastObjectProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ILastObjectProvider>();
		List<Guid> list = (lastObjectInfoFilter.ObjectTypes.HasItems((Guid o) => o != Guid.Empty) ? lastObjectInfoFilter.ObjectTypes : extensionPoints.Select((ILastObjectProvider t) => t.TypeUid).ToList());
		if (list.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("ObjectType", (ICollection)(from o in list
				where o != Guid.Empty
				select new ReferenceOnEntityType
				{
					TypeUid = o
				}).ToList()));
		}
		if (lastObjectInfoFilter.RealObjectTypes.HasItems())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("RealObjectType", (ICollection)(from o in lastObjectInfoFilter.RealObjectTypes
				where o != Guid.Empty
				select new ReferenceOnEntityType
				{
					TypeUid = o
				}).ToList()));
		}
		if (lastObjectInfoFilter.UniqueObjects.HasValue && lastObjectInfoFilter.UniqueObjects.Value)
		{
			DetachedCriteria val = DetachedCriteria.For(base.ImplementationType, "gbu");
			AggregateProjection val2 = Projections.Max((IProjection)(object)Projections.Property("gbu.Id"));
			PropertyProjection val3 = Projections.Property("gbu.User");
			val.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)val2).Add((IProjection)(object)Projections.GroupProperty("Object"))
				.Add((IProjection)(object)Projections.GroupProperty("RealObjectType"))
				.Add((IProjection)(object)Projections.GroupProperty("User"))).Add((ICriterion)(object)Restrictions.EqProperty((IProjection)(object)val2, $"{criteria.get_Alias()}.Id")).Add((ICriterion)(object)Restrictions.EqProperty((IProjection)(object)val3, $"{criteria.get_Alias()}.User"));
			criteria.Add((ICriterion)(object)Subqueries.Exists(val));
		}
	}

	[Transaction]
	public virtual void AddInfo(ReferenceOnEntity @ref)
	{
		IEntity entity = @ref.Object.CastAsRealType();
		IEnumerable<ILastObjectProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ILastObjectProvider>();
		ClassMetadata metadata = MetadataLoader.LoadMetadata(entity.GetType()) as ClassMetadata;
		if (metadata != null)
		{
			ILastObjectProvider lastObjectProvider = extensionPoints.FirstOrDefault((ILastObjectProvider t) => t.TypeUid == metadata.Uid || MetadataLoader.IsBaseClass(t.TypeUid, metadata));
			if (lastObjectProvider == null || !lastObjectProvider.CanAdd((IEntity<long>)entity))
			{
				return;
			}
		}
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		string key = string.Format("{0}_{1}_{2}_{3}", "LASTOBJECTINFO", currentUser.Id, @ref.ObjectTypeUId, @ref.ObjectId);
		ILastObjectInfo lastObjectInfo = null;
		if (CacheService.TryGetValue<long>(key, out var value))
		{
			lastObjectInfo = LoadOrNull(value);
			if (lastObjectInfo == null)
			{
				CacheService.Remove(key);
			}
		}
		if (lastObjectInfo == null)
		{
			InstanceOf<ILastObjectInfoFilter> instanceOf = new InstanceOf<ILastObjectInfoFilter>();
			instanceOf.New.User = currentUser;
			instanceOf.New.Object = @ref;
			ILastObjectInfoFilter @new = instanceOf.New;
			lastObjectInfo = Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
			if (lastObjectInfo != null)
			{
				CacheService.Insert(key, lastObjectInfo.Id);
			}
		}
		if (lastObjectInfo == null)
		{
			InstanceOf<ILastObjectInfo> instanceOf2 = new InstanceOf<ILastObjectInfo>();
			instanceOf2.New.User = currentUser;
			instanceOf2.New.Object = @ref;
			instanceOf2.New.ObjectType = new ReferenceOnEntityType
			{
				TypeUid = @ref.ObjectTypeUId
			};
			instanceOf2.New.RealObjectType = new ReferenceOnEntityType
			{
				TypeUid = metadata.Uid
			};
			lastObjectInfo = instanceOf2.New;
			Save(lastObjectInfo);
			base.Session.Flush();
			CacheService.Insert(key, lastObjectInfo.Id);
		}
		lastObjectInfo.ChangeDate = DateTime.Now;
		Save(lastObjectInfo);
	}

	[Transaction]
	public virtual void RemoveInfo(ReferenceOnEntity @ref)
	{
		InstanceOf<ILastObjectInfoFilter> instanceOf = new InstanceOf<ILastObjectInfoFilter>();
		instanceOf.New.Object = @ref;
		ILastObjectInfoFilter @new = instanceOf.New;
		Find(@new, FetchOptions.All).ForEach(delegate(ILastObjectInfo i)
		{
			i.Delete();
		});
	}

	public List<ILastObjectInfo> GetObjects(FetchOptions fetchOptions = null, List<Guid> objectType = null, bool isRealObjectType = false)
	{
		if (fetchOptions == null)
		{
			fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, "ChangeDate");
		}
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		InstanceOf<ILastObjectInfoFilter> instanceOf = new InstanceOf<ILastObjectInfoFilter>();
		instanceOf.New.User = currentUser;
		instanceOf.New.UniqueObjects = true;
		ILastObjectInfoFilter @new = instanceOf.New;
		if (isRealObjectType)
		{
			@new.RealObjectTypes = objectType;
		}
		else
		{
			@new.ObjectTypes = objectType;
		}
		return Find(@new, fetchOptions).ToList();
	}

	[Transaction]
	public virtual void ClearHistory()
	{
		IProjection val = ((SimpleProjection)Projections.Count("Id")).As("HowMany");
		List<LastObjectInfoDTO> list = (from u in CreateCriteria().CreateAlias("User", "usr", (JoinType)0).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(((SimpleProjection)Projections.GroupProperty("usr.Id")).As("UserId")).Add(((SimpleProjection)Projections.GroupProperty("ObjectType")).As("ObjectType"))
				.Add(val) }).Add((ICriterion)(object)Restrictions.Gt(val, (object)100))
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(LastObjectInfoDTO)))
				.List<LastObjectInfoDTO>()
			where u.UserId > 0 && u.ObjectType != null
			select u).ToList();
		if (list.Count <= 0)
		{
			return;
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		foreach (LastObjectInfoDTO item in list)
		{
			string query = string.Format("{1} from {2} where {3}={0}userId and {4}={0}objType", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("LastObjectInfo"), serviceNotNull.Dialect.QuoteIfNeeded("User"), serviceNotNull.Dialect.QuoteIfNeeded("ObjectType"));
			query = serviceNotNull.SetupFetchOptions(query, new FetchOptions(0, 100, ListSortDirection.Descending, "Id"));
			string sql = string.Format("delete from {1} where {3}={5}userId and {4}={5}objType and {2} not in (select {2} from ({0}) subq) ", query, serviceNotNull.Dialect.QuoteIfNeeded("LastObjectInfo"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("User"), serviceNotNull.Dialect.QuoteIfNeeded("ObjectType"), serviceNotNull.ParameterSeparator);
			serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>
			{
				{
					"objType",
					item.ObjectType.TypeUid
				},
				{ "userId", item.UserId }
			});
		}
	}
}
