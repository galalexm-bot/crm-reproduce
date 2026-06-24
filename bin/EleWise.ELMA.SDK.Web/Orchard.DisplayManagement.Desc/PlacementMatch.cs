using System.Collections.Generic;

namespace Orchard.DisplayManagement.Descriptors.ShapePlacementStrategy;

public class PlacementMatch : PlacementNode
{
	public IDictionary<string, string> Terms { get; set; }
}
