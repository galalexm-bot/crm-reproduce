using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class NamespaceDeclarationSyntax : SyntaxNode
{
	private readonly string _name;

	private readonly MemberSyntax[] _declarations;

	public NamespaceDeclarationSyntax(string name, IEnumerable<MemberSyntax> declarations)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_declarations = declarations.ToArrayOrEmpty();
	}

	internal override void Generate()
	{
		GenerateLeading();
		GenerationContext.Current.Write("namespace ").WriteLine(_name).WriteLine("{")
			.Indentation(delegate(GenerationContext _)
			{
				_.Write(_declarations.Where(SyntaxGenerator.NotNewLineSeparated)).If(_declarations.Any(SyntaxGenerator.NotNewLineSeparated) && _declarations.Any(SyntaxGenerator.NewLineSeparated), delegate(GenerationContext c)
				{
					c.WriteLine();
				}).WriteNewLineSeparated(_declarations.Where(SyntaxGenerator.NewLineSeparated));
			})
			.WriteLine("}");
		GenerateTrailing();
	}
}
