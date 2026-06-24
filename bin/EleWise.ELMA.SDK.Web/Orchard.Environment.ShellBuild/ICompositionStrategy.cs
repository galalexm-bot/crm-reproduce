using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.ShellBuilders.Models;

namespace Orchard.Environment.ShellBuilders;

public interface ICompositionStrategy
{
	ShellBlueprint Compose(ShellSettings settings, ShellDescriptor descriptor);
}
