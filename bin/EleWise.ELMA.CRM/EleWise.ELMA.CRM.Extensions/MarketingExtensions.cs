using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.CRM.Extensions;

public static class MarketingExtensions
{
	public static UtmType GetUtmType(this IMarketingBase marketingObject)
	{
		IMarketingBase marketingBase = marketingObject.CastAsRealType();
		if (marketingBase is IMarketingGroup)
		{
			return UtmType.Source;
		}
		if (marketingBase is IMarketingActivity)
		{
			return UtmType.Medium;
		}
		if (marketingBase is IMarketingEffect)
		{
			return UtmType.Campaign;
		}
		throw new Exception(SR.T("Неизвестный тип объекта маркетинга"));
	}
}
