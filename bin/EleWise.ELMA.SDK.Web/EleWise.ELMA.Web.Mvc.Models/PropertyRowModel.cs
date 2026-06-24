using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class PropertyRowModel
{
	public string ModelName { get; set; }

	public MvcHtmlString Caption { get; set; }

	public MvcHtmlString Description { get; set; }

	public MvcHtmlString Value { get; set; }

	public MvcHtmlString Validation { get; set; }

	public MvcHtmlString HiddenField { get; set; }

	public WebViewAttributes ViewAttributes { get; set; }

	public bool OnlyValueContainerContent { get; set; }

	public bool NeedHidden { get; set; }
}
