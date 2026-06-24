using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Designer.Web.Menu;

[Component]
internal sealed class DesignerMenuItems : IMenuItemsProvider
{
	public const string Designer = "DesignerModule";

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsNames => null;

	public void Items(MenuItemFactory factory)
	{
		if (SR.GetSetting("Designer.Enabled", defaultValue: false))
		{
			factory.Action(new ActionRoute("Index", "Home", new
			{
				area = "EleWise.ELMA.Designer.Web"
			})).Name(SR.M("Дизайнер")).OpenInNewTab()
				.Code("DesignerModule")
				.Image32("#designer.svg")
				.Order(120)
				.Container("left")
				.OnTop(onTop: true)
				.Stretch(stretch: true);
		}
	}
}
