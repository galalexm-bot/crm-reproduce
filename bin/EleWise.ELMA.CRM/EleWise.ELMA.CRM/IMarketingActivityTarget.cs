using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM;

public interface IMarketingActivityTarget
{
	IMarketingGroup MarketingGroup { get; set; }

	IMarketingActivity MarketingActivity { get; set; }

	IMarketingEffect MarketingEffect { get; set; }
}
