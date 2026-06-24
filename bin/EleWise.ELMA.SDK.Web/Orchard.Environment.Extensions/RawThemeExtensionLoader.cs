using System;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Loaders;

public class RawThemeExtensionLoader : ExtensionLoaderBase
{
	private readonly IVirtualPathProvider _virtualPathProvider;

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public override int Order => 10;

	public RawThemeExtensionLoader(IDependenciesFolder dependenciesFolder, IVirtualPathProvider virtualPathProvider)
		: base(dependenciesFolder)
	{
		_virtualPathProvider = virtualPathProvider;
		Logger = NullLogger.Instance;
	}

	public override ExtensionProbeEntry Probe(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		if (descriptor.Location.StartsWith("~/Themes", StringComparison.InvariantCultureIgnoreCase))
		{
			string virtualPath = _virtualPathProvider.Combine(descriptor.Location, descriptor.Id, descriptor.Id + ".csproj");
			if (_virtualPathProvider.FileExists(virtualPath))
			{
				return null;
			}
			string virtualPath2 = _virtualPathProvider.Combine(descriptor.Location, descriptor.Id, "bin", descriptor.Id + ".dll");
			if (_virtualPathProvider.FileExists(virtualPath2))
			{
				return null;
			}
			return new ExtensionProbeEntry
			{
				Descriptor = descriptor,
				Loader = this,
				VirtualPath = descriptor.VirtualPath,
				VirtualPathDependencies = Enumerable.Empty<string>()
			};
		}
		return null;
	}

	protected override ExtensionEntry LoadWorker(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		Logger.Information("Loaded no-code theme \"{0}\"", descriptor.Name);
		return new ExtensionEntry
		{
			Descriptor = descriptor,
			Assembly = GetType().Assembly,
			ExportedTypes = new Type[0]
		};
	}
}
