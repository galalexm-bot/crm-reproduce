using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class StringExtensions
{
	public static LiteralExpressionSyntax GetLiteralExpression(this string str)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		SyntaxToken val = SyntaxFactory.Literal(SyntaxFactory.TriviaList(), "\"" + str + "\"", str, SyntaxFactory.TriviaList());
		return SyntaxFactory.LiteralExpression((SyntaxKind)8750, val);
	}

	public static SyntaxToken ToIdentifier(this string identifier)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		identifier = identifier.TrimStart('@');
		return SyntaxFactory.VerbatimIdentifier(SyntaxTriviaList.get_Empty(), identifier, identifier, SyntaxTriviaList.get_Empty());
	}

	public static IdentifierNameSyntax ToIdentifierName(this string identifier)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.IdentifierName(identifier.ToIdentifier());
	}

	public static GenericNameSyntax ToGenericName(this string identifier)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.GenericName(identifier.ToIdentifier());
	}
}
