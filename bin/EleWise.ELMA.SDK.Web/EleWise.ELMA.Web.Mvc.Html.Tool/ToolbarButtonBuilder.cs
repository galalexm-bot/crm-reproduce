using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Html.Toolbar;

public class ToolbarButtonBuilder : ActionItemBuilder<ActionToolbarItem, ToolbarButtonBuilder>
{
	protected IActionItem ParentItem;

	public ToolbarButtonBuilder(IActionItem parentItem, HtmlHelper htmlHelper, ActionToolbarItem actionToolbarItem)
		: base(htmlHelper, actionToolbarItem)
	{
		if (parentItem == null)
		{
			throw new ArgumentNullException("parentItem");
		}
		ParentItem = parentItem;
		if (!parentItem.Items.Contains(actionToolbarItem))
		{
			parentItem.Items.Add(actionToolbarItem);
		}
	}

	public ToolbarButtonBuilder(IActionItem parentItem, HtmlHelper htmlHelper, string uid = null)
		: base(htmlHelper, new ActionToolbarItem(uid))
	{
		if (parentItem == null)
		{
			throw new ArgumentNullException("parentItem");
		}
		ParentItem = parentItem;
		parentItem.Items.Add(actionItem);
	}

	[NotNull]
	public ToolbarButtonBuilder Checked(bool value)
	{
		ActionItem.Checked = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder FormSubmit(string formId = "", string actionUrl = null)
	{
		ActionItem.FormId = formId;
		ActionItem.ActionUrl = actionUrl;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder IconCls(string value)
	{
		ActionItem.IconCls = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder IconUrl(string value)
	{
		ActionItem.IconUrl = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Url(string value)
	{
		ActionItem.Url = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Click(string value)
	{
		ActionItem.Click = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Buttons([NotNull] Action<ToolbarButtonsBuilder> toolbarButtonsBuilder)
	{
		if (toolbarButtonsBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonsBuilder");
		}
		ToolbarButtonsBuilder obj = new ToolbarButtonsBuilder(ActionItem, htmlHelper);
		toolbarButtonsBuilder(obj);
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Text(string value)
	{
		ActionItem.Text = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder ToolTip(string value)
	{
		ActionItem.ToolTip = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder ToolTipHeader(string value)
	{
		ActionItem.ToolTipHeader = value;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder MainAction(bool isMainAction = true)
	{
		ActionItem.IsMainAction = isMainAction;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder AbortAction(bool isAbortAction = true)
	{
		ActionItem.IsAbortAction = isAbortAction;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder ApproveAction(bool isApproveAction = true)
	{
		ActionItem.IsApproveAction = isApproveAction;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Group(string groupId, int itemIndex = -1)
	{
		if (string.IsNullOrWhiteSpace(groupId))
		{
			throw new ArgumentNullException("groupId");
		}
		ToolbarGroupBuilder toolbarGroupBuilder = HtmlHelper.Toolbar().Group(groupId);
		ParentItem.Items.Remove(ActionItem);
		if (itemIndex > -1 && toolbarGroupBuilder.ActionItem.Items.Count >= itemIndex)
		{
			toolbarGroupBuilder.ActionItem.Items.Insert(itemIndex, ActionItem);
		}
		else
		{
			toolbarGroupBuilder.Add(ActionItem);
		}
		ParentItem = toolbarGroupBuilder.ActionItem;
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder Index(int itemIndex)
	{
		if (itemIndex < 0 || itemIndex > ParentItem.Items.Count)
		{
			return this;
		}
		ParentItem.Items.Remove(ActionItem);
		ParentItem.Items.Insert(itemIndex, ActionItem);
		return this;
	}

	[NotNull]
	public ToolbarButtonBuilder VisibleIf<TManager>([NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		ActionItem.PosibleHidden = BuildPosibleHidden();
		ActionDispatcherService serviceNotNull = Locator.GetServiceNotNull<ActionDispatcherService>();
		ActionItem.Visible &= serviceNotNull.CheckAction(expression);
		return this;
	}
}
