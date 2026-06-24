using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class EnumDeclarationSyntax : MemberSyntax
{
	private readonly string _name;

	private readonly Accessibility _accessibility;

	private readonly DeclarationModifiers _modifiers;

	private readonly EnumMemberSyntax[] _members;

	public EnumDeclarationSyntax(string name, Accessibility accessibility, DeclarationModifiers modifiers, IEnumerable<EnumMemberSyntax> members)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_accessibility = accessibility;
		_modifiers = modifiers;
		_members = members.ToArrayOrEmpty();
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_accessibility).Write(_modifiers).Write("enum ")
			.Write(_name)
			.WriteLine()
			.WriteLine("{")
			.Indentation(delegate(GenerationContext _)
			{
				_.Write(_members, delegate(GenerationContext s)
				{
					s.WriteLine(",").WriteLine();
				});
			})
			.WriteLine()
			.WriteLine("}");
	}
}
