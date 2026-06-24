using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Configuration;
using Orchard.Environment.Extensions.Compilers;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;
using Orchard.Utility.Extensions;

namespace Orchard.Environment.Extensions.Loaders;

public class DynamicExtensionLoader : ExtensionLoaderBase
{
	internal class ReloadWorkaround
	{
		private readonly List<IVolatileToken> _tokens = new List<IVolatileToken>();

		public bool AppDomainRestartNeeded
		{
			get
			{
				lock (_tokens)
				{
					return _tokens.Any((IVolatileToken t) => !t.IsCurrent);
				}
			}
		}

		public void Monitor(IVolatileToken whenProjectFileChanges)
		{
			lock (_tokens)
			{
				_tokens.Add(whenProjectFileChanges);
			}
		}
	}

	private readonly string[] _extensionsVirtualPathPrefixes;

	private readonly IBuildManager _buildManager;

	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IVirtualPathMonitor _virtualPathMonitor;

	private readonly IHostEnvironment _hostEnvironment;

	private readonly IAssemblyProbingFolder _assemblyProbingFolder;

	private readonly IDependenciesFolder _dependenciesFolder;

	private readonly IProjectFileParser _projectFileParser;

	private readonly ReloadWorkaround _reloadWorkaround = new ReloadWorkaround();

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public bool DisableMonitoring { get; set; }

	public override int Order => 100;

	public DynamicExtensionLoader(IBuildManager buildManager, IVirtualPathProvider virtualPathProvider, IVirtualPathMonitor virtualPathMonitor, IHostEnvironment hostEnvironment, IAssemblyProbingFolder assemblyProbingFolder, IDependenciesFolder dependenciesFolder, IProjectFileParser projectFileParser, ExtensionLocations extensionLocations)
		: base(dependenciesFolder)
	{
		_buildManager = buildManager;
		_virtualPathProvider = virtualPathProvider;
		_virtualPathMonitor = virtualPathMonitor;
		_hostEnvironment = hostEnvironment;
		_assemblyProbingFolder = assemblyProbingFolder;
		_projectFileParser = projectFileParser;
		_dependenciesFolder = dependenciesFolder;
		Logger = NullLogger.Instance;
		_extensionsVirtualPathPrefixes = extensionLocations.ModuleAndThemeLocations;
	}

	public override IEnumerable<ExtensionCompilationReference> GetCompilationReferences(DependencyDescriptor dependency)
	{
		yield return new ExtensionCompilationReference
		{
			BuildProviderTarget = dependency.VirtualPath
		};
	}

	public override IEnumerable<string> GetVirtualPathDependencies(DependencyDescriptor dependency)
	{
		return GetDependencies(dependency.VirtualPath);
	}

	public override void Monitor(ExtensionDescriptor descriptor, Action<IVolatileToken> monitor)
	{
		if (Disabled || DisableMonitoring)
		{
			return;
		}
		string projectPath = GetProjectPath(descriptor);
		if (projectPath == null)
		{
			return;
		}
		foreach (string dependency in GetDependencies(projectPath))
		{
			Logger.Debug("Monitoring virtual path \"{0}\"", dependency);
			IVolatileToken volatileToken = _virtualPathMonitor.WhenPathChanges(dependency);
			monitor(volatileToken);
			_reloadWorkaround.Monitor(volatileToken);
		}
	}

	public override void ExtensionRemoved(ExtensionLoadingContext ctx, DependencyDescriptor dependency)
	{
	}

	public override void ExtensionDeactivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
	}

	public override void ExtensionActivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
		if (_reloadWorkaround.AppDomainRestartNeeded)
		{
			Logger.Information("ExtensionActivated: Module \"{0}\" has changed, forcing AppDomain restart", extension.Id);
			ctx.RestartAppDomain = _reloadWorkaround.AppDomainRestartNeeded;
		}
	}

	public override IEnumerable<ExtensionReferenceProbeEntry> ProbeReferences(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return Enumerable.Empty<ExtensionReferenceProbeEntry>();
		}
		Logger.Information("Probing references for module '{0}'", descriptor.Id);
		string projectPath = GetProjectPath(descriptor);
		if (projectPath == null)
		{
			return Enumerable.Empty<ExtensionReferenceProbeEntry>();
		}
		IEnumerable<ExtensionReferenceProbeEntry> result = _projectFileParser.Parse(projectPath).References.Select((ReferenceDescriptor r) => new ExtensionReferenceProbeEntry
		{
			Descriptor = descriptor,
			Loader = this,
			Name = r.SimpleName,
			VirtualPath = _virtualPathProvider.GetProjectReferenceVirtualPath(projectPath, r.SimpleName, r.Path)
		});
		Logger.Information("Done probing references for module '{0}'", descriptor.Id);
		return result;
	}

	public override void ReferenceActivated(ExtensionLoadingContext context, ExtensionReferenceProbeEntry referenceEntry)
	{
		if (string.IsNullOrEmpty(referenceEntry.VirtualPath))
		{
			return;
		}
		string sourceFileName = _virtualPathProvider.MapPath(referenceEntry.VirtualPath);
		if (!_assemblyProbingFolder.AssemblyExists(referenceEntry.Name) || File.GetLastWriteTimeUtc(sourceFileName) > _assemblyProbingFolder.GetAssemblyDateTimeUtc(referenceEntry.Name))
		{
			context.CopyActions.Add(delegate
			{
				_assemblyProbingFolder.StoreAssembly(referenceEntry.Name, sourceFileName);
			});
			if (_hostEnvironment.IsAssemblyLoaded(referenceEntry.Name))
			{
				Logger.Information("ReferenceActivated: Reference \"{0}\" is activated with newer file and its assembly is loaded, forcing AppDomain restart", referenceEntry.Name);
				context.RestartAppDomain = true;
			}
		}
	}

	public override Assembly LoadReference(DependencyReferenceDescriptor reference)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Loading reference '{0}'", reference.Name);
		Assembly result = ((!StringComparer.OrdinalIgnoreCase.Equals(Path.GetExtension(reference.VirtualPath), ".dll")) ? _buildManager.GetCompiledAssembly(reference.VirtualPath) : _assemblyProbingFolder.LoadAssembly(reference.Name));
		Logger.Information("Done loading reference '{0}'", reference.Name);
		return result;
	}

	public override ExtensionProbeEntry Probe(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Probing for module '{0}'", descriptor.Id);
		string projectPath = GetProjectPath(descriptor);
		if (projectPath == null)
		{
			return null;
		}
		ExtensionProbeEntry result = new ExtensionProbeEntry
		{
			Descriptor = descriptor,
			Loader = this,
			VirtualPath = projectPath,
			VirtualPathDependencies = GetDependencies(projectPath).ToList()
		};
		Logger.Information("Done probing for module '{0}'", descriptor.Id);
		return result;
	}

	protected override ExtensionEntry LoadWorker(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		string projectPath = GetProjectPath(descriptor);
		if (projectPath == null)
		{
			return null;
		}
		Logger.Information("Start loading dynamic extension \"{0}\"", descriptor.Name);
		Assembly compiledAssembly = _buildManager.GetCompiledAssembly(projectPath);
		if (compiledAssembly == null)
		{
			return null;
		}
		Logger.Information("Done loading dynamic extension \"{0}\": assembly name=\"{1}\"", descriptor.Name, compiledAssembly.FullName);
		return new ExtensionEntry
		{
			Descriptor = descriptor,
			Assembly = compiledAssembly,
			ExportedTypes = compiledAssembly.GetTypes()
		};
	}

	protected IEnumerable<string> GetDependencies(string projectPath)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		AddDependencies(projectPath, hashSet);
		return hashSet;
	}

	private void AddDependencies(string projectPath, HashSet<string> currentSet)
	{
		if (string.IsNullOrEmpty(PrefixMatch(projectPath, _extensionsVirtualPathPrefixes)))
		{
			return;
		}
		currentSet.Add(projectPath);
		ProjectFileDescriptor projectFileDescriptor = _projectFileParser.Parse(projectPath);
		string basePath = _virtualPathProvider.GetDirectoryName(projectPath);
		currentSet.UnionWith(projectFileDescriptor.SourceFilenames.Select((string f) => _virtualPathProvider.Combine(basePath, f)));
		if (projectFileDescriptor.References == null)
		{
			return;
		}
		foreach (ReferenceDescriptor item in projectFileDescriptor.References.Where((ReferenceDescriptor reference) => !string.IsNullOrEmpty(reference.Path)))
		{
			string text = ((item.ReferenceType == ReferenceType.Library) ? _virtualPathProvider.GetProjectReferenceVirtualPath(projectPath, item.SimpleName, item.Path) : _virtualPathProvider.Combine(basePath, item.Path));
			if (!string.IsNullOrEmpty(text))
			{
				text = _virtualPathProvider.ToAppRelative(text);
			}
			if (!string.IsNullOrEmpty(text) && !currentSet.Contains(text) && _virtualPathProvider.TryFileExists(text))
			{
				switch (item.ReferenceType)
				{
				case ReferenceType.Project:
					AddDependencies(text, currentSet);
					break;
				case ReferenceType.Library:
					currentSet.Add(text);
					break;
				}
			}
		}
	}

	private static string PrefixMatch(string virtualPath, params string[] prefixes)
	{
		return prefixes.FirstOrDefault((string p) => virtualPath.StartsWith(p, StringComparison.OrdinalIgnoreCase));
	}

	private string GetProjectPath(ExtensionDescriptor descriptor)
	{
		string text = _virtualPathProvider.Combine(descriptor.Location, descriptor.Id, descriptor.Id + ".csproj");
		if (!_virtualPathProvider.FileExists(text))
		{
			return null;
		}
		return text;
	}
}
