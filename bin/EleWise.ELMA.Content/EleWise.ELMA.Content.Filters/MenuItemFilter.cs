using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Content.Filters;

public class MenuItemFilter : Filter
{
	public IMenu Menu { get; set; }

	public IMenuItem ParentItem { get; set; }
}
