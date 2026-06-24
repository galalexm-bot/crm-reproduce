namespace Orchard.DisplayManagement.Descriptors;

public interface IShapeTableManager : ISingletonDependency, IDependency
{
	ShapeTable GetShapeTable(string themeName);
}
