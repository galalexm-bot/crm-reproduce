using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Common.Menu;

[Component]
public class BaseItems : IMenuItemsProvider
{
	public const string CatalogSettings = "catalog-admin-settings";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Section(SR.M("Создать"), "create").Order(0);
		factory.Section(SR.M("Сервис"), "elmaservice").Order(1000);
		factory.Action((HomeController c) => c.Help()).Parent("elmaservice").Name(SR.M("Справка"))
			.Order(50);
		factory.Separator().Parent("elmaservice").Order(999);
		factory.Action("EleWise.ELMA.BPM.Web.Common-Module-About").Parent("elmaservice").Name(SR.M("О программе"))
			.Order(1000);
		factory.Section(SR.M("Администрирование"), "admin").Order(90);
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Action((CatalogsController c) => c.Index()).Order(50);
		factory.Section(SR.M("Администрирование"), "admin").Order(100).OnTop(onTop: true)
			.Stretch(stretch: true)
			.Image24("#admin.svg");
		factory.Action((HomeController c) => c.CommonHome()).Order(50).Parent("admin")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.Action((SettingsController c) => c.CatalogSettingsPage()).Code("catalog-admin-settings").Order(50)
			.Parent("commonhome");
	}
}
