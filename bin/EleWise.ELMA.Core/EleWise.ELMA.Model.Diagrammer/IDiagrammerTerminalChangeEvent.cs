using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerTerminalChangeEvent : IDiagrammerChangeEvent
{
	[Name("source")]
	bool Source { get; set; }

	[Name("terminal")]
	string Terminal { get; set; }

	[Name("terminalX")]
	double TerminalX { get; set; }

	[Name("terminalY")]
	double TerminalY { get; set; }
}
