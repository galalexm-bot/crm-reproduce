namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class TrueLiteralExpression : ExpressionSyntax
{
	public TrueLiteralExpression()
		: base(ExpressionSyntaxPriority.Identifier)
	{
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("true");
	}
}
