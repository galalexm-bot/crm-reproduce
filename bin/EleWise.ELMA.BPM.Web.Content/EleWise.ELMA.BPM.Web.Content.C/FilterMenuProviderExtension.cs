using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = 90)]
public class FilterMenuProviderExtension : IFilterMenuProviderExtension
{
	public IContentActionRegistry ContentActionRegistry { get; set; }

	public IComponentManager ComponentManager { get; set; }

	public bool SupportedFilter(IFilterFolder filterFolder)
	{
		return filterFolder is IFilterActionLink;
	}

	public void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string urlAction = null)
	{
		type = null;
		icon = null;
		href = null;
		IFilterActionLink action = filterFolder as IFilterActionLink;
		canMakeDefault = action == null;
		if (action == null)
		{
			return;
		}
		type = "action";
		icon = (isDefault ? "~/Content/IconPack/link.svg" : (isSystemDefault ? "~/Content/IconPack/link.svg" : "~/Content/IconPack/add.svg"));
		if (action.ActionTypeProviderId == null || action.ActionId == null)
		{
			return;
		}
		ContentAction contentItem = ((ContentActionRegistry != null) ? (ContentActionRegistry.Get(action.ActionTypeProviderId, action.ActionId) as ContentAction) : null);
		if (contentItem == null)
		{
			return;
		}
		if (contentItem.Routes != null && contentItem.Routes.Routes != null && contentItem.Routes.Area == "EleWise.ELMA.BPM.Web.Content" && contentItem.Routes.Controller == "Page" && contentItem.Routes.Routes.All((KeyValuePair<string, object> r) => r.Key != "activeMenuItemCode"))
		{
			bool canMakeDefault_ = canMakeDefault;
			ComponentManager.GetExtensionPoints<IContentFilterMenuItemIdExtension>().FirstOrDefault((IContentFilterMenuItemIdExtension e) => e.SetParameters(action, contentItem.Routes, ref canMakeDefault_));
			canMakeDefault = canMakeDefault_;
		}
		if (urlHelper != null)
		{
			href = contentItem.GetHref(urlHelper.get_RequestContext());
		}
	}
}
