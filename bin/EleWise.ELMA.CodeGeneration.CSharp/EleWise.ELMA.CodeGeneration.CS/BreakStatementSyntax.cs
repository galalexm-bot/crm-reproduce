namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class BreakStatementSyntax : StatementSyntax
{
	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write("break");
	}
}
