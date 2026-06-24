using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

public class FilterDefaultManager : EntityManager<IFilterDefault, long>
{
	public IContextBoundVariableService CacheService { get; set; }

	[NotNull]
	public new static FilterDefaultManager Instance => Locator.GetServiceNotNull<FilterDefaultManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter != null && filter is IFilterDefaultFilter && ((IFilterDefaultFilter)filter).NoAuthor)
		{
			criteria.Add((ICriterion)(object)Restrictions.IsNull("CreationAuthor"));
		}
	}

	public void SaveDefaultFilter([NotNull] IFilter filter)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		InstanceOf<IFilterDefaultFilter> instanceOf = new InstanceOf<IFilterDefaultFilter>();
		instanceOf.New.CreationAuthor = currentUser;
		instanceOf.New.ObjectsType = filter.ObjectsType;
		instanceOf.New.Code = filter.Code;
		IFilterDefaultFilter @new = instanceOf.New;
		IFilterDefault filterDefault = Find(@new, FetchOptions.First).FirstOrDefault();
		if (filterDefault == null)
		{
			InstanceOf<IFilterDefault> instanceOf2 = new InstanceOf<IFilterDefault>();
			instanceOf2.New.CreationAuthor = currentUser;
			instanceOf2.New.ObjectsType = filter.ObjectsType;
			instanceOf2.New.Code = filter.Code;
			filterDefault = instanceOf2.New;
		}
		filterDefault.Filter = ((filter.Id > 0) ? filter : null);
		filterDefault.Save();
		CacheService.ClearFor<ReferenceOnEntityType, Guid?, IFilter>(LoadDefaultFilter);
	}

	public IFilter LoadDefaultFilter(Guid typeUid)
	{
		return LoadDefaultFilter(typeUid, null);
	}

	public IFilter LoadDefaultFilter(Guid typeUid, Guid? code)
	{
		return LoadDefaultFilter(new ReferenceOnEntityType
		{
			TypeUid = typeUid
		}, code);
	}

	public virtual IFilter LoadDefaultFilter(ReferenceOnEntityType refType)
	{
		return LoadDefaultFilter(refType, null);
	}

	[ContextCache]
	public virtual IFilter LoadDefaultFilter(ReferenceOnEntityType refType, Guid? code)
	{
		ICriteria val = base.Session.CreateCriteria(base.ImplementationType).Add((ICriterion)(object)Restrictions.Eq("CreationAuthor.Id", (object)Convert.ToInt64(EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser().GetId()))).Add((ICriterion)(object)Restrictions.Eq("ObjectsType", (object)refType));
		if (code.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code));
		}
		if (Convert.ToInt64(val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("Id") }).UniqueResult()) == 0L)
		{
			return LoadSystemDefaultFilter(refType, code);
		}
		return GetFilterDefault(refType, code);
	}

	public void SaveSystemDefaultFilter([NotNull] IFilter filter)
	{
		InstanceOf<IFilterDefaultFilter> instanceOf = new InstanceOf<IFilterDefaultFilter>();
		instanceOf.New.ObjectsType = filter.ObjectsType;
		instanceOf.New.Code = filter.Code;
		instanceOf.New.NoAuthor = true;
		IFilterDefaultFilter @new = instanceOf.New;
		IFilterDefault filterDefault = Find(@new, FetchOptions.First).FirstOrDefault();
		if (filterDefault == null)
		{
			InstanceOf<IFilterDefault> instanceOf2 = new InstanceOf<IFilterDefault>();
			instanceOf2.New.CreationAuthor = null;
			instanceOf2.New.ObjectsType = filter.ObjectsType;
			instanceOf2.New.Code = filter.Code;
			filterDefault = instanceOf2.New;
		}
		filterDefault.Filter = ((filter.Id > 0) ? filter : null);
		filterDefault.Save();
		CacheService.ClearFor<ReferenceOnEntityType, Guid?, IFilter>(LoadSystemDefaultFilter);
	}

	public IFilter LoadSystemDefaultFilter(Guid typeUid)
	{
		return LoadSystemDefaultFilter(typeUid, null);
	}

	public IFilter LoadSystemDefaultFilter(Guid typeUid, Guid? code)
	{
		return LoadSystemDefaultFilter(new ReferenceOnEntityType
		{
			TypeUid = typeUid
		}, code);
	}

	public virtual IFilter LoadSystemDefaultFilter(ReferenceOnEntityType refType)
	{
		return LoadSystemDefaultFilter(refType, null);
	}

	[ContextCache]
	public virtual IFilter LoadSystemDefaultFilter(ReferenceOnEntityType refType, Guid? code)
	{
		return GetFilterDefault(refType, code, filterAuthor: false);
	}

	[Transaction]
	public virtual void DeleteDefaults(IFilter filter)
	{
		foreach (IFilterDefault item in ((AbstractNHEntityManager<IFilterDefault, long>)this).Find((Expression<Func<IFilterDefault, bool>>)((IFilterDefault x) => x.Filter == filter)).ToList())
		{
			item.Filter = null;
			item.Delete();
		}
	}

	private IFilter GetFilterDefault(ReferenceOnEntityType refType, Guid? code, bool filterAuthor = true)
	{
		EleWise.ELMA.Security.IUser currentUser = EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser();
		Junction val = ((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter)).Add((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SystemFilter));
		if (filterAuthor)
		{
			val.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter), (ICriterion)(object)Restrictions.Eq("CreationAuthor.Id", (object)Convert.ToInt64(currentUser.GetId()))));
		}
		ICriteria val2 = CreateCriteria(null, InterfaceActivator.TypeOf<IFilterFolder>()).Add((ICriterion)(object)Restrictions.In("ObjectsType", FilterFolderManager.Instance.Types(refType))).Add((ICriterion)(object)val);
		if (code.HasValue)
		{
			val2.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code));
		}
		FilterFolderManager.Instance.SetPermissionByFilter(val2);
		DetachedCriteria val3 = CreateDetachedCriteria(null, base.ImplementationType).SetProjection((IProjection)(object)Property.ForName("Filter")).Add((ICriterion)(filterAuthor ? ((object)Restrictions.Eq("CreationAuthor.Id", (object)Convert.ToInt64(currentUser.GetId()))) : ((object)Restrictions.IsNull("CreationAuthor")))).Add((ICriterion)(object)Restrictions.Eq("ObjectsType", (object)refType));
		if (code.HasValue)
		{
			val3.Add((ICriterion)(object)Restrictions.Eq("Code", (object)code));
		}
		val2.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val3));
		return val2.SetMaxResults(1).List<IFilter>().FirstOrDefault();
	}
}
