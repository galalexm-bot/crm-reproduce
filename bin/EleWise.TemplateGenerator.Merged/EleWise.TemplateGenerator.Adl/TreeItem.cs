using System;
using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class TreeItem
{
	internal TreeItem parent;

	public virtual int Start { get; set; }

	public virtual int Stop { get; set; }

	public TreeItem Parent => parent;

	public TreeItem Root
	{
		get
		{
			if (Parent == null)
			{
				return this;
			}
			return Parent.Root;
		}
	}

	public virtual IEnumerable<TreeItem> GetChildItems()
	{
		return new TreeItem[0];
	}

	public virtual TreeItem CreateCopy(TreeItem parent)
	{
		TreeItem obj = (TreeItem)Activator.CreateInstance(GetType());
		obj.parent = parent;
		obj.Start = Start;
		obj.Stop = Stop;
		return obj;
	}

	public void RecalcRange(int position, int delta)
	{
		if (Start >= position)
		{
			Start += delta;
		}
		if (Stop >= position)
		{
			Stop += delta;
		}
		foreach (TreeItem childItem in GetChildItems())
		{
			childItem.RecalcRange(position, delta);
		}
	}

	public void RefreshParent()
	{
		RefreshParent(this);
	}

	private void RefreshParent(TreeItem item)
	{
		foreach (TreeItem childItem in item.GetChildItems())
		{
			childItem.parent = item;
			RefreshParent(childItem);
		}
	}
}
