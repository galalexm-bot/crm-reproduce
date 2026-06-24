using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class LambdaParameterSyntax : ParameterDeclarationSyntax
{
	public LambdaParameterSyntax(string identifier, TypeSyntax type)
		: base(identifier, type, null, RefKind.None)
	{
	}
}
