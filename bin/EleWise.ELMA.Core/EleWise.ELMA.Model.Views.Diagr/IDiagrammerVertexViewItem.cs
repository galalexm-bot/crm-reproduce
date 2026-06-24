using EleWise.ELMA.Model.Diagrammer;

namespace EleWise.ELMA.Model.Views.Diagrammer;

public interface IDiagrammerVertexViewItem : IDiagrammerShapeViewItem, IViewItem, IReactive
{
	int X { get; set; }

	int Y { get; set; }

	string BackgroundColor { get; set; }

	string BorderColor { get; set; }

	int BorderWidth { get; set; }

	DiagrammerLineStyle BorderStyle { get; set; }
}
