using System.Drawing;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

public interface IWebDiagrammerElementShape
{
	int Width { get; }

	int Height { get; }

	int StrokeWidth { get; }

	Color StrokeColor { get; }

	Color BackgroundColor { get; }
}
