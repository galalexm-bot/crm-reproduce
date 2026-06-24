using System;
using System.Collections.Generic;

namespace EleWise.ELMA.NemerleParser;

public class TreeItem
{
	private TreeItem parent;

	public override int Start { get; set; }

	public override int Stop { get; set; }

	public TreeItem Parent => parent;

	public TreeItem Root => (Parent != null) ? Parent.Root : this;

	public override IEnumerable<TreeItem> GetChildItems()
	{
		return new TreeItem[0];
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		TreeItem treeItem = null;
		treeItem = (TreeItem)Activator.CreateInstance(GetType());
		treeItem.parent = parent;
		treeItem.Start = Start;
		treeItem.Stop = Stop;
		return treeItem;
	}

	public void RecalcRange(int position, int delta)
	{
		checked
		{
			if (Start >= position)
			{
				Start += delta;
			}
			if (Stop >= position)
			{
				Stop += delta;
			}
			IEnumerator<TreeItem> enumerator = GetChildItems().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeItem current = enumerator.Current;
					TreeItem treeItem = current;
					treeItem.RecalcRange(position, delta);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}
	}

	public void RefreshParent()
	{
		RefreshParent(this);
	}

	private void RefreshParent(TreeItem item)
	{
		IEnumerator<TreeItem> enumerator = item.GetChildItems().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeItem current = enumerator.Current;
				TreeItem treeItem = current;
				treeItem.parent = item;
				RefreshParent(treeItem);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}
}
