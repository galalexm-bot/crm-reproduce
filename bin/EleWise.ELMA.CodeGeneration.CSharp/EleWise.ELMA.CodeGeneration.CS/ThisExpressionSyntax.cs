namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ThisExpressionSyntax : ExpressionSyntax
{
	public ThisExpressionSyntax()
		: base(ExpressionSyntaxPriority.Identifier)
	{
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("this");
	}
}
