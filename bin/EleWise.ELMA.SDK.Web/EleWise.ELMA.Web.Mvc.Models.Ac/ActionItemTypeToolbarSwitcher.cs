using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

public class ActionItemTypeToolbarSwitcher : ActionItemType
{
	public static readonly Guid Guid = new Guid("{E48623E7-027A-4D5B-B0E9-1BC425F07701}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		if (!actionItem.Visible || !actionItem.Items.Any())
		{
			return;
		}
		bool visible = false;
		ActionItemList actionItemList = new ActionItemList();
		foreach (IActionItem item in actionItem.Items)
		{
			IEnumerable<ActionToolbarItem> enumerable = item.Items.CastOrNull<ActionToolbarItem>();
			if (enumerable != null && enumerable.Any())
			{
				ActionToolbarItem active = enumerable.FirstOrDefault((ActionToolbarItem a) => a.Checked);
				if (active == null)
				{
					active = enumerable.First();
				}
				active.Click = string.Empty;
				active.Url = string.Empty;
				List<IActionItem> list = ((IEnumerable<IActionItem>)enumerable.Where((ActionToolbarItem a) => !a.Checked && a.Uid != active.Uid)).ToList();
				active.Items = new ActionItemList(list);
				actionItemList.Add(active);
				if (active.Visible && list.Count > 0)
				{
					visible = true;
				}
			}
		}
		actionItem.Items.Clear();
		actionItem.Items.AddRange(actionItemList);
		actionItem.Visible = visible;
		builder.Append(PartialExtensions.Partial(htmlHelper, "UI/ActionItems/ActionToolbar/ToolbarItemSwitcher", (object)actionItem));
	}
}
