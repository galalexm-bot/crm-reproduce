using System;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

public class CalendarEventDeleteExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EntityId = "EventId";
	}

	public const string MethodName = "DeleteEvent";

	public static string MethodDescription => SR.T("Удалить событие");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EventId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public CalendarEventDeleteExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected virtual WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true
		});
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("EventId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"));
		}
		DoCompleteAction(result);
		return GetResult();
	}

	private static void DoCompleteAction(long entityId)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.Instance.LoadOrNull(entityId);
		if (calendarEvent == null || !CalendarEventManager.Instance.CanDeleteEvent(calendarEvent, all: false))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на удаление события"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			CalendarEventManager.Instance.DeleteEvent(calendarEvent, all: false);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}
