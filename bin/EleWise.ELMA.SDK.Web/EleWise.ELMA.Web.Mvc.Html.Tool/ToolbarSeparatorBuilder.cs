using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Html.Toolbar;

public class ToolbarSeparatorBuilder : ActionItemBuilder<ActionToolbarSeparator, ToolbarSeparatorBuilder>
{
	protected readonly IActionItem parentItem;

	public ToolbarSeparatorBuilder(IActionItem parentItem, HtmlHelper htmlHelper, ActionToolbarSeparator actionToolbarItem)
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

	public ToolbarSeparatorBuilder(IActionItem parentItem, HtmlHelper htmlHelper, string uid = null)
		: base(htmlHelper, new ActionToolbarSeparator(uid))
	{
		if (parentItem == null)
		{
			throw new ArgumentNullException("parentItem");
		}
		this.parentItem = parentItem;
		parentItem.Items.Add(actionItem);
	}
}
