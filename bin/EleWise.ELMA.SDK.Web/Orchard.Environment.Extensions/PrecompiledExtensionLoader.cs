using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Loaders;

public class PrecompiledExtensionLoader : ExtensionLoaderBase
{
	private readonly IHostEnvironment _hostEnvironment;

	private readonly IAssemblyProbingFolder _assemblyProbingFolder;

	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IVirtualPathMonitor _virtualPathMonitor;

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public bool DisableMonitoring { get; set; }

	public override int Order => 30;

	public PrecompiledExtensionLoader(IHostEnvironment hostEnvironment, IDependenciesFolder dependenciesFolder, IAssemblyProbingFolder assemblyProbingFolder, IVirtualPathProvider virtualPathProvider, IVirtualPathMonitor virtualPathMonitor)
		: base(dependenciesFolder)
	{
		_hostEnvironment = hostEnvironment;
		_assemblyProbingFolder = assemblyProbingFolder;
		_virtualPathProvider = virtualPathProvider;
		_virtualPathMonitor = virtualPathMonitor;
		Logger = NullLogger.Instance;
	}

	public override IEnumerable<ExtensionCompilationReference> GetCompilationReferences(DependencyDescriptor dependency)
	{
		yield return new ExtensionCompilationReference
		{
			AssemblyName = dependency.Name
		};
	}

	public override IEnumerable<string> GetVirtualPathDependencies(DependencyDescriptor dependency)
	{
		yield return _assemblyProbingFolder.GetAssemblyVirtualPath(dependency.Name);
	}

	public override void ExtensionRemoved(ExtensionLoadingContext ctx, DependencyDescriptor dependency)
	{
		if (_assemblyProbingFolder.AssemblyExists(dependency.Name))
		{
			ctx.DeleteActions.Add(delegate
			{
				Logger.Information("ExtensionRemoved: Deleting assembly \"{0}\" from probing directory", dependency.Name);
				_assemblyProbingFolder.DeleteAssembly(dependency.Name);
			});
			if (_hostEnvironment.IsAssemblyLoaded(dependency.Name))
			{
				Logger.Information("ExtensionRemoved: Module \"{0}\" is removed and its assembly is loaded, forcing AppDomain restart", dependency.Name);
				ctx.RestartAppDomain = true;
			}
		}
	}

	public override void ExtensionActivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
		string sourceFileName = _virtualPathProvider.MapPath(GetAssemblyPath(extension));
		if (!_assemblyProbingFolder.AssemblyExists(extension.Id) || File.GetLastWriteTimeUtc(sourceFileName) > _assemblyProbingFolder.GetAssemblyDateTimeUtc(extension.Id))
		{
			ctx.CopyActions.Add(delegate
			{
				_assemblyProbingFolder.StoreAssembly(extension.Id, sourceFileName);
			});
			if (_hostEnvironment.IsAssemblyLoaded(extension.Id))
			{
				Logger.Information("ExtensionRemoved: Module \"{0}\" is activated with newer file and its assembly is loaded, forcing AppDomain restart", extension.Id);
				ctx.RestartAppDomain = true;
			}
		}
	}

	public override void ExtensionDeactivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
		if (_assemblyProbingFolder.AssemblyExists(extension.Id))
		{
			ctx.DeleteActions.Add(delegate
			{
				Logger.Information("ExtensionDeactivated: Deleting assembly \"{0}\" from probing directory", extension.Id);
				_assemblyProbingFolder.DeleteAssembly(extension.Id);
			});
			if (_hostEnvironment.IsAssemblyLoaded(extension.Id))
			{
				Logger.Information("ExtensionDeactivated: Module \"{0}\" is deactivated and its assembly is loaded, forcing AppDomain restart", extension.Id);
				ctx.RestartAppDomain = true;
			}
		}
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

	public override void Monitor(ExtensionDescriptor descriptor, Action<IVolatileToken> monitor)
	{
		if (Disabled || DisableMonitoring)
		{
			return;
		}
		string assemblyPath = GetAssemblyPath(descriptor);
		if (assemblyPath != null)
		{
			Logger.Debug("Monitoring virtual path \"{0}\"", assemblyPath);
			monitor(_virtualPathMonitor.WhenPathChanges(assemblyPath));
			return;
		}
		string text = _virtualPathProvider.Combine(descriptor.Location, descriptor.Id, "bin");
		if (_virtualPathProvider.DirectoryExists(text))
		{
			Logger.Debug("Monitoring virtual path \"{0}\"", text);
			monitor(_virtualPathMonitor.WhenPathChanges(text));
		}
	}

	public override IEnumerable<ExtensionReferenceProbeEntry> ProbeReferences(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return Enumerable.Empty<ExtensionReferenceProbeEntry>();
		}
		Logger.Information("Probing references for module '{0}'", descriptor.Id);
		string assemblyPath = GetAssemblyPath(descriptor);
		if (assemblyPath == null)
		{
			return Enumerable.Empty<ExtensionReferenceProbeEntry>();
		}
		List<ExtensionReferenceProbeEntry> result = (from s in _virtualPathProvider.ListFiles(_virtualPathProvider.GetDirectoryName(assemblyPath))
			where StringComparer.OrdinalIgnoreCase.Equals(Path.GetExtension(s), ".dll")
			where !StringComparer.OrdinalIgnoreCase.Equals(Path.GetFileNameWithoutExtension(s), descriptor.Id)
			select s into path
			select new ExtensionReferenceProbeEntry
			{
				Descriptor = descriptor,
				Loader = this,
				Name = Path.GetFileNameWithoutExtension(path),
				VirtualPath = path
			}).ToList();
		Logger.Information("Done probing references for module '{0}'", descriptor.Id);
		return result;
	}

	public override bool IsCompatibleWithModuleReferences(ExtensionDescriptor extension, IEnumerable<ExtensionProbeEntry> references)
	{
		bool flag = references.All((ExtensionProbeEntry r) => r.Loader.GetType() != typeof(DynamicExtensionLoader));
		if (!flag)
		{
			Logger.Information("Extension \"{0}\" will not be loaded as pre-compiled extension because one or more referenced extension is dynamically compiled", extension.Id);
		}
		return flag;
	}

	public override ExtensionProbeEntry Probe(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Probing for module '{0}'", descriptor.Id);
		string assemblyPath = GetAssemblyPath(descriptor);
		if (assemblyPath == null)
		{
			return null;
		}
		ExtensionProbeEntry extensionProbeEntry = new ExtensionProbeEntry();
		extensionProbeEntry.Descriptor = descriptor;
		extensionProbeEntry.Loader = this;
		extensionProbeEntry.VirtualPath = assemblyPath;
		extensionProbeEntry.VirtualPathDependencies = new string[1] { assemblyPath };
		ExtensionProbeEntry result = extensionProbeEntry;
		Logger.Information("Done probing for module '{0}'", descriptor.Id);
		return result;
	}

	public override Assembly LoadReference(DependencyReferenceDescriptor reference)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Loading reference '{0}'", reference.Name);
		Assembly result = _assemblyProbingFolder.LoadAssembly(reference.Name);
		Logger.Information("Done loading reference '{0}'", reference.Name);
		return result;
	}

	protected override ExtensionEntry LoadWorker(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Start loading pre-compiled extension \"{0}\"", descriptor.Name);
		Assembly assembly = _assemblyProbingFolder.LoadAssembly(descriptor.Id);
		if (assembly == null)
		{
			return null;
		}
		Logger.Information("Done loading pre-compiled extension \"{0}\": assembly name=\"{1}\"", descriptor.Name, assembly.FullName);
		return new ExtensionEntry
		{
			Descriptor = descriptor,
			Assembly = assembly,
			ExportedTypes = assembly.GetTypes()
		};
	}

	public string GetAssemblyPath(ExtensionDescriptor descriptor)
	{
		string text = _virtualPathProvider.Combine(descriptor.Location, descriptor.Id, "bin", descriptor.Id + ".dll");
		if (!_virtualPathProvider.FileExists(text))
		{
			return null;
		}
		return text;
	}
}
