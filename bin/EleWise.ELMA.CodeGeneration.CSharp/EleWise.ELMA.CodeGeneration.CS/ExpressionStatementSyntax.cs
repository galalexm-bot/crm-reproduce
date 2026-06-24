namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ExpressionStatementSyntax : StatementSyntax
{
	private readonly ExpressionSyntax _expression;

	public ExpressionStatementSyntax(ExpressionSyntax expression)
	{
		_expression = expression;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_expression);
	}
}
