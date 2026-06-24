using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.WebForms;
using Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;

namespace Orchard.Mvc.ViewEngines.WebForms;

public class WebFormViewEngineProvider : IViewEngineProvider, ISingletonDependency, IDependency, IShapeTemplateViewEngine
{
	private static readonly string[] DisabledFormats = new string[1] { "~/Disabled" };

	public ILogger Logger { get; set; }

	public WebFormViewEngineProvider()
	{
		Logger = NullLogger.Instance;
	}

	public IViewEngine CreateThemeViewEngine(CreateThemeViewEngineParams parameters)
	{
		string[] partialViewLocationFormats = new string[2]
		{
			parameters.VirtualPath + "/Views/{0}.ascx",
			parameters.VirtualPath + "/Views/{0}.aspx"
		};
		string[] areaPartialViewLocationFormats = new string[2]
		{
			parameters.VirtualPath + "/Views/{2}/{1}/{0}.ascx",
			parameters.VirtualPath + "/Views/{2}/{1}/{0}.aspx"
		};
		WebFormViewEngine webFormViewEngine = new WebFormViewEngine();
		((VirtualPathProviderViewEngine)webFormViewEngine).set_MasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_PartialViewLocationFormats(partialViewLocationFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaMasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaPartialViewLocationFormats(areaPartialViewLocationFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationCache((IViewLocationCache)(object)new ThemeViewLocationCache(parameters.VirtualPath));
		return (IViewEngine)(object)webFormViewEngine;
	}

	public IViewEngine CreateModulesViewEngine(CreateModulesViewEngineParams parameters)
	{
		string[] array = new string[6] { "~/Core/{2}/Views/{1}/{0}.ascx", "~/Core/{2}/Views/{1}/{0}.aspx", "~/Modules/{2}/Views/{1}/{0}.ascx", "~/Modules/{2}/Views/{1}/{0}.aspx", "~/Themes/{2}/Views/{1}/{0}.ascx", "~/Themes/{2}/Views/{1}/{0}.aspx" };
		string[] array2 = parameters.VirtualPaths.SelectMany((string x) => new string[2]
		{
			x + "/Views/{0}.ascx",
			x + "/Views/{0}.aspx"
		}).ToArray();
		WebFormViewEngine webFormViewEngine = new WebFormViewEngine();
		((VirtualPathProviderViewEngine)webFormViewEngine).set_MasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationFormats(array2);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_PartialViewLocationFormats(array2);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaMasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaViewLocationFormats(array);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaPartialViewLocationFormats(array);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationCache((IViewLocationCache)(object)new DefaultViewLocationCache());
		return (IViewEngine)(object)webFormViewEngine;
	}

	public IViewEngine CreateBareViewEngine()
	{
		WebFormViewEngine webFormViewEngine = new WebFormViewEngine();
		((VirtualPathProviderViewEngine)webFormViewEngine).set_MasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_PartialViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaMasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaPartialViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationCache((IViewLocationCache)(object)new DefaultViewLocationCache());
		return (IViewEngine)(object)webFormViewEngine;
	}

	public IEnumerable<string> DetectTemplateFileNames(IEnumerable<string> fileNames)
	{
		return fileNames.Where((string fileName) => fileName.EndsWith(".aspx", StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".ascx", StringComparison.OrdinalIgnoreCase));
	}
}
