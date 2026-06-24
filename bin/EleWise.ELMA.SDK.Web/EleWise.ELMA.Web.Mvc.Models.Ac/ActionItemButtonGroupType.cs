using System;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Types;

internal class ActionItemButtonGroupType : ActionItemType
{
	public static readonly Guid Guid = new Guid("{04D810AD-6247-438F-AE9B-C432C52817CA}");

	public override Guid Uid => Guid;

	public override void Render(IActionItem actionItem, HtmlHelper htmlHelper, StringBuilder builder)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (actionItem is ActionButtonGroup actionButtonGroup && actionButtonGroup.Items.Any((IActionItem a) => a.Visible))
		{
			TagBuilder val = new TagBuilder("div");
			SetAttributes(actionButtonGroup, val);
			StringBuilder stringBuilder = new StringBuilder();
			if (actionButtonGroup.AsBreadcrumbs)
			{
				AppendItemsInBreadcrumbs(actionButtonGroup.Items, htmlHelper, stringBuilder);
			}
			else
			{
				AppendItems(actionButtonGroup.Items, htmlHelper, stringBuilder);
			}
			val.set_InnerHtml(stringBuilder.ToString());
			builder.Append(val.ToString((TagRenderMode)0));
		}
	}

	private void AppendItems(IActionItemList items, HtmlHelper htmlHelper, StringBuilder builder)
	{
		foreach (IActionItem item in items)
		{
			builder.AppendLine(((HtmlString)(object)htmlHelper.ActionItem(item)).ToHtmlString());
		}
	}

	private void AppendItemsInBreadcrumbs(IActionItemList items, HtmlHelper htmlHelper, StringBuilder builder)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		string text = "breadcrumbs-item";
		TagBuilder val = new TagBuilder("div");
		val.AddCssClass(text);
		MvcHtmlString value = htmlHelper.SvgImage("#triangle_down.svg", new
		{
			@class = "t-button-breadcrumbs-icon"
		});
		TagBuilder val2 = new TagBuilder("div");
		val2.AddCssClass(text + " breadcrumbs-item-link");
		int num = items.Count - 1;
		for (int i = 0; i <= num; i++)
		{
			IActionItem actionItem = items[i];
			if (actionItem is ActionButton actionButton && !actionButton.Items.Any())
			{
				if (i == num && string.IsNullOrWhiteSpace(actionButton.Click) && string.IsNullOrWhiteSpace(actionButton.Url) && !actionButton.AsSwitcher && MvcHtmlString.IsNullOrEmpty(actionButton.Template))
				{
					TagBuilder val3 = new TagBuilder("span");
					val3.MergeAttributes<string, object>(actionButton.CustomAttributes, true);
					val3.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(actionButton.Attributes), true);
					val3.AddCssClass(text);
					val3.set_InnerHtml(actionButton.Text);
					builder.Append(val3.ToString((TagRenderMode)0));
					continue;
				}
				actionButton.AsLink = true;
				builder.Append(val2.ToString((TagRenderMode)1));
				builder.Append(((HtmlString)(object)htmlHelper.ActionItem(actionButton)).ToHtmlString());
				if (i != num)
				{
					builder.Append(value);
				}
				builder.Append(val2.ToString((TagRenderMode)2));
			}
			else
			{
				builder.Append(val.ToString((TagRenderMode)1));
				builder.AppendLine(((HtmlString)(object)htmlHelper.ActionItem(actionItem)).ToHtmlString());
				builder.Append(val.ToString((TagRenderMode)2));
			}
		}
	}

	private void SetAttributes(ActionButtonGroup model, TagBuilder group)
	{
		group.get_Attributes().Add("uid", model.Uid);
		group.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(model.Attributes), true);
		group.AddCssClass("t-button-container");
		if (model.IsMerged && model.Items.Count > 1)
		{
			group.AddCssClass("t-button-group-merged");
		}
		if (model.AsBreadcrumbs)
		{
			group.AddCssClass("t-button-breadcrumbs");
		}
	}
}
