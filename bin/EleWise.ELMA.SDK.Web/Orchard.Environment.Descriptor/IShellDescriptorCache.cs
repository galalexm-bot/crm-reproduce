using Orchard.Environment.Descriptor.Models;

namespace Orchard.Environment.Descriptor;

public interface IShellDescriptorCache
{
	ShellDescriptor Fetch(string shellName);

	void Store(string shellName, ShellDescriptor descriptor);
}
