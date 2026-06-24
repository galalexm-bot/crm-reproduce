using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
[Component(EnableInterceptiors = true)]
public class WatchManager : EntityManager<IWatch, long>
{
	public new static WatchManager Instance => Locator.GetServiceNotNull<WatchManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IWatchFilter watchFilter && watchFilter.Global)
		{
			criteria.Add((ICriterion)(object)Restrictions.IsNull("EntityId"));
		}
	}

	public List<IWatch> GetWatches(Guid typeUid, object entityId, bool onlyForEntity = false, bool excludeExtensions = true)
	{
		string criteriaTypeUidPropertyName = NHibernateHelper.GetCriteriaTypeUidPropertyName(typeof(IWatch));
		ICriteria obj = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(criteriaTypeUidPropertyName, (object)typeUid)).SetCacheable(true);
		string text = Convert.ToString(entityId);
		obj.Add((ICriterion)((entityId == null) ? Restrictions.IsNull("EntityId") : ((!onlyForEntity) ? ((object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("EntityId", (object)text), (ICriterion)(object)Restrictions.IsNull("EntityId"))) : ((object)Restrictions.Eq("EntityId", (object)text)))));
		List<IWatch> list = obj.List<IWatch>().ToList();
		if (excludeExtensions)
		{
			IWatchExtension watchExtension = ComponentManager.Current.GetExtensionPoints<IWatchExtension>().FirstOrDefault((IWatchExtension p) => p.Can(typeUid));
			if (watchExtension != null)
			{
				foreach (IWatch item in list.ToList())
				{
					if (!watchExtension.CanSendToUser(item))
					{
						list.Remove(item);
					}
				}
				return list;
			}
			return list;
		}
		foreach (IWatchExtension item2 in (from p in ComponentManager.Current.GetExtensionPoints<IWatchExtension>()
			where p.Can(typeUid)
			select p).ToList())
		{
			list.AddRange(item2.GetWatches(typeUid, entityId));
		}
		return list;
	}

	public List<IWatch> BuildWatchList(Guid typeUid, object entityId, Guid[] parentTypeUid, object parentEntityId)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)typeUid));
		string text = Convert.ToString(entityId);
		string text2 = Convert.ToString(parentEntityId);
		val.Add((ICriterion)(object)((entityId != null) ? Restrictions.Or((ICriterion)(object)Restrictions.Eq("EntityId", (object)text), (ICriterion)(object)Restrictions.IsNull("EntityId")) : Restrictions.IsNull("EntityId")));
		if (parentTypeUid != null && parentTypeUid.Length != 0)
		{
			val.Add((ICriterion)(object)Restrictions.In("ParentTypeUid", (ICollection)parentTypeUid));
		}
		val.Add((ICriterion)(object)((parentEntityId != null) ? Restrictions.Or((ICriterion)(object)Restrictions.Eq("ParentEntityId", (object)text2), (ICriterion)(object)Restrictions.IsNull("ParentEntityId")) : Restrictions.IsNull("ParentEntityId")));
		return val.List<IWatch>().ToList();
	}

	public List<IWatch> GetWatchByUser(Guid typeUid, long? userId, object entityId = null)
	{
		string text = Convert.ToString(entityId);
		ICriteria val = CreateCriteria().SetCacheable(true).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)typeUid), (ICriterion)((entityId != null) ? ((object)Restrictions.Eq("EntityId", (object)text)) : ((object)Restrictions.IsNull("EntityId")))), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("ParentTypeUid", (object)typeUid), (ICriterion)((entityId != null) ? ((object)Restrictions.Eq("ParentEntityId", (object)text)) : ((object)Restrictions.IsNull("ParentEntityId"))))));
		if (userId.HasValue)
		{
			val.CreateAlias("User", "usr").Add((ICriterion)(object)Restrictions.Eq("usr.Id", (object)userId.Value));
		}
		return val.List<IWatch>().ToList();
	}

	public bool IsWatchExsist(Guid typeUid, object entityId, IUser user = null)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)typeUid));
		string text = Convert.ToString(entityId);
		val.Add((ICriterion)((entityId != null) ? ((object)Restrictions.Eq("EntityId", (object)text)) : ((object)Restrictions.IsNull("EntityId"))));
		if (user != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("User", (object)user));
		}
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")) });
		return Convert.ToInt64(val.UniqueResult()) > 0;
	}

	[ActionMethod("e7ece447-5a97-445e-b01b-ac8467b985d3")]
	[Transaction]
	public virtual void CreateWatchByUser(Guid typeUid, object entityId, IUser user)
	{
		string sEntityId = ((entityId != null) ? Convert.ToString(entityId) : null);
		InstanceOf<IWatch> instanceOf = new InstanceOf<IWatch>();
		instanceOf.New.TypeUid = typeUid;
		instanceOf.New.EntityId = sEntityId;
		instanceOf.New.User = user;
		instanceOf.New.Save();
		(from p in ComponentManager.Current.GetExtensionPoints<IWatchProvider>()
			where p.ParentTypeUid != null && p.ParentTypeUid.Any((Guid t) => t == typeUid)
			select p).ToList().ForEach(delegate(IWatchProvider p)
		{
			p.TypeUid.ToList().ForEach(delegate(Guid t)
			{
				InstanceOf<IWatch> instanceOf2 = new InstanceOf<IWatch>();
				instanceOf2.New.TypeUid = t;
				instanceOf2.New.User = user;
				instanceOf2.New.ParentTypeUid = typeUid;
				instanceOf2.New.ParentEntityId = sEntityId;
				instanceOf2.New.Save();
			});
		});
	}

	public List<IWatch> GetAllWatchesByUser(IUser user)
	{
		return CreateCriteria().SetCacheable(true).CreateAlias("User", "usr").Add((ICriterion)(object)Restrictions.Eq("usr.Id", (object)user.Id))
			.Add((ICriterion)(object)Restrictions.IsNull("ParentTypeUid"))
			.List<IWatch>()
			.ToList();
	}

	[ActionMethod("55d73569-93cc-4955-9f50-0d71b5f0ca66")]
	public virtual void DeleteWatchesByUser(IUser user, object entityId, Guid typeUid)
	{
		string text = Convert.ToString(entityId);
		ICriteria obj = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("User", (object)user));
		obj.Add((ICriterion)((entityId != null) ? ((object)Restrictions.Eq("EntityId", (object)text)) : ((object)Restrictions.IsNull("EntityId"))));
		obj.Add((ICriterion)(object)Restrictions.Eq(base.EntityTypeUidPropertyName, (object)typeUid));
		obj.List<IWatch>().ToList().ForEach(delegate(IWatch w)
		{
			w.Delete();
		});
	}

	[ActionCheck("55d73569-93cc-4955-9f50-0d71b5f0ca66")]
	[Auditable]
	public virtual bool CanDeleteWatchesByUser(IUser user, object entityId, Guid typeUid)
	{
		return true;
	}
}
