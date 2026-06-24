using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.DisplayManagement.Implementation;
using Orchard.Environment;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;
using Orchard.Mvc.ViewEngines.ThemeAwareness;
using Orchard.Utility.Extensions;

namespace Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;

public class ShapeTemplateBindingStrategy : IShapeTableProvider, IDependency
{
	private class StubController : Controller
	{
	}

	private readonly ShellDescriptor _shellDescriptor;

	private readonly IExtensionManager _extensionManager;

	private readonly ICacheManager _cacheManager;

	private readonly IVirtualPathMonitor _virtualPathMonitor;

	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IEnumerable<IShapeTemplateHarvester> _harvesters;

	private readonly IEnumerable<IShapeTemplateViewEngine> _shapeTemplateViewEngines;

	private readonly IParallelCacheContext _parallelCacheContext;

	private readonly Work<ILayoutAwareViewEngine> _viewEngine;

	private readonly IWorkContextAccessor _workContextAccessor;

	public ILogger Logger { get; set; }

	public bool DisableMonitoring { get; set; }

	public ShapeTemplateBindingStrategy(IEnumerable<IShapeTemplateHarvester> harvesters, ShellDescriptor shellDescriptor, IExtensionManager extensionManager, ICacheManager cacheManager, IVirtualPathMonitor virtualPathMonitor, IVirtualPathProvider virtualPathProvider, IEnumerable<IShapeTemplateViewEngine> shapeTemplateViewEngines, IParallelCacheContext parallelCacheContext, Work<ILayoutAwareViewEngine> viewEngine, IWorkContextAccessor workContextAccessor)
	{
		_harvesters = harvesters;
		_shellDescriptor = shellDescriptor;
		_extensionManager = extensionManager;
		_cacheManager = cacheManager;
		_virtualPathMonitor = virtualPathMonitor;
		_virtualPathProvider = virtualPathProvider;
		_shapeTemplateViewEngines = shapeTemplateViewEngines;
		_parallelCacheContext = parallelCacheContext;
		_viewEngine = viewEngine;
		_workContextAccessor = workContextAccessor;
		Logger = NullLogger.Instance;
	}

	private static IEnumerable<ExtensionDescriptor> Once(IEnumerable<FeatureDescriptor> featureDescriptors)
	{
		ConcurrentDictionary<string, object> once = new ConcurrentDictionary<string, object>();
		return (from fd in featureDescriptors
			select fd.Extension into ed
			where once.TryAdd(ed.Id, null)
			select ed).ToList();
	}

	public void Discover(ShapeTableBuilder builder)
	{
		Logger.Information("Start discovering shapes");
		var harvesterInfos = _harvesters.Select((IShapeTemplateHarvester harvester) => new
		{
			harvester = harvester,
			subPaths = harvester.SubPaths()
		});
		IEnumerable<ExtensionDescriptor> source = Once(_extensionManager.AvailableFeatures().Where(FeatureIsEnabled));
		foreach (var item in _parallelCacheContext.RunInParallel(source, delegate(ExtensionDescriptor extensionDescriptor)
		{
			Logger.Information("Start discovering candidate views filenames");
			var source2 = harvesterInfos.SelectMany(harvesterInfo => harvesterInfo.subPaths.Select(delegate(string subPath)
			{
				string text = Path.Combine(extensionDescriptor.Location, extensionDescriptor.Id).Replace(Path.DirectorySeparatorChar, '/');
				string virtualPath = Path.Combine(text, subPath).Replace(Path.DirectorySeparatorChar, '/');
				IList<string> fileNames = _cacheManager.Get(virtualPath, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
				{
					if (!_virtualPathProvider.DirectoryExists(virtualPath))
					{
						return new List<string>();
					}
					if (!DisableMonitoring)
					{
						Logger.Debug("Monitoring virtual path \"{0}\"", virtualPath);
						ctx.Monitor(_virtualPathMonitor.WhenPathChanges(virtualPath));
					}
					return _virtualPathProvider.ListFiles(virtualPath).Select(Path.GetFileName).ToReadOnlyCollection();
				});
				return new
				{
					harvester = harvesterInfo.harvester,
					basePath = text,
					subPath = subPath,
					virtualPath = virtualPath,
					fileNames = fileNames
				};
			})).ToList();
			Logger.Information("Done discovering candidate views filenames");
			return (from shapeContext in source2.SelectMany(pathContext => _shapeTemplateViewEngines.SelectMany((IShapeTemplateViewEngine ve) => from fileName in ve.DetectTemplateFileNames(pathContext.fileNames)
					select new
					{
						fileName = Path.GetFileNameWithoutExtension(fileName),
						fileVirtualPath = Path.Combine(pathContext.virtualPath, fileName).Replace(Path.DirectorySeparatorChar, '/'),
						pathContext = pathContext
					})).SelectMany(fileContext =>
				{
					HarvestShapeInfo harvestShapeInfo = new HarvestShapeInfo
					{
						SubPath = fileContext.pathContext.subPath,
						FileName = fileContext.fileName,
						TemplateVirtualPath = fileContext.fileVirtualPath
					};
					return from harvestShapeHit in fileContext.pathContext.harvester.HarvestShape(harvestShapeInfo)
						select new { harvestShapeInfo, harvestShapeHit, fileContext };
				})
				select new { extensionDescriptor, shapeContext }).ToList();
		}).SelectMany(hits2 => hits2))
		{
			var hit = item;
			foreach (FeatureDescriptor item2 in item.extensionDescriptor.Features.Where((FeatureDescriptor fd) => fd.Id == hit.extensionDescriptor.Id))
			{
				Logger.Debug("Binding {0} as shape [{1}] for feature {2}", hit.shapeContext.harvestShapeInfo.TemplateVirtualPath, item.shapeContext.harvestShapeHit.ShapeType, item2.Id);
				builder.Describe(item.shapeContext.harvestShapeHit.ShapeType).From(new Feature
				{
					Descriptor = item2
				}).BoundAs(hit.shapeContext.harvestShapeInfo.TemplateVirtualPath, (ShapeDescriptor shapeDescriptor) => (DisplayContext displayContext) => Render(shapeDescriptor, displayContext, hit.shapeContext.harvestShapeInfo, hit.shapeContext.harvestShapeHit));
			}
		}
		Logger.Information("Done discovering shapes");
	}

	private bool FeatureIsEnabled(FeatureDescriptor fd)
	{
		if (!DefaultExtensionTypes.IsTheme(fd.Extension.ExtensionType) || (!(fd.Id == "TheAdmin") && !(fd.Id == "SafeMode")))
		{
			return _shellDescriptor.Features.Any((ShellFeature sf) => sf.Name == fd.Id);
		}
		return true;
	}

	private IHtmlString Render(ShapeDescriptor shapeDescriptor, DisplayContext displayContext, HarvestShapeInfo harvestShapeInfo, HarvestShapeHit harvestShapeHit)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		Logger.Information("Rendering template file '{0}'", harvestShapeInfo.TemplateVirtualPath);
		IHtmlString result = ((displayContext.ViewContext.get_View() == null) ? RenderRazorViewToString(harvestShapeInfo.TemplateVirtualPath, displayContext) : ((IHtmlString)PartialExtensions.Partial(new HtmlHelper(displayContext.ViewContext, displayContext.ViewDataContainer), harvestShapeInfo.TemplateVirtualPath, displayContext.Value)));
		Logger.Information("Done rendering template file '{0}'", harvestShapeInfo.TemplateVirtualPath);
		return result;
	}

	private IHtmlString RenderRazorViewToString(string path, DisplayContext context)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		using StringWriter stringWriter = new StringWriter();
		ControllerContext val = CreateControllerContext();
		ViewEngineResult val2 = ((IViewEngine)_viewEngine.Value).FindPartialView(val, path, false);
		context.ViewContext.set_ViewData(new ViewDataDictionary(context.Value));
		context.ViewContext.set_TempData(new TempDataDictionary());
		context.ViewContext.set_View(val2.get_View());
		((ControllerContext)context.ViewContext).set_RouteData(val.get_RouteData());
		((ControllerContext)context.ViewContext).get_RequestContext().RouteData = val.get_RouteData();
		val2.get_View().Render(context.ViewContext, (TextWriter)stringWriter);
		val2.get_ViewEngine().ReleaseView(val, val2.get_View());
		return new HtmlString(stringWriter.GetStringBuilder().ToString());
	}

	private ControllerContext CreateControllerContext()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		StubController stubController = new StubController();
		HttpContextBase httpContextBase = _workContextAccessor.GetContext().Resolve<HttpContextBase>();
		RequestContext requestContext = _workContextAccessor.GetContext().Resolve<RequestContext>();
		RouteData routeData = requestContext.RouteData;
		routeData.DataTokens["IWorkContextAccessor"] = _workContextAccessor;
		if (!routeData.Values.ContainsKey("controller") && !routeData.Values.ContainsKey("Controller"))
		{
			routeData.Values.Add("controller", ((object)stubController).GetType().Name.ToLower().Replace("controller", ""));
		}
		((ControllerBase)stubController).set_ControllerContext(new ControllerContext(httpContextBase, routeData, (ControllerBase)(object)stubController));
		((ControllerBase)stubController).get_ControllerContext().set_RequestContext(requestContext);
		return ((ControllerBase)stubController).get_ControllerContext();
	}
}
