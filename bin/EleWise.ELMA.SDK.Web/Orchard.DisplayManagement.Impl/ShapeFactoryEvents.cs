namespace Orchard.DisplayManagement.Implementation;

public abstract class ShapeFactoryEvents : IShapeFactoryEvents, IDependency
{
	public virtual void Creating(ShapeCreatingContext context)
	{
	}

	public virtual void Created(ShapeCreatedContext context)
	{
	}
}
