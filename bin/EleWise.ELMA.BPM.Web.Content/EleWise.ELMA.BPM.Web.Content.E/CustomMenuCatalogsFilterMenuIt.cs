using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Extensions;

[Component(Order = int.MaxValue)]
internal class CustomMenuCatalogsFilterMenuItemExtension : IFilterMenuItemExtension
{
	public IEnumerable<FilterMenuItem> FilterMenuItems()
	{
		IMenu currentLeftMenuReadOnly = WorkPlaceExtensions.GetCurrentLeftMenuReadOnly();
		return (from i in MenuItemManager.Instance.LoadItemsReadOnly(currentLeftMenuReadOnly.Uid, allowDisabled: true)
			where i.ActionTypeProviderId == ComponentManager.Current.GetExtensionPointByType<UrlActionProvider>().Id && i.ActionId.Contains("/Common/Catalogs/View?")
			select i).Select(delegate(IMenuItem i)
		{
			Guid guid = ParseGuid(i.ActionId);
			return new FilterMenuItem
			{
				TypeUid = guid,
				Code = i.ActionId,
				FilterIdParameter = "FilterId",
				FilterEditAction = "EditFilters",
				Routes = new ActionRoute("View", "Catalogs", new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = guid
				})
			};
		}).ToList();
	}

	private Guid ParseGuid(string actionId)
	{
		Uri result = new Uri(actionId, UriKind.RelativeOrAbsolute);
		if (!result.IsAbsoluteUri)
		{
			Uri.TryCreate(new Uri(Locator.GetServiceNotNull<CommonSettingsModule>().Settings.ApplicationBaseUrl), result, out result);
		}
		return new Guid(HttpUtility.ParseQueryString(result.Query).Get("uid"));
	}
}
