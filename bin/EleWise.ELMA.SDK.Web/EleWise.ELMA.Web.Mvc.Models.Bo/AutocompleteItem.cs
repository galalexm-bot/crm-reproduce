using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Models.Boxes;

public class AutocompleteItem
{
	private string viewText;

	public string Value { get; set; }

	public string Text { get; set; }

	public string ViewText
	{
		get
		{
			return viewText ?? Text;
		}
		set
		{
			viewText = value;
		}
	}

	public string DropDownText { get; set; }

	public bool IsEndItem { get; set; }

	public string EndItemText { get; set; }

	public bool VirtualItem { get; set; }

	public string ListItemClass { get; set; }

	public RouteValueDictionary Meta { get; set; }

	public string EntityUrl { get; set; }

	public AutocompleteItem()
	{
		Meta = new RouteValueDictionary();
	}
}
