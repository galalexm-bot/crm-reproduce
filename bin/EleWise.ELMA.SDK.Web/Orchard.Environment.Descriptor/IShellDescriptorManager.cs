using System.Collections.Generic;
using Orchard.Environment.Descriptor.Models;

namespace Orchard.Environment.Descriptor;

public interface IShellDescriptorManager : IDependency
{
	ShellDescriptor GetShellDescriptor();

	void UpdateShellDescriptor(int priorSerialNumber, IEnumerable<ShellFeature> enabledFeatures);
}
