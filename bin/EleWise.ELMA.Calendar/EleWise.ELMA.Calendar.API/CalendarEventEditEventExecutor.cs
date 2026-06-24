using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

internal class CalendarEventEditEventExecutor : CalendarEventCreateExecutor
{
	private static class Names
	{
		public const string Id = "Id";

		public const string Subject = "Subject";

		public const string Place = "Place";

		public const string EventUsers = "EventUsers";

		public const string InformUsers = "InformUsers";

		public const string StartDate = "StartDate";

		public const string EndDate = "EndDate";

		public const string Period = "Period";

		public const string UntilDate = "UntilDate";

		public const string SchedulesId = "SchedulesId";

		public const string IsPrivate = "IsPrivate";

		public const string Description = "Description";

		public const string Attachments = "Attachments";
	}

	public const string Name = "EditEvent";

	public static string Description => SR.T("Изменить событие");

	public static TypeSerializationDescriptor ParamsDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Id", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("Subject", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Тема")).Type(typeof(string));
	}).ItemWithDescriptor("Place", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Место")).Type(typeof(string)).Optional();
	})
		.ItemWithDescriptor("EventUsers", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Участники")).IsArray().Type(typeof(long[]));
		})
		.ItemWithDescriptor("InformUsers", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Информируемые")).IsArray().Type(typeof(long[]))
				.Optional();
		})
		.ItemWithDescriptor("StartDate", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Дата начала")).Type(typeof(DateTime));
		})
		.ItemWithDescriptor("EndDate", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Дата окончания")).Type(typeof(DateTime));
		})
		.ItemWithDescriptor("Period", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Периодичность")).Type(typeof(long)).Optional();
		})
		.ItemWithDescriptor("UntilDate", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Дата завершения периодического события")).Type(typeof(DateTime)).Optional();
		})
		.ItemWithDescriptor("SchedulesId", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Общие календари")).IsArray().Type(typeof(long[]))
				.Optional();
		})
		.ItemWithDescriptor("IsPrivate", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Конфиденциально")).Type(typeof(bool)).Optional();
		})
		.ItemWithDescriptor("Description", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Описание")).Type(typeof(string)).Optional();
		})
		.ItemWithDescriptor("Attachments", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Вложения")).Optional().IsArray()
				.Item(delegate(TypeSerializationItemDescriptorBuilder ci)
				{
					ci.Name("Uid").Descriptor(SR.T("Идентификатор файла BinaryFile (Guid)"));
				});
		})
		.Descriptor;

	public CalendarEventEditEventExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected override ICalendarEvent GetEvent()
	{
		WebDataItem webDataItem = Parameters.FindItem("Id");
		if (webDataItem == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"));
		}
		if (long.TryParse(webDataItem.Value, out var result))
		{
			ICalendarEvent calendarEvent = base.CalendarEventManager.LoadOrNull(result);
			if (calendarEvent == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Не найдено событие с идентификатором \"{0}\"", result));
			}
			if (calendarEvent is ICalendarEventPeriodical calendarEventPeriodical)
			{
				KeyValuePair<Periodicity, DateTime?>? periodicity = GetPeriodicity();
				if (periodicity.HasValue)
				{
					calendarEventPeriodical.UntilDate = periodicity.Value.Value;
					if (calendarEventPeriodical.Period != periodicity.Value.Key)
					{
						calendarEventPeriodical.Period = periodicity.Value.Key;
						base.PeriodicalManager.ChangePeriodicity(calendarEventPeriodical);
					}
				}
			}
			return calendarEvent;
		}
		throw PublicServiceException.CreateWebFault(SR.T("Идентификатор события должен быть long"));
	}
}
