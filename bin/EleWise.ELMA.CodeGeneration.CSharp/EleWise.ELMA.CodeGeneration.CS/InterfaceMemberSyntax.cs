using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public abstract class InterfaceMemberSyntax : MemberSyntax
{
	protected readonly Accessibility _accessibility;

	protected readonly DeclarationModifiers _modifiers;

	public string Name { get; }

	public TypeSyntax Type { get; }

	public TypeSyntax PrivateInterfaceImplementationType { get; set; }

	public InterfaceMemberSyntax(string name, TypeSyntax type, Accessibility accessibility, DeclarationModifiers modifiers)
	{
		Name = name;
		Type = type;
		_accessibility = accessibility;
		_modifiers = modifiers;
	}

	protected override void InternalGenerate()
	{
		bool flag = GenerationContext.Current.ParentNode is ClassDeclarationSyntax;
		GenerationContext.Current.If(PrivateInterfaceImplementationType == null && flag, delegate(GenerationContext _)
		{
			_.Write(_accessibility).Write(_modifiers);
		}).If(Type != null, delegate(GenerationContext _)
		{
			_.Write(Type);
		}).If(Type == null, delegate(GenerationContext _)
		{
			_.Write("void");
		})
			.Write(" ")
			.If(PrivateInterfaceImplementationType != null, delegate(GenerationContext _)
			{
				_.Write(PrivateInterfaceImplementationType).Write(".");
			})
			.Write(IdentifierNameSyntax.EscapeIdentifier(Name));
	}
}
