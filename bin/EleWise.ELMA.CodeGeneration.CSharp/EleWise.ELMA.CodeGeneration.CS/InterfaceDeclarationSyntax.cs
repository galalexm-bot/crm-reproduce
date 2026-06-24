using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class InterfaceDeclarationSyntax : MemberSyntax
{
	private readonly string _name;

	private readonly string[] _typeParameters;

	private readonly Accessibility _accessibility;

	private readonly DeclarationModifiers _modifiers;

	private readonly TypeSyntax[] _interfaceTypes;

	private readonly MemberSyntax[] _members;

	public string Name => _name;

	protected virtual string Type => "interface ";

	public InterfaceDeclarationSyntax(string name, IEnumerable<string> typeParameters, Accessibility accessibility, DeclarationModifiers modifiers, IEnumerable<TypeSyntax> interfaceTypes, IEnumerable<MemberSyntax> members)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_typeParameters = ((typeParameters != null) ? typeParameters.Select(IdentifierNameSyntax.EscapeIdentifier).ToArray() : new string[0]);
		_accessibility = accessibility;
		_modifiers = modifiers;
		_interfaceTypes = interfaceTypes.ToArrayOrEmpty();
		_members = members.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_accessibility).Write(_modifiers).Write(Type)
			.Write(_name)
			.If(_typeParameters.Length != 0, delegate(GenerationContext _)
			{
				_.Write("<").WriteComaSeparated(_typeParameters).Write(">");
			})
			.If(_interfaceTypes.Length != 0, delegate(GenerationContext _)
			{
				_.Write(" : ").WriteComaSeparated(_interfaceTypes);
			})
			.Call(delegate
			{
				GenerateTypeConstraints();
			})
			.WriteLine()
			.WriteLine("{")
			.Indentation(delegate(GenerationContext _)
			{
				_.WriteNewLineSeparated(_members);
			})
			.WriteLine("}");
	}
}
