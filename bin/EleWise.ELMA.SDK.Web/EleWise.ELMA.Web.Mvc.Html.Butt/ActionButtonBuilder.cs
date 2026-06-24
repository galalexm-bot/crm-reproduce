using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Enums;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.Buttons;

public class ActionButtonBuilder : ActionItemBuilder<ActionButton, ActionButtonBuilder>
{
	protected readonly IActionItem ParentItem;

	public ActionButtonBuilder(HtmlHelper htmlHelper, ActionButton actionItem)
		: base(htmlHelper, actionItem)
	{
	}

	public ActionButtonBuilder(HtmlHelper htmlHelper, ActionButton parentItem, ActionButton actionItem)
		: base(htmlHelper, actionItem)
	{
		ParentItem = parentItem;
		if (!parentItem.Items.Contains(actionItem))
		{
			parentItem.Items.Add(actionItem);
		}
	}

	public new ActionButtonBuilder Uid(string value)
	{
		ActionItem.Uid = value;
		return Builder;
	}

	public ActionButtonBuilder Text(string text)
	{
		ActionItem.Text = text;
		return Builder;
	}

	public ActionButtonBuilder IconAttributes(object iconAttributes)
	{
		ActionItem.IconAttributes = UIExtensions.ObjectToDictionary(iconAttributes);
		return Builder;
	}

	public ActionButtonBuilder IconUrl(string icon)
	{
		ActionItem.IconUrl = icon;
		return Builder;
	}

	public ActionButtonBuilder Disabled()
	{
		ActionItem.Disabled = true;
		return Builder;
	}

	public ActionButtonBuilder Disabled(bool value)
	{
		ActionItem.Disabled = value;
		return Builder;
	}

	public ActionButtonBuilder Style(ButtonStyle style)
	{
		ActionItem.Style = style;
		return Builder;
	}

	public ActionButtonBuilder Size(UISize size)
	{
		ActionItem.Size = size;
		return Builder;
	}

	public ActionButtonBuilder Template(MvcHtmlString template)
	{
		ActionItem.Template = template;
		return Builder;
	}

	public ActionButtonBuilder Url(string url)
	{
		ActionItem.Url = url;
		return Builder;
	}

	public ActionButtonBuilder Click(string click)
	{
		ActionItem.Click = click;
		return Builder;
	}

	public ActionButtonBuilder AsLink()
	{
		ActionItem.AsLink = true;
		return Builder;
	}

	public ActionButtonBuilder Circle()
	{
		ActionItem.IsCircle = true;
		return Builder;
	}

	public ActionButtonBuilder Checked(bool value = true)
	{
		ActionItem.IsChecked = value;
		return Builder;
	}

	public ActionButtonBuilder NoFill()
	{
		ActionItem.NoFill = true;
		return Builder;
	}

	public ActionButtonBuilder NoBorder()
	{
		ActionItem.NoBorder = true;
		return Builder;
	}

	public ActionButtonBuilder AsSwitcher()
	{
		ActionItem.AsSwitcher = true;
		return Builder;
	}

	public ActionButtonBuilder ReadOnly()
	{
		ActionItem.ReadOnly = true;
		return Builder;
	}

	public ActionButtonBuilder ReadOnlyHover()
	{
		ActionItem.ReadOnlyHover = true;
		return Builder;
	}

	public ActionButtonBuilder Buttons(Action<ButtonsBuilder> builder)
	{
		ButtonsBuilder obj = new ButtonsBuilder(htmlHelper, ActionItem);
		builder(obj);
		return this;
	}

	public override string ToHtmlString()
	{
		return ((HtmlString)(object)htmlHelper.ActionItem(ActionItem)).ToHtmlString();
	}
}
