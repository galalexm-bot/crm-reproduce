using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Html.Buttons;

public class FilterButtonBuilder : IHtmlString
{
	private ActionFilterButton buttonItem;

	private HtmlHelper htmlHelper;

	public FilterButtonBuilder(HtmlHelper html, ActionFilterButton button)
	{
		htmlHelper = html;
		buttonItem = button;
	}

	public FilterButtonBuilder CloseIconClick(string value)
	{
		buttonItem.CloseIconClick = value;
		return this;
	}

	public FilterButtonBuilder CloseIconHide(bool isHide)
	{
		buttonItem.CloseIconHide = isHide;
		return this;
	}

	public FilterButtonBuilder Text(string text)
	{
		buttonItem.Text = text;
		return this;
	}

	public FilterButtonBuilder Attributes(object attributes)
	{
		buttonItem.Attributes = attributes;
		return this;
	}

	public FilterButtonBuilder ShowTooltip()
	{
		buttonItem.ShowTooltip = true;
		return this;
	}

	public FilterButtonBuilder Click(string click)
	{
		buttonItem.Click = click;
		return this;
	}

	public string ToHtmlString()
	{
		return Build();
	}

	private string Build()
	{
		StringBuilder stringBuilder = new StringBuilder();
		TagBuilder tagBuilder = GetTagBuilder();
		tagBuilder = SetAttributes(tagBuilder, buttonItem);
		tagBuilder.set_InnerHtml(((HtmlString)(object)RenderContent(buttonItem, htmlHelper)).ToHtmlString());
		stringBuilder.Append(tagBuilder.ToString((TagRenderMode)0));
		return stringBuilder.ToString();
	}

	private TagBuilder GetTagBuilder()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		val.AddCssClass("filter-button-container");
		return val;
	}

	private TagBuilder SetAttributes(TagBuilder button, ActionFilterButton buttonModel)
	{
		bool flag = !string.IsNullOrWhiteSpace(buttonModel.Text);
		if (!string.IsNullOrWhiteSpace(buttonModel.Click))
		{
			button.get_Attributes().Add("onclick", buttonModel.Click);
		}
		button.MergeAttributes<string, object>(UIExtensions.ObjectToDictionary(buttonModel.Attributes), true);
		if (buttonModel.ShowTooltip && flag && !button.get_Attributes().Any((KeyValuePair<string, string> a) => (a.Key == "tooltiptext" || a.Key == "tooltipheader") && !string.IsNullOrWhiteSpace(a.Value)))
		{
			button.get_Attributes().AddIfNotContains(new KeyValuePair<string, string>("tooltiptextfunc", "elma.filterButton.getTooltip"));
			button.get_Attributes().AddIfNotContains(new KeyValuePair<string, string>("tooltipoptions", "{\"events\" : { \"toggle\" : \"elma.filterButton.toggleTooltipOnOverflow\" } }"));
		}
		return button;
	}

	private MvcHtmlString RenderContent(ActionFilterButton buttonModel, HtmlHelper htmlHelper)
	{
		string.IsNullOrWhiteSpace(buttonModel.Text);
		string text = ((HtmlString)(object)RenderText(buttonModel)).ToHtmlString();
		string text2 = ((HtmlString)(object)RenderIcon(buttonModel, htmlHelper)).ToHtmlString();
		return MvcHtmlString.Create(text + text2);
	}

	private MvcHtmlString RenderIcon(ActionFilterButton buttonModel, HtmlHelper htmlHelper)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		val.AddCssClass("filter-button-close-icon-container");
		if (buttonModel.CloseIconHide)
		{
			val.AddCssClass("filter-button-close-icon-container-hide");
		}
		val.set_InnerHtml(((HtmlString)(object)htmlHelper.SvgImage("#close_mini.svg", new
		{
			@class = "filter-button-close-icon",
			onclick = "elma.filterButton.closeIcon(event," + buttonModel.CloseIconClick + ");"
		})).ToHtmlString());
		return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}

	private MvcHtmlString RenderText(ActionFilterButton buttonModel)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		if (!string.IsNullOrWhiteSpace(buttonModel.Text))
		{
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("filter-button-text");
			val.set_InnerHtml(buttonModel.Text);
			text = val.ToString((TagRenderMode)0);
		}
		return MvcHtmlString.Create(text);
	}
}
