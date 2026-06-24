using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Content.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Menu;

[Component]
public class PortalMenuItems : IMenuItemsProvider
{
	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action((SecurityHomeController c) => c.Index()).Name(SR.M("Администрирование")).Code("start-settings-menu")
			.Order(1000)
			.Color("yellow")
			.Image16("#setting.svg")
			.Container("start");
		factory.Action((SecurityHomeController c) => c.Index()).Parent("start-settings-menu").Order(1010)
			.Image16("#setting.svg")
			.Container("start")
			.Name(SR.M("Панель администратора"));
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
			b.Parent("admin");
		});
		factory.Action((PortalController c) => c.Index()).Code("portal").Order(70);
		factory.Action((PageController c) => c.Index()).Order(20).Parent("portal");
		factory.Action((PortletsController c) => c.Index()).Order(30).Parent("portal");
		factory.Action((ThemeSettingsController c) => c.Index()).Order(35).Parent("portal");
		factory.Action(new ActionRoute("Index", "HomePageManagment", new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		})).Order(40).Parent("portal");
		factory.Action((ContentActionController c) => c.Index()).Order(50).Parent("portal");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Action(new ActionRoute("Home", "Page", new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		})).Order(0).Name(SR.M("Главная"))
			.Code("home");
		factory.Action((SecurityHomeController c) => c.Index()).Parent("admin").Code("admin-home")
			.Order(1)
			.Name(SR.M("Домашняя страница"));
		factory.Action((PortalController c) => c.Index()).Code("portal").Order(70)
			.Parent("admin");
		factory.Action((WorkPlaceController c) => c.Index()).Order(5).Parent("portal")
			.Description(SR.M("Адаптированные для пользователей интерфейсы. Данный раздел позволяет создать для определенных пользователей специальный интерфейс системы."));
		factory.Action((PageController c) => c.Index()).Parent("portal").Order(10)
			.Description(SR.M("«Пользовательские» страницы. В данном разделе вы можете создать функциональные страницы  пользовательского интерфейса. Эта функция позволяет легко «расширять» систему без программирования."));
		factory.Action((ThemeSettingsController c) => c.Index()).Order(15).Parent("portal")
			.Description(SR.M("Раздел позволяет создавать и настраивать цветовые схемы."));
		factory.Action((PortletsController c) => c.Index()).Order(37).Parent("portal")
			.Description(SR.M("Раздел содержит перечень портлетов системы. В данном разделе вы можете сделать настройку портлетов на уровне системы. Эти настройки будут настройками «по умолчанию» для пользователей системы."));
		factory.Action((ContentActionController c) => c.Index()).Order(50).Parent("portal")
			.Description(SR.M("Раздел содержит реестр действий системы. Данные действия вы можете использовать при настройке меню (левого и верхнего), можете сделать на них ссылки в любых местах системы.<br>Действия добавляются с помощью программного кода."));
	}
}
