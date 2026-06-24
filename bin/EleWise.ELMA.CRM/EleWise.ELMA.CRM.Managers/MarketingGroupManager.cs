using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingGroupManager : MarketingBaseManager<IMarketingGroup, long>
{
	public new static MarketingGroupManager Instance => Locator.GetServiceNotNull<MarketingGroupManager>();

	public override void Save(IMarketingGroup obj)
	{
		foreach (IMarketingTag item in (IEnumerable<IMarketingTag>)obj.Tags)
		{
			if (item.IsNew() && Convert.ToInt32(CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingTag>(), "mt").CreateAlias("MarketingObject", "mo").Add((ICriterion)(object)Restrictions.Eq($"mo.{GetTypeUidPropertyName(typeof(IMarketingBase))}", (object)InterfaceActivator.UID<IMarketingGroup>())).Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)item.Name))
				.SetProjection((IProjection[])(object)new IProjection[1] { Projections.RowCount() })
				.UniqueResult()) > 0)
			{
				throw new Exception(SR.T("Метка \"{0}\" уже содержится в другой группе", item.Name));
			}
		}
		base.Save(obj);
	}

	public void UpdateBudget(IMarketingGroup marketingGroup)
	{
		if (marketingGroup != null && marketingGroup.BudgetType == MarketingBudgetType.SumOfChild)
		{
			marketingGroup.Budget = CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingActivity>()).Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingGroup)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum("Budget") }).UniqueResult<Money>();
			marketingGroup.Save();
		}
	}

	public IMarketingGroup FindByUtm(string utmSource)
	{
		return CreateCriteria(new FetchOptions(0, 1), InterfaceActivator.TypeOf<IMarketingGroup>()).CreateAlias("Tags", "mt").Add((ICriterion)(object)Restrictions.Eq("mt.Name", (object)utmSource)).UniqueResult<IMarketingGroup>();
	}
}
