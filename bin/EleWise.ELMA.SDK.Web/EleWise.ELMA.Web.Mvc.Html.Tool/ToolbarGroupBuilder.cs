using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Html.Toolbar;

public class ToolbarGroupBuilder : ActionSubItemBuilderBase<ActionToolbarGroup, ToolbarGroupBuilder, ActionToolbarItem, ToolbarButtonBuilder>
{
	private readonly ToolbarBuilder _builder;

	private readonly ActionToolbarGroup _parentGroup;

	public ToolbarGroupBuilder([NotNull] ToolbarBuilder builder, [NotNull] ActionToolbar parentGroup, [NotNull] HtmlHelper htmlHelper, [NotNull] ActionToolbarGroup actionItemButtonGroup)
		: base(htmlHelper, actionItemButtonGroup, (Func<string, ActionToolbarGroup>)null, "action-item-")
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (parentGroup == null)
		{
			throw new ArgumentNullException("parentGroup");
		}
		_builder = builder;
		_parentGroup = parentGroup;
		if (!_parentGroup.Items.Contains(actionItemButtonGroup))
		{
			_parentGroup.Items.Add(actionItemButtonGroup);
		}
	}

	public ToolbarGroupBuilder([NotNull] ToolbarBuilder builder, [NotNull] ActionToolbarGroup parentGroup, [NotNull] HtmlHelper htmlHelper, string uid = null)
		: base(htmlHelper, new ActionToolbarGroup(uid), (Func<string, ActionToolbarGroup>)null, "action-item-")
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (parentGroup == null)
		{
			throw new ArgumentNullException("parentGroup");
		}
		_builder = builder;
		_parentGroup = parentGroup;
		_parentGroup.Items.Add(actionItem);
	}

	[NotNull]
	public ToolbarGroupBuilder Group(string uid = null)
	{
		if (_parentGroup.Items.FirstOrDefault((IActionItem g) => g is ActionToolbarGroup && !g.Uid.IsNullOrEmpty() && g.Uid == uid) is ActionToolbarGroup actionItemButtonGroup && _parentGroup is ActionToolbar)
		{
			return new ToolbarGroupBuilder(_builder, (ActionToolbar)_parentGroup, HtmlHelper, actionItemButtonGroup);
		}
		return new ToolbarGroupBuilder(_builder, _parentGroup, HtmlHelper, uid);
	}

	[NotNull]
	public ToolbarGroupBuilder Button([NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder)
	{
		if (toolbarButtonBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonBuilder");
		}
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(ActionItem, HtmlHelper);
		toolbarButtonBuilder(obj);
		return this;
	}

	[NotNull]
	public ToolbarGroupBuilder AdditionalActions([NotNull] Action<ToolbarButtonsBuilder> toolbarButtonBuilder)
	{
		_builder.AdditionalButton(toolbarButtonBuilder);
		return this;
	}

	[NotNull]
	public ToolbarGroupBuilder AdditionalActions([NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder)
	{
		_builder.AdditionalButton(toolbarButtonBuilder);
		return this;
	}

	[NotNull]
	public ToolbarGroupBuilder Button(string itemUid, [NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder)
	{
		if (toolbarButtonBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonBuilder");
		}
		ActionToolbarItem actionToolbarItem = ActionItem.Items.OfType<ActionToolbarItem>().FirstOrDefault((ActionToolbarItem g) => !g.Uid.IsNullOrEmpty() && g.Uid == itemUid);
		if (actionToolbarItem == null)
		{
			actionToolbarItem = new ActionToolbarItem(itemUid);
		}
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(ActionItem, HtmlHelper, actionToolbarItem);
		toolbarButtonBuilder(obj);
		return this;
	}

	[NotNull]
	protected override ToolbarButtonBuilder CreateSubItemBuilder(ActionToolbarItem actionSubItem = null)
	{
		if (actionSubItem == null)
		{
			return new ToolbarButtonBuilder(ActionItem, HtmlHelper);
		}
		return new ToolbarButtonBuilder(ActionItem, HtmlHelper, actionSubItem);
	}

	[NotNull]
	public ToolbarGroupBuilder Buttons([NotNull] Action<ToolbarButtonsBuilder> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		ToolbarButtonsBuilder obj = new ToolbarButtonsBuilder(ActionItem, HtmlHelper);
		action(obj);
		return this;
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarButton([NotNull] ActionToolbarItem button)
	{
		if (button == null)
		{
			throw new ArgumentNullException("button");
		}
		return Add(button);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarLink(string text, string toolTip, string imageUrl, string url, ActionItemList subItems, string itemUid = "", string toolTipHeader = null, bool @checked = false)
	{
		return Add(new ActionToolbarItem(itemUid)
		{
			Text = text,
			ToolTip = toolTip,
			ToolTipHeader = toolTipHeader,
			IconUrl = imageUrl,
			Url = url,
			Items = subItems,
			Checked = @checked
		});
	}

	public ToolbarGroupBuilder ToolbarLink(string text, string toolTip, string imageUrl, string url, string itemUid = "")
	{
		return ToolbarLink(text, toolTip, imageUrl, url, null, itemUid);
	}

	public ToolbarGroupBuilder ToolbarLink(string text, string imageUrl, string url, string itemUid = "")
	{
		return ToolbarLink(text, null, imageUrl, url, itemUid);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarClick(string text, string toolTip, string imageUrl, string click, string itemUid = "", bool @checked = false)
	{
		return Add(new ActionToolbarItem(itemUid)
		{
			Text = text,
			ToolTip = toolTip,
			IconUrl = imageUrl,
			Click = click,
			Checked = @checked
		});
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarAction<TController>(Expression<Action<TController>> action, string text, string imageUrl, string itemUid = "") where TController : Controller
	{
		return ToolbarAction(action, text, imageUrl, null, itemUid);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarAction<TController>(Expression<Action<TController>> action, string text, string imageUrl, string toolTip, string itemUid = "", string toolTipHeader = null) where TController : Controller
	{
		return ToolbarLink(text, toolTip, imageUrl, HtmlHelper.Url().Action(action), null, itemUid, toolTipHeader);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string text)
	{
		return ToolbarSubmit(text, "", "", null, "", "", null);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string text, string imageUrl, string itemUid = "", string formId = null)
	{
		return ToolbarSubmit(text, imageUrl, "", formId, "", itemUid, null);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string text, string imageUrl, KeyValuePair<string, string> tooltip, string itemUid = "", string formId = null)
	{
		return ToolbarSubmit(text, imageUrl, "", formId, tooltip.Value, itemUid, tooltip.Key);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string text, string imageUrl, string submitUrl, string formId, string toolTip = "", string itemUid = "", string toolTipHeader = "")
	{
		return Add(new ActionToolbarItem(itemUid)
		{
			Text = text,
			ToolTip = toolTip,
			ToolTipHeader = toolTipHeader,
			IconUrl = imageUrl,
			ActionUrl = submitUrl,
			FormId = formId,
			IsMainAction = true
		});
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string text, string toolTip, string imageUrl, string submitUrl, ActionItemList subItems, string itemUid = "")
	{
		return Add(new ActionToolbarItem(itemUid)
		{
			Text = text,
			ToolTip = toolTip,
			IconUrl = imageUrl,
			ActionUrl = submitUrl,
			Items = subItems
		});
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit<TController>(Expression<Action<TController>> action, string text, string imageUrl, string toolTip, string itemUid = "", string toolTipHeader = "") where TController : Controller
	{
		return ToolbarSubmit(text, imageUrl, HtmlHelper.Url().Action(action), null, toolTip, itemUid, toolTipHeader);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit<TController>(Expression<Action<TController>> action, string text, string imageUrl, string toolTip, ActionItemList subItems, string itemUid = "") where TController : Controller
	{
		return ToolbarSubmit(text, toolTip, imageUrl, HtmlHelper.Url().Action(action), subItems, itemUid);
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit(string itemUid, [NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder)
	{
		if (toolbarButtonBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonBuilder");
		}
		ActionToolbarItem actionToolbarItem = ActionItem.Items.OfType<ActionToolbarItem>().FirstOrDefault((ActionToolbarItem g) => !g.Uid.IsNullOrEmpty() && g.Uid == itemUid);
		if (actionToolbarItem == null)
		{
			actionToolbarItem = new ActionToolbarItem(itemUid);
			actionToolbarItem.ActionUrl = "";
		}
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(ActionItem, HtmlHelper, actionToolbarItem);
		toolbarButtonBuilder(obj);
		return this;
	}

	[NotNull]
	public ToolbarGroupBuilder ToolbarSubmit<TController>(Expression<Action<TController>> action, string itemUid, [NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder) where TController : Controller
	{
		if (toolbarButtonBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonBuilder");
		}
		ActionToolbarItem actionToolbarItem = ActionItem.Items.OfType<ActionToolbarItem>().FirstOrDefault((ActionToolbarItem g) => !g.Uid.IsNullOrEmpty() && g.Uid == itemUid);
		if (actionToolbarItem == null)
		{
			actionToolbarItem = new ActionToolbarItem(itemUid);
			actionToolbarItem.ActionUrl = HtmlHelper.Url().Action(action);
		}
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(ActionItem, HtmlHelper, actionToolbarItem);
		toolbarButtonBuilder(obj);
		return this;
	}
}
