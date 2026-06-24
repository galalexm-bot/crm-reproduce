using EleWise.ELMA.CRM.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM;

public interface IMarketingActivityTargetFilter
{
	ISet<IMarketingBase> MarketingObjects { get; set; }
}
