namespace EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;

public class FastSearchActionButton : IFastSearchActionButton
{
	public long Index { get; set; }

	public string Content { get; set; }

	public HtmlStyle Style { get; set; }

	public string OnClick { get; set; }

	public string CssClass { get; set; }

	public string Icon { get; set; }
}
