using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard;
using Orchard.DisplayManagement;
using Orchard.Mvc.Spooling;
using Orchard.Mvc.ViewEngines.ThemeAwareness;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.ThemeAwareness;

public class LayoutAwareViewEngine : ILayoutAwareViewEngine, IDependency, IViewEngine
{
	private class LayoutView : IView, IViewDataContainer
	{
		private readonly Action<ViewContext, TextWriter, IViewDataContainer> _render;

		private readonly Action<ControllerContext, IView> _releaseView;

		public ViewDataDictionary ViewData { get; set; }

		public LayoutView(Action<ViewContext, TextWriter, IViewDataContainer> render, Action<ControllerContext, IView> releaseView)
		{
			_render = render;
			_releaseView = releaseView;
		}

		public void Render(ViewContext viewContext, TextWriter writer)
		{
			ViewData = viewContext.get_ViewData();
			_render(viewContext, writer, (IViewDataContainer)(object)this);
		}

		public void ReleaseView(ControllerContext context, IView view)
		{
			_releaseView(context, view);
		}
	}

	private readonly WorkContext _workContext;

	private readonly IThemeAwareViewEngine _themeAwareViewEngine;

	private readonly IDisplayHelperFactory _displayHelperFactory;

	private readonly IEnumerable<ISkipLauoutApply> skipLauoutApplies;

	public LayoutAwareViewEngine(WorkContext workContext, IThemeAwareViewEngine themeAwareViewEngine, IDisplayHelperFactory displayHelperFactory, IEnumerable<ISkipLauoutApply> skipLauoutApplies)
	{
		_workContext = workContext;
		_themeAwareViewEngine = themeAwareViewEngine;
		_displayHelperFactory = displayHelperFactory;
		this.skipLauoutApplies = skipLauoutApplies;
	}

	public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
	{
		return _themeAwareViewEngine.FindPartialView(controllerContext, partialViewName, useCache, useDeepPaths: true);
	}

	public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		ViewEngineResult viewResult = _themeAwareViewEngine.FindPartialView(controllerContext, viewName, useCache, useDeepPaths: true);
		if (viewResult.get_View() == null)
		{
			return viewResult;
		}
		if (skipLauoutApplies.Any((ISkipLauoutApply s) => s.Skip(controllerContext)))
		{
			return viewResult;
		}
		if (!ThemeFilter.IsApplied(controllerContext.get_RequestContext()))
		{
			return viewResult;
		}
		return new ViewEngineResult((IView)(object)new LayoutView(delegate(ViewContext viewContext, TextWriter writer, IViewDataContainer viewDataContainer)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			HtmlStringWriter htmlStringWriter = new HtmlStringWriter();
			ViewContext val = new ViewContext((ControllerContext)(object)viewContext, viewContext.get_View(), viewContext.get_ViewData(), viewContext.get_TempData(), (TextWriter)htmlStringWriter);
			viewResult.get_View().Render(val, (TextWriter)htmlStringWriter);
			_workContext.Layout.Metadata.ChildContent = htmlStringWriter;
			object obj = _displayHelperFactory.CreateHelper(viewContext, viewDataContainer);
			IHtmlString htmlString = ((dynamic)obj)(_workContext.Layout);
			writer.Write(htmlString.ToHtmlString());
		}, delegate(ControllerContext context, IView view)
		{
			viewResult.get_ViewEngine().ReleaseView(context, viewResult.get_View());
		}), (IViewEngine)(object)this);
	}

	public void ReleaseView(ControllerContext controllerContext, IView view)
	{
		((LayoutView)(object)view).ReleaseView(controllerContext, view);
	}
}
