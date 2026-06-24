using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.CRM.Helpers;

internal static class MarketingObjectsWalker
{
	public static IMarketingBase GetParent(IMarketingBase marketingObj)
	{
		Contract.ArgumentNotNull(marketingObj, "marketingObj");
		if (marketingObj is IMarketingGroup)
		{
			return null;
		}
		if (marketingObj is IMarketingActivity marketingActivity)
		{
			return marketingActivity.MarketingGroup;
		}
		if (marketingObj is IMarketingEffect marketingEffect)
		{
			return marketingEffect.MarketingActivity;
		}
		throw new ArgumentException(SR.T("Неизвестный тип маркетингового объекта"));
	}

	public static IEnumerable<IMarketingBase> GetDescendantsWithEnabledInheritance(IMarketingBase marketingObj)
	{
		Contract.ArgumentNotNull(marketingObj, "marketingObj");
		IEnumerable<IMarketingBase> source = Enumerable.Empty<IMarketingBase>();
		if (marketingObj is IMarketingGroup marketingGroup)
		{
			source = (IEnumerable<IMarketingBase>)marketingGroup.MarketingActivities;
		}
		else if (marketingObj is IMarketingActivity marketingActivity)
		{
			source = (IEnumerable<IMarketingBase>)marketingActivity.MarketingEffects;
		}
		return source.Where((IMarketingBase m) => m.InheritPermissions);
	}

	public static IEnumerable<IMarketingBase> EnumerateParents(IMarketingBase marketingObj)
	{
		Contract.ArgumentNotNull(marketingObj, "marketingObj");
		return marketingObj.GenerateSequense(GetParent, (IMarketingBase obj) => obj != null).Skip(1);
	}

	public static IEnumerable<IMarketingBase> EnumerateTreeItemsWithEnabledInheritance(IMarketingBase marketingObj)
	{
		Contract.ArgumentNotNull(marketingObj, "marketingObj");
		return marketingObj.AsDepthFirstEnumerable((IMarketingBase obj) => GetDescendantsWithEnabledInheritance(obj)).Skip(1);
	}
}
