using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Web.Mvc.Html.Menu;

public class ActionMenuBuilder : ActionItemBuilder<ActionMenu, ActionMenuBuilder>
{
	public ActionMenuBuilder(HtmlHelper html, ActionMenu actionMenu)
		: base(html, actionMenu)
	{
	}

	public ActionMenuBuilder Buttons(Action<ActionMenuButtonsBuilder> menuButtonsBuilder)
	{
		if (menuButtonsBuilder == null)
		{
			throw new ArgumentNullException("menuButtonsBuilder");
		}
		if (ActionItem.Items == null)
		{
			ActionItem.Items = new ActionItemList();
		}
		ActionMenuButtonsBuilder obj = new ActionMenuButtonsBuilder(ActionItem, htmlHelper);
		menuButtonsBuilder(obj);
		return this;
	}

	public ActionMenuBuilder MenuItem(string text, string url, Action<ActionMenuItemBuilder> menuItemBuilder = null)
	{
		ActionMenuItem actionMenuItem = new ActionMenuItem(PrepareButtonId(null))
		{
			Text = text,
			Url = url
		};
		if (menuItemBuilder != null)
		{
			ActionMenuItemBuilder obj = new ActionMenuItemBuilder(ActionItem, HtmlHelper, actionMenuItem);
			menuItemBuilder(obj);
		}
		else
		{
			ActionItem.Items.Add(actionMenuItem);
		}
		return Builder;
	}

	public ActionMenuBuilder Separator(Action<ActionMenuItemBuilder> menuItemBuilder = null, string uid = null)
	{
		ActionMenuItem actionMenuItem = (ActionItem.Items.FirstOrDefault((IActionItem i) => i != null && i.Uid == uid) as ActionMenuItem) ?? new ActionMenuSeparator(PrepareButtonId(uid));
		if (menuItemBuilder != null)
		{
			ActionMenuItemBuilder obj = new ActionMenuItemBuilder(ActionItem, HtmlHelper, actionMenuItem);
			menuItemBuilder(obj);
		}
		else
		{
			ActionItem.Items.Add(actionMenuItem);
		}
		return Builder;
	}

	public override string ToHtmlString()
	{
		return ((object)HtmlHelper.ActionItem(ActionItem)).ToString();
	}
}
