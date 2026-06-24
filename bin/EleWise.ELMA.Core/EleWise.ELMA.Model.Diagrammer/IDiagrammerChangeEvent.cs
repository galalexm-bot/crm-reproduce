using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerChangeEvent
{
	[Name("event")]
	string EventName { get; set; }

	[Name("target")]
	string Target { get; set; }

	void Apply(IDiagrammerElement element);
}
