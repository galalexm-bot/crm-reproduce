using System;
using EleWise.ELMA.Model.Transformations;

namespace EleWise.ELMA.Model.Views;

public class ListViewItem : EventedList<ViewItem>
{
	protected override System.Exception ListAddingException(ViewItem parent, ViewItem item)
	{
		return new ListViewItemAddingException(parent, item);
	}

	protected override ViewItem GetParent(ViewItem item)
	{
		return item.Parent;
	}

	protected override void SetParent(ViewItem item, ViewItem parent)
	{
		item.Parent = (RootViewItem)parent;
	}

	protected override void RemoveFromParent(ViewItem item)
	{
		if (item.Parent != null)
		{
			item.Parent.Items.Remove(item);
		}
	}
}
