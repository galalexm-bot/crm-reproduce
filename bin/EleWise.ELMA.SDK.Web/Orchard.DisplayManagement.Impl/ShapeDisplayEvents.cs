namespace Orchard.DisplayManagement.Implementation;

public abstract class ShapeDisplayEvents : IShapeDisplayEvents, IDependency
{
	public virtual void Displaying(ShapeDisplayingContext context)
	{
	}

	public virtual void Displayed(ShapeDisplayedContext context)
	{
	}
}
