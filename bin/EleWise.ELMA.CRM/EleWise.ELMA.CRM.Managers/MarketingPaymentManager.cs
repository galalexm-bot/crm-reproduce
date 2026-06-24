using System.Collections.Generic;
using EleWise.ELMA.Actions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingPaymentManager : EntityManager<IMarketingPayment, long>
{
	public new static MarketingPaymentManager Instance => Locator.GetServiceNotNull<MarketingPaymentManager>();

	public ICollection<IMarketingPayment> GetMarketingPayments(IMarketingBase marketingBase, DateTimeRange period)
	{
		ICriteria val = CreateCriteria();
		val.Add(DateTimeRangeDescriptor.GetCriterion(period, showTime: true, val.get_Alias(), "CreationDate"));
		if (marketingBase != null)
		{
			Junction val2 = ((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq("MarketingObjectBase", (object)marketingBase));
			if (marketingBase.BudgetType == MarketingBudgetType.SumOfChild)
			{
				if (marketingBase is IMarketingGroup)
				{
					DetachedCriteria val3 = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingActivity>()).SetProjection((IProjection)(object)Projections.Property("Id")).Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingBase)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false)));
					val2.Add((ICriterion)(object)Subqueries.PropertyIn("MarketingObjectBase", val3));
					DetachedCriteria val4 = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingActivity>()).SetProjection((IProjection)(object)Projections.Property("Id")).Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingBase)).Add((ICriterion)(object)Restrictions.Eq("BudgetType", (object)MarketingBudgetType.SumOfChild))
						.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false)));
					DetachedCriteria val5 = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingEffect>()).SetProjection((IProjection)(object)Projections.Property("Id")).Add((ICriterion)(object)Subqueries.PropertyIn("MarketingActivity", val4)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false)));
					val2.Add((ICriterion)(object)Subqueries.PropertyIn("MarketingObjectBase", val5));
				}
				if (marketingBase is IMarketingActivity marketingActivity)
				{
					DetachedCriteria val6 = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingEffect>()).SetProjection((IProjection)(object)Projections.Property("Id")).Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)marketingActivity)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false)));
					val2.Add((ICriterion)(object)Subqueries.PropertyIn("MarketingObjectBase", val6));
				}
			}
			val.Add((ICriterion)(object)val2);
		}
		else
		{
			DetachedCriteria val7 = CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingBase>()).SetProjection((IProjection)(object)Projections.Property("Id")).Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)true));
			val.Add((ICriterion)(object)Subqueries.PropertyNotIn("MarketingObjectBase", val7));
		}
		return val.List<IMarketingPayment>();
	}

	public void CreatePaymentOnBudget(IMarketingBase marketingBase)
	{
		if (marketingBase != null)
		{
			IMarketingPayment marketingPayment = InterfaceActivator.Create<IMarketingPayment>();
			marketingPayment.Name = SR.T("Первоначальный платеж по {0}", marketingBase.Name);
			marketingPayment.Sum = marketingBase.Budget;
			marketingPayment.MarketingObjectBase = marketingBase;
			marketingPayment.CreationDate = marketingBase.CreationDate;
			marketingPayment.Save();
		}
	}

	public override ActionCheckResult CanDelete(IMarketingPayment obj)
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMMarketingBudgetControlPermission, obj.MarketingObjectBase))
		{
			return base.CanDelete(obj);
		}
		return ActionCheckResult.True;
	}
}
