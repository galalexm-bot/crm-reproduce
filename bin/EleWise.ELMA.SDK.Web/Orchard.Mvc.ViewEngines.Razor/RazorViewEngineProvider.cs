using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;
using Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;
using Orchard.Mvc.ViewEngines.ThemeAwareness;

namespace Orchard.Mvc.ViewEngines.Razor;

public class RazorViewEngineProvider : IViewEngineProvider, ISingletonDependency, IDependency, IShapeTemplateViewEngine
{
	private static readonly string[] DisabledFormats = new string[1] { "~/Disabled" };

	public ILogger Logger { get; set; }

	public RazorViewEngineProvider()
	{
		Logger = NullLogger.Instance;
		RazorCompilationEventsShim.EnsureInitialized();
	}

	public IViewEngine CreateThemeViewEngine(CreateThemeViewEngineParams parameters)
	{
		string[] partialViewLocationFormats = new string[2]
		{
			parameters.VirtualPath + "/Views/{0}.cshtml",
			parameters.VirtualPath + "/Views/{1}/{0}.cshtml"
		};
		string[] areaPartialViewLocationFormats = new string[1] { parameters.VirtualPath + "/Views/{2}/{1}/{0}.cshtml" };
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
		string[] array = parameters.ExtensionLocations.Select((string location) => location + "/{2}/Views/{1}/{0}.cshtml").ToArray();
		string[] array2 = parameters.VirtualPaths.Select((string x) => x + "/Views/{0}.cshtml").Concat(new string[2] { "~/Views/{1}/{0}.cshtml", "~/Views/{0}.cshtml" }).ToArray();
		VirtualPathProviderViewEngine obj = CachedRazorViewEngine.Create();
		obj.set_MasterLocationFormats(DisabledFormats);
		obj.set_ViewLocationFormats(array2);
		obj.set_PartialViewLocationFormats(array2);
		obj.set_AreaMasterLocationFormats(DisabledFormats);
		obj.set_AreaViewLocationFormats(array);
		obj.set_AreaPartialViewLocationFormats(array);
		return (IViewEngine)(object)obj;
	}

	public IViewEngine CreateBareViewEngine()
	{
		VirtualPathProviderViewEngine obj = CachedRazorViewEngine.Create();
		obj.set_MasterLocationFormats(DisabledFormats);
		obj.set_ViewLocationFormats(DisabledFormats);
		obj.set_PartialViewLocationFormats(DisabledFormats);
		obj.set_AreaMasterLocationFormats(DisabledFormats);
		obj.set_AreaViewLocationFormats(DisabledFormats);
		obj.set_AreaPartialViewLocationFormats(DisabledFormats);
		return (IViewEngine)(object)obj;
	}

	public IEnumerable<string> DetectTemplateFileNames(IEnumerable<string> fileNames)
	{
		return fileNames.Where((string fileName) => fileName.EndsWith(".cshtml", StringComparison.OrdinalIgnoreCase));
	}
}
