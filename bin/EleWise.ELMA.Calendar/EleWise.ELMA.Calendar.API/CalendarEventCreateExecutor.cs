using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

internal class CalendarEventCreateExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
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

	private IAuthenticationService authenticationService;

	private UserManager userManager;

	private ScheduleManager scheduleManager;

	private CalendarEventPeriodicalManager periodicalManager;

	private CalendarEventManager calendarEventManager;

	private DateTimeDescriptor dateTimeDescriptor;

	public const string MethodName = "CreateEvent";

	private IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	private UserManager UserManager => userManager ?? (userManager = UserManager.Instance);

	private ScheduleManager ScheduleManager => scheduleManager ?? (scheduleManager = ScheduleManager.Instance);

	internal CalendarEventPeriodicalManager PeriodicalManager => periodicalManager ?? (periodicalManager = CalendarEventPeriodicalManager.Instance);

	internal CalendarEventManager CalendarEventManager => calendarEventManager ?? (calendarEventManager = CalendarEventManager.Instance);

	protected DateTimeDescriptor DateTimeDescriptor => dateTimeDescriptor ?? (dateTimeDescriptor = Locator.GetServiceNotNull<DateTimeDescriptor>());

	public static string MethodDescription => SR.T("Создать событие");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Subject", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Тема")).Type(typeof(string));
	}).ItemWithDescriptor("Place", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Место")).Type(typeof(string)).Optional();
	}).ItemWithDescriptor("EventUsers", delegate(TypeSerializationDescriptorBuilder i)
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

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Description(SR.T("Результат выполнения. True, если выполнение завершено успешно.")).Type(typeof(bool));
	}).ItemWithDescriptor("EventId", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Type(typeof(long));
	}).Descriptor;

	public CalendarEventCreateExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData GetResult(ICalendarEvent evnt)
	{
		return WebData.CreateFromObject(new
		{
			Result = true,
			EventId = evnt.Id
		});
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	protected virtual KeyValuePair<Periodicity, DateTime?>? GetPeriodicity()
	{
		WebDataItem webDataItem = Parameters.FindItem("Period");
		if (webDataItem != null)
		{
			if (long.TryParse(webDataItem.Value, out var result))
			{
				Periodicity? periodicity = null;
				EnumMetadata enumMetadata = MetadataLoader.LoadMetadata(typeof(Periodicity)) as EnumMetadata;
				foreach (EnumValueMetadata value2 in enumMetadata.Values)
				{
					if (value2.IntValue == result)
					{
						periodicity = (Periodicity)result;
					}
				}
				if (!periodicity.HasValue)
				{
					throw PublicServiceException.CreateWebFault(SR.T("Значение периодичности не найдено по идентификатору \"{0}\"", result));
				}
				WebDataItem webDataItem2 = Parameters.FindItem("UntilDate");
				DateTime? value = ((webDataItem2 != null && !string.IsNullOrWhiteSpace(webDataItem2.Value)) ? new DateTime?(DateTimeDescriptor.DeserializeSimple(webDataItem2.Value)) : null);
				return new KeyValuePair<Periodicity, DateTime?>(periodicity.Value, value);
			}
			throw PublicServiceException.CreateWebFault(SR.T("Параметр {0} должно быть в формате long", "Period"));
		}
		return null;
	}

	protected virtual ICalendarEvent GetEvent()
	{
		KeyValuePair<Periodicity, DateTime?>? periodicity = GetPeriodicity();
		if (!periodicity.HasValue)
		{
			return InterfaceActivator.Create<ICalendarEvent>();
		}
		ICalendarEventPeriodical calendarEventPeriodical = InterfaceActivator.Create<ICalendarEventPeriodical>();
		calendarEventPeriodical.Period = periodicity.Value.Key;
		calendarEventPeriodical.UntilDate = periodicity.Value.Value;
		return calendarEventPeriodical;
	}

	private WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		ICalendarEvent @event = GetEvent();
		WebDataItem webDataItem = Parameters.FindItem("Subject");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задана тема события"));
		}
		@event.Subject = webDataItem.Value;
		WebDataItem webDataItem2 = Parameters.FindItem("StartDate");
		if (webDataItem2 == null || string.IsNullOrWhiteSpace(webDataItem2.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задано время начала события"));
		}
		@event.StartDate = DateTimeDescriptor.DeserializeSimple(webDataItem2.Value);
		WebDataItem webDataItem3 = Parameters.FindItem("EndDate");
		if (webDataItem3 == null || string.IsNullOrWhiteSpace(webDataItem3.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задано время окончания события"));
		}
		@event.EndDate = DateTimeDescriptor.DeserializeSimple(webDataItem3.Value);
		WebDataItem webDataItem4 = Parameters.FindItem("Place");
		if (webDataItem4 != null)
		{
			@event.Place = (string.IsNullOrWhiteSpace(webDataItem4.Value) ? "" : webDataItem4.Value);
		}
		WebDataItem webDataItem5 = Parameters.FindItem("EventUsers");
		if (webDataItem5 == null || (webDataItem5.DataArray == null && string.IsNullOrWhiteSpace(webDataItem5.Value)))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не заданы участники события"));
		}
		if (webDataItem5.DataArray.Length == 0 && !string.IsNullOrWhiteSpace(webDataItem5.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Параметр \"{0}\" должен иметь формать long[]", "EventUsers"));
		}
		AddEventusersUsers(webDataItem5.DataArray, CalendarEventUserStatus.Participant, @event);
		WebDataItem webDataItem6 = Parameters.FindItem("InformUsers");
		if (webDataItem6 != null)
		{
			if ((webDataItem6.DataArray == null || webDataItem6.DataArray.Length == 0) && !string.IsNullOrWhiteSpace(webDataItem6.Value))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Параметр \"{0}\" должен иметь формать long[]", "InformUsers"));
			}
			AddEventusersUsers(webDataItem6.DataArray, CalendarEventUserStatus.InfromTo, @event);
		}
		WebDataItem webDataItem7 = Parameters.FindItem("SchedulesId");
		if (webDataItem7 != null && webDataItem7.DataArray != null)
		{
			if (webDataItem7.DataArray.Length != 0)
			{
				ICollection<ISchedule> allowedSchedules = GetAvalibleSchedules();
				((ISet<ISchedule>)@event.Schedules).AddAll(from a in webDataItem7.DataArray
					select GetSchedules(a, allowedSchedules) into a
					where a != null
					select a);
			}
			else if (!string.IsNullOrEmpty(webDataItem7.Value))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Параметр \"{0}\" должен иметь формать long[]", "SchedulesId"));
			}
		}
		WebDataItem webDataItem8 = Parameters.FindItem("IsPrivate");
		if (webDataItem8 != null)
		{
			if (!bool.TryParse(webDataItem8.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Параметр \"{0}\" должен иметь формать bool", "IsPrivate"));
			}
			@event.IsPrivate = result;
		}
		WebDataItem webDataItem9 = Parameters.FindItem("Description");
		if (webDataItem9 != null)
		{
			@event.Description = webDataItem9.Value;
		}
		WebDataItem attachItem = Parameters.FindItem("Attachments");
		IList<IAttachment> attachments = GetAttachments(attachItem);
		@event.Attachments.AddAll((ICollection<IAttachment>)attachments);
		DoSaveAction(@event);
		return GetResult(@event);
	}

	private IList<IAttachment> GetAttachments(WebDataItem attachItem)
	{
		List<IAttachment> list = new List<IAttachment>();
		if (attachItem == null || attachItem.DataArray == null)
		{
			return list;
		}
		list.AddRange(from a in attachItem.DataArray.Select(GetAttachment)
			where a != null
			select a);
		return list;
	}

	private IAttachment GetAttachment(WebData data)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		string value = data.FindItem("Uid").Value;
		attachment.File = BinaryFileDescriptor.Download(Guid.Parse(value));
		attachment.CreationAuthor = AuthenticationService.GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}

	private void AddEventusersUsers(WebData[] webData, CalendarEventUserStatus status, ICalendarEvent evnt)
	{
		if (webData == null || webData.Length == 0)
		{
			return;
		}
		long[] array = new long[webData.Length];
		for (int i = 0; i < webData.Length; i++)
		{
			if (long.TryParse(webData[i].Value, out var result))
			{
				array[i] = result;
				continue;
			}
			throw PublicServiceException.CreateWebFault(SR.T("Идентификатор участника события должен иметь формат long"));
		}
		ICollection<IUser> collection = UserManager.FindByIdArray(array);
		long[] array2 = array;
		foreach (long id in array2)
		{
			if (!collection.Any((IUser a) => a.Id == id))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Не найден пользователь с идентификатором '{0}'", id));
			}
		}
		foreach (IUser user in collection)
		{
			if (!((IEnumerable<ICalendarEventUser>)evnt.EventUsers).Any((ICalendarEventUser a) => a.User != null && a.User.Id == user.Id))
			{
				ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser.Event = evnt;
				calendarEventUser.User = user;
				calendarEventUser.Status = status;
				evnt.EventUsers.Add(calendarEventUser);
			}
		}
	}

	private ISchedule GetSchedules(WebData webData, ICollection<ISchedule> allowedSchedules)
	{
		if (webData == null)
		{
			return null;
		}
		if (long.TryParse(webData.Value, out var scheduleId))
		{
			return allowedSchedules.FirstOrDefault((ISchedule a) => a.Id == scheduleId);
		}
		throw PublicServiceException.CreateWebFault(SR.T("Идентификатор календаря должен иметь формат long"));
	}

	private void DoSaveAction(ICalendarEvent evnt)
	{
		if (evnt is ICalendarEventPeriodical calendarEventPeriodical)
		{
			if (calendarEventPeriodical.UntilDate < evnt.StartDate.Date)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Дата завершения периодического события должна быть позже даты начала"));
			}
			try
			{
				PeriodicalManager.Save(calendarEventPeriodical);
				PeriodicalManager.CreatingPeriodicEntities(calendarEventPeriodical, continueFromLastDate: false);
				return;
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex);
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка при попытке сохранить периодическое событие"), ex);
			}
		}
		try
		{
			CalendarEventManager.Save(evnt);
		}
		catch (Exception ex2)
		{
			Logger.Log.Error(ex2);
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка при попытке сохранить событие"), ex2);
		}
	}

	private ICollection<ISchedule> GetAvalibleSchedules()
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Shared = true;
		scheduleFilter.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
		return ScheduleManager.Find(scheduleFilter, FetchOptions.All);
	}
}
