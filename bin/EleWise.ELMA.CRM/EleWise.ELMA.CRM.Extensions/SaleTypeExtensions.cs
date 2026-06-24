using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Extensions;

public static class SaleTypeExtensions
{
	public static bool UsedInSales(this ISaleType saleType)
	{
		ISaleFilter saleFilter = InterfaceActivator.Create<ISaleFilter>();
		saleFilter.SaleTypes.Add(saleType);
		saleFilter.DisableSecurity = true;
		return EntityManager<ISale>.Instance.Exists(saleFilter);
	}
}
