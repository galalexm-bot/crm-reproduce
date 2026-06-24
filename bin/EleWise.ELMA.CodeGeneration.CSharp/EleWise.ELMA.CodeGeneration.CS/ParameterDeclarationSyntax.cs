using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ParameterDeclarationSyntax : SyntaxNode
{
	private readonly string _name;

	private readonly SyntaxNode _type;

	private readonly SyntaxNode _initializer;

	private readonly RefKind _refKind;

	public bool ParamsModifier { get; set; }

	public ParameterDeclarationSyntax(string name, SyntaxNode type, SyntaxNode initializer, RefKind refKind)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_type = type;
		_initializer = initializer;
		_refKind = refKind;
	}

	internal override void Generate()
	{
		GenerationContext.Current.Call(delegate
		{
			GenerateLeading();
		}).If(ParamsModifier, delegate(GenerationContext _)
		{
			_.Write("params ");
		}).Write(_refKind)
			.If(_type != null, delegate(GenerationContext _)
			{
				_.Write(_type).Write(" ");
			})
			.Write(_name)
			.If(_initializer != null, delegate(GenerationContext _)
			{
				_.Write(" = ").Write(_initializer);
			});
	}

	protected override void AttributeEol()
	{
		GenerationContext.Current.Write(" ");
	}
}
