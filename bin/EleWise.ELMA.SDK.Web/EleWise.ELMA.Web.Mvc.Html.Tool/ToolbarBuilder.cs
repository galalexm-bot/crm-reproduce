using System;
using System.Collections.Specialized;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Html.Toolbar;

public class ToolbarBuilder : ActionItemBuilder<ActionToolbar, ToolbarBuilder>
{
	public const string DefaultActionsToolbarUid = "DefaultActionsToolbar";

	public const string BackButtonGroupUid = "DefaultBackButtonToolbarGroup";

	public const string BackButtonUid = "back_btn";

	public const string MoreButtonGroupUid = "MoreButtonToolbarGroup";

	public const string MoreButtonUid = "more_btn";

	public ToolbarBuilder([NotNull] HtmlHelper htmlHelper, [NotNull] ActionToolbar rootActionToolbar)
		: base(htmlHelper, rootActionToolbar)
	{
		NameValueCollection nameValueCollection = HtmlHelper.Url().RemoveUnsecureParamsFromRequest();
		if (nameValueCollection != null)
		{
			HtmlHelper.Url().RedirectWithNewQueryString(nameValueCollection);
		}
		namePrefix = "toolbar-button-";
		More();
	}

	public static ToolbarBuilder GetCurrentToolbarBuilder(string uid = null, Func<ToolbarBuilder> ifNull = null)
	{
		return ContextVars.GetOrAdd("ToolbarBuilder_" + uid.ValueOrDefault("DefaultActionsToolbar"), () => (ifNull == null) ? null : ifNull());
	}

	public ToolbarGroupBuilder AdditionalButton([NotNull] Action<ToolbarButtonsBuilder> toolbarButtonBuilder)
	{
		Contract.ArgumentNotNull(toolbarButtonBuilder, "toolbarButtonBuilder");
		ToolbarButtonsBuilder obj = new ToolbarButtonsBuilder(GetMoreButton(), HtmlHelper);
		toolbarButtonBuilder(obj);
		return Group("MoreButtonToolbarGroup");
	}

	public ToolbarGroupBuilder AdditionalButton([NotNull] Action<ToolbarButtonBuilder> toolbarButtonBuilder)
	{
		Contract.ArgumentNotNull(toolbarButtonBuilder, "toolbarButtonBuilder");
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(GetMoreButton(), HtmlHelper);
		toolbarButtonBuilder(obj);
		return Group("MoreButtonToolbarGroup");
	}

	[NotNull]
	public ToolbarGroupBuilder Back(bool showButton = false, string url = null)
	{
		if (Group("DefaultBackButtonToolbarGroup").ActionItem.Items.FirstOrDefault((IActionItem item) => item.Uid == "back_btn") is ActionToolbarItem actionToolbarItem)
		{
			SetBackItem(actionToolbarItem, url, showButton);
			return Group("DefaultBackButtonToolbarGroup");
		}
		ActionToolbarItem actionToolbarItem2 = new ActionToolbarItem("back_btn")
		{
			Text = SR.T("Назад"),
			ToolTip = SR.T("Вернуться на предыдущую страницу"),
			ToolTipHeader = SR.T("Назад"),
			IconUrl = "#back.svg",
			Click = "history.back(); return false;"
		};
		SetBackItem(actionToolbarItem2, url, showButton);
		return Group("DefaultBackButtonToolbarGroup").Add(actionToolbarItem2);
	}

	[NotNull]
	public ToolbarGroupBuilder More()
	{
		return Group("MoreButtonToolbarGroup").Add(new MoreActionToolbarButton("more_btn"));
	}

	private void SetBackItem([NotNull] ActionToolbarItem actionToolbarItem, string url, bool isVisible)
	{
		if (actionToolbarItem == null)
		{
			throw new ArgumentNullException("actionToolbarItem");
		}
		string text = url ?? HtmlHelper.ReturnUrl();
		if (!string.IsNullOrWhiteSpace(text))
		{
			actionToolbarItem.Click = null;
			actionToolbarItem.Url = text;
		}
		actionToolbarItem.Visible = isVisible;
	}

	[NotNull]
	public ToolbarGroupBuilder Group(string uid = null)
	{
		ActionToolbarGroup actionToolbarGroup = ActionItem.Items.OfType<ActionToolbarGroup>().FirstOrDefault((ActionToolbarGroup g) => !g.Uid.IsNullOrEmpty() && g.Uid == uid);
		if (actionToolbarGroup != null)
		{
			return new ToolbarGroupBuilder(this, ActionItem, HtmlHelper, actionToolbarGroup);
		}
		return new ToolbarGroupBuilder(this, ActionItem, HtmlHelper, uid);
	}

	public ToolbarBuilder Group([NotNull] Action<ToolbarGroupBuilder> buildGroup, string uid = null)
	{
		if (buildGroup == null)
		{
			throw new ArgumentNullException("buildGroup");
		}
		ToolbarGroupBuilder obj = Group(uid);
		buildGroup(obj);
		return this;
	}

	public ToolbarBuilder SwitcherButton([NotNull] string uid, [NotNull] Action<ToolbarButtonBuilder> action)
	{
		ActionToolbarSwitсher actionToolbarSwitсher = ActionItem.Items.OfType<ActionToolbarSwitсher>().FirstOrDefault((ActionToolbarSwitсher g) => !g.Uid.IsNullOrEmpty() && g.Uid == "ActionToolbarSwitcherUid");
		ToolbarGroupBuilder toolbarGroupBuilder = new ToolbarGroupBuilder(this, ActionItem, HtmlHelper, (actionToolbarSwitсher == null) ? new ActionToolbarSwitсher() : actionToolbarSwitсher);
		ActionToolbarItem actionToolbarItem = toolbarGroupBuilder.ActionItem.Items.OfType<ActionToolbarItem>().FirstOrDefault((ActionToolbarItem g) => !g.Uid.IsNullOrEmpty() && g.Uid == uid);
		if (actionToolbarItem == null)
		{
			actionToolbarItem = new ActionToolbarItem(uid);
		}
		actionToolbarItem.Text = uid;
		ToolbarButtonBuilder obj = new ToolbarButtonBuilder(toolbarGroupBuilder.ActionItem, HtmlHelper, actionToolbarItem);
		action(obj);
		return this;
	}

	private ActionToolbarItem GetMoreButton()
	{
		return Group("MoreButtonToolbarGroup").ActionItem.Items.FirstOrDefault((IActionItem item) => item.Uid == "more_btn") as ActionToolbarItem;
	}
}
