using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Cache;

public abstract class CachedBuildManagerViewEngine : VirtualPathProviderViewEngine
{
	internal class DefaultViewPageActivator : IViewPageActivator
	{
		private readonly Func<IDependencyResolver> _resolverThunk;

		public DefaultViewPageActivator()
			: this(null)
		{
		}

		public DefaultViewPageActivator(IDependencyResolver resolver)
		{
			if (resolver == null)
			{
				_resolverThunk = () => DependencyResolver.get_Current();
			}
			else
			{
				_resolverThunk = () => resolver;
			}
		}

		public object Create(ControllerContext controllerContext, Type type)
		{
			return _resolverThunk().GetService(type) ?? Activator.CreateInstance(type);
		}
	}

	private class ViewLocation
	{
		protected string _virtualPathFormatString;

		public ViewLocation(string virtualPathFormatString)
		{
			_virtualPathFormatString = virtualPathFormatString;
		}

		public virtual string Format(string viewName, string controllerName, string areaName)
		{
			return string.Format(CultureInfo.InvariantCulture, _virtualPathFormatString, viewName, controllerName);
		}
	}

	private class AreaAwareViewLocation : ViewLocation
	{
		public AreaAwareViewLocation(string virtualPathFormatString)
			: base(virtualPathFormatString)
		{
		}

		public override string Format(string viewName, string controllerName, string areaName)
		{
			return string.Format(CultureInfo.InvariantCulture, _virtualPathFormatString, viewName, controllerName, areaName);
		}
	}

	private IViewPageActivator _viewPageActivator;

	private static IEnumerable<IViewEngineOtherVirtualPaths> viewEngineOtherVirtualPaths;

	private static readonly string[] _emptyLocations = new string[0];

	private static Type mvcResources = null;

	private static ResourceManager mvcResources_ResourceManager = null;

	private static CultureInfo mvcResources_Culture = null;

	protected IViewPageActivator ViewPageActivator
	{
		get
		{
			if (_viewPageActivator == null)
			{
				_viewPageActivator = (IViewPageActivator)(object)new DefaultViewPageActivator();
			}
			return _viewPageActivator;
		}
	}

	private static IEnumerable<IViewEngineOtherVirtualPaths> ViewEngineOtherVirtualPaths => viewEngineOtherVirtualPaths ?? (viewEngineOtherVirtualPaths = ComponentManager.Current.GetExtensionPoints<IViewEngineOtherVirtualPaths>());

	private static ResourceManager MvcResources_ResourceManager
	{
		get
		{
			if (mvcResources_ResourceManager == null)
			{
				mvcResources = mvcResources ?? typeof(VirtualPathProviderViewEngine).Assembly.GetType("System.Web.Mvc.Resources.MvcResources");
				mvcResources_ResourceManager = (ResourceManager)mvcResources.GetProperty("ResourceManager", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty).GetValue(null, null);
			}
			return mvcResources_ResourceManager;
		}
	}

	private static CultureInfo MvcResources_Culture
	{
		get
		{
			if (mvcResources_Culture == null)
			{
				mvcResources = mvcResources ?? typeof(VirtualPathProviderViewEngine).Assembly.GetType("System.Web.Mvc.Resources.MvcResources");
				mvcResources_Culture = (CultureInfo)mvcResources.GetProperty("Culture", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty).GetValue(null, null);
			}
			return mvcResources_Culture;
		}
	}

	protected CachedBuildManagerViewEngine()
		: this(null)
	{
	}

	protected CachedBuildManagerViewEngine(IViewPageActivator viewPageActivator)
	{
		_viewPageActivator = viewPageActivator;
	}

	private bool FilePathIsSupported(string virtualPath)
	{
		if (((VirtualPathProviderViewEngine)this).get_FileExtensions() != null)
		{
			return ((VirtualPathProviderViewEngine)this).get_FileExtensions().Contains(VirtualPathUtility.GetExtension(virtualPath).TrimStart('.'), StringComparer.OrdinalIgnoreCase);
		}
		return true;
	}

	private static string GetAreaName(RouteBase route)
	{
		IRouteWithArea val = (IRouteWithArea)(object)((route is IRouteWithArea) ? route : null);
		if (val != null)
		{
			return val.get_Area();
		}
		if (!(route is Route route2) || route2.DataTokens == null)
		{
			return null;
		}
		return route2.DataTokens["area"] as string;
	}

	private static string GetAreaName(RouteData routeData)
	{
		if (!routeData.DataTokens.TryGetValue("area", out var value))
		{
			return GetAreaName(routeData.Route);
		}
		return value as string;
	}

	public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		if (string.IsNullOrEmpty(partialViewName))
		{
			throw new ArgumentException(MvcResources_ResourceManager.GetString("Common_NullOrEmpty", MvcResources_Culture), "partialViewName");
		}
		using FindViewInfo findViewInfo = DiagnosticsManager.StartCall(() => new FindViewInfo(controllerContext, partialViewName, null, null, isFound: false, useCache, isPartial: true));
		string[] searchedLocations;
		string path = GetPath(controllerContext, ((VirtualPathProviderViewEngine)this).get_PartialViewLocationFormats(), ((VirtualPathProviderViewEngine)this).get_AreaPartialViewLocationFormats(), "PartialViewLocationFormats", partialViewName, controllerContext.get_RouteData().GetRequiredString("controller"), "Partial", useCache, out searchedLocations);
		bool flag = string.IsNullOrEmpty(path);
		ViewEngineResult val = (flag ? new ViewEngineResult((IEnumerable<string>)searchedLocations) : new ViewEngineResult(((VirtualPathProviderViewEngine)this).CreatePartialView(controllerContext, path), (IViewEngine)(object)this));
		if (findViewInfo != null)
		{
			findViewInfo.SearchedLocations = searchedLocations;
			findViewInfo.IsFound = !flag;
			findViewInfo.ViewEngineResult = val;
		}
		return val;
	}

	public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		if (controllerContext == null)
		{
			throw new ArgumentNullException("controllerContext");
		}
		if (string.IsNullOrEmpty(viewName))
		{
			throw new ArgumentException(MvcResources_ResourceManager.GetString("Common_NullOrEmpty", MvcResources_Culture), "viewName");
		}
		using FindViewInfo findViewInfo = DiagnosticsManager.StartCall(() => new FindViewInfo(controllerContext, viewName, masterName, null, isFound: false, useCache, isPartial: false));
		string requiredString = controllerContext.get_RouteData().GetRequiredString("controller");
		string[] searchedLocations;
		string path = GetPath(controllerContext, ((VirtualPathProviderViewEngine)this).get_ViewLocationFormats(), ((VirtualPathProviderViewEngine)this).get_AreaViewLocationFormats(), "ViewLocationFormats", viewName, requiredString, "View", useCache, out searchedLocations);
		string[] searchedLocations2;
		string path2 = GetPath(controllerContext, ((VirtualPathProviderViewEngine)this).get_MasterLocationFormats(), ((VirtualPathProviderViewEngine)this).get_AreaMasterLocationFormats(), "MasterLocationFormats", masterName, requiredString, "Master", useCache, out searchedLocations2);
		string[] array = searchedLocations.Union(searchedLocations2).ToArray();
		bool flag = string.IsNullOrEmpty(path) || (string.IsNullOrEmpty(path2) && !string.IsNullOrEmpty(masterName));
		ViewEngineResult val = (flag ? new ViewEngineResult((IEnumerable<string>)array) : new ViewEngineResult(((VirtualPathProviderViewEngine)this).CreateView(controllerContext, path, path2), (IViewEngine)(object)this));
		if (findViewInfo != null)
		{
			findViewInfo.SearchedLocations = array;
			findViewInfo.IsFound = !flag;
			findViewInfo.ViewEngineResult = val;
		}
		return val;
	}

	private string CreateCacheKey(string cacheKeyFormat, string prefix, string name, string controllerName, string areaName)
	{
		return string.Format(CultureInfo.InvariantCulture, cacheKeyFormat, ((object)this).GetType().AssemblyQualifiedName, prefix, name, controllerName, areaName);
	}

	private string GetPath(ControllerContext controllerContext, string[] locations, string[] areaLocations, string locationsPropertyName, string name, string controllerName, string cacheKeyPrefix, bool useCache, out string[] searchedLocations)
	{
		searchedLocations = _emptyLocations;
		if (string.IsNullOrEmpty(name))
		{
			return string.Empty;
		}
		string areaName = GetAreaName(controllerContext.get_RouteData());
		bool flag = !string.IsNullOrEmpty(areaName);
		bool flag2 = name.StartsWith("/") || name.StartsWith("~");
		IList<ViewLocation> list = (useCache ? null : GetViewLocations(locations, flag ? areaLocations : null));
		if (!useCache && list.Count == 0)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, MvcResources_ResourceManager.GetString("Common_PropertyCannotBeNullOrEmpty", mvcResources_Culture), locationsPropertyName));
		}
		string text = CreateCacheKey(":ViewCacheEntry:{0}:{1}:{2}:{3}:{4}:", cacheKeyPrefix, name, flag2 ? string.Empty : controllerName, areaName);
		string text2 = (useCache ? ((VirtualPathProviderViewEngine)this).get_ViewLocationCache().GetViewLocation(controllerContext.get_HttpContext(), text) : (flag2 ? GetPathFromSpecificName(controllerContext, name, text, ref searchedLocations) : GetPathFromGeneralName(controllerContext, list, name, controllerName, areaName, text, ref searchedLocations)));
		IEnumerable<string> paths4Points;
		if (!string.IsNullOrEmpty(text2))
		{
			paths4Points = new string[1] { text2 };
		}
		else if (flag2)
		{
			paths4Points = new string[1] { name };
		}
		else
		{
			paths4Points = (useCache ? GetViewLocations(locations, flag ? areaLocations : null) : list).Select((ViewLocation l) => l.Format(name, controllerName, areaName)).ToArray();
		}
		return ViewEngineOtherVirtualPaths.Select((IViewEngineOtherVirtualPaths point) => point.OtherExistsVirtualPath(controllerContext, paths4Points)).FirstOrDefault((string vp) => vp != null) ?? text2;
	}

	private string GetPathFromGeneralName(ControllerContext controllerContext, IList<ViewLocation> locations, string name, string controllerName, string areaName, string cacheKey, ref string[] searchedLocations)
	{
		string text = string.Empty;
		searchedLocations = new string[locations.Count];
		for (int i = 0; i < locations.Count; i++)
		{
			string text2 = locations[i].Format(name, controllerName, areaName);
			if (((VirtualPathProviderViewEngine)this).FileExists(controllerContext, text2))
			{
				searchedLocations = _emptyLocations;
				text = text2;
				((VirtualPathProviderViewEngine)this).get_ViewLocationCache().InsertViewLocation(controllerContext.get_HttpContext(), cacheKey, text);
				break;
			}
			searchedLocations[i] = text2;
		}
		return text;
	}

	private string GetPathFromSpecificName(ControllerContext controllerContext, string name, string cacheKey, ref string[] searchedLocations)
	{
		string text = name;
		if (!FilePathIsSupported(name) || !((VirtualPathProviderViewEngine)this).FileExists(controllerContext, name))
		{
			text = string.Empty;
			searchedLocations = new string[1] { name };
		}
		((VirtualPathProviderViewEngine)this).get_ViewLocationCache().InsertViewLocation(controllerContext.get_HttpContext(), cacheKey, text);
		return text;
	}

	private static IList<ViewLocation> GetViewLocations(IEnumerable<string> viewLocationFormats, IEnumerable<string> areaViewLocationFormats)
	{
		List<ViewLocation> list = new List<ViewLocation>();
		if (areaViewLocationFormats != null)
		{
			list.AddRange(areaViewLocationFormats.Select((string areaViewLocationFormat) => new AreaAwareViewLocation(areaViewLocationFormat)));
		}
		if (viewLocationFormats != null)
		{
			list.AddRange(viewLocationFormats.Select((string viewLocationFormat) => new ViewLocation(viewLocationFormat)));
		}
		return list;
	}
}
