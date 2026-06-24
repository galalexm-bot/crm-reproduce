using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class InvocationExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _expression;

	private readonly ExpressionSyntax[] _arguments;

	public InvocationExpressionSyntax(ExpressionSyntax expression, IEnumerable<ExpressionSyntax> arguments)
		: base(ExpressionSyntaxPriority.Invocation)
	{
		_expression = expression;
		_arguments = arguments.ToArrayOrEmpty();
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_expression).Write("(").WriteComaSeparated(_arguments)
			.Write(")");
	}
}
