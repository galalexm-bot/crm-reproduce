namespace Orchard.DisplayManagement.Descriptors;

public interface IShapeTableProvider : IDependency
{
	void Discover(ShapeTableBuilder builder);
}
