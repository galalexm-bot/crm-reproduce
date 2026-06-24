using Orchard.DisplayManagement.Shapes;

namespace Orchard.DisplayManagement;

public interface IShape
{
	ShapeMetadata Metadata { get; set; }
}
