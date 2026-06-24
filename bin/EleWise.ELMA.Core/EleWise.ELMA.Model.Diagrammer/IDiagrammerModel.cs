using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public interface IDiagrammerModel : ICloneableObjectLiteral
{
	[Name("id")]
	string Id { get; set; }

	[Name("items")]
	IDiagrammerElement[] Items { get; set; }
}
