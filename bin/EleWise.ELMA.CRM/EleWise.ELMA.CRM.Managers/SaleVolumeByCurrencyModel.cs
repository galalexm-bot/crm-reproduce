using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Managers;

internal class SaleVolumeByCurrencyModel
{
	public ICurrency Currency { get; set; }

	public double SalesVolume { get; set; }
}
