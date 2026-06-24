using System;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class SelectMarketingActivityModel
{
	public long[] EntitiesId { get; set; }

	public Guid EntityTypeUid { get; set; }

	public IMarketingGroup MarketingGroup { get; set; }

	public IMarketingActivity MarketingActivity { get; set; }

	public IMarketingEffect MarketingEffect { get; set; }

	public string RedirectControllerName { get; set; }

	public string RedirectActionName { get; set; }

	public string EntitiesName { get; set; }

	public string EntitiesNameForErrorMessage { get; set; }
}
