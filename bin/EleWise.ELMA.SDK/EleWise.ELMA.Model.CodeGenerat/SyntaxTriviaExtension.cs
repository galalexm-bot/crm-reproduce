using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class SyntaxTriviaExtension
{
	public static ISyntaxTrivia Pack(this IEnumerable<SyntaxTrivia> syntaxTrivia)
	{
		return new SyntaxTriviaContainer(syntaxTrivia);
	}

	public static IEnumerable<SyntaxTrivia> Unpack(this ISyntaxTrivia syntaxTrivia)
	{
		return ((SyntaxTriviaContainer)syntaxTrivia).SyntaxTrivia;
	}

	public static IEnumerable<SyntaxTrivia> Unpack(this IEnumerable<ISyntaxTrivia> syntaxTrivias)
	{
		return syntaxTrivias?.Where((ISyntaxTrivia t) => t != null).SelectMany(Unpack);
	}
}
