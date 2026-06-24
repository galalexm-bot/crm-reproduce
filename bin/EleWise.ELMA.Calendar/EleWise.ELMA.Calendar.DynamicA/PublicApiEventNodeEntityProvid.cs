using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Calendar.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Calendar.DynamicAPI;

[Component(Order = 15)]
internal class PublicApiEventNodeEntityProvider : IPublicApiNodeProvider
{
	private const BindingFlags InvokeMethodFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod;

	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		PublicApiPropertyClassNode eventNode = new PublicApiPropertyClassNode("PublicAPI.Portal", "CalendarEventPortalApi", typeof(ICalendarEvent))
		{
			Description = SR.T("Событие"),
			Remarks = SR.T("Раздел содержащий методы для работы с событиями"),
			Code = SR.T("\r\n<para>\r\nСоздадим событие календаря для списка пользователей\r\n<code>\r\n<![CDATA[\r\n//место события\r\nvar place = \"Место для события\";\r\n//тема события\r\nvar theme = \"Тема для события\";\r\n//описание события\r\nvar desc = \"Описание для события\";\r\n//создаем событие\r\nvar calendarEvent = PublicAPI.Portal.CalendarEvent.Create(context.UserList, DateTime.Now, DateTime.Now.AddDays(3), theme, place, desc);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nСоздадим напоминание для события календаря\r\n<code>\r\n<![CDATA[\r\nvar myReminder = PublicAPI.Portal.CalendarEvent.CreateReminder(context.User, calendarEvent, DateTime.Now.AddDays(2).AddHours(3));\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return eventNode;
		foreach (IPublicApiNode item in PublicApiNodeEntityProvider.Members<ICalendarEvent, CalendarEventManager>(eventNode.Path))
		{
			yield return item;
		}
		PublicApiCustomBuilderMethodNode calendarEventBuilder = new PublicApiCustomBuilderMethodNode(eventNode.Path, "CalendarEventBuilder", "Calendar.Managers", "CalendarEventBuilderApi", SR.T("Помощник для создания события календаря"));
		yield return calendarEventBuilder;
		PublicApiCustomBuilderMethodNode calendarEventPeriodicalBuilder = new PublicApiCustomBuilderMethodNode(eventNode.Path, "CalendarEventPeriodicalBuilder", "Calendar.Managers", "CalendarEventPeriodicalBuilderApi", SR.T("Помощник для создания переодического события календаря"));
		yield return calendarEventPeriodicalBuilder;
		yield return new PublicApiCustomBuilderNode(calendarEventBuilder.Path, typeof(CalendarEventBuilder));
		yield return new PublicApiCustomBuilderNode(calendarEventPeriodicalBuilder.Path, typeof(CalendarEventPeriodicalBuilder));
		PublicApiPropertyClassNode permissionNode = new PublicApiPropertyClassNode(eventNode.Path, "PermissionsEventApi", "Permissions")
		{
			Description = SR.T("Привилегии"),
			Remarks = SR.T("Раздел, содержащий привилегии и методы для работы с ними")
		};
		yield return permissionNode;
		yield return new PublicApiPermissionsNode<CommonPermissions>(permissionNode.Path);
		yield return new PublicApiPermissionsNode<PermissionProvider>(permissionNode.Path);
		foreach (IPublicApiNode item2 in PublicApiNodeServicesProvider.Services(typeof(IProductionCalendarService), typeof(IAvailableTimeSlotsService)))
		{
			yield return item2;
		}
	}
}
