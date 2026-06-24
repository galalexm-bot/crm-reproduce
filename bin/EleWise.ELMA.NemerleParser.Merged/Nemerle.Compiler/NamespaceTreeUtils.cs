using System.Collections.Generic;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Extension]
public static class NamespaceTreeUtils
{
	[Extension]
	public static List<Tuple<list<NamespaceTree.Node>, Location>> GetReferencedNamespaces(this NamespaceTree nspace)
	{
		return nspace.referenced_namespace_nodes;
	}
}
