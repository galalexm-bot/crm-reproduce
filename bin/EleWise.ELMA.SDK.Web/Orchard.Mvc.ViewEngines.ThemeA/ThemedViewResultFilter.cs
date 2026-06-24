using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using Orchard.Mvc.Filters;
using Orchard.Themes;

namespace Orchard.Mvc.ViewEngines.ThemeAwareness;

public class ThemedViewResultFilter : FilterProvider, IResultFilter
{
	private readonly IThemeManager _themeManager;

	private readonly WorkContext _workContext;

	private readonly ILayoutAwareViewEngine _layoutAwareViewEngine;

	public ILogger Logger { get; set; }

	public ThemedViewResultFilter(IThemeManager themeManager, WorkContext workContext, ILayoutAwareViewEngine layoutAwareViewEngine)
	{
		_themeManager = themeManager;
		_workContext = workContext;
		_layoutAwareViewEngine = layoutAwareViewEngine;
		Logger = NullLogger.Instance;
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		ActionResult result = filterContext.get_Result();
		ViewResultBase val = (ViewResultBase)(object)((result is ViewResultBase) ? result : null);
		if (val != null)
		{
			if (_workContext.CurrentTheme == null)
			{
				_workContext.CurrentTheme = _themeManager.GetRequestTheme(((ControllerContext)filterContext).get_RequestContext());
			}
			val.set_ViewEngineCollection(new ViewEngineCollection((IList<IViewEngine>)new ILayoutAwareViewEngine[1] { _layoutAwareViewEngine }));
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
