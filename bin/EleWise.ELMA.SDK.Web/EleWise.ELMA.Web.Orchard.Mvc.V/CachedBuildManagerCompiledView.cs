using System;
using System.Globalization;
using System.IO;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Cache;

public abstract class CachedBuildManagerCompiledView : IView
{
	private ControllerContext _controllerContext;

	internal IViewPageActivator _viewPageActivator;

	public string ViewPath { get; protected set; }

	protected CachedBuildManagerCompiledView(ControllerContext controllerContext, string viewPath)
		: this(controllerContext, viewPath, null)
	{
	}

	protected CachedBuildManagerCompiledView(ControllerContext controllerContext, string viewPath, IViewPageActivator viewPageActivator)
		: this(controllerContext, viewPath, viewPageActivator, null)
	{
	}

	internal CachedBuildManagerCompiledView(ControllerContext controllerContext, string viewPath, IViewPageActivator viewPageActivator, IDependencyResolver dependencyResolver)
	{
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		if (string.IsNullOrEmpty(viewPath))
		{
			throw new ArgumentException("viewPath is null or empty");
		}
		_controllerContext = controllerContext;
		ViewPath = viewPath;
		_viewPageActivator = (IViewPageActivator)(((object)viewPageActivator) ?? ((object)new CachedBuildManagerViewEngine.DefaultViewPageActivator(dependencyResolver)));
	}

	public void Render(ViewContext viewContext, TextWriter writer)
	{
		RenderView(viewContext, writer);
	}

	protected virtual void RenderView(ViewContext viewContext, TextWriter writer)
	{
		if (viewContext == null)
		{
			throw new ArgumentNullException("viewContext");
		}
		object obj = null;
		Type compiledType = GetCompiledType();
		if (compiledType != null)
		{
			obj = _viewPageActivator.Create(_controllerContext, compiledType);
		}
		if (obj == null)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "View could not be created: {0}", new object[1] { ViewPath }));
		}
		RenderView(viewContext, writer, obj);
	}

	public abstract Type GetCompiledType();

	protected abstract void RenderView(ViewContext viewContext, TextWriter writer, object instance);
}
