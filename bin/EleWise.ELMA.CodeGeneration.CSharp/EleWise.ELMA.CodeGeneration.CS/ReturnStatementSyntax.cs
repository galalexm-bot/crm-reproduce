namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ReturnStatementSyntax : StatementSyntax
{
	private ExpressionSyntax _expression;

	public ReturnStatementSyntax(ExpressionSyntax expression)
	{
		_expression = expression;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write("return").If(_expression != null, delegate(GenerationContext _)
		{
			_.Write(" ").Write(_expression);
		});
	}
}
