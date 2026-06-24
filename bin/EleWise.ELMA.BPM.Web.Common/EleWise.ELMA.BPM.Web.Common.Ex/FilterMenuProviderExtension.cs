using System.ComponentModel;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 100)]
public class FilterMenuProviderExtension : IFilterMenuProviderExtension
{
	public bool SupportedFilter(IFilterFolder filterFolder)
	{
		return true;
	}

	public void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string action = null)
	{
		type = ((filterFolder.ParentFolder != null) ? ((filterFolder is IFilter) ? "filter" : "folder") : ((filterFolder is IFilter) ? "top_filter" : "top_folder"));
		icon = ((filterFolder is IFilter) ? "#filter.svg" : "#folder.svg");
		href = null;
		canMakeDefault = filterFolder is IFilter;
		if (!(filterFolder is IFilter) || urlHelper == null || filterIdParameter == null || routes == null)
		{
			return;
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary(routes.Routes);
		object obj = HttpContextAccessor.CurrentContext.Items["filterAdditionalRouteParameters"];
		if (obj != null)
		{
			foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(obj))
			{
				routeValueDictionary.Add(property.Name, property.GetValue(obj));
			}
		}
		routeValueDictionary.Add(filterIdParameter, filterFolder.Id);
		href = urlHelper.Action(action ?? routes.Action, routes.Controller, routeValueDictionary);
	}
}
