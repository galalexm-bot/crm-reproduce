namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class TryCastExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _expression;

	private readonly TypeSyntax _type;

	public TryCastExpressionSyntax(TypeSyntax type, ExpressionSyntax expression)
		: base(ExpressionSyntaxPriority.TryCast)
	{
		_type = type;
		_expression = expression;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_expression).Write(" as ").Write(_type);
	}
}
