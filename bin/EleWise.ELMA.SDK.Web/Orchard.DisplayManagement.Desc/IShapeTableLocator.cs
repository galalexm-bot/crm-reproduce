namespace Orchard.DisplayManagement.Descriptors;

public interface IShapeTableLocator : IUnitOfWorkDependency, IDependency
{
	ShapeTable Lookup(string themeName);
}
