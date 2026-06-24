using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

internal sealed class CalendarEventGetConfirmaionStatusExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EventId = "EventId";

		public const string UserId = "UserId";

		public const string Confirmation = "Confirmation";

		public const string Status = "Status";

		public const string Date = "Date";

		public const string Comment = "Comment";

		public const string Result = "Result";

		public const string ResultText = "ResultText";
	}

	private class ConfirmationModel
	{
		public ConfirmParticipation Status { get; }

		public DateTime? Date { get; }

		public string Comment { get; }

		public ConfirmationModel(ICalendarEventUser eventUser)
			: this(eventUser.Confirmed, eventUser.ConfirmDate, eventUser.ConfirmComment)
		{
		}

		public ConfirmationModel(ConfirmParticipation status, DateTime? date, string comment)
		{
			Status = status;
			Date = date;
			Comment = comment;
		}
	}

	public const string MethodName = "GetConfirmaionStatus";

	private CalendarEventManager calendarEventManager;

	public static string MethodDescription => SR.T("Получить статус подтверждения участия пользователя в событии");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EventId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("UserId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор пользователя")).Type(typeof(long));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Результат выполнения. True, если выполнение завершено успешно.")).Type(typeof(bool));
	}).ItemWithDescriptor("ResultText", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий к результату выполненения. При возникновении исключения возвращается текст ошибки")).Type(typeof(string));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder item)
	{
		item.Name("Confirmation").Descriptor(delegate(TypeSerializationDescriptorBuilder d)
		{
			d.ItemWithDescriptor("Status", delegate(TypeSerializationDescriptorBuilder i)
			{
				i.Description(SR.T("Статус подтверждения участия пользователя в событии")).Type(typeof(ConfirmParticipation));
			}).ItemWithDescriptor("Date", delegate(TypeSerializationDescriptorBuilder i)
			{
				i.Description(SR.T("Дата подтверждения участия пользователя в событии")).Type(typeof(DateTime));
			}).ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
			{
				i.Description(SR.T("Комментарий к подтверждению участия пользователя в событии")).Type(typeof(string));
			});
		});
	})
		.Descriptor;

	internal CalendarEventManager CalendarEventManager => calendarEventManager ?? (calendarEventManager = CalendarEventManager.Instance);

	public CalendarEventGetConfirmaionStatusExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не заданы параметры запроса"), 400);
		}
		WebDataItem webDataItem = Parameters.FindItem("EventId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"), 400);
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"), 400);
		}
		WebDataItem webDataItem2 = Parameters.FindItem("UserId");
		if (webDataItem2 == null || string.IsNullOrEmpty(webDataItem2.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор пользователя"), 400);
		}
		if (!long.TryParse(webDataItem2.Value, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора пользователя, должен быть Int64"), 400);
		}
		try
		{
			string message;
			ConfirmationModel confirmation = DoCompleteAction(result, result2, out message);
			return WebData.CreateFromObject(new
			{
				Result = string.IsNullOrWhiteSpace(message),
				ResultText = message,
				Confirmation = confirmation
			});
		}
		catch (Exception ex)
		{
			return WebData.CreateFromObject(new
			{
				Result = false,
				ResultText = ex.Message
			});
		}
	}

	private ConfirmationModel DoCompleteAction(long eventId, long userId, out string message)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.LoadOrNull(eventId);
		if (calendarEvent == null)
		{
			throw new ObjectNotFoundException(SR.T("Событие календаря"), eventId);
		}
		message = null;
		if (!calendarEvent.ConfirmParticipation || calendarEvent is ICalendarEventPeriodical)
		{
			message = SR.T("Подтверждение участия не нужно в событии");
			return null;
		}
		ICalendarEventUser calendarEventUser = ((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).FirstOrDefault((ICalendarEventUser eu) => eu.User.Id == userId && eu.Status == CalendarEventUserStatus.Participant);
		if (calendarEventUser != null)
		{
			if (calendarEvent.Completed)
			{
				message = SR.T("Событие завершено");
			}
			return new ConfirmationModel(calendarEventUser);
		}
		message = SR.T("Пользователь не является участником события");
		return null;
	}
}
