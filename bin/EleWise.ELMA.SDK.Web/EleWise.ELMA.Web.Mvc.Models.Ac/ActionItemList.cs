using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionItemList : Collection<IActionItem>, IActionItemList, IList<IActionItem>, ICollection<IActionItem>, IEnumerable<IActionItem>, IEnumerable
{
	protected object attributes;

	public virtual object Attributes
	{
		get
		{
			return attributes;
		}
		set
		{
			attributes = value;
		}
	}

	public ActionItemList()
	{
	}

	public ActionItemList(IList<IActionItem> list)
		: base(list)
	{
	}

	protected override void InsertItem(int index, IActionItem item)
	{
		if (!Contains(item))
		{
			base.InsertItem(index, item);
		}
	}
}
