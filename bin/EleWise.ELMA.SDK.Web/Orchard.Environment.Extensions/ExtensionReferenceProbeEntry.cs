using Orchard.Environment.Extensions.Models;

namespace Orchard.Environment.Extensions.Loaders;

public class ExtensionReferenceProbeEntry
{
	public ExtensionDescriptor Descriptor { get; set; }

	public IExtensionLoader Loader { get; set; }

	public string Name { get; set; }

	public string VirtualPath { get; set; }
}
