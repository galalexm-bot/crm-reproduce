namespace EleWise.ELMA.CRM.Models;

public class LeadMarketingStatisticCounts : LeadCounts
{
	public long SaleCurrent { get; set; }

	public long SalePositive { get; set; }

	public long SaleNegative { get; set; }
}
