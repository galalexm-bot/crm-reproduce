using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class CaseStatementSyntax : StatementSyntax
{
	private readonly ExpressionSyntax value;

	private readonly StatementSyntax[] statements;

	public CaseStatementSyntax(ExpressionSyntax value, IEnumerable<StatementSyntax> statements)
	{
		this.value = value;
		this.statements = statements.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
	}

	internal override void Generate()
	{
		GenerationContext.Current.If(value != null, delegate(GenerationContext _)
		{
			_.Write("case ").Write(value).WriteLine(":");
		}).If(value == null, delegate(GenerationContext _)
		{
			_.WriteLine("default:");
		}).WriteLine("{")
			.Indentation(statements)
			.WriteLine("}");
	}
}
