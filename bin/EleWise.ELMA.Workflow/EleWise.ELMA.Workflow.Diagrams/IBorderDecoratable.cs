using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes;

public interface IBorderDecoratable
{
	NModel GetBorderDecoratorModel(NRectangleF bounds);
}
