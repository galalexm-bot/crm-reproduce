namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class AttributeArgumentSyntax : SyntaxNode
{
	private readonly string _name;

	private readonly ExpressionSyntax _expression;

	public AttributeArgumentSyntax(ExpressionSyntax expression)
	{
		_expression = expression;
	}

	public AttributeArgumentSyntax(string name, ExpressionSyntax expression)
		: this(expression)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
	}

	internal override void Generate()
	{
		GenerationContext.Current.If(!string.IsNullOrWhiteSpace(_name), delegate(GenerationContext _)
		{
			_.Write(_name).Write(" = ");
		}).Write(_expression);
	}
}
