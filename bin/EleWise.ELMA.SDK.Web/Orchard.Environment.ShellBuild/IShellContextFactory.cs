using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;

namespace Orchard.Environment.ShellBuilders;

public interface IShellContextFactory
{
	ShellContext CreateShellContext(ShellSettings settings);

	ShellContext CreateSetupContext(ShellSettings settings);

	ShellContext CreateDescribedContext(ShellSettings settings, ShellDescriptor shellDescriptor);
}
