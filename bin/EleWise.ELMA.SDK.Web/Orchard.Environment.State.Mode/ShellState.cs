using System.Collections.Generic;

namespace Orchard.Environment.State.Models;

public class ShellState
{
	public IEnumerable<ShellFeatureState> Features { get; set; }

	public ShellState()
	{
		Features = new List<ShellFeatureState>();
	}
}
