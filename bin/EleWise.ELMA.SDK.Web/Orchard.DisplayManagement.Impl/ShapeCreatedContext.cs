namespace Orchard.DisplayManagement.Implementation;

public class ShapeCreatedContext
{
	public IShapeFactory ShapeFactory { get; set; }

	public dynamic New { get; set; }

	public string ShapeType { get; set; }

	public dynamic Shape { get; set; }
}
