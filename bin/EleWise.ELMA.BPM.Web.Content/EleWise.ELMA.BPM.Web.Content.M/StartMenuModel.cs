using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class StartMenuModel
{
	public IMenu CreateMenu { get; set; }

	public IMenu StartMenu { get; set; }

	public StartMenuModel(IMenu createMenu, IMenu startMenu)
	{
		CreateMenu = createMenu;
		StartMenu = startMenu;
	}
}
