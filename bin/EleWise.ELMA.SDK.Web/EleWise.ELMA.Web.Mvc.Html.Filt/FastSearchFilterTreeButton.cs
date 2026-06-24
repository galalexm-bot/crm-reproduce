using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;

public class FastSearchFilterTreeButton : IFastSearchActionButton
{
	public const string FilterTreePrefix = "FilterTreePopover_";

	private string cssClass;

	public string Content { get; set; }

	public string CssClass
	{
		get
		{
			if (!string.IsNullOrEmpty(Content))
			{
				return cssClass + " grid-filter-value";
			}
			return cssClass + " grid-filter";
		}
		set
		{
			cssClass = value;
		}
	}

	public long Index { get; set; }

	public string OnClick { get; set; }

	public HtmlStyle Style { get; set; }

	private string icon { get; set; }

	public string Icon
	{
		get
		{
			if (!string.IsNullOrEmpty(icon))
			{
				return icon;
			}
			if (!string.IsNullOrEmpty(Content))
			{
				return "";
			}
			return "#filter.svg";
		}
		set
		{
			icon = value;
		}
	}

	public FastSearchFilterTreeButton()
	{
	}

	public FastSearchFilterTreeButton(string filterName, string returnUrl)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(filterName))
		{
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("grid-filter-name");
			val.set_InnerHtml(filterName);
			TagBuilder val2 = new TagBuilder("a");
			val2.AddCssClass("grid-filter-remove");
			val2.get_Attributes()["href"] = returnUrl;
			Content = "<div>" + val.ToString((TagRenderMode)0) + val2.ToString((TagRenderMode)0) + "</div>";
		}
	}

	public static string GetFilterTreeId(string code)
	{
		if (string.IsNullOrWhiteSpace(code))
		{
			return string.Empty;
		}
		return "FilterTreePopover_" + UIExtensions.PrepareId(code);
	}
}
