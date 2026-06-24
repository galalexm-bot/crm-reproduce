using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.Utility;

namespace Orchard.Environment.Extensions;

public class ExtensionLoaderCoordinator : IExtensionLoaderCoordinator
{
	private readonly IDependenciesFolder _dependenciesFolder;

	private readonly IExtensionDependenciesManager _extensionDependenciesManager;

	private readonly IExtensionManager _extensionManager;

	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IEnumerable<IExtensionLoader> _loaders;

	private readonly IHostEnvironment _hostEnvironment;

	private readonly IParallelCacheContext _parallelCacheContext;

	private readonly IBuildManager _buildManager;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public ExtensionLoaderCoordinator(IDependenciesFolder dependenciesFolder, IExtensionDependenciesManager extensionDependenciesManager, IExtensionManager extensionManager, IVirtualPathProvider virtualPathProvider, IEnumerable<IExtensionLoader> loaders, IHostEnvironment hostEnvironment, IParallelCacheContext parallelCacheContext, IBuildManager buildManager)
	{
		_dependenciesFolder = dependenciesFolder;
		_extensionDependenciesManager = extensionDependenciesManager;
		_extensionManager = extensionManager;
		_virtualPathProvider = virtualPathProvider;
		_loaders = loaders.OrderBy((IExtensionLoader l) => l.Order);
		_hostEnvironment = hostEnvironment;
		_parallelCacheContext = parallelCacheContext;
		_buildManager = buildManager;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public void SetupExtensions()
	{
		Logger.Information("Start loading extensions...");
		ExtensionLoadingContext context = CreateLoadingContext();
		foreach (DependencyDescriptor deletedDependency in context.DeletedDependencies)
		{
			Logger.Information("Extension {0} has been removed from site", deletedDependency.Name);
			foreach (IExtensionLoader loader in _loaders)
			{
				if (deletedDependency.LoaderName == loader.Name)
				{
					loader.ExtensionRemoved(context, deletedDependency);
				}
			}
		}
		foreach (ExtensionDescriptor availableExtension in context.AvailableExtensions)
		{
			ProcessExtension(context, availableExtension);
		}
		ProcessContextCommands(context);
		_dependenciesFolder.StoreDescriptors(context.NewDependencies);
		_extensionDependenciesManager.StoreDependencies(context.NewDependencies, (DependencyDescriptor desc) => GetExtensionHash(context, desc));
		Logger.Information("Done loading extensions...");
	}

	private string GetExtensionHash(ExtensionLoadingContext context, DependencyDescriptor dependencyDescriptor)
	{
		Hash hash = new Hash();
		hash.AddStringInvariant(dependencyDescriptor.Name);
		foreach (string virtualPathDependency in context.ProcessedExtensions[dependencyDescriptor.Name].VirtualPathDependencies)
		{
			hash.AddDateTime(GetVirtualPathModificationTimeUtc(context.VirtualPathModficationDates, virtualPathDependency));
		}
		foreach (DependencyReferenceDescriptor reference in dependencyDescriptor.References)
		{
			hash.AddStringInvariant(reference.Name);
			hash.AddString(reference.LoaderName);
			hash.AddDateTime(GetVirtualPathModificationTimeUtc(context.VirtualPathModficationDates, reference.VirtualPath));
		}
		return hash.Value;
	}

	private void ProcessExtension(ExtensionLoadingContext context, ExtensionDescriptor extension)
	{
		IEnumerable<ExtensionProbeEntry> source = (context.AvailableExtensionsProbes.ContainsKey(extension.Id) ? context.AvailableExtensionsProbes[extension.Id] : Enumerable.Empty<ExtensionProbeEntry>());
		source = source.ToArray();
		if (Logger.IsEnabled(LogLevel.Debug))
		{
			Logger.Debug("Loaders for extension \"{0}\": ", extension.Id);
			foreach (ExtensionProbeEntry item in source)
			{
				Logger.Debug("  Loader: {0}", item.Loader.Name);
				Logger.Debug("    VirtualPath: {0}", item.VirtualPath);
				Logger.Debug("    VirtualPathDependencies: {0}", string.Join(", ", item.VirtualPathDependencies));
			}
		}
		List<ExtensionDescriptor> source2 = context.AvailableExtensions.Where((ExtensionDescriptor e) => context.ReferencesByModule.ContainsKey(extension.Id) && context.ReferencesByModule[extension.Id].Any((ExtensionReferenceProbeEntry r) => StringComparer.OrdinalIgnoreCase.Equals(e.Id, r.Name))).ToList();
		List<ExtensionProbeEntry> processedModuleReferences = (from e in source2
			where context.ProcessedExtensions.ContainsKey(e.Id)
			select context.ProcessedExtensions[e.Id]).ToList();
		ExtensionProbeEntry extensionProbeEntry = source.FirstOrDefault((ExtensionProbeEntry e) => e.Loader.IsCompatibleWithModuleReferences(extension, processedModuleReferences));
		DependencyDescriptor dependencyDescriptor = context.PreviousDependencies.FirstOrDefault((DependencyDescriptor d) => StringComparer.OrdinalIgnoreCase.Equals(d.Name, extension.Id));
		if (extensionProbeEntry == null)
		{
			Logger.Warning("No loader found for extension \"{0}\"!", extension.Id);
		}
		IEnumerable<DependencyReferenceDescriptor> references = ProcessExtensionReferences(context, extensionProbeEntry);
		foreach (IExtensionLoader loader in _loaders)
		{
			if (extensionProbeEntry != null && extensionProbeEntry.Loader.Name == loader.Name)
			{
				Logger.Information("Activating extension \"{0}\" with loader \"{1}\"", extensionProbeEntry.Descriptor.Id, loader.Name);
				loader.ExtensionActivated(context, extension);
			}
			else if (dependencyDescriptor != null && dependencyDescriptor.LoaderName == loader.Name)
			{
				Logger.Information("Deactivating extension \"{0}\" from loader \"{1}\"", dependencyDescriptor.Name, loader.Name);
				loader.ExtensionDeactivated(context, extension);
			}
		}
		if (extensionProbeEntry != null)
		{
			context.NewDependencies.Add(new DependencyDescriptor
			{
				Name = extension.Id,
				LoaderName = extensionProbeEntry.Loader.Name,
				VirtualPath = extensionProbeEntry.VirtualPath,
				References = references
			});
		}
		context.ProcessedExtensions.Add(extension.Id, extensionProbeEntry);
	}

	private ExtensionLoadingContext CreateLoadingContext()
	{
		List<ExtensionDescriptor> availableExtensions = (from d in _extensionManager.AvailableExtensions()
			where DefaultExtensionTypes.IsModule(d.ExtensionType) || DefaultExtensionTypes.IsTheme(d.ExtensionType)
			orderby d.Id
			select d).ToList();
		List<IGrouping<string, ExtensionDescriptor>> list = (from ed in availableExtensions
			group ed by ed.Id into g
			where g.Count() >= 2
			select g).ToList();
		if (list.Any())
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(T("There are multiple extensions with the same name installed in this instance of Orchard.\r\n"));
			foreach (IGrouping<string, ExtensionDescriptor> item in list)
			{
				stringBuilder.Append(T("Extension '{0}' has been found from the following locations: {1}.\r\n", item.Key, string.Join(", ", item.Select((ExtensionDescriptor e) => e.Location + "/" + e.Id))));
			}
			stringBuilder.Append(T("This issue can be usually solved by removing or renaming the conflicting extension."));
			Logger.Error(stringBuilder.ToString());
			throw new OrchardException(new LocalizedString(stringBuilder.ToString()));
		}
		List<DependencyDescriptor> list2 = _dependenciesFolder.LoadDescriptors().ToList();
		ConcurrentDictionary<string, DateTime> virtualPathModficationDates = new ConcurrentDictionary<string, DateTime>(StringComparer.OrdinalIgnoreCase);
		Logger.Information("Probing extensions");
		IEnumerable<IGrouping<string, ExtensionProbeEntry>> source = from entry in _parallelCacheContext.RunInParallel(availableExtensions, (ExtensionDescriptor extension) => (from loader in _loaders
				select loader.Probe(extension) into entry
				where entry != null
				select entry).ToArray()).SelectMany((ExtensionProbeEntry[] entries) => entries)
			group entry by entry.Descriptor.Id;
		Dictionary<string, IEnumerable<ExtensionProbeEntry>> availableExtensionsProbes = _parallelCacheContext.RunInParallel(source, (IGrouping<string, ExtensionProbeEntry> g) => new
		{
			Id = g.Key,
			Entries = SortExtensionProbeEntries(g, virtualPathModficationDates)
		}).ToDictionary(g => g.Id, g => g.Entries, StringComparer.OrdinalIgnoreCase);
		Logger.Information("Done probing extensions");
		List<DependencyDescriptor> deletedDependencies = list2.Where((DependencyDescriptor e) => !availableExtensions.Any((ExtensionDescriptor e2) => StringComparer.OrdinalIgnoreCase.Equals(e2.Id, e.Name))).ToList();
		Logger.Information("Probing extension references");
		List<ExtensionReferenceProbeEntry> source2 = _parallelCacheContext.RunInParallel(availableExtensions, (ExtensionDescriptor extension) => _loaders.SelectMany((IExtensionLoader loader) => loader.ProbeReferences(extension)).ToList()).SelectMany((List<ExtensionReferenceProbeEntry> entries) => entries).ToList();
		Logger.Information("Done probing extension references");
		Dictionary<string, IEnumerable<ExtensionReferenceProbeEntry>> referencesByModule = source2.GroupBy((ExtensionReferenceProbeEntry entry) => entry.Descriptor.Id, StringComparer.OrdinalIgnoreCase).ToDictionary((IGrouping<string, ExtensionReferenceProbeEntry> g) => g.Key, (IGrouping<string, ExtensionReferenceProbeEntry> g) => g.AsEnumerable(), StringComparer.OrdinalIgnoreCase);
		Dictionary<string, IEnumerable<ExtensionReferenceProbeEntry>> referencesByName = source2.GroupBy((ExtensionReferenceProbeEntry reference) => reference.Name, StringComparer.OrdinalIgnoreCase).ToDictionary((IGrouping<string, ExtensionReferenceProbeEntry> g) => g.Key, (IGrouping<string, ExtensionReferenceProbeEntry> g) => g.AsEnumerable(), StringComparer.OrdinalIgnoreCase);
		List<ExtensionDescriptor> availableExtensions2 = availableExtensions.OrderByDependenciesAndPriorities((ExtensionDescriptor item, ExtensionDescriptor dep) => referencesByModule.ContainsKey(item.Id) && referencesByModule[item.Id].Any((ExtensionReferenceProbeEntry r) => StringComparer.OrdinalIgnoreCase.Equals(dep.Id, r.Name)), (ExtensionDescriptor item) => 0).ToList();
		return new ExtensionLoadingContext
		{
			AvailableExtensions = availableExtensions2,
			PreviousDependencies = list2,
			DeletedDependencies = deletedDependencies,
			AvailableExtensionsProbes = availableExtensionsProbes,
			ReferencesByName = referencesByName,
			ReferencesByModule = referencesByModule,
			VirtualPathModficationDates = virtualPathModficationDates,
			Logger = Logger
		};
	}

	private IEnumerable<ExtensionProbeEntry> SortExtensionProbeEntries(IEnumerable<ExtensionProbeEntry> entries, ConcurrentDictionary<string, DateTime> virtualPathModficationDates)
	{
		IEnumerable<ExtensionProbeEntry> enumerable = (from entry in entries
			group entry by entry.Priority into g
			orderby g.Key descending
			select g).FirstOrDefault((IGrouping<int, ExtensionProbeEntry> g) => g.Any());
		IEnumerable<ExtensionProbeEntry> enumerable2 = enumerable ?? Enumerable.Empty<ExtensionProbeEntry>();
		if (enumerable2.Count() <= 1)
		{
			return enumerable2;
		}
		return (from probe in enumerable2
			orderby GetVirtualPathDepedenciesModificationTimeUtc(virtualPathModficationDates, probe) descending, probe.Loader.Order
			select probe).ToList();
	}

	private DateTime GetVirtualPathDepedenciesModificationTimeUtc(ConcurrentDictionary<string, DateTime> virtualPathDependencies, ExtensionProbeEntry probe)
	{
		if (!probe.VirtualPathDependencies.Any())
		{
			return DateTime.MinValue;
		}
		Logger.Information("Retrieving modification dates of dependencies of extension '{0}'", probe.Descriptor.Id);
		DateTime result = probe.VirtualPathDependencies.Max((string path) => GetVirtualPathModificationTimeUtc(virtualPathDependencies, path));
		Logger.Information("Done retrieving modification dates of dependencies of extension '{0}'", probe.Descriptor.Id);
		return result;
	}

	private DateTime GetVirtualPathModificationTimeUtc(ConcurrentDictionary<string, DateTime> virtualPathDependencies, string path)
	{
		return virtualPathDependencies.GetOrAdd(path, (string p) => _virtualPathProvider.GetFileLastWriteTimeUtc(p));
	}

	private IEnumerable<DependencyReferenceDescriptor> ProcessExtensionReferences(ExtensionLoadingContext context, ExtensionProbeEntry activatedExtension)
	{
		if (activatedExtension == null)
		{
			return Enumerable.Empty<DependencyReferenceDescriptor>();
		}
		IEnumerable<string> enumerable = (context.ReferencesByModule.ContainsKey(activatedExtension.Descriptor.Id) ? context.ReferencesByModule[activatedExtension.Descriptor.Id] : Enumerable.Empty<ExtensionReferenceProbeEntry>()).Select((ExtensionReferenceProbeEntry r) => r.Name).Distinct(StringComparer.OrdinalIgnoreCase);
		List<DependencyReferenceDescriptor> list = new List<DependencyReferenceDescriptor>();
		foreach (string item in enumerable)
		{
			ProcessExtensionReference(context, activatedExtension, item, list);
		}
		return list;
	}

	private void ProcessExtensionReference(ExtensionLoadingContext context, ExtensionProbeEntry activatedExtension, string referenceName, IList<DependencyReferenceDescriptor> activatedReferences)
	{
		ExtensionProbeEntry extensionProbeEntry = (context.ProcessedExtensions.ContainsKey(referenceName) ? context.ProcessedExtensions[referenceName] : null);
		if (extensionProbeEntry != null)
		{
			activatedReferences.Add(new DependencyReferenceDescriptor
			{
				LoaderName = extensionProbeEntry.Loader.Name,
				Name = referenceName,
				VirtualPath = extensionProbeEntry.VirtualPath
			});
		}
		else
		{
			if (_buildManager.HasReferencedAssembly(referenceName))
			{
				return;
			}
			var anon = (from entry in context.ReferencesByName.ContainsKey(referenceName) ? context.ReferencesByName[referenceName] : Enumerable.Empty<ExtensionReferenceProbeEntry>()
				where !string.IsNullOrEmpty(entry.VirtualPath)
				select new
				{
					Entry = entry,
					LastWriteTimeUtc = _virtualPathProvider.GetFileLastWriteTimeUtc(entry.VirtualPath)
				} into e
				orderby e.LastWriteTimeUtc, e.Entry.Name
				select e).FirstOrDefault();
			if (anon != null)
			{
				if (!context.ProcessedReferences.ContainsKey(anon.Entry.Name))
				{
					context.ProcessedReferences.Add(anon.Entry.Name, anon.Entry);
					anon.Entry.Loader.ReferenceActivated(context, anon.Entry);
				}
				activatedReferences.Add(new DependencyReferenceDescriptor
				{
					LoaderName = anon.Entry.Loader.Name,
					Name = anon.Entry.Name,
					VirtualPath = anon.Entry.VirtualPath
				});
			}
		}
	}

	private void ProcessContextCommands(ExtensionLoadingContext ctx)
	{
		Logger.Information("Executing list of operations needed for loading extensions...");
		foreach (Action deleteAction in ctx.DeleteActions)
		{
			deleteAction();
		}
		foreach (Action copyAction in ctx.CopyActions)
		{
			copyAction();
		}
	}
}
