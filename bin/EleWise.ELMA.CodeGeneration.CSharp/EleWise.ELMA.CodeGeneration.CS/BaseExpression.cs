namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class BaseExpression : ExpressionSyntax
{
	public BaseExpression()
		: base(ExpressionSyntaxPriority.Identifier)
	{
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("base");
	}
}
