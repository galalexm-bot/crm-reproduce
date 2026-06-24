using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.Buttons;

public class ButtonsBuilder : ActionSubItemBuilderBase<ActionButton, ButtonsBuilder, ActionButton, ActionButtonBuilder>
{
	public ButtonsBuilder(HtmlHelper htmlHelper, ActionButton parentItem)
		: base(htmlHelper, parentItem, (Func<string, ActionButton>)null, "action-item-")
	{
	}

	public ActionButtonBuilder Button()
	{
		return Button(string.Empty);
	}

	public ActionButtonBuilder Button(string itemUid)
	{
		return Button(itemUid, null);
	}

	public ActionButtonBuilder Button(Action<ActionButtonBuilder> buttonBuilder)
	{
		return Button(string.Empty, buttonBuilder);
	}

	public ActionButtonBuilder Button(string itemUid, Action<ActionButtonBuilder> buttonBuilder)
	{
		ActionButton actionButton;
		if (string.IsNullOrWhiteSpace(itemUid))
		{
			actionButton = new ActionButton();
		}
		else
		{
			actionButton = ActionItem.Items.OfType<ActionButton>().FirstOrDefault((ActionButton g) => !g.Uid.IsNullOrEmpty() && g.Uid == itemUid);
			if (actionButton == null)
			{
				actionButton = new ActionButton(itemUid);
			}
		}
		ActionButtonBuilder actionButtonBuilder = CreateSubItemBuilder(actionButton);
		buttonBuilder?.Invoke(actionButtonBuilder);
		return actionButtonBuilder;
	}

	protected override ActionButtonBuilder CreateSubItemBuilder(ActionButton actionSubItem = null)
	{
		if (actionSubItem == null)
		{
			return new ActionButtonBuilder(HtmlHelper, ActionItem);
		}
		return new ActionButtonBuilder(HtmlHelper, ActionItem, actionSubItem);
	}
}
