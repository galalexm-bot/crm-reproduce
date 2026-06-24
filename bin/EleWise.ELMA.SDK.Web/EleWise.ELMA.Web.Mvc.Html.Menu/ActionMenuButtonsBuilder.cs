using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Web.Mvc.Html.Menu;

public class ActionMenuButtonsBuilder : ActionSubItemBuilderBase<IActionItem, ActionMenuButtonsBuilder, ActionMenuItem, ActionMenuItemBuilder>
{
	public ActionMenuButtonsBuilder([NotNull] IActionItem parentItem, [NotNull] HtmlHelper htmlHelper)
		: base(htmlHelper, parentItem, (Func<string, IActionItem>)null, "action-item-")
	{
		namePrefix = "menu-item-";
	}

	public ActionMenuItemBuilder MenuItem(string text)
	{
		ActionMenuItem actionSubItem = new ActionMenuItem(PrepareButtonId(null))
		{
			Text = text
		};
		return CreateSubItemBuilder(actionSubItem);
	}

	public ActionMenuItemBuilder MenuItem(string uid, string text)
	{
		ActionMenuItem actionSubItem = new ActionMenuItem(PrepareButtonId(uid))
		{
			Text = text
		};
		return CreateSubItemBuilder(actionSubItem);
	}

	public ActionMenuButtonsBuilder Separator(Action<ActionMenuItemBuilder> menuItemBuilder = null, string uid = null)
	{
		ActionMenuItem actionMenuItem = (ActionItem.Items.FirstOrDefault((IActionItem i) => i != null && i.Uid == uid) as ActionMenuItem) ?? new ActionMenuSeparator(PrepareButtonId(uid));
		if (menuItemBuilder != null)
		{
			ActionMenuItemBuilder obj = CreateSubItemBuilder(actionMenuItem);
			menuItemBuilder(obj);
		}
		else
		{
			ActionItem.Items.Add(actionMenuItem);
		}
		return Builder;
	}

	protected override ActionMenuItemBuilder CreateSubItemBuilder(ActionMenuItem actionSubItem = null)
	{
		if (actionSubItem == null)
		{
			return new ActionMenuItemBuilder(ActionItem, HtmlHelper);
		}
		return new ActionMenuItemBuilder(ActionItem, HtmlHelper, actionSubItem);
	}
}
