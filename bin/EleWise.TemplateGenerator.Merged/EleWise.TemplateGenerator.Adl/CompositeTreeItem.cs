using System.Collections.Generic;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class CompositeTreeItem : TreeItem
{
	public override int Start
	{
		get
		{
			if (Items.Count <= 0)
			{
				return 0;
			}
			return Items[0].Start;
		}
		set
		{
		}
	}

	public override int Stop
	{
		get
		{
			if (Items.Count <= 0)
			{
				return 0;
			}
			return Items[Items.Count - 1].Stop;
		}
		set
		{
		}
	}

	public List<TreeItem> Items { get; set; }

	public CompositeTreeItem()
	{
		Items = new List<TreeItem>();
	}

	public void AddItem(TreeItem i)
	{
		Items.Add(i);
		i.parent = this;
	}

	public void AddItems(IEnumerable<TreeItem> items)
	{
		foreach (TreeItem item in items)
		{
			Items.Add(item);
			item.parent = this;
		}
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		CompositeTreeItem compositeTreeItem = (CompositeTreeItem)base.CreateCopy(parent);
		foreach (TreeItem item in Items)
		{
			compositeTreeItem.Items.Add(item.CreateCopy(compositeTreeItem));
		}
		return compositeTreeItem;
	}

	public override IEnumerable<TreeItem> GetChildItems()
	{
		foreach (TreeItem childItem in base.GetChildItems())
		{
			yield return childItem;
		}
		foreach (TreeItem item in Items)
		{
			yield return item;
		}
	}
}
