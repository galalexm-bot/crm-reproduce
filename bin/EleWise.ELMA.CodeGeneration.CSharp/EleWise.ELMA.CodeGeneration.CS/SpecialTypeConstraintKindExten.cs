using System.Collections.Generic;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;

namespace EleWise.ELMA.CodeGeneration.CSharp.Extensions;

internal static class SpecialTypeConstraintKindExtensions
{
	public static IEnumerable<SyntaxNode> Generate(this SpecialTypeConstraintKind kinds)
	{
		if ((kinds & SpecialTypeConstraintKind.ReferenceType) > SpecialTypeConstraintKind.None)
		{
			yield return new SnippetExpressionSyntax("class");
		}
		if ((kinds & SpecialTypeConstraintKind.ValueType) > SpecialTypeConstraintKind.None)
		{
			yield return new SnippetExpressionSyntax("struct");
		}
		if ((kinds & SpecialTypeConstraintKind.Constructor) > SpecialTypeConstraintKind.None)
		{
			yield return new SnippetExpressionSyntax("new()");
		}
	}
}
