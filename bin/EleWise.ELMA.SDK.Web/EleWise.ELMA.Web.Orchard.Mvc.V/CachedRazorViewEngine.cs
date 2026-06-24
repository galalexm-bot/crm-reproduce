using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Cache;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;

public class CachedRazorViewEngine : CachedBuildManagerViewEngine
{
	internal static readonly string ViewStartFileName = "_ViewStart";

	public static VirtualPathProviderViewEngine Create()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (!SR.GetSetting("UseCachedViewEngines", defaultValue: false))
		{
			return (VirtualPathProviderViewEngine)new RazorViewEngine();
		}
		return (VirtualPathProviderViewEngine)(object)new CachedRazorViewEngine();
	}

	public CachedRazorViewEngine()
		: this(null)
	{
	}

	public CachedRazorViewEngine(IViewPageActivator viewPageActivator)
		: base(viewPageActivator)
	{
		((VirtualPathProviderViewEngine)this).set_AreaViewLocationFormats(new string[4] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/{1}/{0}.vbhtml", "~/Areas/{2}/Views/Shared/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_AreaMasterLocationFormats(new string[4] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/{1}/{0}.vbhtml", "~/Areas/{2}/Views/Shared/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_AreaPartialViewLocationFormats(new string[4] { "~/Areas/{2}/Views/{1}/{0}.cshtml", "~/Areas/{2}/Views/{1}/{0}.vbhtml", "~/Areas/{2}/Views/Shared/{0}.cshtml", "~/Areas/{2}/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_ViewLocationFormats(new string[4] { "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml", "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_MasterLocationFormats(new string[4] { "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml", "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_PartialViewLocationFormats(new string[4] { "~/Views/{1}/{0}.cshtml", "~/Views/{1}/{0}.vbhtml", "~/Views/Shared/{0}.cshtml", "~/Views/Shared/{0}.vbhtml" });
		((VirtualPathProviderViewEngine)this).set_FileExtensions(new string[2] { "cshtml", "vbhtml" });
	}

	protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
	{
		string layoutPath = null;
		bool runViewStartPages = false;
		IEnumerable<string> fileExtensions = ((VirtualPathProviderViewEngine)this).get_FileExtensions();
		return (IView)(object)new CachedRazorView(controllerContext, partialPath, layoutPath, runViewStartPages, fileExtensions, base.ViewPageActivator);
	}

	protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
	{
		bool runViewStartPages = true;
		IEnumerable<string> fileExtensions = ((VirtualPathProviderViewEngine)this).get_FileExtensions();
		return (IView)(object)new CachedRazorView(controllerContext, viewPath, masterPath, runViewStartPages, fileExtensions, base.ViewPageActivator);
	}
}
