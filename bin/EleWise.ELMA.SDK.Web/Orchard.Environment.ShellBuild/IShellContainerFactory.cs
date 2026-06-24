using Autofac;
using Orchard.Environment.Configuration;
using Orchard.Environment.ShellBuilders.Models;

namespace Orchard.Environment.ShellBuilders;

public interface IShellContainerFactory
{
	ILifetimeScope CreateContainer(ShellSettings settings, ShellBlueprint blueprint);
}
