using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Extensions;

public static class SaleExtensions
{
	public static bool SaleClosed(this ISale sale)
	{
		if (sale != null)
		{
			if (sale.SaleStatus != SaleStatus.NegativeClosed)
			{
				return sale.SaleStatus == SaleStatus.PositiveClosed;
			}
			return true;
		}
		return false;
	}
}
