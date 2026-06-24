using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class SwitchStatementSyntax : StatementSyntax
{
	private readonly IdentifierNameSyntax identifier;

	private readonly CaseStatementSyntax[] caseStatements;

	public SwitchStatementSyntax(IdentifierNameSyntax identifier, IEnumerable<CaseStatementSyntax> caseStatements)
	{
		this.identifier = identifier;
		this.caseStatements = caseStatements.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
	}

	internal override void Generate()
	{
		GenerationContext.Current.Write("switch (").Write(identifier).WriteLine(")")
			.WriteLine("{")
			.Indentation(caseStatements)
			.WriteLine("}");
	}
}
