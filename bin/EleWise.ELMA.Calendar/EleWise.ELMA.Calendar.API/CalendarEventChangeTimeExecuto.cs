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

public class CalendarEventChangeTimeExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EntityId = "EntityId";

		public const string StartDate = "StartDate";

		public const string EndDate = "EndDate";

		public const string Comment = "Comment";
	}

	public const string MethodName = "ChangeTimeEvent";

	public static string MethodDescription => SR.T("Изменить время события");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("StartDate", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Время начала события")).Type(typeof(DateTime));
	}).ItemWithDescriptor("EndDate", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Время окончания события")).Type(typeof(DateTime)).Optional();
	})
		.ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Комментарий")).Type(typeof(string)).Optional();
		})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public CalendarEventChangeTimeExecutor(WebData parameters)
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
		WebDataItem webDataItem2 = Parameters.FindItem("StartDate");
		if (webDataItem2 == null || string.IsNullOrEmpty(webDataItem2.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задано время начала события"));
		}
		if (!DateTime.TryParse(webDataItem2.Value, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат времени начала события, должен быть DateTime"));
		}
		WebDataItem webDataItem3 = Parameters.FindItem("EndDate");
		if (webDataItem3 == null || string.IsNullOrEmpty(webDataItem3.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задано время окончания события"));
		}
		if (!DateTime.TryParse(webDataItem3.Value, out var result3))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат времени окончания события, должен быть DateTime"));
		}
		WebDataItem webDataItem4 = Parameters.FindItem("Comment");
		string comment = ((webDataItem4 != null) ? webDataItem4.Value : "");
		DoCompleteAction(result, result2, result3, comment);
		return GetResult();
	}

	private static void DoCompleteAction(long entityId, DateTime startDate, DateTime endDate, string comment)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.Instance.LoadOrNull(entityId);
		if (calendarEvent == null || !CalendarEventManager.Instance.CanChangeTime(calendarEvent, startDate, endDate, null))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на изменение события"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		IComment comment2 = null;
		try
		{
			if (!string.IsNullOrEmpty(comment))
			{
				comment2 = InterfaceActivator.Create<IComment>();
				comment2.Text = comment;
				comment2.Save();
			}
			CalendarEventManager.Instance.ChangeTime(calendarEvent, startDate, endDate, comment2);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}
