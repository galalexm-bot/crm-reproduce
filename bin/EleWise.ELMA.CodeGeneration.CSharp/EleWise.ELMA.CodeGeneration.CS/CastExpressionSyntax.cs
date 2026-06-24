namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class CastExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _expression;

	private readonly TypeSyntax _type;

	public CastExpressionSyntax(TypeSyntax type, ExpressionSyntax expression)
		: base(ExpressionSyntaxPriority.Cast)
	{
		_type = type;
		_expression = expression;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("(").Write(_type).Write(")")
			.Write(_expression);
	}
}
