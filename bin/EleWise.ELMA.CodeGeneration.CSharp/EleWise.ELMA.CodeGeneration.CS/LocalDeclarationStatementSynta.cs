namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class LocalDeclarationStatementSyntax : StatementSyntax
{
	private readonly bool _isConst;

	private readonly TypeSyntax _type;

	private readonly string _identifier;

	private readonly ExpressionSyntax _initializer;

	public LocalDeclarationStatementSyntax(string identifier, ExpressionSyntax initializer)
	{
		_identifier = IdentifierNameSyntax.EscapeIdentifier(identifier);
		_initializer = initializer;
	}

	public LocalDeclarationStatementSyntax(TypeSyntax type, string identifier, ExpressionSyntax initializer, bool isConst)
	{
		_type = type;
		_identifier = identifier;
		_initializer = initializer;
		_isConst = isConst;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.If(_isConst, delegate(GenerationContext _)
		{
			_.Write("const ");
		}).If(_type != null, delegate(GenerationContext _)
		{
			_.Write(_type);
		}).If(_type == null, delegate(GenerationContext _)
		{
			_.Write("var");
		})
			.Write(" ")
			.Write(_identifier)
			.If(_initializer != null, delegate(GenerationContext _)
			{
				_.Write(" = ").Write(_initializer);
			});
	}
}
