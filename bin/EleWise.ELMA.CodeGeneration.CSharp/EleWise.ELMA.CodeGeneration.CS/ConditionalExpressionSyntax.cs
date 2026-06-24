namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ConditionalExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax condition;

	private readonly ExpressionSyntax trueExpression;

	private readonly ExpressionSyntax falseExpression;

	public ConditionalExpressionSyntax(ExpressionSyntax condition, ExpressionSyntax trueExpression, ExpressionSyntax falseExpression)
		: base(ExpressionSyntaxPriority.Coalesce)
	{
		this.condition = condition;
		this.trueExpression = trueExpression;
		this.falseExpression = falseExpression;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(condition).Write(" ? ").Write(trueExpression)
			.Write(" : ")
			.Write(falseExpression);
	}
}
