using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingActivityManager : MarketingBaseManager<IMarketingActivity, long>
{
	public new static MarketingActivityManager Instance => Locator.GetServiceNotNull<MarketingActivityManager>();

	public override void Save(IMarketingActivity obj)
	{
		foreach (IMarketingTag item in (IEnumerable<IMarketingTag>)obj.Tags)
		{
			if (item.IsNew() && Convert.ToInt32(CreateCriteria().CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)obj.MarketingGroup)).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)item.Name))
				.SetProjection((IProjection[])(object)new IProjection[1] { Projections.RowCount() })
				.UniqueResult()) > 0)
			{
				throw new Exception(SR.T("Метка \"{0}\" уже содержится в другом мероприятии", item.Name));
			}
		}
		base.Save(obj);
	}

	public void UpdateBudget(IMarketingActivity marketingActivity)
	{
		if (marketingActivity != null && marketingActivity.BudgetType == MarketingBudgetType.SumOfChild)
		{
			marketingActivity.Budget = CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingEffect>()).Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)marketingActivity)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum("Budget") }).UniqueResult<Money>();
			marketingActivity.Save();
		}
	}

	public IMarketingActivity FindByUtm(IMarketingGroup marketingGroup, string utmMedium)
	{
		return CreateCriteria(new FetchOptions(0, 1), InterfaceActivator.TypeOf<IMarketingActivity>()).CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingGroup)).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)utmMedium))
			.UniqueResult<IMarketingActivity>();
	}

	public IMarketingActivity FindByUtm(string utmMedium)
	{
		return CreateCriteria(new FetchOptions(0, 1), InterfaceActivator.TypeOf<IMarketingActivity>()).CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.IsNull("MarketingGroup")).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)utmMedium))
			.UniqueResult<IMarketingActivity>();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IMarketingActivityFilter marketingActivityFilter)
		{
			if (marketingActivityFilter.DateRange.From.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Ge("EndDate", (object)marketingActivityFilter.DateRange.From));
			}
			if (marketingActivityFilter.DateRange.To.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Le("StartDate", (object)marketingActivityFilter.DateRange.To));
			}
		}
	}
}
