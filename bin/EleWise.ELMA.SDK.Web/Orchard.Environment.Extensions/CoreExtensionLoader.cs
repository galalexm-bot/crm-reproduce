using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Loaders;

public class CoreExtensionLoader : ExtensionLoaderBase
{
	private const string CoreAssemblyName = "Orchard.Core";

	private readonly IAssemblyLoader _assemblyLoader;

	public ILogger Logger { get; set; }

	public bool Disabled { get; set; }

	public override int Order => 10;

	public CoreExtensionLoader(IDependenciesFolder dependenciesFolder, IAssemblyLoader assemblyLoader)
		: base(dependenciesFolder)
	{
		_assemblyLoader = assemblyLoader;
		Logger = NullLogger.Instance;
	}

	public override ExtensionProbeEntry Probe(ExtensionDescriptor descriptor)
	{
		if (Disabled)
		{
			return null;
		}
		if (descriptor.Location == "~/Core")
		{
			return new ExtensionProbeEntry
			{
				Descriptor = descriptor,
				Loader = this,
				Priority = 100,
				VirtualPath = "~/Core/" + descriptor.Id,
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
		Assembly assembly = _assemblyLoader.Load("Orchard.Core");
		if (assembly == null)
		{
			Logger.Error("Core modules cannot be activated because assembly '{0}' could not be loaded", "Orchard.Core");
			return null;
		}
		Logger.Information("Loaded core module \"{0}\": assembly name=\"{1}\"", descriptor.Name, assembly.FullName);
		return new ExtensionEntry
		{
			Descriptor = descriptor,
			Assembly = assembly,
			ExportedTypes = from x in assembly.GetTypes()
				where IsTypeFromModule(x, descriptor)
				select x
		};
	}

	private static bool IsTypeFromModule(Type type, ExtensionDescriptor descriptor)
	{
		return (type.Namespace + ".").StartsWith("Orchard.Core." + descriptor.Id + ".");
	}
}
