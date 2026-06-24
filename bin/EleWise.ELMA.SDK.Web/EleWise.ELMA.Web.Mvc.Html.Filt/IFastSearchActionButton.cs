namespace EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;

public interface IFastSearchActionButton
{
	long Index { get; set; }

	string Content { get; set; }

	HtmlStyle Style { get; set; }

	string OnClick { get; set; }

	string CssClass { get; set; }

	string Icon { get; set; }
}
