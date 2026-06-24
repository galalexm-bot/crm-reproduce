using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class MenuSubItemsModel
{
	public IMenu Menu { get; set; }

	public long ParentItemId { get; set; }
}
