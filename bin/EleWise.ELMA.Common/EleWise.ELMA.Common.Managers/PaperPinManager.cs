using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

public class PaperPinManager : EntityManager<IPaperPin, long>
{
	public new static PaperPinManager Instance => Locator.GetServiceNotNull<PaperPinManager>();

	public List<IPaperPin> GetPaperPinByUser(Guid typeUid, IUser user, object entityId = null)
	{
		IPaperPinFilter paperPinFilter = InterfaceActivator.Create<IPaperPinFilter>();
		paperPinFilter.TypeUid = typeUid;
		paperPinFilter.EntityId = ((entityId != null) ? Convert.ToString(entityId) : null);
		paperPinFilter.User = user;
		return Find(paperPinFilter, FetchOptions.All).ToList();
	}

	[Transaction]
	public virtual void CreatePaperPinByUser(Guid typeUid, object entityId, IUser user)
	{
		InstanceOf<IPaperPin> instanceOf = new InstanceOf<IPaperPin>();
		instanceOf.New.TypeUid = typeUid;
		instanceOf.New.EntityId = ((entityId != null) ? Convert.ToString(entityId) : null);
		instanceOf.New.User = user;
		instanceOf.New.Save();
	}

	public List<IPaperPin> GetAllPaperPinsByUser(IUser user, List<Guid> typeUids = null)
	{
		IPaperPinFilter paperPinFilter = InterfaceActivator.Create<IPaperPinFilter>();
		paperPinFilter.TypeUids = typeUids;
		paperPinFilter.User = user;
		return Find(paperPinFilter, FetchOptions.All).ToList();
	}

	public IPaperPin FirstPaperPinByUser(IUser user, List<Guid> typeUids)
	{
		IPaperPinFilter paperPinFilter = InterfaceActivator.Create<IPaperPinFilter>();
		paperPinFilter.TypeUids = typeUids;
		paperPinFilter.User = user;
		return Find(paperPinFilter, new FetchOptions
		{
			FirstResult = 0,
			MaxResults = 1
		}).FirstOrDefault();
	}

	public void DeletePaperPinsByUser(IUser user, [NotNull] object entityId, Guid typeUid)
	{
		IPaperPinFilter paperPinFilter = InterfaceActivator.Create<IPaperPinFilter>();
		paperPinFilter.TypeUid = typeUid;
		paperPinFilter.EntityId = Convert.ToString(entityId);
		paperPinFilter.User = user;
		Find(paperPinFilter, FetchOptions.All).ToList().ForEach(delegate(IPaperPin w)
		{
			w.Delete();
		});
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IPaperPinFilter paperPinFilter && paperPinFilter.TypeUids != null && paperPinFilter.TypeUids.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)paperPinFilter.TypeUids));
		}
	}
}
