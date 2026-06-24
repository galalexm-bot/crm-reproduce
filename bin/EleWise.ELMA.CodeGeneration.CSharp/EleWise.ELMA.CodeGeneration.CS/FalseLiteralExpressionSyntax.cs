namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class FalseLiteralExpressionSyntax : ExpressionSyntax
{
	public FalseLiteralExpressionSyntax()
		: base(ExpressionSyntaxPriority.Identifier)
	{
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("false");
	}
}
