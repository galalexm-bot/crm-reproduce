using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ElementAccessExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax expression;

	private readonly ExpressionSyntax[] arguments;

	public ElementAccessExpressionSyntax(ExpressionSyntax expression, IEnumerable<ExpressionSyntax> arguments)
		: base(ExpressionSyntaxPriority.ElementAccess)
	{
		this.expression = expression;
		this.arguments = arguments.ToArrayOrEmpty();
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(expression).Write("[").WriteComaSeparated(arguments)
			.Write("]");
	}
}
