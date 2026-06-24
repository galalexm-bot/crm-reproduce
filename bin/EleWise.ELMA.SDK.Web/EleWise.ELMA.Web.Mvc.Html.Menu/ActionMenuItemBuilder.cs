using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Web.Mvc.Html.Menu;

public class ActionMenuItemBuilder : ActionItemBuilder<ActionMenuItem, ActionMenuItemBuilder>
{
	protected readonly IActionItem parentItem;

	public ActionMenuItemBuilder(IActionItem parentItem, HtmlHelper htmlHelper, ActionMenuItem actionToolbarItem)
		: base(htmlHelper, actionToolbarItem)
	{
		if (parentItem == null)
		{
			throw new ArgumentNullException("parentItem");
		}
		this.parentItem = parentItem;
		if (!parentItem.Items.Contains(actionToolbarItem))
		{
			parentItem.Items.Add(actionToolbarItem);
		}
	}

	public ActionMenuItemBuilder(IActionItem parentItem, HtmlHelper htmlHelper, string uid = null)
		: base(htmlHelper, new ActionMenuItem(uid ?? htmlHelper.GenerateName("menu-item-")))
	{
		if (parentItem == null)
		{
			throw new ArgumentNullException("parentItem");
		}
		this.parentItem = parentItem;
		parentItem.Items.Add(actionItem);
	}

	public ActionMenuItemBuilder ActionUrl(string value)
	{
		ActionItem.ActionUrl = value;
		return this;
	}

	public ActionMenuItemBuilder Checked(bool value)
	{
		ActionItem.Checked = value;
		return this;
	}

	public ActionMenuItemBuilder FormId(string value)
	{
		ActionItem.FormId = value;
		return this;
	}

	public ActionMenuItemBuilder IconCls(string value)
	{
		ActionItem.IconCls = value;
		return this;
	}

	public ActionMenuItemBuilder IconUrl(string value)
	{
		ActionItem.IconUrl = value;
		return this;
	}

	public ActionMenuItemBuilder Url(string value)
	{
		ActionItem.Url = value;
		return this;
	}

	public ActionMenuItemBuilder Click(string value)
	{
		ActionItem.Click = value;
		return this;
	}

	public ActionMenuItemBuilder Buttons([NotNull] Action<ActionMenuButtonsBuilder> menuButtonsBuilder)
	{
		if (menuButtonsBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonsBuilder");
		}
		if (ActionItem.Items == null)
		{
			ActionItem.Items = new ActionItemList();
		}
		ActionMenuButtonsBuilder obj = new ActionMenuButtonsBuilder(ActionItem, htmlHelper);
		menuButtonsBuilder(obj);
		return this;
	}

	public ActionMenuItemBuilder Text(string value)
	{
		ActionItem.Text = value;
		return this;
	}

	public ActionMenuItemBuilder ToolTip(string value)
	{
		ActionItem.ToolTip = value;
		return this;
	}

	public ActionMenuItemBuilder ToolTipHeader(string value)
	{
		ActionItem.ToolTipHeader = value;
		return this;
	}
}
