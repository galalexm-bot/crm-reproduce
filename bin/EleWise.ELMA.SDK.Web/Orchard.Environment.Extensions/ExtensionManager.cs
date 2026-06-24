using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Extensions.Folders;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Environment.Extensions.Models;
using Orchard.Exceptions;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.Utility;
using Orchard.Utility.Extensions;

namespace Orchard.Environment.Extensions;

public class ExtensionManager : IExtensionManager
{
	private readonly IEnumerable<IExtensionFolders> _folders;

	private readonly IAsyncTokenProvider _asyncTokenProvider;

	private readonly ICacheManager _cacheManager;

	private readonly IParallelCacheContext _parallelCacheContext;

	private readonly IEnumerable<IExtensionLoader> _loaders;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public ExtensionManager(IEnumerable<IExtensionFolders> folders, IEnumerable<IExtensionLoader> loaders, ICacheManager cacheManager, IParallelCacheContext parallelCacheContext, IAsyncTokenProvider asyncTokenProvider)
	{
		_folders = folders;
		_asyncTokenProvider = asyncTokenProvider;
		_cacheManager = cacheManager;
		_parallelCacheContext = parallelCacheContext;
		_loaders = loaders.OrderBy((IExtensionLoader x) => x.Order).ToArray();
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public ExtensionDescriptor GetExtension(string id)
	{
		return AvailableExtensions().FirstOrDefault((ExtensionDescriptor x) => x.Id == id);
	}

	public IEnumerable<ExtensionDescriptor> AvailableExtensions()
	{
		return _cacheManager.Get("AvailableExtensions", preventConcurrentCalls: true, (AcquireContext<string> ctx) => _parallelCacheContext.RunInParallel(_folders, (IExtensionFolders folder) => folder.AvailableExtensions().ToList()).SelectMany((List<ExtensionDescriptor> descriptors) => descriptors).ToReadOnlyCollection());
	}

	public IEnumerable<FeatureDescriptor> AvailableFeatures()
	{
		return _cacheManager.Get("AvailableFeatures", preventConcurrentCalls: true, (AcquireContext<string> ctx) => AvailableExtensions().SelectMany((ExtensionDescriptor ext) => ext.Features).OrderByDependenciesAndPriorities(HasDependency, GetPriority).ToReadOnlyCollection());
	}

	internal static int GetPriority(FeatureDescriptor featureDescriptor)
	{
		return featureDescriptor.Priority;
	}

	internal static bool HasDependency(FeatureDescriptor item, FeatureDescriptor subject)
	{
		if (DefaultExtensionTypes.IsTheme(item.Extension.ExtensionType))
		{
			if (DefaultExtensionTypes.IsModule(subject.Extension.ExtensionType))
			{
				return true;
			}
			if (DefaultExtensionTypes.IsTheme(subject.Extension.ExtensionType))
			{
				return item.Extension.BaseTheme == subject.Id;
			}
		}
		if (item.Dependencies != null)
		{
			return item.Dependencies.Any((string x) => StringComparer.OrdinalIgnoreCase.Equals(x, subject.Id));
		}
		return false;
	}

	public IEnumerable<Feature> LoadFeatures(IEnumerable<FeatureDescriptor> featureDescriptors)
	{
		Logger.Information("Loading features");
		Feature[] result = _parallelCacheContext.RunInParallel(featureDescriptors, (FeatureDescriptor descriptor) => _cacheManager.Get(descriptor.Id, preventConcurrentCalls: true, (AcquireContext<string> ctx) => LoadFeature(descriptor))).ToArray();
		Logger.Information("Done loading features");
		return result;
	}

	private Feature LoadFeature(FeatureDescriptor featureDescriptor)
	{
		ExtensionDescriptor extensionDescriptor = featureDescriptor.Extension;
		string id = featureDescriptor.Id;
		string id2 = extensionDescriptor.Id;
		ExtensionEntry extensionEntry;
		try
		{
			extensionEntry = _cacheManager.Get(id2, preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
			{
				ExtensionEntry entry = BuildEntry(extensionDescriptor);
				if (entry != null)
				{
					ctx.Monitor(_asyncTokenProvider.GetToken(delegate(Action<IVolatileToken> monitor)
					{
						foreach (IExtensionLoader loader in _loaders)
						{
							loader.Monitor(entry.Descriptor, delegate(IVolatileToken token)
							{
								monitor(token);
							});
						}
					}));
				}
				return entry;
			});
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Error(ex, "Error loading extension '{0}'", id2);
			throw new OrchardException(T("Error while loading extension '{0}'.", id2), ex);
		}
		if (extensionEntry == null)
		{
			return new Feature
			{
				Descriptor = featureDescriptor,
				ExportedTypes = Enumerable.Empty<Type>()
			};
		}
		IEnumerable<Type> enumerable = extensionEntry.ExportedTypes.Where((Type t) => t.IsClass && !t.IsAbstract);
		List<Type> list = new List<Type>();
		foreach (Type item in enumerable)
		{
			if (string.Equals(GetSourceFeatureNameForType(item, id2), id, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(item);
			}
		}
		return new Feature
		{
			Descriptor = featureDescriptor,
			ExportedTypes = list
		};
	}

	private static string GetSourceFeatureNameForType(Type type, string extensionId)
	{
		object[] customAttributes = type.GetCustomAttributes(typeof(OrchardFeatureAttribute), inherit: false);
		int num = 0;
		if (num < customAttributes.Length)
		{
			return ((OrchardFeatureAttribute)customAttributes[num]).FeatureName;
		}
		return extensionId;
	}

	private ExtensionEntry BuildEntry(ExtensionDescriptor descriptor)
	{
		foreach (IExtensionLoader loader in _loaders)
		{
			ExtensionEntry extensionEntry = loader.Load(descriptor);
			if (extensionEntry != null)
			{
				return extensionEntry;
			}
		}
		Logger.Warning("No suitable loader found for extension \"{0}\"", descriptor.Id);
		return null;
	}
}
