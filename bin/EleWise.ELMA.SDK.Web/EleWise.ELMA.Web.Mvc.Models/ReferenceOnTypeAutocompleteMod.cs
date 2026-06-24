namespace EleWise.ELMA.Web.Mvc.Models;

public class ReferenceOnTypeAutocompleteModel
{
	public string EntityUrl { get; set; }

	public string Value { get; set; }

	public string Text { get; set; }

	public string ViewText { get; set; }

	public bool VirtualItem { get; set; }

	public string Parent { get; set; }

	public long Level { get; set; }
}
