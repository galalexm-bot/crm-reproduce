using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public interface IMacro
{
	bool IsTailRecursionTransparent { get; }

	bool IsInherited { get; }

	list<string> Keywords { get; }

	MacroUsageAttribute Usage { get; }

	Location Location { get; }

	string GetName();

	string GetNamespace();

	PExpr Run(Typer ctx, list<SyntaxElement> args);

	list<SyntaxElement> CallTransform(list<PExpr> _N_wildcard_3382);

	Tuple<GrammarElement, Function<list<SyntaxElement>, list<SyntaxElement>>> SyntaxExtension();
}
