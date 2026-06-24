using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingEffectManager : MarketingBaseManager<IMarketingEffect, long>
{
	public new static MarketingEffectManager Instance => Locator.GetServiceNotNull<MarketingEffectManager>();

	public override void Save(IMarketingEffect obj)
	{
		foreach (IMarketingTag item in (IEnumerable<IMarketingTag>)obj.Tags)
		{
			if (item.IsNew() && Convert.ToInt32(CreateCriteria().CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)obj.MarketingActivity)).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)item.Name))
				.SetProjection((IProjection[])(object)new IProjection[1] { Projections.RowCount() })
				.UniqueResult()) > 0)
			{
				throw new Exception(SR.T("Метка \"{0}\" уже содержится в другом воздействии", item.Name));
			}
		}
		base.Save(obj);
	}

	public IMarketingEffect FindByUtm(IMarketingActivity marketingActivity, string utmCampaign)
	{
		return CreateCriteria(new FetchOptions(0, 1), InterfaceActivator.TypeOf<IMarketingEffect>()).CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)marketingActivity)).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)utmCampaign))
			.UniqueResult<IMarketingEffect>();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IMarketingEffectFilter marketingEffectFilter)
		{
			if (marketingEffectFilter.DateRange.From.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Ge("EndDate", (object)marketingEffectFilter.DateRange.From));
			}
			if (marketingEffectFilter.DateRange.To.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Le("StartDate", (object)marketingEffectFilter.DateRange.To));
			}
		}
	}
}
