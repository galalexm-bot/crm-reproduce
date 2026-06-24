namespace Orchard.DisplayManagement.Implementation;

public interface IShapeDisplayEvents : IDependency
{
	void Displaying(ShapeDisplayingContext context);

	void Displayed(ShapeDisplayedContext context);
}
