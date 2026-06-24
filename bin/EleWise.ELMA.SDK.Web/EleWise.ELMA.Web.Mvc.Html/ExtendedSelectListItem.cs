using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public class ExtendedSelectListItem : SelectListItem
{
	public string Description { get; set; }

	public object HtmlAttributes { get; set; }
}
