using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

public class ContextMenu
{
	public string Id { get; set; }

	public List<IActionItem> Items { get; set; }
}
