using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class CombinedMarkupContentModel
{
	public MvcHtmlString ExpressionMarkup { get; set; }

	public MvcHtmlString СustomMarkup { get; set; }

	public WebViewAttributes Attributes { get; set; }
}
