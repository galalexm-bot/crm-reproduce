using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Security.Menu;

[Component]
public class AdministrationItems : IMenuItemsProvider
{
	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action((UserController c) => c.Index()).Parent("start-settings-menu").Order(1020)
			.Image16("#users.svg")
			.Container("start");
		factory.Action((PermissionManagmentController c) => c.Index()).Name(SR.M("Доступ приложений")).Parent("start-settings-menu")
			.Order(1030)
			.Image16("#permissions.svg")
			.Container("start")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Order(4);
				b.Parent("admin");
				b.Container("left");
			});
		factory.Section(SR.M("Пользователи"), "security-home").Order(2).Image24("#users.svg")
			.Parent("admin")
			.Container("left")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Parent("security-home");
			b.Container("left");
		});
		factory.Action((UserController c) => c.Index()).Order(10).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action((UserGroupController c) => c.Index()).Order(20).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action((ReplacementController c) => c.Index()).Order(30).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action((AbsenceController c) => c.Index()).Order(40).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Section(SR.M("Система"), "system-home").Order(3).Image24("#systems.svg")
			.Parent("admin")
			.Container("left")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Parent("system-home");
			b.Container("left");
		});
		factory.Action((PublicApplicationController c) => c.Index()).Order(30).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
	}
}
