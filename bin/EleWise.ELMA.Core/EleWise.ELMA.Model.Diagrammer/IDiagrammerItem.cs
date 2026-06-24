using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

public interface IDiagrammerItem : IDiagrammerElement, ICloneableObjectLiteral
{
	[Name("size")]
	DiagrammerSize Size { get; set; }

	[Name("position")]
	DiagrammerPoint Position { get; set; }

	[Name("type")]
	DiagrammerItemType Type { get; set; }

	[Name("parent")]
	string Parent { get; set; }
}
