namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ThrowStatementSyntax : StatementSyntax
{
	private readonly ExpressionSyntax _expression;

	public ThrowStatementSyntax(ExpressionSyntax expression)
	{
		_expression = expression;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write("throw").If(_expression != null, delegate(GenerationContext _)
		{
			_.Write(" ").Write(_expression);
		});
	}
}
