using EleWise.ELMA.Events;
using Orchard.Environment.Descriptor.Models;

namespace Orchard.Environment.Descriptor;

public interface IShellDescriptorManagerEventHandler : IEventHandler
{
	void Changed(ShellDescriptor descriptor, string tenant);
}
