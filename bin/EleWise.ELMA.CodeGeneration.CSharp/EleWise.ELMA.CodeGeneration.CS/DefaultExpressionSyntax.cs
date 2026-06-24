namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class DefaultExpressionSyntax : ExpressionSyntax
{
	private readonly TypeSyntax type;

	public DefaultExpressionSyntax(TypeSyntax type)
		: base(ExpressionSyntaxPriority.Identifier)
	{
		this.type = type;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("default(").Write(type).Write(")");
	}
}
