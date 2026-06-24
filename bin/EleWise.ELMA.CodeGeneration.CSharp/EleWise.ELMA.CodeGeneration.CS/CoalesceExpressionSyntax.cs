namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class CoalesceExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax left;

	private readonly ExpressionSyntax right;

	public CoalesceExpressionSyntax(ExpressionSyntax left, ExpressionSyntax right)
		: base(ExpressionSyntaxPriority.Coalesce)
	{
		this.left = left;
		this.right = right;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(left).Write(" ?? ").Write(right);
	}
}
