namespace Orchard.DisplayManagement.Implementation;

public interface IShapeFactoryEvents : IDependency
{
	void Creating(ShapeCreatingContext context);

	void Created(ShapeCreatedContext context);
}
