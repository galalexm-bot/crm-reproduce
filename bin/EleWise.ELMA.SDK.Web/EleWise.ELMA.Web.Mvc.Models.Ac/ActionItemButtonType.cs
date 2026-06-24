using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Web.Mvc.Enums;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

internal class ActionItemButtonType : ActionItemType
{
	public static readonly Guid Guid = new Guid("{F4A53F6E-C600-4AFB-96C3-020F3BFF5112}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		if (actionItem is ActionButton actionButton && actionButton.Visible)
		{
			RenderItems(builder, actionButton, htmlHelper);
			TagBuilder tagBuilder = GetTagBuilder(actionButton);
			tagBuilder = SetAttributes(tagBuilder, actionButton);
			tagBuilder.set_InnerHtml(((HtmlString)(object)RenderContent(actionButton, htmlHelper)).ToHtmlString());
			builder.Append(tagBuilder.ToString((TagRenderMode)0));
		}
	}

	private void RenderItems(StringBuilder builder, ActionButton buttonModel, HtmlHelper htmlHelper)
	{
		if (!buttonModel.Items.Any((IActionItem a) => a.Visible))
		{
			return;
		}
		IEnumerable<ActionButton> enumerable = buttonModel.Items.CastOrNull<ActionButton>();
		if (enumerable == null)
		{
			return;
		}
		string click = buttonModel.Click;
		IEnumerable<ActionMenuItem> enumerable2 = MapButtonsToMenuItems(enumerable);
		string text = "buttonMenu" + buttonModel.Uid;
		if (buttonModel.AsSwitcher)
		{
			ActionMenuItem actionMenuItem = enumerable2.FirstOrDefault((ActionMenuItem a) => a.Checked);
			if (actionMenuItem == null)
			{
				actionMenuItem = enumerable2.First();
			}
			ChangeButton(actionMenuItem, buttonModel);
			foreach (ActionMenuItem item in enumerable2)
			{
				if (!string.IsNullOrWhiteSpace(item.Click + click))
				{
					item.Click = $"elma.ButtonSwitcher.click(sender, selectedMenuItem, menu, \"{MvcHtmlString.Create(item.Click ?? click)}\")";
				}
			}
		}
		buttonModel.CustomAttributes.Add("menuUid", text);
		string key = "onmouseenter";
		string key2 = "onmouseup";
		if (!buttonModel.CustomAttributes.ContainsKey(key) || !buttonModel.CustomAttributes.ContainsKey(key2))
		{
			if (buttonModel.AsSwitcher)
			{
				buttonModel.CustomAttributes.Add(key, $"elma.ButtonSwitcher.show(this)");
			}
			else
			{
				buttonModel.CustomAttributes.Add(key, htmlHelper.ActionMenuShow(new ActionMenuShowParams
				{
					MenuGuid = text
				}));
			}
		}
		ActionMenu actionMenu = new ActionMenu(text);
		actionMenu.Items.AddRange(enumerable2);
		builder.Append(htmlHelper.ActionItem(actionMenu));
	}

	private IEnumerable<ActionMenuItem> MapButtonsToMenuItems(IEnumerable<ActionButton> list)
	{
		List<ActionMenuItem> list2 = new List<ActionMenuItem>();
		foreach (ActionButton item in list)
		{
			list2.Add(new ActionMenuItem
			{
				Text = item.Text,
				IconUrl = item.IconUrl,
				Checked = item.IsChecked,
				CustomAttributes = item.CustomAttributes,
				Attributes = item.Attributes,
				Url = item.Url,
				Click = item.Click,
				Visible = item.Visible,
				Uid = item.Uid
			});
		}
		return list2;
	}

	private void ChangeButton(ActionMenuItem activeButton, ActionButton buttonModel)
	{
		buttonModel.Text = activeButton.Text;
		buttonModel.IconUrl = activeButton.IconUrl;
		buttonModel.CustomAttributes.Remove("onclick");
		buttonModel.CustomAttributes.Remove("href");
		buttonModel.Click = string.Empty;
		buttonModel.Url = string.Empty;
		buttonModel.CustomAttributes.Add("selectedMenuItemId", activeButton.Uid);
	}

	private TagBuilder GetTagBuilder(ActionButton buttonModel)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		TagBuilder val;
		if (buttonModel.Template != null)
		{
			val = new TagBuilder("div");
		}
		else if (!string.IsNullOrWhiteSpace(buttonModel.Url))
		{
			val = new TagBuilder("a");
			val.get_Attributes().Add("href", buttonModel.Url);
		}
		else
		{
			val = new TagBuilder("button");
		}
		return val;
	}

	protected virtual MvcHtmlString RenderContent(ActionButton buttonModel, HtmlHelper htmlHelper)
	{
		if (buttonModel.Template != null)
		{
			return buttonModel.Template;
		}
		bool flag = !string.IsNullOrWhiteSpace(buttonModel.IconUrl);
		bool flag2 = !string.IsNullOrWhiteSpace(buttonModel.Text);
		if (flag && !flag2)
		{
			return RenderIcon(buttonModel, htmlHelper);
		}
		string text = ((HtmlString)(object)RenderText(buttonModel)).ToHtmlString();
		string text2 = ((buttonModel.Items.Count > 0) ? ((HtmlString)(object)htmlHelper.RotatableIcon("#triangle_down.svg", isRotated: false, 0, new
		{
			@class = "t-arrow-down-icon"
		})).ToHtmlString() : "");
		if (!flag)
		{
			return MvcHtmlString.Create(text + text2);
		}
		return MvcHtmlString.Create(((HtmlString)(object)RenderIcon(buttonModel, htmlHelper)).ToHtmlString() + text + text2);
	}

	protected virtual MvcHtmlString RenderIcon(ActionButton buttonModel, HtmlHelper htmlHelper)
	{
		if (buttonModel.IconAttributes.ContainsKey("class"))
		{
			buttonModel.IconAttributes["class"] = string.Concat(buttonModel.IconAttributes["class"], " t-button-image");
		}
		else
		{
			buttonModel.IconAttributes.Add("class", "t-button-image");
		}
		return htmlHelper.SvgImage(buttonModel.IconUrl, buttonModel.IconAttributes);
	}

	protected virtual MvcHtmlString RenderText(ActionButton buttonModel)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		if (!string.IsNullOrWhiteSpace(buttonModel.Text))
		{
			TagBuilder val = new TagBuilder("span");
			val.AddCssClass("t-button-text");
			val.set_InnerHtml(buttonModel.Text);
			text = val.ToString((TagRenderMode)0);
		}
		return MvcHtmlString.Create(text);
	}

	protected TagBuilder SetAttributes(TagBuilder button, ActionButton buttonModel)
	{
		if (!string.IsNullOrWhiteSpace(buttonModel.Click))
		{
			button.get_Attributes().Add("onclick", buttonModel.Click);
		}
		button.get_Attributes().AddIfNotContains(new KeyValuePair<string, string>("type", "button"));
		button.MergeAttributes<string, object>(buttonModel.CustomAttributes, true);
		button.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(buttonModel.Attributes), true);
		button.AddCssClass("t-button");
		bool flag = !string.IsNullOrWhiteSpace(buttonModel.IconUrl);
		bool flag2 = !string.IsNullOrWhiteSpace(buttonModel.Text);
		UISize uISize = UISize.Medium;
		button.AddCssClass(((!buttonModel.Size.HasValue) ? UISize.Medium : buttonModel.Size.Value).ToString().ToLower());
		button.AddCssClass(ButtonStyleHelper.GetCssClass(buttonModel.Style));
		if (buttonModel.IsChecked)
		{
			button.AddCssClass("t-state-selected");
		}
		if (flag && flag2)
		{
			button.AddCssClass("t-button-icontext");
		}
		else if (flag)
		{
			button.AddCssClass("t-button-icon");
		}
		if (flag2 && !button.get_Attributes().Any((KeyValuePair<string, string> a) => (a.Key == "tooltiptext" || a.Key == "tooltipheader") && !string.IsNullOrWhiteSpace(a.Value)))
		{
			button.get_Attributes().AddIfNotContains(new KeyValuePair<string, string>("tooltiptextfunc", "elma.Button.getTooltip"));
			button.get_Attributes().AddIfNotContains(new KeyValuePair<string, string>("tooltipoptions", "{\"events\" : { \"toggle\" : \"elma.Button.toggleTooltipOnOverflow\" } }"));
		}
		if (buttonModel.AsLink)
		{
			button.AddCssClass("t-link");
		}
		if (buttonModel.Disabled)
		{
			button.AddCssClass("t-state-disabled");
			button.get_Attributes().Add("disabled", "disabled");
		}
		if (buttonModel.IsCircle)
		{
			button.AddCssClass("circle");
		}
		if (buttonModel.NoFill || buttonModel.NoBorder)
		{
			button.AddCssClass("t-button-nofill");
		}
		if (buttonModel.NoBorder || buttonModel.AsLink)
		{
			button.AddCssClass("t-button-noborder");
		}
		if (buttonModel.Template != null)
		{
			button.AddCssClass("t-button-has-template");
		}
		if (buttonModel.AsSwitcher)
		{
			button.AddCssClass("t-button-switcher");
		}
		if (buttonModel.ReadOnly)
		{
			button.AddCssClass("t-button-readonly");
		}
		if (buttonModel.ReadOnlyHover)
		{
			button.AddCssClass("t-button-readonly-hover");
		}
		button.AppendAttributeValue("uid", buttonModel.Uid);
		return button;
	}
}
