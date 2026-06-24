using System;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

public class CalendarEventAddDayExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EntityId = "EntityId";

		public const string Comment = "Comment";
	}

	public const string MethodName = "AddDayEvent";

	public static string MethodDescription => SR.T("Отложить событие на день");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий")).Type(typeof(string)).Optional();
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public CalendarEventAddDayExecutor(WebData parameters)
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
		WebDataItem webDataItem = Parameters.FindItem("EntityId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"));
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Comment");
		string comment = ((webDataItem2 != null) ? webDataItem2.Value : "");
		DoCompleteAction(result, comment);
		return GetResult();
	}

	private static void DoCompleteAction(long entityId, string comment)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.Instance.LoadOrNull(entityId);
		if (calendarEvent == null || !CalendarEventManager.Instance.CanEdit(calendarEvent))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на изменение события"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			IComment comment2 = null;
			if (!string.IsNullOrEmpty(comment))
			{
				comment2 = InterfaceActivator.Create<IComment>();
				comment2.Text = comment;
				comment2.Save();
			}
			CalendarEventManager.Instance.ChangeTime(calendarEvent, calendarEvent.StartDate.AddDays(1.0), calendarEvent.EndDate.AddDays(1.0), comment2);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}
