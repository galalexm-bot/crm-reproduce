using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Orchard.Mvc.ViewEngines.ThemeAwareness;

public class ViewEngineCollectionWrapper : IViewEngine
{
	private readonly IEnumerable<IViewEngine> _engines;

	public ViewEngineCollectionWrapper(IEnumerable<IViewEngine> engines)
	{
		_engines = engines.ToArray();
	}

	public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		IEnumerable<string> enumerable = Enumerable.Empty<string>();
		foreach (IViewEngine engine in _engines)
		{
			ViewEngineResult val = engine.FindPartialView(controllerContext, partialViewName, useCache);
			if (val.get_View() != null)
			{
				return val;
			}
			if (!useCache)
			{
				enumerable = enumerable.Concat(val.get_SearchedLocations());
			}
		}
		return new ViewEngineResult(enumerable.Distinct());
	}

	public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		IEnumerable<string> enumerable = Enumerable.Empty<string>();
		foreach (IViewEngine engine in _engines)
		{
			ViewEngineResult val = engine.FindView(controllerContext, viewName, masterName, useCache);
			if (val.get_View() != null)
			{
				return val;
			}
			if (!useCache)
			{
				enumerable = enumerable.Concat(val.get_SearchedLocations());
			}
		}
		return new ViewEngineResult(enumerable.Distinct());
	}

	public void ReleaseView(ControllerContext controllerContext, IView view)
	{
		throw new NotImplementedException();
	}
}
