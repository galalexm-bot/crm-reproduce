using System.Collections.Generic;
using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal abstract class NodeWrapper
{
	private Node node;

	internal NodeWrapper parent;

	public Node Node => node;

	public NodeWrapper Parent => parent;

	public NodeWrapper Root
	{
		get
		{
			if (parent == null)
			{
				return this;
			}
			return parent.Root;
		}
	}

	public abstract string FullText { get; }

	public int Start { get; set; }

	public int Stop { get; set; }

	public NodeWrapper(Node node, NodeWrapper parent)
	{
		this.node = node;
		this.parent = parent;
	}

	public abstract void RecalcRange();

	public abstract bool ReplaceText(int start, int stop, string text);

	public virtual bool Cut(int start, int stop)
	{
		return ReplaceText(start, stop, "");
	}

	public virtual bool PasteUp(List<NodeWrapper> newWrappers, int pastePosition)
	{
		if (Parent != null)
		{
			return Parent.PasteUp(newWrappers, pastePosition);
		}
		return false;
	}

	public virtual NodeWrapper Clone(NodeWrapper wrapperParent, bool isCloneChildren)
	{
		return WrapperManager.Create(Node.Clone(isCloneChildren), wrapperParent);
	}
}
