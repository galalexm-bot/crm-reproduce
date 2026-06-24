namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class AssignmentExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _left;

	private readonly ExpressionSyntax _right;

	public AssignmentExpressionSyntax(ExpressionSyntax left, ExpressionSyntax right)
		: base(ExpressionSyntaxPriority.Assignment)
	{
		_left = left;
		_right = right;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_left).Write(" = ").Write(_right);
	}
}
