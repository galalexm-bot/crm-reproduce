namespace Orchard.DisplayManagement.Descriptors.ShapePlacementStrategy;

public interface IPlacementFileParser : IDependency
{
	PlacementFile Parse(string virtualPath);

	PlacementFile ParseText(string placementText);
}
