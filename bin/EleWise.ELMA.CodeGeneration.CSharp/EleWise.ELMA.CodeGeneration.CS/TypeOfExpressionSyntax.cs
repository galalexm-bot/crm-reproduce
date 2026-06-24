namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class TypeOfExpressionSyntax : ExpressionSyntax
{
	private readonly TypeSyntax _type;

	public TypeOfExpressionSyntax(TypeSyntax type)
		: base(ExpressionSyntaxPriority.Identifier)
	{
		_type = type;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write("typeof(").Write(_type).Write(")");
	}
}
