using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class FieldDeclarationSyntax : MemberSyntax
{
	private readonly string _name;

	private readonly TypeSyntax _type;

	private readonly Accessibility _accessibility;

	private readonly DeclarationModifiers _modifiers;

	private readonly ExpressionSyntax _initializer;

	public FieldDeclarationSyntax(string name, TypeSyntax type, Accessibility accessibility, DeclarationModifiers modifiers, ExpressionSyntax initializer)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_type = type;
		_accessibility = accessibility;
		_modifiers = modifiers;
		_initializer = initializer;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_accessibility).Write(_modifiers).Write(_type)
			.Write(" ")
			.Write(_name)
			.If(_initializer != null, delegate(GenerationContext _)
			{
				_.Write(" = ").Write(_initializer);
			})
			.WriteLine(";");
	}
}
