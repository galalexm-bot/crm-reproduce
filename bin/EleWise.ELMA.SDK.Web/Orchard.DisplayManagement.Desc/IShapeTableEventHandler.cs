using EleWise.ELMA.Events;

namespace Orchard.DisplayManagement.Descriptors;

public interface IShapeTableEventHandler : IEventHandler
{
	void ShapeTableCreated(ShapeTable shapeTable);
}
