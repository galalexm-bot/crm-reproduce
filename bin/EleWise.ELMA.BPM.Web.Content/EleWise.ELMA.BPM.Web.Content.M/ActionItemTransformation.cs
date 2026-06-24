using System.Collections.Generic;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class ActionItemTransformation : Transformation<IActionItem, ActionItemTransformation, string>
{
	protected override IList<IActionItem> GetSubItems(IActionItem item)
	{
		return item.Items;
	}

	protected override string GetUid(IActionItem item)
	{
		return item.Uid;
	}

	protected override bool IsHide(IActionItem item)
	{
		return !item.Visible;
	}

	protected override void SetHide(IActionItem parentItem, IActionItem item, bool hide = true)
	{
		item.Visible = !hide;
	}

	protected override IActionItem CreateCopy(IActionItem item)
	{
		return CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<IActionItem> r)
		{
			r.Rule().ForPropertyName((IActionItem t) => t.Items).Ignore();
		}).Clone();
	}

	protected override IActionItem Clone(IActionItem item)
	{
		return CloneHelperBuilder.Create(item).Clone();
	}

	internal new IActionItem FindItem(IActionItem viewItem, string itemUid)
	{
		return base.FindItem(viewItem, itemUid);
	}
}
