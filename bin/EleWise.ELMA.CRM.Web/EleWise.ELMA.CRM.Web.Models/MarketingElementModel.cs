using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class MarketingElementModel
{
	private readonly int countColumn;

	public IMarketingBase Entity { get; set; }

	public long[] AllCountMonth { get; set; }

	public long[] ConvertedCountMonth { get; set; }

	public bool AnyChildren { get; set; }

	public bool IsShow { get; set; }

	public bool UserHasCreateItemsPermission { get; set; }

	public MarketingElementModel()
	{
	}

	public MarketingElementModel(IMarketingGroup group, IEnumerable<LeadDynamicCount> listCount, int countCol, bool showArchive = false)
	{
		Entity = group;
		AnyChildren = (showArchive ? ((IEnumerable<IMarketingActivity>)group.MarketingActivities).Any((IMarketingActivity m) => !m.IsDeleted && m.Status == MarketingObjectStatus.Archived) : ((IEnumerable<IMarketingActivity>)group.MarketingActivities).Any((IMarketingActivity m) => !m.IsDeleted && m.Status == MarketingObjectStatus.Active));
		countColumn = countCol;
		SetCount(listCount.Where((LeadDynamicCount m) => m.MarketingGroup != null && m.MarketingGroup.Id == group.Id));
	}

	public MarketingElementModel(IEnumerable<LeadDynamicCount> listCount, int countCol, bool showArchive = false)
	{
		Entity = null;
		AnyChildren = true;
		countColumn = countCol;
		SetCount(listCount);
	}

	public MarketingElementModel(IMarketingActivity activity, IEnumerable<LeadDynamicCount> listCount, int countCol, bool showArchive = false)
	{
		Entity = activity;
		AnyChildren = (showArchive ? ((IEnumerable<IMarketingEffect>)activity.MarketingEffects).Any((IMarketingEffect m) => !m.IsDeleted && m.Status == MarketingObjectStatus.Archived) : ((IEnumerable<IMarketingEffect>)activity.MarketingEffects).Any((IMarketingEffect m) => !m.IsDeleted && m.Status == MarketingObjectStatus.Active));
		countColumn = countCol;
		SetCount(listCount.Where((LeadDynamicCount m) => m.MarketingActivity != null && m.MarketingActivity.Id == activity.Id));
	}

	public MarketingElementModel(IMarketingEffect effect, IEnumerable<LeadDynamicCount> listCount, int countCol, bool showArchive = false)
	{
		Entity = effect;
		countColumn = countCol;
		SetCount(listCount.Where((LeadDynamicCount m) => m.MarketingEffect != null && m.MarketingEffect.Id == effect.Id));
	}

	private void SetCount(IEnumerable<LeadDynamicCount> resultList)
	{
		AllCountMonth = new long[countColumn];
		ConvertedCountMonth = new long[countColumn];
		if (resultList == null || !resultList.Any())
		{
			return;
		}
		int i;
		for (i = 0; i < countColumn; i++)
		{
			AllCountMonth[i] = resultList.Sum((LeadDynamicCount m) => m.AllCountMonth[i]);
			ConvertedCountMonth[i] = resultList.Sum((LeadDynamicCount m) => m.ConvertedCountMonth[i]);
		}
	}
}
