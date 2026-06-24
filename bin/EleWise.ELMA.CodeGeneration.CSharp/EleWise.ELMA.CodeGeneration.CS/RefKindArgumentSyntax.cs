using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class RefKindArgumentSyntax : ExpressionSyntax
{
	private readonly RefKind _refKind;

	private readonly ExpressionSyntax _expression;

	public RefKindArgumentSyntax(RefKind refKind, ExpressionSyntax expression)
		: base(ExpressionSyntaxPriority.Default)
	{
		_refKind = refKind;
		_expression = expression;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_refKind).Write(_expression);
	}
}
