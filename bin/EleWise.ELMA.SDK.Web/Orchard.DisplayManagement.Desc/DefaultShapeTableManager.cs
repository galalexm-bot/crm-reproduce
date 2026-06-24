using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Features.Metadata;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Logging;
using Orchard.Utility;
using Orchard.Utility.Extensions;

namespace Orchard.DisplayManagement.Descriptors;

public class DefaultShapeTableManager : IShapeTableManager, ISingletonDependency, IDependency
{
	private readonly IEnumerable<Meta<IShapeTableProvider>> _bindingStrategies;

	private readonly IExtensionManager _extensionManager;

	private readonly ICacheManager _cacheManager;

	private readonly IParallelCacheContext _parallelCacheContext;

	private readonly Work<IEnumerable<IShapeTableEventHandler>> _shapeTableEventHandlersWork;

	public ILogger Logger { get; set; }

	public DefaultShapeTableManager(IEnumerable<Meta<IShapeTableProvider>> bindingStrategies, IExtensionManager extensionManager, ICacheManager cacheManager, IParallelCacheContext parallelCacheContext, Work<IEnumerable<IShapeTableEventHandler>> shapeTableEventHandlersWork)
	{
		_extensionManager = extensionManager;
		_cacheManager = cacheManager;
		_parallelCacheContext = parallelCacheContext;
		_shapeTableEventHandlersWork = shapeTableEventHandlersWork;
		_bindingStrategies = bindingStrategies;
		Logger = NullLogger.Instance;
	}

	public ShapeTable GetShapeTable(string themeName)
	{
		return _cacheManager.Get(themeName ?? "", preventConcurrentCalls: true, delegate
		{
			Logger.Information("Start building shape table");
			List<ShapeAlteration> source = (from alteration in _parallelCacheContext.RunInParallel(_bindingStrategies, delegate(Meta<IShapeTableProvider> bindingStrategy)
				{
					ShapeTableBuilder shapeTableBuilder = new ShapeTableBuilder(bindingStrategy.get_Metadata().ContainsKey("Feature") ? ((Feature)bindingStrategy.get_Metadata()["Feature"]) : null);
					bindingStrategy.get_Value().Discover(shapeTableBuilder);
					return shapeTableBuilder.BuildAlterations().ToReadOnlyCollection();
				}).SelectMany((IList<ShapeAlteration> shapeAlterations) => shapeAlterations)
				where IsModuleOrRequestedTheme(alteration, themeName)
				select alteration).OrderByDependenciesAndPriorities(AlterationHasDependency, GetPriority).ToList();
			List<ShapeDescriptor> list = (from @group in source.GroupBy((ShapeAlteration alteration) => alteration.ShapeType, StringComparer.OrdinalIgnoreCase)
				select @group.Aggregate(new ShapeDescriptor
				{
					ShapeType = @group.Key
				}, delegate(ShapeDescriptor descriptor, ShapeAlteration alteration)
				{
					alteration.Alter(descriptor);
					return descriptor;
				})).ToList();
			foreach (ShapeDescriptor descriptor2 in list)
			{
				foreach (ShapeAlteration item in source.Where((ShapeAlteration a) => a.ShapeType == descriptor2.ShapeType).ToList())
				{
					ShapeDescriptor shapeDescriptor = new ShapeDescriptor
					{
						ShapeType = descriptor2.ShapeType
					};
					item.Alter(shapeDescriptor);
					descriptor2.BindingSources.Add(shapeDescriptor.BindingSource);
				}
			}
			ShapeTable result = new ShapeTable
			{
				Descriptors = list.ToDictionary((ShapeDescriptor sd) => sd.ShapeType, StringComparer.OrdinalIgnoreCase),
				Bindings = list.SelectMany((ShapeDescriptor sd) => sd.Bindings).ToDictionary((KeyValuePair<string, ShapeBinding> kv) => kv.Key, (KeyValuePair<string, ShapeBinding> kv) => kv.Value, StringComparer.OrdinalIgnoreCase)
			};
			_shapeTableEventHandlersWork.Value.Invoke(delegate(IShapeTableEventHandler ctx)
			{
				ctx.ShapeTableCreated(result);
			}, Logger);
			Logger.Information("Done building shape table");
			return result;
		});
	}

	private static int GetPriority(ShapeAlteration shapeAlteration)
	{
		return shapeAlteration.Feature.Descriptor.Priority;
	}

	private static bool AlterationHasDependency(ShapeAlteration item, ShapeAlteration subject)
	{
		return ExtensionManager.HasDependency(item.Feature.Descriptor, subject.Feature.Descriptor);
	}

	private bool IsModuleOrRequestedTheme(ShapeAlteration alteration, string themeName)
	{
		if (alteration == null || alteration.Feature == null || alteration.Feature.Descriptor == null || alteration.Feature.Descriptor.Extension == null)
		{
			return false;
		}
		string extensionType = alteration.Feature.Descriptor.Extension.ExtensionType;
		if (DefaultExtensionTypes.IsModule(extensionType))
		{
			return true;
		}
		if (DefaultExtensionTypes.IsTheme(extensionType))
		{
			string id = alteration.Feature.Descriptor.Id;
			if (!string.IsNullOrEmpty(id) && !(id == themeName))
			{
				return IsBaseTheme(id, themeName);
			}
			return true;
		}
		return false;
	}

	private bool IsBaseTheme(string featureName, string themeName)
	{
		IEnumerable<FeatureDescriptor> source = _extensionManager.AvailableFeatures();
		FeatureDescriptor featureDescriptor = source.SingleOrDefault((FeatureDescriptor fd) => fd.Id == themeName);
		while (featureDescriptor != null)
		{
			string baseTheme = featureDescriptor.Extension.BaseTheme;
			if (string.IsNullOrEmpty(baseTheme))
			{
				return false;
			}
			if (featureName == baseTheme)
			{
				return true;
			}
			featureDescriptor = source.SingleOrDefault((FeatureDescriptor fd) => fd.Id == baseTheme);
		}
		return false;
	}
}
