using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Cache;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;

public class CachedRazorView : CachedBuildManagerCompiledView
{
	private RenderViewInfo renderInfo;

	public string LayoutPath { get; private set; }

	public bool RunViewStartPages { get; private set; }

	internal StartPageLookupDelegate StartPageLookup { get; set; }

	public IEnumerable<string> ViewStartFileExtensions { get; private set; }

	public CachedRazorView(ControllerContext controllerContext, string viewPath, string layoutPath, bool runViewStartPages, IEnumerable<string> viewStartFileExtensions, IViewPageActivator viewPageActivator)
		: base(controllerContext, viewPath, viewPageActivator)
	{
		LayoutPath = layoutPath ?? string.Empty;
		RunViewStartPages = runViewStartPages;
		StartPageLookup = StartPage.GetStartPage;
		ViewStartFileExtensions = viewStartFileExtensions ?? Enumerable.Empty<string>();
	}

	public override Type GetCompiledType()
	{
		return BuildManager.GetCompiledType(VirtualPathUtility.ToAbsolute(base.ViewPath));
	}

	protected override void RenderView(ViewContext viewContext, TextWriter writer)
	{
		DiagnosticsManager.StartCall(() => new RenderViewInfo(viewContext, base.ViewPath, !RunViewStartPages), delegate
		{
			base.RenderView(viewContext, writer);
		});
	}

	protected override void RenderView(ViewContext viewContext, TextWriter writer, object instance)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		WebViewPage val = (WebViewPage)((instance is WebViewPage) ? instance : null);
		if (val == null)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "Wrong view base: {0}", base.ViewPath));
		}
		((WebPageExecutingBase)val).set_VirtualPath(base.ViewPath);
		val.set_ViewContext(viewContext);
		val.set_ViewData(viewContext.get_ViewData());
		val.InitHelpers();
		WebPageRenderingBase val2 = null;
		if (RunViewStartPages)
		{
			val2 = StartPageLookup((WebPageRenderingBase)(object)val, CachedRazorViewEngine.ViewStartFileName, ViewStartFileExtensions);
		}
		HttpContextBase httpContext = ((ControllerContext)viewContext).get_HttpContext();
		((WebPageBase)val).ExecutePageHierarchy(new WebPageContext(httpContext, (WebPageRenderingBase)null, (object)null), writer, val2);
	}
}
