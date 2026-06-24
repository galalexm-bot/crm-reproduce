using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class Namespace : TypedBase
{
	public readonly NamespaceTree.Node Node;

	[RecordCtor]
	public Namespace([MappedMember("Node")] NamespaceTree.Node node)
	{
		Node = node;
	}

	[RecordCtor]
	public Namespace(Location loc, [MappedMember("Node")] NamespaceTree.Node node)
		: base(loc)
	{
		Node = node;
	}
}
