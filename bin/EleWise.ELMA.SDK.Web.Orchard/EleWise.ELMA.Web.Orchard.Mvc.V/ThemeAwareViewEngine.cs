using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using Orchard;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Mvc.ViewEngines;
using Orchard.Mvc.ViewEngines.ThemeAwareness;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.ThemeAwareness;

public class ThemeAwareViewEngine : IThemeAwareViewEngine, IDependency
{
	private readonly WorkContext _workContext;

	private readonly IEnumerable<IViewEngineProvider> _viewEngineProviders;

	private readonly IConfiguredEnginesCache _configuredEnginesCache;

	private readonly IExtensionManager _extensionManager;

	private readonly ShellDescriptor _shellDescriptor;

	private readonly IViewEngine _nullEngines = (IViewEngine)(object)new ViewEngineCollectionWrapper(Enumerable.Empty<IViewEngine>());

	public ILogger Logger { get; set; }

	public ThemeAwareViewEngine(WorkContext workContext, IEnumerable<IViewEngineProvider> viewEngineProviders, IConfiguredEnginesCache configuredEnginesCache, IExtensionManager extensionManager, ShellDescriptor shellDescriptor)
	{
		_workContext = workContext;
		_viewEngineProviders = viewEngineProviders;
		_configuredEnginesCache = configuredEnginesCache;
		_extensionManager = extensionManager;
		_shellDescriptor = shellDescriptor;
		Logger = NullLogger.Instance;
	}

	public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache, bool useDeepPaths)
	{
		IViewEngine val = _nullEngines;
		if (partialViewName.StartsWith("/") || partialViewName.StartsWith("~"))
		{
			val = BareEngines();
		}
		else if (_workContext.CurrentTheme != null)
		{
			val = (useDeepPaths ? DeepEngines(_workContext.CurrentTheme) : ShallowEngines(_workContext.CurrentTheme));
		}
		return val.FindPartialView(controllerContext, partialViewName, useCache);
	}

	public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache, bool useDeepPaths)
	{
		IViewEngine val = _nullEngines;
		if (viewName.StartsWith("/") || viewName.StartsWith("~"))
		{
			val = BareEngines();
		}
		else if (_workContext.CurrentTheme != null)
		{
			val = (useDeepPaths ? DeepEngines(_workContext.CurrentTheme) : ShallowEngines(_workContext.CurrentTheme));
		}
		return val.FindView(controllerContext, viewName, masterName, useCache);
	}

	private IViewEngine BareEngines()
	{
		return _configuredEnginesCache.BindBareEngines(() => (IViewEngine)(object)new ViewEngineCollectionWrapper(_viewEngineProviders.Select((IViewEngineProvider vep) => vep.CreateBareViewEngine())));
	}

	private IViewEngine ShallowEngines(ExtensionDescriptor theme)
	{
		return DeepEngines(theme);
	}

	private IViewEngine DeepEngines(ExtensionDescriptor theme)
	{
		return _configuredEnginesCache.BindDeepEngines(theme.Id, delegate
		{
			IEnumerable<IViewEngine> first = Enumerable.Empty<IViewEngine>();
			first = first.Concat(CreateThemeViewEngines(theme));
			first = GetBaseThemes(theme).Aggregate(first, (IEnumerable<IViewEngine> current, ExtensionDescriptor baseTheme) => current.Concat(CreateThemeViewEngines(baseTheme)));
			IEnumerable<FeatureDescriptor> enumerable = from fd in _extensionManager.EnabledFeatures(_shellDescriptor).Reverse()
				where DefaultExtensionTypes.IsModule(fd.Extension.ExtensionType)
				select fd;
			List<string> virtualPaths = (from fd in enumerable.Concat(enumerable)
				select fd.Extension.Location + "/" + fd.Extension.Id).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
			CreateModulesViewEngineParams moduleParams = new CreateModulesViewEngineParams
			{
				VirtualPaths = virtualPaths
			};
			first = first.Concat(_viewEngineProviders.Select((IViewEngineProvider vep) => vep.CreateModulesViewEngine(moduleParams)));
			return (IViewEngine)(object)new ViewEngineCollectionWrapper(first);
		});
	}

	private IEnumerable<IViewEngine> CreateThemeViewEngines(ExtensionDescriptor theme)
	{
		string virtualPath = theme.Location + "/" + theme.Id;
		CreateThemeViewEngineParams themeParams = new CreateThemeViewEngineParams
		{
			VirtualPath = virtualPath
		};
		return _viewEngineProviders.Select((IViewEngineProvider vep) => vep.CreateThemeViewEngine(themeParams));
	}

	private IEnumerable<ExtensionDescriptor> GetBaseThemes(ExtensionDescriptor themeExtension)
	{
		if (themeExtension.Id.Equals("TheAdmin", StringComparison.OrdinalIgnoreCase))
		{
			return from fd in _extensionManager.EnabledFeatures(_shellDescriptor).Reverse()
				select fd.Extension into fd
				where DefaultExtensionTypes.IsTheme(fd.ExtensionType)
				select fd;
		}
		IEnumerable<FeatureDescriptor> source = _extensionManager.AvailableFeatures();
		List<ExtensionDescriptor> list = new List<ExtensionDescriptor>();
		while (themeExtension != null && !string.IsNullOrEmpty(themeExtension.BaseTheme))
		{
			FeatureDescriptor featureDescriptor = source.FirstOrDefault((FeatureDescriptor fd) => fd.Id == themeExtension.BaseTheme);
			if (featureDescriptor == null)
			{
				Logger.ErrorFormat("Base theme '{0}' of theme '{1}' not found in list of features", themeExtension.BaseTheme, themeExtension.Id);
				break;
			}
			if (list.Contains(featureDescriptor.Extension))
			{
				Logger.ErrorFormat("Base theme '{0}' of theme '{1}' ignored, as it seems there is recursion in base themes", themeExtension.BaseTheme, themeExtension.Id);
				break;
			}
			list.Add(featureDescriptor.Extension);
			themeExtension = featureDescriptor.Extension;
		}
		return list;
	}

	public void ReleaseView(ControllerContext controllerContext, IView view)
	{
		throw new NotImplementedException();
	}
}
