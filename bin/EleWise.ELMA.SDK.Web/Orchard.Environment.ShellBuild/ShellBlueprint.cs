using System.Collections.Generic;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;

namespace Orchard.Environment.ShellBuilders.Models;

public class ShellBlueprint
{
	public ShellSettings Settings { get; set; }

	public ShellDescriptor Descriptor { get; set; }

	public IEnumerable<DependencyBlueprint> Dependencies { get; set; }

	public IEnumerable<ControllerBlueprint> Controllers { get; set; }

	public IEnumerable<ControllerBlueprint> HttpControllers { get; set; }

	public IEnumerable<RecordBlueprint> Records { get; set; }
}
