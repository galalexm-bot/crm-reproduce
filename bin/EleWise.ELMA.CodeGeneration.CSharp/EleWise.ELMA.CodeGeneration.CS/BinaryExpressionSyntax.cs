namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

internal class BinaryExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntaxPriority _operation;

	private readonly ExpressionSyntax _left;

	private readonly ExpressionSyntax _right;

	public BinaryExpressionSyntax(ExpressionSyntaxPriority operation, ExpressionSyntax left, ExpressionSyntax right)
		: base(operation)
	{
		_operation = operation;
		_left = left;
		_right = right;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_left).Write(_operation).Write(_right);
	}
}
