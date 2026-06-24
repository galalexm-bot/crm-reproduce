namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public abstract class StatementSyntax : SyntaxNode
{
	protected abstract void InternalGenerate();

	internal override void Generate()
	{
		InternalGenerate();
		GenerationContext.Current.WriteLine(";");
	}
}
