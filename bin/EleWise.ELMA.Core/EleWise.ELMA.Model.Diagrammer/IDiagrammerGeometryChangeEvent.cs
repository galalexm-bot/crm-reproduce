using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerGeometryChangeEvent : IDiagrammerChangeEvent
{
	[Name("position")]
	DiagrammerPoint Position { get; set; }

	[Name("size")]
	DiagrammerSize Size { get; set; }

	[Name("relative")]
	bool Relative { get; set; }

	[Name("points")]
	DiagrammerPoint[] Points { get; set; }
}
