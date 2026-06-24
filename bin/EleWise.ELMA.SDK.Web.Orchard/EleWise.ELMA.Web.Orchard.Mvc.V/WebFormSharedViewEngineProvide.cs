using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using Orchard;
using Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;
using Orchard.Mvc.ViewEngines;
using Orchard.Mvc.ViewEngines.ThemeAwareness;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines;

public class WebFormSharedViewEngineProvider : IViewEngineProvider, ISingletonDependency, IDependency, IShapeTemplateViewEngine
{
	private static readonly string[] DisabledFormats = new string[1] { "~/Disabled" };

	public ILogger Logger { get; set; }

	public WebFormSharedViewEngineProvider()
	{
		Logger = NullLogger.Instance;
	}

	public IViewEngine CreateThemeViewEngine(CreateThemeViewEngineParams parameters)
	{
		string[] partialViewLocationFormats = new string[2]
		{
			parameters.VirtualPath + "/Views/Shared/{0}.ascx",
			parameters.VirtualPath + "/Views/{0}.aspx"
		};
		string[] areaPartialViewLocationFormats = new string[2]
		{
			parameters.VirtualPath + "/Views/Shared/{2}/{1}/{0}.ascx",
			parameters.VirtualPath + "/Views/Shared/{2}/{1}/{0}.aspx"
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
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		string[] array = new string[6] { "~/Core/{2}/Views/Shared/{1}/{0}.ascx", "~/Core/{2}/Views/{1}/Shared/{0}.aspx", "~/Modules/{2}/Views/Shared/{1}/{0}.ascx", "~/Modules/{2}/Views/Shared/{1}/{0}.aspx", "~/Themes/{2}/Views/Shared/{1}/{0}.ascx", "~/Themes/{2}/Views/Shared/{1}/{0}.aspx" };
		string[] array2 = parameters.VirtualPaths.SelectMany((string x) => new string[2]
		{
			x + "/Views/Shared/{0}.ascx",
			x + "/Views/Shared/{0}.aspx"
		}).ToArray();
		WebFormViewEngine webFormViewEngine = new WebFormViewEngine();
		((VirtualPathProviderViewEngine)webFormViewEngine).set_MasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationFormats(array2);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_PartialViewLocationFormats(array2);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaMasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaViewLocationFormats(array);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaPartialViewLocationFormats(array);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationCache((IViewLocationCache)new DefaultViewLocationCache());
		return (IViewEngine)(object)webFormViewEngine;
	}

	public IViewEngine CreateBareViewEngine()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		WebFormViewEngine webFormViewEngine = new WebFormViewEngine();
		((VirtualPathProviderViewEngine)webFormViewEngine).set_MasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_PartialViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaMasterLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_AreaPartialViewLocationFormats(DisabledFormats);
		((VirtualPathProviderViewEngine)webFormViewEngine).set_ViewLocationCache((IViewLocationCache)new DefaultViewLocationCache());
		return (IViewEngine)(object)webFormViewEngine;
	}

	public IEnumerable<string> DetectTemplateFileNames(IEnumerable<string> fileNames)
	{
		return fileNames.Where((string fileName) => fileName.EndsWith(".aspx", StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".ascx", StringComparison.OrdinalIgnoreCase));
	}
}
