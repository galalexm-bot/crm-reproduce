using System;
using Autofac;

namespace Orchard.Environment;

public interface IShellContainerRegistrations
{
	Action<ContainerBuilder> Registrations { get; }
}
