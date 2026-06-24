using System.Collections.Generic;
using System.Linq;

namespace Orchard.Environment.Extensions.Models;

public class FeatureDescriptor
{
	public ExtensionDescriptor Extension { get; set; }

	public string Id { get; set; }

	public string Name { get; set; }

	public string Module { get; set; }

	public string Description { get; set; }

	public string Category { get; set; }

	public int Priority { get; set; }

	public IEnumerable<string> Dependencies { get; set; }

	public FeatureDescriptor()
	{
		Dependencies = Enumerable.Empty<string>();
	}
}
