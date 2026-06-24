using System.Runtime.CompilerServices;
using Nemerle.Compiler;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace CFG;

public class Node : ISupportRelocation
{
	public list<int> prev;

	public list<int> next;

	public TExpr expr;

	public Node(TExpr e)
	{
		prev = list<int>.Nil._N_constant_object;
		next = list<int>.Nil._N_constant_object;
		expr = e;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			expr?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
