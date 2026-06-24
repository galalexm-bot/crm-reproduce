using System;

namespace Antlr.Runtime.Tree;

[Serializable]
public class CommonTree : BaseTree
{
	[CLSCompliant(false)]
	public IToken token;

	protected int startIndex = -1;

	protected int stopIndex = -1;

	private CommonTree parent;

	private int childIndex = -1;

	public override int CharPositionInLine
	{
		get
		{
			if (token == null || token.CharPositionInLine == -1)
			{
				if (ChildCount > 0)
				{
					return Children[0].CharPositionInLine;
				}
				return 0;
			}
			return token.CharPositionInLine;
		}
		set
		{
			base.CharPositionInLine = value;
		}
	}

	public override int ChildIndex
	{
		get
		{
			return childIndex;
		}
		set
		{
			childIndex = value;
		}
	}

	public override bool IsNil => token == null;

	public override int Line
	{
		get
		{
			if (token == null || token.Line == 0)
			{
				if (ChildCount > 0)
				{
					return Children[0].Line;
				}
				return 0;
			}
			return token.Line;
		}
		set
		{
			base.Line = value;
		}
	}

	public override ITree Parent
	{
		get
		{
			return parent;
		}
		set
		{
			parent = (CommonTree)value;
		}
	}

	public override string Text
	{
		get
		{
			if (token == null)
			{
				return null;
			}
			return token.Text;
		}
		set
		{
		}
	}

	public virtual IToken Token
	{
		get
		{
			return token;
		}
		set
		{
			token = value;
		}
	}

	public override int TokenStartIndex
	{
		get
		{
			if (startIndex == -1 && token != null)
			{
				return token.TokenIndex;
			}
			return startIndex;
		}
		set
		{
			startIndex = value;
		}
	}

	public override int TokenStopIndex
	{
		get
		{
			if (stopIndex == -1 && token != null)
			{
				return token.TokenIndex;
			}
			return stopIndex;
		}
		set
		{
			stopIndex = value;
		}
	}

	public override int Type
	{
		get
		{
			if (token == null)
			{
				return 0;
			}
			return token.Type;
		}
		set
		{
		}
	}

	public CommonTree()
	{
	}

	public CommonTree(CommonTree node)
		: base(node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		token = node.token;
		startIndex = node.startIndex;
		stopIndex = node.stopIndex;
	}

	public CommonTree(IToken t)
	{
		token = t;
	}

	public override ITree DupNode()
	{
		return new CommonTree(this);
	}

	public virtual void SetUnknownTokenBoundaries()
	{
		if (Children == null)
		{
			if (startIndex < 0 || stopIndex < 0)
			{
				startIndex = (stopIndex = token.TokenIndex);
			}
			return;
		}
		for (int i = 0; i < Children.Count; i++)
		{
			((CommonTree)Children[i]).SetUnknownTokenBoundaries();
		}
		if ((startIndex < 0 || stopIndex < 0) && Children.Count > 0)
		{
			CommonTree commonTree = (CommonTree)Children[0];
			CommonTree commonTree2 = (CommonTree)Children[Children.Count - 1];
			startIndex = commonTree.TokenStartIndex;
			stopIndex = commonTree2.TokenStopIndex;
		}
	}

	public override string ToString()
	{
		if (IsNil)
		{
			return "nil";
		}
		if (Type == 0)
		{
			return "<errornode>";
		}
		if (token == null)
		{
			return string.Empty;
		}
		return token.Text;
	}
}
