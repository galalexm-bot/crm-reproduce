using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace CFG;

public class Array : ISupportRelocation
{
	private readonly List<Node> iNode;

	public Array()
	{
		iNode = new List<Node>();
	}

	public int AddNode(TExpr expr)
	{
		iNode.Add(new Node(expr));
		return checked(iNode.Count - 1);
	}

	public int AddEdge(int i1, int i2)
	{
		Node node = iNode[i1];
		Node node2 = iNode[i2];
		node.next = new list<int>.Cons(i2, node.next);
		node2.prev = new list<int>.Cons(i1, node2.prev);
		return i2;
	}

	public void Iterate(Function<int, Node, bool> f)
	{
		int num = 0;
		bool flag = false;
		int num2 = 0;
		checked
		{
			while (true)
			{
				flag = true;
				for (num = 0; num < iNode.Count; num++)
				{
					flag = f.apply(num, iNode[num]) && flag;
				}
				if (num2 >= 10000)
				{
					throw new AssertionException("ncc\\optimization\\CFGArray.n", 68, "x < 10000", "");
				}
				if (!flag)
				{
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void ReverseIterate(Function<int, Node, bool> f)
	{
		int num = 0;
		bool flag = false;
		int num2 = 0;
		checked
		{
			while (true)
			{
				flag = true;
				for (num = iNode.Count - 1; num >= 0; num--)
				{
					flag = f.apply(num, iNode[num]) && flag;
				}
				if (num2 >= 10000)
				{
					throw new AssertionException("ncc\\optimization\\CFGArray.n", 80, "x < 10000", "");
				}
				if (!flag)
				{
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public TExpr.Use GetUse(int i)
	{
		TExpr expr = iNode[i].expr;
		return (!(expr is TExpr.Use)) ? null : ((TExpr.Use)expr);
	}

	public int Count()
	{
		return iNode.Count;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		List<Node> list = iNode;
		if (list == null)
		{
			return;
		}
		foreach (Node item in list)
		{
			Node node = item;
			((ISupportRelocation)node).RelocateImpl(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
