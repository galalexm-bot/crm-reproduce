using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerChildChangeEvent : IDiagrammerChangeEvent
{
	[Name("parent")]
	string Parent { get; set; }

	[Name("index")]
	int Index { get; set; }

	[Name("previous")]
	string Previous { get; set; }

	[Name("previousIndex")]
	int PreviousIndex { get; set; }
}
