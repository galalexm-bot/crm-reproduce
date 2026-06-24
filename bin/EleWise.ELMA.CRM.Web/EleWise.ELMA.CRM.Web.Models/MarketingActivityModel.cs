using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Models;

public class MarketingActivityModel : EntityModel<IMarketingBase>
{
	public bool LockParentItem { get; set; }

	public bool LockResponsible { get; set; }

	public MarketingActivityModel(IMarketingBase marketingActivity)
	{
		base.Entity = marketingActivity;
	}

	public MarketingActivityModel()
	{
	}

	public void Save()
	{
		base.Entity.Save();
	}
}
