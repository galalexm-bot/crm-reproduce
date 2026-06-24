using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Code;

public static class MarketingActivityRelatedEntitiesFinder
{
	public static GridData<T> Find<T>(GridCommand command, IMarketingBase marketingBase) where T : class, IEntity<long>
	{
		if (marketingBase == null)
		{
			return CreateEmptyResult<T>(command);
		}
		object obj = InterfaceActivator.Create(ModelHelper.GetEntityFilterType(typeof(T)));
		if (!(obj is IMarketingActivityTargetFilter marketingActivityTargetFilter))
		{
			return CreateEmptyResult<T>(command);
		}
		marketingActivityTargetFilter.MarketingObjects.Add(marketingBase);
		return AbstractNHEntityManager<T, long>.Instance.CreateGridData(command, obj as IEntityFilter);
	}

	private static GridData<T> CreateEmptyResult<T>(GridCommand command) where T : class, IEntity<long>
	{
		return AbstractNHEntityManager<T, long>.Instance.CreateGridData(command);
	}
}
