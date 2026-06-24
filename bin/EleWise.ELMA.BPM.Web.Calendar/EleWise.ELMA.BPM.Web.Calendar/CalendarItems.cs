using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Calendar.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Calendar.Menu;

[Component]
public class CalendarItems : IMenuItemsProvider
{
	public const string CREATE_EVENT = "calendar-create-event";

	public const string CalendarSettings = "admin-calendar";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action("calendar-create-event").Order(30).Name(SR.M("Добавить событие"))
			.Container("create");
		factory.Section(SR.M("Календарь"), "start-calendar-menu").Order(400).Color("yellow")
			.Image16("#calendar.svg")
			.Container("start");
		factory.Action(new ActionRoute("Index", "Scheduler", new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar"
		})).Name(SR.M("Календарь")).Parent("start-calendar-menu")
			.Order(410)
			.Image16("#calendar.svg")
			.Container("start");
		factory.Action("calendar-create-event").Parent("create").Order(60)
			.Name(SR.M("Событие в календаре"))
			.Container("top");
		factory.Section(SR.M("Календарь"), "calendar").Order(30).Container("top");
		factory.Action("SchedulerController.CalendarTodayItemId").Name(SR.M("Сегодня")).Parent("calendar")
			.Container("top");
		factory.Action("SchedulerController.CalendarMyItemId").Parent("calendar").Name(SR.M("Мой календарь"))
			.Container("top");
		factory.Action((SchedulerController c) => c.Index(null)).Order(30).Name(SR.M("Календарь"))
			.Code("calendar")
			.Image24("#calendar.svg")
			.Container("left");
		factory.Action((AdminController c) => c.CalendarSettingsPage()).Code("admin-calendar").Order(10)
			.Parent("commonhome")
			.Container("left");
	}
}
