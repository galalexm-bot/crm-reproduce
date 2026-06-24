namespace EleWise.ELMA.CRM.Models;

public class LeadDynamicCount
{
	public IMarketingGroup MarketingGroup { get; set; }

	public long MarketingGroupId { get; set; }

	public IMarketingActivity MarketingActivity { get; set; }

	public long MarketingActivityId { get; set; }

	public IMarketingEffect MarketingEffect { get; set; }

	public long MarketingEffectId { get; set; }

	public long[] AllCountMonth { get; set; }

	public long[] ConvertedCountMonth { get; set; }
}
