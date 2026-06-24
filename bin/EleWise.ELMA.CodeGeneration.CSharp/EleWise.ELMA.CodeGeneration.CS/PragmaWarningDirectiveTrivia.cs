using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;

namespace EleWise.ELMA.CodeGeneration.CSharp.Trivias;

public class PragmaWarningDirectiveTrivia : SyntaxTrivia
{
	private readonly bool _disable;

	private readonly ExpressionSyntax[] _errorCodes;

	public PragmaWarningDirectiveTrivia(bool disable, IEnumerable<ExpressionSyntax> errorCodes)
	{
		_disable = disable;
		_errorCodes = errorCodes.ToArrayOrEmpty();
	}

	internal override void Generate()
	{
		GenerationContext.Current.Write("#pragma warning " + (_disable ? "disable" : "restore") + " ", ignoreIndentation: true);
		GenerationContext.Current.WriteComaSeparated(_errorCodes);
		GenerationContext.Current.WriteLine();
	}
}
