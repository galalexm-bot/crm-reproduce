using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class LambdaExpressionSyntax : ExpressionSyntax
{
	private LambdaParameterSyntax[] _lambdaParameters;

	private ExpressionSyntax _expression;

	private StatementSyntax[] _statements;

	public LambdaExpressionSyntax(IEnumerable<LambdaParameterSyntax> lambdaParameters, ExpressionSyntax expression)
		: base(ExpressionSyntaxPriority.LambdaExpression)
	{
		_lambdaParameters = lambdaParameters.ToArrayOrEmpty();
		_expression = expression;
	}

	public LambdaExpressionSyntax(IEnumerable<LambdaParameterSyntax> lambdaParameters, IEnumerable<StatementSyntax> statements)
		: base(ExpressionSyntaxPriority.LambdaExpression)
	{
		_lambdaParameters = lambdaParameters.ToArrayOrEmpty();
		_statements = statements.ToArrayOrNull();
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.If(_lambdaParameters.Length != 1, delegate(GenerationContext _)
		{
			_.Write("(");
		}).WriteComaSeparated(_lambdaParameters).If(_lambdaParameters.Length != 1, delegate(GenerationContext _)
		{
			_.Write(")");
		})
			.Write(" => ")
			.If(_expression != null, delegate(GenerationContext _)
			{
				_.Write(_expression);
			})
			.If(_statements != null, delegate(GenerationContext _)
			{
				_.WriteLine().WriteLine("{").Indentation(_statements)
					.Write("}");
			});
	}
}
