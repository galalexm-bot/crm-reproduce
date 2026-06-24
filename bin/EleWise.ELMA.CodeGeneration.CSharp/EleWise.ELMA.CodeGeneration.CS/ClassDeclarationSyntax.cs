using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ClassDeclarationSyntax : InterfaceDeclarationSyntax
{
	protected override string Type => "class ";

	public ClassDeclarationSyntax(string name, IEnumerable<string> typeParameters, Accessibility accessibility, DeclarationModifiers modifiers, TypeSyntax baseType, IEnumerable<TypeSyntax> interfaceTypes, IEnumerable<MemberSyntax> members)
		: base(name, typeParameters, accessibility, modifiers, (baseType != null) ? new TypeSyntax[1] { baseType }.Concat(interfaceTypes ?? Enumerable.Empty<TypeSyntax>()) : interfaceTypes, members)
	{
	}
}
