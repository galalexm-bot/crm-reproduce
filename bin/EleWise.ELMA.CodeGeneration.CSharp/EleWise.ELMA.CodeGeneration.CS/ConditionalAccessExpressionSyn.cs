namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ConditionalAccessExpressionSyntax : ExpressionSyntax
{
	private readonly ExpressionSyntax expression;

	private readonly SyntaxNode memberName;

	public ConditionalAccessExpressionSyntax(ExpressionSyntax expression, SyntaxNode memberName)
		: base(ExpressionSyntaxPriority.MemberAccess)
	{
		this.expression = expression;
		this.memberName = memberName;
	}

	public ConditionalAccessExpressionSyntax(ExpressionSyntax expression, string memberName)
		: base(ExpressionSyntaxPriority.MemberAccess)
	{
		this.expression = expression;
		this.memberName = new IdentifierNameSyntax(memberName);
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(expression).Write("?.").Write(memberName);
	}
}
