namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class MemberAccessExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax _expression;

	private readonly SyntaxNode _memberName;

	public MemberAccessExpressionSyntax(ExpressionSyntax expression, SyntaxNode memberName)
		: base(ExpressionSyntaxPriority.MemberAccess)
	{
		_expression = expression;
		_memberName = memberName;
	}

	public MemberAccessExpressionSyntax(ExpressionSyntax expression, string memberName)
		: base(ExpressionSyntaxPriority.MemberAccess)
	{
		_expression = expression;
		_memberName = new IdentifierNameSyntax(memberName);
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_expression).Write(".").Write(_memberName);
	}
}
