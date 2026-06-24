using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Menu;

public class MenuModel
{
	public string MenuUid { get; set; }

	public string Name { get; set; }

	public List<MenuItemNode> ActiveItems { get; set; }

	public bool FullScreen { get; set; }

	public List<MenuItemNode> TreeItems { get; set; }

	public bool IsHomeActive { get; set; }

	public MenuModel()
	{
		ActiveItems = new List<MenuItemNode>();
		TreeItems = new List<MenuItemNode>();
	}
}
