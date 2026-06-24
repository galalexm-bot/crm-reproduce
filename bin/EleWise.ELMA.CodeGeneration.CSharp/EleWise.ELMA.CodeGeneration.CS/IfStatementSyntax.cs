using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class IfStatementSyntax : StatementSyntax
{
	private readonly ExpressionSyntax _condition;

	private readonly StatementSyntax[] _trueStatements;

	private readonly StatementSyntax[] _falseStatements;

	public IfStatementSyntax(ExpressionSyntax condition, IEnumerable<StatementSyntax> trueStatements, IEnumerable<StatementSyntax> falseStatements)
	{
		_condition = condition;
		_trueStatements = trueStatements.ToArrayOrEmpty();
		_falseStatements = falseStatements.ToArrayOrNull();
	}

	protected override void InternalGenerate()
	{
	}

	internal override void Generate()
	{
		GenerationContext.Current.Write("if (").Write(_condition).WriteLine(")")
			.WriteLine("{")
			.Indentation(_trueStatements)
			.WriteLine("}")
			.If(_falseStatements != null, delegate(GenerationContext _)
			{
				_.WriteLine("else").WriteLine("{").Indentation(_falseStatements)
					.WriteLine("}");
			});
	}
}
