using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.DisplayManagement;
using Orchard.Mvc.Filters;
using Orchard.UI.Admin;

namespace Orchard.UI.Navigation;

public class MenuFilter : FilterProvider, IResultFilter
{
	private readonly INavigationManager _navigationManager;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly dynamic _shapeFactory;

	public MenuFilter(INavigationManager navigationManager, IWorkContextAccessor workContextAccessor, IShapeFactory shapeFactory)
	{
		_navigationManager = navigationManager;
		_workContextAccessor = workContextAccessor;
		_shapeFactory = shapeFactory;
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (!(filterContext.get_Result() is ViewResult))
		{
			return;
		}
		WorkContext context = _workContextAccessor.GetContext((ControllerContext)(object)filterContext);
		if (!AdminFilter.IsApplied(((ControllerContext)filterContext).get_RequestContext()))
		{
			return;
		}
		IEnumerable<MenuItem> enumerable = _navigationManager.BuildMenu("admin");
		RouteValueDictionary routeData = new RouteValueDictionary(((ControllerContext)filterContext).get_RouteData().Values);
		NameValueCollection queryString = context.HttpContext.Request.QueryString;
		if (queryString != null)
		{
			foreach (string item in from string key in queryString.Keys
				where key != null && !routeData.ContainsKey(key)
				let value = queryString[key]
				select key)
			{
				routeData[item] = queryString[item];
			}
		}
		Stack<MenuItem> stack = NavigationHelper.SetSelectedPath(enumerable, context.HttpContext.Request, routeData);
		dynamic val = _shapeFactory.Menu().MenuName("admin");
		NavigationHelper.PopulateMenu(_shapeFactory, val, val, enumerable);
		IEnumerable<string> enumerable2 = _navigationManager.BuildImageSets("admin");
		if (enumerable2 != null && enumerable2.Any())
		{
			val.ImageSets(enumerable2);
		}
		context.Layout.Navigation.Add(val);
		dynamic val2 = _shapeFactory.LocalMenu().MenuName(string.Format("local_{0}", "admin"));
		NavigationHelper.PopulateLocalMenu(_shapeFactory, val2, val2, stack);
		context.Layout.LocalNavigation.Add(val2);
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
