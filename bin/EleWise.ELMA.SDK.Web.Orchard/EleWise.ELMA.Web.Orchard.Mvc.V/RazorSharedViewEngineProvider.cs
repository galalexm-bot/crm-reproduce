using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;
using Orchard;
using Orchard.Mvc.ViewEngines;
using Orchard.Mvc.ViewEngines.Razor;
using Orchard.Mvc.ViewEngines.ThemeAwareness;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines;

public class RazorSharedViewEngineProvider : IViewEngineProvider, ISingletonDependency, IDependency
{
	private static readonly string[] DisabledFormats = new string[1] { "~/Disabled" };

	public ILogger Logger { get; set; }

	public RazorSharedViewEngineProvider()
	{
		Logger = NullLogger.Instance;
		RazorCompilationEventsShim.EnsureInitialized();
	}

	public IViewEngine CreateThemeViewEngine(CreateThemeViewEngineParams parameters)
	{
		string[] partialViewLocationFormats = new string[1] { parameters.VirtualPath + "/Views/Shared/{0}.cshtml" };
		string[] areaPartialViewLocationFormats = new string[1] { parameters.VirtualPath + "/Views/Shared/{2}/{1}/{0}.cshtml" };
		VirtualPathProviderViewEngine obj = CachedRazorViewEngine.Create();
		obj.set_MasterLocationFormats(DisabledFormats);
		obj.set_ViewLocationFormats(DisabledFormats);
		obj.set_PartialViewLocationFormats(partialViewLocationFormats);
		obj.set_AreaMasterLocationFormats(DisabledFormats);
		obj.set_AreaViewLocationFormats(DisabledFormats);
		obj.set_AreaPartialViewLocationFormats(areaPartialViewLocationFormats);
		obj.set_ViewLocationCache((IViewLocationCache)(object)new ThemeViewLocationCache(parameters.VirtualPath));
		return (IViewEngine)(object)obj;
	}

	public IViewEngine CreateModulesViewEngine(CreateModulesViewEngineParams parameters)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		string[] array = new string[3] { "~/Core/{2}/Views/Shared/{1}/{0}.cshtml", "~/Modules/{2}/Views/Shared/{1}/{0}.cshtml", "~/Themes/{2}/Views/Shared/{1}/{0}.cshtml" };
		string[] array2 = parameters.VirtualPaths.Select((string x) => x + "/Views/Shared/{0}.cshtml").Concat(new string[2] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" }).ToArray();
		VirtualPathProviderViewEngine obj = CachedRazorViewEngine.Create();
		obj.set_MasterLocationFormats(DisabledFormats);
		obj.set_ViewLocationFormats(array2);
		obj.set_PartialViewLocationFormats(array2);
		obj.set_AreaMasterLocationFormats(DisabledFormats);
		obj.set_AreaViewLocationFormats(array);
		obj.set_AreaPartialViewLocationFormats(array);
		obj.set_ViewLocationCache((IViewLocationCache)new DefaultViewLocationCache());
		return (IViewEngine)(object)obj;
	}

	public IViewEngine CreateBareViewEngine()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		VirtualPathProviderViewEngine obj = CachedRazorViewEngine.Create();
		obj.set_MasterLocationFormats(DisabledFormats);
		obj.set_ViewLocationFormats(DisabledFormats);
		obj.set_PartialViewLocationFormats(DisabledFormats);
		obj.set_AreaMasterLocationFormats(DisabledFormats);
		obj.set_AreaViewLocationFormats(DisabledFormats);
		obj.set_AreaPartialViewLocationFormats(DisabledFormats);
		obj.set_ViewLocationCache((IViewLocationCache)new DefaultViewLocationCache());
		return (IViewEngine)(object)obj;
	}

	public IEnumerable<string> DetectTemplateFileNames(IEnumerable<string> fileNames)
	{
		return fileNames.Where((string fileName) => fileName.EndsWith(".cshtml", StringComparison.OrdinalIgnoreCase));
	}
}
