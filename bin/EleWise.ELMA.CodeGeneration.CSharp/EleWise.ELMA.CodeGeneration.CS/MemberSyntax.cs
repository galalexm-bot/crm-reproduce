namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public abstract class MemberSyntax : SyntaxNode
{
	protected abstract void InternalGenerate();

	internal override void Generate()
	{
		GenerateLeading();
		InternalGenerate();
		GenerateTrailing();
	}
}
