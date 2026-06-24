using Nemerle.Core;

namespace Nemerle.Compiler.Parsetree;

public interface IParametersProvider
{
	list<PParameter> ParametersDeclarations { get; }

	list<PExpr> ParametersReferences { get; }
}
