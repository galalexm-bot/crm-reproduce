using System.IO;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Loaders;

public class ReferencedExtensionLoader : ExtensionLoaderBase
{
	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IBuildManager _buildManager;

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public override int Order => 20;

	public ReferencedExtensionLoader(IDependenciesFolder dependenciesFolder, IVirtualPathProvider virtualPathProvider, IBuildManager buildManager)
		: base(dependenciesFolder)
	{
		_virtualPathProvider = virtualPathProvider;
		_buildManager = buildManager;
		Logger = NullLogger.Instance;
	}

	public override void ExtensionDeactivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
		DeleteAssembly(ctx, extension.Id);
	}

	public override void ExtensionRemoved(ExtensionLoadingContext ctx, DependencyDescriptor dependency)
	{
		DeleteAssembly(ctx, dependency.Name);
	}

	private void DeleteAssembly(ExtensionLoadingContext ctx, string moduleName)
	{
		string assemblyPath = _virtualPathProvider.Combine("~/bin", moduleName + ".dll");
		if (_virtualPathProvider.FileExists(assemblyPath))
		{
			ctx.DeleteActions.Add(delegate
			{
				Logger.Information("ExtensionRemoved: Deleting assembly \"{0}\" from bin directory (AppDomain will restart)", moduleName);
				File.Delete(_virtualPathProvider.MapPath(assemblyPath));
			});
			ctx.RestartAppDomain = true;
		}
	}

	public override ExtensionProbeEntry Probe(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		if (_buildManager.GetReferencedAssembly(descriptor.Id) == null)
		{
			return null;
		}
		string text = _virtualPathProvider.Combine("~/bin", descriptor.Id + ".dll");
		ExtensionProbeEntry extensionProbeEntry = new ExtensionProbeEntry();
		extensionProbeEntry.Descriptor = descriptor;
		extensionProbeEntry.Loader = this;
		extensionProbeEntry.Priority = 100;
		extensionProbeEntry.VirtualPath = text;
		extensionProbeEntry.VirtualPathDependencies = new string[1] { text };
		return extensionProbeEntry;
	}

	protected override ExtensionEntry LoadWorker(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		Assembly referencedAssembly = _buildManager.GetReferencedAssembly(descriptor.Id);
		if (referencedAssembly == null)
		{
			return null;
		}
		Logger.Information("Loaded referenced extension \"{0}\": assembly name=\"{1}\"", descriptor.Name, referencedAssembly.FullName);
		return new ExtensionEntry
		{
			Descriptor = descriptor,
			Assembly = referencedAssembly,
			ExportedTypes = referencedAssembly.GetTypes()
		};
	}
}
