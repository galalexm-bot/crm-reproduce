using System.Collections.Generic;

namespace Orchard.DisplayManagement.Descriptors.ShapePlacementStrategy;

public class PlacementNode
{
	public IEnumerable<PlacementNode> Nodes { get; set; }
}
