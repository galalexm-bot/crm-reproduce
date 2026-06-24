using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;

public interface IFastSearchButtonModel
{
	string Text { get; set; }

	bool Enabled { get; set; }

	HtmlAttributes HtmlAttributes { get; }

	string ToHtmlString(HtmlHelper html);
}
