using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Web.Models;

public class OnePeriodStatisticModel
{
	public DateTimeRange Period { get; set; }

	public LeadMarketingStatisticCounts LeadCount { get; set; }

	public double SumPayment { get; set; }
}
