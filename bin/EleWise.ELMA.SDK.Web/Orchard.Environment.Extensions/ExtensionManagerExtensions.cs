using System.Collections.Generic;
using System.Linq;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Environment.Extensions;

public static class ExtensionManagerExtensions
{
	public static IEnumerable<FeatureDescriptor> EnabledFeatures(this IExtensionManager extensionManager, ShellDescriptor descriptor)
	{
		return extensionManager.EnabledFeatures(descriptor.Features);
	}

	public static IEnumerable<FeatureDescriptor> EnabledFeatures(this IExtensionManager extensionManager, IEnumerable<ShellFeature> features)
	{
		return from fd in extensionManager.AvailableFeatures()
			where features.Any((ShellFeature sf) => sf.Name == fd.Id)
			select fd;
	}

	public static IEnumerable<FeatureDescriptor> DisabledFeatures(this IExtensionManager extensionManager, ShellDescriptor descriptor)
	{
		return from fd in extensionManager.AvailableFeatures()
			where descriptor.Features.All((ShellFeature sf) => sf.Name != fd.Id)
			select fd;
	}
}
