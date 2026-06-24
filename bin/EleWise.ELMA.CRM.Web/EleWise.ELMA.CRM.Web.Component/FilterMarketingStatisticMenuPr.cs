using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 12)]
public class FilterMarketingStatisticMenuProviderExtension : IFilterMenuProviderExtension
{
	public IContentActionRegistry ContentActionRegistry { get; set; }

	public IComponentManager ComponentManager { get; set; }

	public bool SupportedFilter(IFilterFolder filterFolder)
	{
		return filterFolder.Uid == CrmConstants.MarketingStatisticActionFilter;
	}

	public void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string urlAction = null)
	{
		type = null;
		icon = null;
		href = null;
		if (urlHelper != null)
		{
			href = urlHelper.Action("MarketingStatistic", "MarketingActivity", (object)new
			{
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		canMakeDefault = true;
		if (filterFolder is IFilterActionLink)
		{
			type = "action";
			icon = "#statistic.svg";
		}
	}
}
