using Nemerle.Core;

namespace Nemerle.Compiler;

public class OperatorDefinition : SyntaxDefinition
{
	public readonly int Left;

	public readonly int Right;

	public OperatorDefinition(NamespaceTree.Node node, string name, int left, int right, bool is_unary)
		: base(name, (!is_unary) ? null : list<string>.Nil._N_constant_object, node, null, null)
	{
		Left = left;
		Right = right;
	}
}
