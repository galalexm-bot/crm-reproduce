using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class AttributeSyntax : SyntaxNode
{
	private readonly string _attributeTypeName;

	private readonly AttributeArgumentSyntax[] _args;

	public bool AssemblySpecifier { get; set; }

	public AttributeSyntax(string attributeTypeName, IEnumerable<AttributeArgumentSyntax> args)
	{
		_attributeTypeName = IdentifierNameSyntax.EscapeIdentifier(attributeTypeName);
		_args = args.ToArrayOrEmpty();
	}

	internal void Generate(Action eolAction)
	{
		GenerationContext.Current.Write("[").If(AssemblySpecifier, delegate(GenerationContext _)
		{
			_.Write("assembly: ");
		}).Write(_attributeTypeName)
			.Write("(")
			.If(_args.Length != 0, delegate(GenerationContext _)
			{
				_.WriteComaSeparated(_args);
			})
			.Write(")")
			.Write("]");
		eolAction();
	}

	internal override void Generate()
	{
		GenerateLeading();
		Generate(delegate
		{
			GenerationContext.Current.WriteLine();
		});
		GenerateTrailing();
	}
}
