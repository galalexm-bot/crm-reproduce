using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html;

public class ListItem
{
	public string Value { get; set; }

	public string Description { get; set; }

	public string Image { get; set; }

	public string DisplayText { get; set; }

	public MvcHtmlString Content { get; set; }

	public object Item { get; set; }

	public string OnPostDeleteScript { get; set; }
}
