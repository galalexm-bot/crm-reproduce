using System.Collections.Generic;
using System.Linq;

namespace Orchard.Environment.Descriptor.Models;

public class ShellDescriptor
{
	public int SerialNumber { get; set; }

	public IEnumerable<ShellFeature> Features { get; set; }

	public ShellDescriptor()
	{
		Features = Enumerable.Empty<ShellFeature>();
	}
}
