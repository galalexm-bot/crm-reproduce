using System;
using Autofac;

namespace Orchard.Environment;

public class ShellContainerRegistrations : IShellContainerRegistrations
{
	public Action<ContainerBuilder> Registrations { get; private set; }

	public ShellContainerRegistrations()
	{
		Registrations = delegate
		{
		};
	}
}
