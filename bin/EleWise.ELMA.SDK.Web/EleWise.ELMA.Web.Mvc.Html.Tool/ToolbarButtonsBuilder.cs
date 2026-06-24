using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Html.Toolbar;

public class ToolbarButtonsBuilder : ActionSubItemBuilderBase<IActionItem, ToolbarButtonsBuilder, ActionToolbarItem, ToolbarButtonBuilder>
{
	public ToolbarButtonsBuilder([NotNull] IActionItem parentItem, [NotNull] HtmlHelper htmlHelper)
		: base(htmlHelper, parentItem, (Func<string, IActionItem>)null, "action-item-")
	{
	}

	[NotNull]
	public ToolbarButtonBuilder Button(Action<ToolbarButtonBuilder> toolbarButtonBuilder = null)
	{
		ToolbarButtonBuilder toolbarButtonBuilder2 = CreateSubItemBuilder();
		toolbarButtonBuilder?.Invoke(toolbarButtonBuilder2);
		return toolbarButtonBuilder2;
	}

	[NotNull]
	public ToolbarButtonBuilder Button(string itemUid, Action<ToolbarButtonBuilder> toolbarButtonBuilder = null)
	{
		ActionToolbarItem actionToolbarItem = ActionItem.Items.OfType<ActionToolbarItem>().FirstOrDefault((ActionToolbarItem g) => !g.Uid.IsNullOrEmpty() && g.Uid == itemUid);
		if (actionToolbarItem == null)
		{
			actionToolbarItem = new ActionToolbarItem();
		}
		ToolbarButtonBuilder toolbarButtonBuilder2 = CreateSubItemBuilder(actionToolbarItem);
		toolbarButtonBuilder2.Uid(itemUid);
		toolbarButtonBuilder?.Invoke(toolbarButtonBuilder2);
		return toolbarButtonBuilder2;
	}

	[NotNull]
	public ToolbarSeparatorBuilder Separator(Action<ToolbarSeparatorBuilder> toolbarSeparatorBuilder = null)
	{
		ToolbarSeparatorBuilder toolbarSeparatorBuilder2 = new ToolbarSeparatorBuilder(ActionItem, HtmlHelper);
		toolbarSeparatorBuilder?.Invoke(toolbarSeparatorBuilder2);
		return toolbarSeparatorBuilder2;
	}

	[NotNull]
	public ToolbarButtonBuilder Link(string url)
	{
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem(htmlHelper.GenerateName("button_"))
		{
			Url = url
		};
		Add(actionToolbarItem);
		return new ToolbarButtonBuilder(actionItem, htmlHelper, actionToolbarItem);
	}

	[NotNull]
	public ToolbarButtonBuilder Click(string click)
	{
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem(htmlHelper.GenerateName("button_"))
		{
			Click = click
		};
		Add(actionToolbarItem);
		return new ToolbarButtonBuilder(actionItem, htmlHelper, actionToolbarItem);
	}

	protected override ToolbarButtonBuilder CreateSubItemBuilder(ActionToolbarItem actionSubItem = null)
	{
		if (actionSubItem == null)
		{
			return new ToolbarButtonBuilder(ActionItem, HtmlHelper);
		}
		return new ToolbarButtonBuilder(ActionItem, HtmlHelper, actionSubItem);
	}
}
