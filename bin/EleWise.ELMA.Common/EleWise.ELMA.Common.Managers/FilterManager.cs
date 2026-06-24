using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class FilterManager : EntityManager<IFilter, long>
{
	public IContextBoundVariableService CacheService { get; set; }

	public new static FilterManager Instance => Locator.GetServiceNotNull<FilterManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IFilterFilter filterFilter)
		{
			if (filterFilter.GetUserFilters)
			{
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.SharedFilter), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("FilterType", (object)FilterType.MyFilter), (ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser()))));
				FilterFolderManager.Instance.SetPermissionByFilter(criteria);
			}
			if (filterFilter.ParentIsNull.HasValue && filterFilter.ParentIsNull.Value)
			{
				criteria.Add((ICriterion)(object)Restrictions.IsNull("ParentFolder"));
			}
			if (filterFilter.TypeUid.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq(GetTypeUidPropertyName(filter), (object)filterFilter.TypeUid.Value));
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public override void Delete(IFilter obj)
	{
		FilterDefaultManager.Instance.DeleteDefaults(obj);
		DeletePermissions(obj);
		base.Delete(obj);
	}

	[Transaction]
	public virtual void DeletePermissions(IFilter obj)
	{
		foreach (IFilterPermission item in EntityManager<IFilterPermission>.Instance.Find((IFilterPermission p) => p.Filter == obj))
		{
			item.Filter = null;
			item.Delete();
		}
	}
}
