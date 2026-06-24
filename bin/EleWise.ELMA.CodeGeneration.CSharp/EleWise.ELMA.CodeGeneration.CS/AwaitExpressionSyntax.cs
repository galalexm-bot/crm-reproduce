namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class AwaitExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _expression;

	public AwaitExpressionSyntax(ExpressionSyntax expression)
		: base(ExpressionSyntaxPriority.Default)
	{
		_expression = expression;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("await ").Write(_expression);
	}
}
