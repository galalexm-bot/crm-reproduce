using Bridge;

namespace EleWise.ELMA.Model.Diagrammer.Events;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerCopyEvent : IDiagrammerChangeEvent
{
	[Name("elements")]
	string[] Elements { get; set; }
}
