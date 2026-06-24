using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SaleStageManager : EntityManager<ISaleStage, long>
{
	private const string SaleStageColorFieldName = "Color";

	private const string ColorCodeFieldName = "ColorCode";

	private const string ColorBindingEntityUidFieldName = "EntityUid";

	private const string ColorBindingColorCodeFieldName = "ColorCode";

	private const string ColorAliasName = "c";

	public new static SaleStageManager Instance => Locator.GetServiceNotNull<SaleStageManager>();

	private void KickStage(IEnumerable<ISaleStage> stages, ISaleStage stage, ListSortDirection direction)
	{
		foreach (ISaleStage stage2 in stages)
		{
			if (direction == ListSortDirection.Ascending)
			{
				if (stage2.Id != stage.Id && stage2.GlobalOrder > stage.GlobalOrder)
				{
					stage2.GlobalOrder++;
				}
			}
			else if (stage2.Id != stage.Id && stage2.GlobalOrder >= stage.GlobalOrder)
			{
				stage2.GlobalOrder++;
			}
		}
		if (direction == ListSortDirection.Ascending)
		{
			stage.GlobalOrder++;
		}
	}

	private bool MergeStage(List<ISaleStage> stages, ISaleStage stage, ListSortDirection direction)
	{
		bool result = false;
		long targetOrder = 0L;
		if (direction == ListSortDirection.Ascending)
		{
			List<ISaleStage> source = stages.Where((ISaleStage x) => x.GlobalOrder > stage.GlobalOrder).ToList();
			if (source.Any() && source.Any((ISaleStage x) => x.SaleFunnel.Id != stage.SaleFunnel.Id))
			{
				targetOrder = source.Min((ISaleStage x) => x.GlobalOrder);
			}
		}
		else
		{
			List<ISaleStage> source2 = stages.Where((ISaleStage x) => x.GlobalOrder < stage.GlobalOrder).ToList();
			if (source2.Any() && source2.Any((ISaleStage x) => x.SaleFunnel.Id != stage.SaleFunnel.Id))
			{
				targetOrder = source2.Max((ISaleStage x) => x.GlobalOrder);
			}
		}
		if (targetOrder > 0)
		{
			ISaleStage forKick = stages.FirstOrDefault((ISaleStage x) => x.SaleFunnel.Id == stage.SaleFunnel.Id && x.GlobalOrder == targetOrder);
			if (forKick != null)
			{
				if (stages.Count((ISaleStage x) => x.GlobalOrder == forKick.GlobalOrder) > 1)
				{
					KickStage(stages, forKick, direction);
					MergeStage(stages, stage, direction);
				}
				else
				{
					MergeStage(stages, forKick, direction);
					MergeStage(stages, stage, direction);
				}
			}
			else
			{
				stage.GlobalOrder = targetOrder;
				result = true;
			}
		}
		return result;
	}

	[Transaction]
	public virtual List<ISaleStage> ChangeGlobalOrder(long id, ListSortDirection direction)
	{
		List<ISaleStage> list = (from x in Instance.FindAll()
			orderby x.GlobalOrder
			select x).ToList();
		ISaleStage stage = list.FirstOrDefault((ISaleStage x) => x.Id == id);
		if (list.Count((ISaleStage x) => x.GlobalOrder == stage.GlobalOrder) > 1)
		{
			KickStage(list, stage, direction);
		}
		else
		{
			MergeStage(list, stage, direction);
		}
		list = list.OrderBy((ISaleStage x) => x.GlobalOrder).ToList();
		long num = 0L;
		long num2 = 0L;
		foreach (ISaleStage item in list)
		{
			if (item.GlobalOrder != num2)
			{
				num++;
			}
			num2 = item.GlobalOrder;
			item.GlobalOrder = num;
			item.Save();
		}
		return list;
	}

	public virtual IEnumerable<ColorBinding> GetAllSaleStageColorBindings()
	{
		return CreateCriteria().CreateAlias("Color", "c").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property<ISaleStage>((Expression<Func<ISaleStage, object>>)((ISaleStage x) => x.Uid)), "EntityUid").Add((IProjection)(object)Projections.Property("c.ColorCode"), "ColorCode") }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ColorBinding)))
			.List<ColorBinding>();
	}
}
