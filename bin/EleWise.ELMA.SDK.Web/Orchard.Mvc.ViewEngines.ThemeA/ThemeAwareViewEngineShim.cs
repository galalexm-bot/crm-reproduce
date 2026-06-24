using System;
using System.Linq;
using System.Web.Mvc;
using Orchard.Environment;

namespace Orchard.Mvc.ViewEngines.ThemeAwareness;

public class ThemeAwareViewEngineShim : IViewEngine, IShim
{
	public IOrchardHostContainer HostContainer { get; set; }

	public ThemeAwareViewEngineShim()
	{
		OrchardHostContainerRegistry.RegisterShim(this);
	}

	public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
	{
		return Forward(controllerContext, (IThemeAwareViewEngine dve) => dve.FindPartialView(controllerContext, partialViewName, useCache, useDeepPaths: false), EmptyViewEngineResult);
	}

	public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
	{
		return Forward(controllerContext, (IThemeAwareViewEngine dve) => dve.FindView(controllerContext, viewName, masterName, useCache, useDeepPaths: false), EmptyViewEngineResult);
	}

	public void ReleaseView(ControllerContext controllerContext, IView view)
	{
		throw new NotImplementedException();
	}

	private static TResult Forward<TResult>(ControllerContext controllerContext, Func<IThemeAwareViewEngine, TResult> forwardAction, Func<TResult> defaultAction)
	{
		WorkContext workContext = controllerContext.GetWorkContext();
		if (workContext != null)
		{
			IThemeAwareViewEngine themeAwareViewEngine = workContext.Resolve<IThemeAwareViewEngine>();
			if (themeAwareViewEngine != null)
			{
				return forwardAction(themeAwareViewEngine);
			}
		}
		return defaultAction();
	}

	private static ViewEngineResult EmptyViewEngineResult()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new ViewEngineResult(Enumerable.Empty<string>());
	}
}
