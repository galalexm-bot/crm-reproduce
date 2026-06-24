using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Export.Managers;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Mobile.API.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.Mobile.API.Calendar;

internal class GetExternalCalendarItemsExecutor : PublicServiceMethodExecutor
{
	private DateTimeDescriptor dateTimeDescriptor;

	private ScheduleManager scheduleManager;

	private IAuthenticationService authenticationService;

	private ExternalCalendarManager externalCalendarManager;

	public const string MethodName = "GetExternalCalendarItems";

	private DateTimeDescriptor DateTimeDescriptor => dateTimeDescriptor ?? (dateTimeDescriptor = Locator.GetServiceNotNull<DateTimeDescriptor>());

	private ScheduleManager ScheduleManager => scheduleManager ?? (scheduleManager = ScheduleManager.Instance);

	private IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	private ExternalCalendarManager ExternalCalendarManager => externalCalendarManager ?? (externalCalendarManager = Locator.GetServiceNotNull<ExternalCalendarManager>());

	public static string MethodDescription => SR.T("Получить список элементов внешних календарей для заданного промежутка времени");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("StartDate", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Дата, с которой нужно получить данные")).Type(typeof(DateTime));
	}).ItemWithDescriptor("EndDate", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Дата, до которой нужно получить данные (включительно)")).Type(typeof(DateTime));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Description(SR.T("Результат выполнения. True, если выполнение завершено успешно.")).Type(typeof(bool));
	}).ItemWithDescriptor("ExternalCalendarItems", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Description(SR.T("Список элементов внешних календарей для заданного промежутка времени")).Type(typeof(ExternalCalendarItemModel[]));
	}).Descriptor;

	public GetExternalCalendarItemsExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData GetResult(IEnumerable<ExternalCalendarItem> calendarItems)
	{
		EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
		entitySerializationSettings.Mode = EntitySerializationMode.ChangesOnly;
		ExternalCalendarItemModel[] externalCalendarItems = calendarItems.Select((ExternalCalendarItem i) => new ExternalCalendarItemModel(i)).ToArray();
		return WebData.CreateFromObject(new
		{
			Result = true,
			ExternalCalendarItems = externalCalendarItems
		}, entitySerializationSettings);
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	private WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("StartDate");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задана дата начала"));
		}
		DateTime startDate = DateTimeDescriptor.DeserializeSimple(webDataItem.Value);
		WebDataItem webDataItem2 = Parameters.FindItem("EndDate");
		if (webDataItem2 == null || string.IsNullOrEmpty(webDataItem2.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задана дата окончания"));
		}
		DateTime endDate = DateTimeDescriptor.DeserializeSimple(webDataItem2.Value);
		ISchedule[] schedules = new ISchedule[1] { ScheduleManager.GetUserSchedule(AuthenticationService.GetCurrentUser<IUser>()) };
		IEnumerable<ExternalCalendarItem> calendarItems = ExternalCalendarManager.FindCalendars(schedules, disableSecurity: false).SelectMany((IExternalCalendar c) => ExternalCalendarManager.GetCalendarEvents(c, startDate, endDate));
		return GetResult(calendarItems);
	}
}
