using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ProductManager : EntityManager<IProduct, long>
{
	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IProductFilter productFilter && productFilter.IsGroup.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("IsGroup", (object)productFilter.IsGroup.Value));
		}
	}

	[Transaction]
	[Auditable]
	public override void Delete(IProduct obj)
	{
		if (!obj.IsGroup)
		{
			ISaleProductFilter saleProductFilter = InterfaceActivator.Create<ISaleProductFilter>();
			saleProductFilter.Query = $"Product IN (Id = {obj.Id})";
			if (AbstractNHEntityManager<ISaleProduct, long>.Instance.Exists(saleProductFilter))
			{
				throw new Exception(SR.T("Нельзя удалять продукт использующийся в сделке"));
			}
		}
		base.Delete(obj);
	}
}
