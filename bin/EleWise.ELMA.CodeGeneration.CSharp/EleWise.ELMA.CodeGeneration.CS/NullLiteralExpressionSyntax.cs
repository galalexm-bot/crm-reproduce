namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class NullLiteralExpressionSyntax : ExpressionSyntax
{
	public NullLiteralExpressionSyntax()
		: base(ExpressionSyntaxPriority.Identifier)
	{
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("null");
	}
}
