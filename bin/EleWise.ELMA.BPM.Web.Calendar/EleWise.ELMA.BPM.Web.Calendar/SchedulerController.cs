using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar.Controllers;

[Permission("47DB2A47-0E59-420E-87E7-E85890750CA1")]
public class SchedulerController : BPMController<ISchedule, long>
{
	public const string CalendarItemsId = "SchedulerController.CalendarItems";

	public const string CalendarTodayItemId = "SchedulerController.CalendarTodayItemId";

	public const string CalendarMyItemId = "SchedulerController.CalendarMyItemId";

	public const string LastVisitDate = "SchedulerController.LastVisitDate";

	public const string CalendarLogItemsId = "SchedulerController.CalendarLogItems";

	public ScheduleLogManager ScheduleLogManager { get; set; }

	public IEnumerable<IModifyTimeCalendarItemProvider> ModifyTimeCalendarItemProviders { get; set; }

	public IEnumerable<ICalendarItemProvider> CalendarItemProviders { get; set; }

	[ChildActionOnly]
	public ActionResult Portlet()
	{
		ISchedule currentUserSchedule = ScheduleManager.Instance.GetCurrentUserSchedule();
		ScheduleModel scheduleModel = GenerateModel(currentUserSchedule, DateTime.Now.ToShortDateString(), true, ScheduleMode.Week, 0, inPopup: false, saveState: false, forPortlet: true, showExpired: true);
		((dynamic)((ControllerBase)this).get_ViewBag()).InPortlet = true;
		return (ActionResult)(object)((Controller)this).PartialView("Controls/ListGrid", (object)scheduleModel);
	}

	public ActionResult Print()
	{
		base.ViewTitle = SR.T("Календарь");
		ScheduleModel scheduleModel = GenerateModel(null, null, true);
		return (ActionResult)(object)((Controller)this).View("Print", (object)scheduleModel);
	}

	public ActionResult Events(ISchedule schedule, DateTime? start, DateTime? end)
	{
		List<object> list = new List<object>();
		if (schedule == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				events = list
			}, (JsonRequestBehavior)0);
		}
		DateTime startDate = start ?? DateTime.Now;
		DateTime endDate = end ?? new DateTime(startDate.Year, startDate.Month, startDate.Day, 23, 59, 59);
		bool editable = (schedule.Owner != null && schedule.Owner == base.AuthenticationService.GetCurrentUser<IUser>()) || base.SecurityService.HasPermission(PermissionProvider.ScheduleEditPermission, schedule) || base.SecurityService.HasPermission(PermissionProvider.ScheduleFullPermission, schedule);
		IEnumerable<ICalendarItemProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>();
		DateTime nowDate = DateTime.Now.ToClientDateTime();
		foreach (ICalendarItemProvider item in extensionPoints)
		{
			ICalendarItemProvider prov = item;
			ICollection<ICalendarItem> items = item.GetItems(schedule, startDate, endDate, checkPermission: false);
			list.AddRange(items.Select((ICalendarItem i) => CreateEventItem(i, prov, nowDate, editable)));
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			events = list
		}, (JsonRequestBehavior)0);
	}

	private object CreateEventItem(ICalendarItem item, ICalendarItemProvider provider, DateTime nowDate, bool editable = false)
	{
		if (item == null || provider == null)
		{
			return null;
		}
		IUser user = UserManager.Instance.LoadOrNull(item.CreationAuthor);
		long currentUserId = base.AuthenticationService.GetCurrentUser<IUser>().Id;
		bool toConfirmParticipation = CalendarEventManager.Instance.EventIdNeedConfirmParticipation(item);
		DateTime dateTime = item.StartDate.ToClientDateTime();
		DateTime dateTime2 = item.EndDate.ToClientDateTime();
		return new
		{
			typeUid = item.SourceTypeUid,
			id = item.Id,
			title = HttpUtility.HtmlEncode(item.Theme),
			url = ((Controller)this).get_Url().ObjectLink(item),
			allDay = (dateTime.Year != dateTime2.Year || dateTime.Month != dateTime2.Month || dateTime.Day != dateTime2.Day || (dateTime == dateTime.NormalizeStartDate(time: false) && dateTime2 == dateTime2.NormalizeEndDate(time: false))),
			start = GetDate(dateTime),
			end = GetDate((dateTime2 <= dateTime) ? dateTime.AddMinutes(15.0) : dateTime2),
			classNames = "calendar-item-" + item.SourceTypeUid.ToString(),
			editable = (!item.ReadOnly && !item.Completed && editable),
			extendedProps = new
			{
				sourceId = item.SourceId,
				description = HttpUtility.HtmlEncode(item.Description),
				place = HttpUtility.HtmlEncode(item.Place),
				to = ((!string.IsNullOrEmpty(item.To)) ? HttpUtility.HtmlEncode(item.To) : null),
				iconUrl = ((Controller)this).get_Url().ObjectIcon(ObjectIconFormat.x16, item),
				completed = item.Completed,
				timeNotSet = (dateTime == dateTime2),
				uid = provider.Uid,
				authorId = ((user != null) ? user.Id.ToString() : ""),
				authorName = ((user != null) ? user.GetShortName() : ""),
				toInform = item.ToInform,
				toConfirmParticipation = toConfirmParticipation,
				isExpired = (item.MarkExpired && dateTime2 < nowDate),
				confirmChange = item.EventUsers.Any((KeyValuePair<string, string> u) => u.Key != currentUserId.ToString()),
				eventUsers = item.EventUsers.Select((KeyValuePair<string, string> i) => new
				{
					userId = i.Key,
					userName = i.Value
				}).ToList(),
				removable = (!item.ReadOnly && !item.Completed && editable),
				canEdit = (item.CreationAuthor == currentUserId)
			}
		};
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult ChangeTime(Guid providerUid, string id, int dayDelta, int minuteDelta, bool? resize)
	{
		DateTime nowDate = DateTime.Now.ToClientDateTime();
		var anon = new
		{
			success = false,
			message = "",
			item = CreateEventItem(null, null, nowDate)
		};
		if (string.IsNullOrEmpty(id))
		{
			anon = new
			{
				success = false,
				message = SR.T("Событие не может быть добавленно, не задан id"),
				item = CreateEventItem(null, null, nowDate)
			};
		}
		else
		{
			ICalendarItemProvider calendarItemProvider = ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>().FirstOrDefault((ICalendarItemProvider p) => p.Uid == providerUid);
			if (calendarItemProvider == null)
			{
				anon = new
				{
					success = false,
					message = SR.T("Не найден провайдер для события"),
					item = CreateEventItem(null, null, nowDate)
				};
			}
			else
			{
				try
				{
					ICalendarItem calendarItem = calendarItemProvider.ModifyTime(id, dayDelta, minuteDelta, !resize.HasValue || !resize.Value);
					anon = ((calendarItem != null) ? new
					{
						success = true,
						message = "",
						item = CreateEventItem(calendarItem, calendarItemProvider, nowDate, editable: true)
					} : new
					{
						success = false,
						message = SR.T("Не удалось добавить событие, неизвестная ошибка"),
						item = CreateEventItem(null, null, nowDate)
					});
				}
				catch (Exception ex)
				{
					base.Logger.Error(SR.T("Ошибка при изменении времени события"), ex);
					anon = new
					{
						success = false,
						message = ex.Message,
						item = CreateEventItem(null, null, nowDate)
					};
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)anon, "text/html", (JsonRequestBehavior)0);
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult ChangeTimeByDates(Guid providerUid, string id, DateTime startDate, DateTime endDate)
	{
		DateTime nowDate = DateTime.Now.ToClientDateTime();
		var anon = new
		{
			success = false,
			message = "",
			item = CreateEventItem(null, null, nowDate)
		};
		if (string.IsNullOrEmpty(id))
		{
			anon = new
			{
				success = false,
				message = SR.T("Событие не может быть добавленно, не задан id"),
				item = CreateEventItem(null, null, nowDate)
			};
		}
		else
		{
			IModifyTimeCalendarItemProvider modifyTimeCalendarItemProvider = ModifyTimeCalendarItemProviders.FirstOrDefault((IModifyTimeCalendarItemProvider p) => p.Uid == providerUid);
			ICalendarItemProvider calendarItemProvider = CalendarItemProviders.FirstOrDefault((ICalendarItemProvider p) => p.Uid == providerUid);
			if (modifyTimeCalendarItemProvider == null || calendarItemProvider == null)
			{
				anon = new
				{
					success = false,
					message = SR.T("Не найден провайдер для события"),
					item = CreateEventItem(null, null, nowDate)
				};
			}
			else
			{
				try
				{
					ICalendarItem calendarItem = modifyTimeCalendarItemProvider.ModifyTime(id, startDate, endDate);
					anon = ((calendarItem != null) ? new
					{
						success = true,
						message = "",
						item = CreateEventItem(calendarItem, calendarItemProvider, nowDate, editable: true)
					} : new
					{
						success = false,
						message = SR.T("Не удалось добавить событие, неизвестная ошибка"),
						item = CreateEventItem(null, null, nowDate)
					});
				}
				catch (Exception ex)
				{
					base.Logger.Error(SR.T("Ошибка при изменении времени события"), ex);
					anon = new
					{
						success = false,
						message = ex.Message,
						item = CreateEventItem(null, null, nowDate)
					};
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)anon, "text/html", (JsonRequestBehavior)0);
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult RemoveEvent(Guid providerUid, string id)
	{
		var anon = new
		{
			success = false,
			message = ""
		};
		if (string.IsNullOrEmpty(id))
		{
			anon = new
			{
				success = false,
				message = SR.T("Событие не может быть добавленно, не задан id")
			};
		}
		else
		{
			ICalendarItemProvider calendarItemProvider = ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>().FirstOrDefault((ICalendarItemProvider p) => p.Uid == providerUid);
			if (calendarItemProvider == null)
			{
				anon = new
				{
					success = false,
					message = SR.T("Не найден провайдер для события")
				};
			}
			else
			{
				try
				{
					calendarItemProvider.Remove(id);
					anon = new
					{
						success = true,
						message = ""
					};
				}
				catch (Exception ex)
				{
					base.Logger.Error(SR.T("Ошибка при удалении события"), ex);
					anon = new
					{
						success = false,
						message = ex.Message
					};
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)anon, "text/html", (JsonRequestBehavior)0);
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult AddEvent(Guid providerUid, string id, DateTime startDate, DateTime? endDate, bool removeOther)
	{
		DateTime nowDate = DateTime.Now.ToClientDateTime();
		var anon = new
		{
			success = false,
			message = "",
			item = CreateEventItem(null, null, nowDate)
		};
		if (string.IsNullOrEmpty(id))
		{
			anon = new
			{
				success = false,
				message = SR.T("Событие не может быть добавленно, не задан id"),
				item = CreateEventItem(null, null, nowDate)
			};
		}
		else
		{
			ICalendarItemProvider calendarItemProvider = ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>().FirstOrDefault((ICalendarItemProvider p) => p.Uid == providerUid);
			if (calendarItemProvider == null)
			{
				anon = new
				{
					success = false,
					message = SR.T("Не найден провайдер для события"),
					item = CreateEventItem(null, null, nowDate)
				};
			}
			else
			{
				try
				{
					ICalendarItem calendarItem = calendarItemProvider.AddItem(base.AuthenticationService.GetCurrentUser<IUser>(), id, startDate, endDate ?? startDate.AddMinutes(60.0), removeOther);
					anon = ((calendarItem != null) ? new
					{
						success = true,
						message = "",
						item = CreateEventItem(calendarItem, calendarItemProvider, nowDate, editable: true)
					} : new
					{
						success = false,
						message = SR.T("Не удалось добавить событие, неизвестная ошибка"),
						item = CreateEventItem(null, null, nowDate)
					});
				}
				catch (Exception ex)
				{
					anon = new
					{
						success = false,
						message = ex.Message,
						item = CreateEventItem(null, null, nowDate)
					};
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)anon, "text/html", (JsonRequestBehavior)0);
	}

	private ScheduleModel GenerateModel(ISchedule schedule, string date, bool? forList, ScheduleMode? mode = null, int delta = 0, bool inPopup = false, bool saveState = true, bool forPortlet = false, bool showExpired = false)
	{
		ScheduleModel scheduleModel = new ScheduleModel(schedule)
		{
			ShowExpired = showExpired,
			InPopup = inPopup,
			CurrentUser = base.AuthenticationService.GetCurrentUser<IUser>(),
			ShowPermissionButton = (schedule != null && (schedule.Owner == base.AuthenticationService.GetCurrentUser<IUser>() || base.SecurityService.HasPermission(PermissionProvider.ScheduleFullPermission, schedule))),
			Editable = (schedule != null && ((schedule.Owner != null && schedule.Owner == base.AuthenticationService.GetCurrentUser<IUser>()) || base.SecurityService.HasPermission(PermissionProvider.ScheduleEditPermission, schedule) || base.SecurityService.HasPermission(PermissionProvider.ScheduleFullPermission, schedule))),
			RefetchEventsTimeout = 300000
		};
		DateTime result = DateTime.Now;
		if ((string.IsNullOrEmpty(date) || !DateTime.TryParse(date, out result)) && ((Controller)this).get_Session()["SchedulerController.LastVisitDate"] != null)
		{
			result = (DateTime)((Controller)this).get_Session()["SchedulerController.LastVisitDate"];
		}
		else if (saveState)
		{
			scheduleModel.State.ViewDate = result;
			((Controller)this).get_Session()["SchedulerController.LastVisitDate"] = result;
			StateExtensions.SaveState(scheduleModel.State.Id, scheduleModel.State);
		}
		scheduleModel.CurrentDate = result;
		if (scheduleModel.InPopup)
		{
			scheduleModel.ForList = false;
		}
		else if (forList.HasValue)
		{
			scheduleModel.ForList = forList.Value;
		}
		else
		{
			scheduleModel.ForList = scheduleModel.State.ListView;
		}
		if (schedule != null)
		{
			IEnumerable<ICalendarItemProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>();
			if (extensionPoints != null)
			{
				DateTime start = result.AddMonths(-1);
				DateTime end = result.AddMonths(1);
				if (scheduleModel.ForList)
				{
					if (!mode.HasValue)
					{
						mode = scheduleModel.State.Mode;
					}
					scheduleModel.CalendarTitle = CalendarExtensions.CalendarTitle(result, delta, mode.Value);
					if (forPortlet)
					{
						start = result;
						end = result.AddDays(7.0);
					}
					else
					{
						CalendarExtensions.CalendarDateRange(result, delta, mode.Value, out start, out end);
						scheduleModel.CurrentDate = start;
					}
					start = new DateTime(start.Year, start.Month, start.Day, 0, 0, 0).ToRuntimeDateTimeFromClient();
					end = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59).ToRuntimeDateTimeFromClient();
				}
				foreach (ICalendarItemProvider item in extensionPoints)
				{
					ICalendarItemProvider prov = item;
					if (scheduleModel.ForList)
					{
						ICollection<ICalendarItem> items = item.GetItems(schedule, start, end, checkPermission: false, showExpired);
						scheduleModel.Events.AddRange(items.Select((ICalendarItem i) => new CalendarItemModel<ICalendarItem>(i, prov.Uid)));
						scheduleModel.Events = scheduleModel.Events.OrderBy((CalendarItemModel<ICalendarItem> e) => e.Item.StartDate).ToList();
					}
				}
			}
			if (!inPopup)
			{
				InstanceOf<IScheduleLogFilter> instanceOf = new InstanceOf<IScheduleLogFilter>();
				instanceOf.New.User = base.AuthenticationService.GetCurrentUser<IUser>();
				instanceOf.New.Schedule = schedule;
				instanceOf.New.Favorite = true;
				IScheduleLogFilter @new = instanceOf.New;
				scheduleModel.IsFavorite = ScheduleLogManager.Exists(@new);
			}
		}
		if (!inPopup)
		{
			scheduleModel.AddActions = (from a in ComponentManager.Current.GetExtensionPoints<IEventAddAction>()
				orderby a.Order
				select a).ToList();
			ICollection<ISchedule> source = base.Manager.Find(FetchOptions.All);
			IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
			scheduleModel.CurrentUserSchedule = source.FirstOrDefault((ISchedule s) => s.Owner == currentUser);
			scheduleModel.CommonSchedules = (from s in source
				where s.Owner == null
				orderby s.Name
				select s).ToList();
			scheduleModel.UserSchedules = (from s in source
				where s.Owner != null && s.Owner != currentUser && s.Owner.Status == UserStatus.Active
				orderby s.Name
				select s).ToList();
			scheduleModel.BlockUserSchedules = (from s in source
				where s.Owner != null && s.Owner != currentUser && s.Owner.Status != UserStatus.Active
				orderby s.Name
				select s).ToList();
			scheduleModel.ShowSharedSchedulesPopup = source.Any((ISchedule s) => s.Owner != currentUser);
		}
		return scheduleModel;
	}

	[ContentItem(Name = "SR.M('Мой календарь')", Root = true, Id = "SchedulerController.CalendarMyItemId", Image24 = "#user.svg")]
	public ActionResult My(string date)
	{
		ISchedule currentUserSchedule = ScheduleManager.Instance.GetCurrentUserSchedule();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = currentUserSchedule.Id,
			date = date
		});
	}

	public ActionResult View(long id, string date)
	{
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule == null)
		{
			base.Notifier.Error(SR.T("Календарь не найден"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		if (!base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) || !base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule))
		{
			base.Notifier.Error(SR.T("Нет доступа к календарю - {0}", schedule.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		ScheduleLogManager.Visit(schedule, base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).View("Index", (object)GenerateModel(schedule, date, null));
	}

	public ActionResult ViewFor(long userId, string date)
	{
		ISchedule userSchedule = ScheduleManager.Instance.GetUserSchedule(UserManager.Instance.LoadOrNull(userId));
		if (userSchedule == null)
		{
			base.Notifier.Error(SR.T("Календарь не найден"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		if (!base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, userSchedule) || !base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, userSchedule))
		{
			base.Notifier.Error(SR.T("Нет доступа к календарю - {0}", userSchedule.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		ScheduleLogManager.Visit(userSchedule, base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).View("Index", (object)GenerateModel(userSchedule, date, null));
	}

	public ActionResult ViewForListStateDay(long id, string date)
	{
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule == null)
		{
			base.Notifier.Error(SR.T("Календарь не найден"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		if (!base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) || !base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule))
		{
			base.Notifier.Error(SR.T("Нет доступа к календарю - {0}", schedule.Name.HtmlEncode()));
			return (ActionResult)(object)((Controller)this).RedirectToAction("My");
		}
		ScheduleLogManager.Visit(schedule, base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).View("Index", (object)GenerateModel(schedule, date, true, ScheduleMode.Day));
	}

	[ContentItem(Name = "SR.M('Сегодня')", Id = "SchedulerController.CalendarTodayItemId", Image24 = "#calendar_today.svg")]
	public ActionResult Today()
	{
		ScheduleModel scheduleModel = new ScheduleModel();
		scheduleModel.State.ViewDate = DateTime.Now;
		StateExtensions.SaveState(scheduleModel.State.Id, scheduleModel.State);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[ContentItem(Name = "SR.M('Календарь')", Root = true, Image24 = "#calendar.svg")]
	[ContentItem(Name = "SR.M('Переключатель дней')", Id = "SchedulerController.CalendarItems", Image24 = "#switch.svg")]
	[ContentItem(Name = "SR.M('Закладки')", Id = "SchedulerController.CalendarLogItems", Image24 = "#favorite_fill.svg")]
	public ActionResult Index(bool? forlist)
	{
		InstanceOf<IScheduleLogFilter> instanceOf = new InstanceOf<IScheduleLogFilter>();
		instanceOf.New.User = base.AuthenticationService.GetCurrentUser<IUser>();
		IScheduleLogFilter @new = instanceOf.New;
		if (forlist.HasValue)
		{
			ScheduleState state = new ScheduleModel().State;
			state.ListView = forlist.Value;
			StateExtensions.SaveState(state.Id, state);
		}
		List<IScheduleLog> source = (from sl in ScheduleLogManager.Find(@new, new FetchOptions(0, 1, ListSortDirection.Descending, "ViewDate"))
			where sl != null && sl.Schedule != null && base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule) && base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule)
			select sl).ToList();
		ISchedule schedule = (source.Any() ? source.First().Schedule : ScheduleManager.Instance.GetCurrentUserSchedule());
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = schedule.Id
		});
	}

	public ActionResult EventsList(long id, string calendarId, string mode, int delta, bool today)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule == null || !base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) || !base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule))
		{
			return (ActionResult)new EmptyResult();
		}
		ScheduleModel scheduleModel = new ScheduleModel();
		if (!string.IsNullOrEmpty(calendarId))
		{
			ScheduleState scheduleState = StateExtensions.LoadState<ScheduleState>(calendarId) ?? scheduleModel.State;
			if (!string.IsNullOrEmpty(mode))
			{
				scheduleState.SetMode(mode);
			}
			if (today)
			{
				scheduleState.ViewDate = DateTime.Now;
			}
			else if (delta != 0)
			{
				scheduleState.SetDelta(delta);
			}
			scheduleState.ListView = true;
			StateExtensions.SaveState(scheduleState.Id, scheduleState);
			scheduleModel = GenerateModel(schedule, scheduleState.ViewDate.ToShortDateString(), true);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Controls/ListGrid", (object)scheduleModel);
	}

	public ActionResult SaveScheduleState(string id, string mode, string date)
	{
		if (!string.IsNullOrEmpty(id))
		{
			ScheduleState scheduleState = StateExtensions.LoadState<ScheduleState>(id);
			if (scheduleState == null)
			{
				scheduleState = new ScheduleState
				{
					Id = id,
					ListView = false,
					Mode = ScheduleMode.Day,
					ViewDate = DateTime.Now
				};
			}
			scheduleState.SetMode(mode);
			if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var result))
			{
				scheduleState.ViewDate = result;
				((Controller)this).get_Session()["SchedulerController.LastVisitDate"] = result;
			}
			StateExtensions.SaveState(id, scheduleState);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	[RegisterContentAtStart]
	public ActionResult PopupView(long id, string date, string providerUid, string itemId, string itemTheme)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule == null || !base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) || !base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule))
		{
			return (ActionResult)new EmptyResult();
		}
		ScheduleModel scheduleModel = GenerateModel(schedule, date, false, null, 0, inPopup: true);
		if (!string.IsNullOrEmpty(providerUid) && !string.IsNullOrEmpty(itemId) && !string.IsNullOrEmpty(itemTheme))
		{
			CalendarPlannedItem calendarPlannedItem = default(CalendarPlannedItem);
			calendarPlannedItem.Id = itemId;
			calendarPlannedItem.Theme = itemTheme.HtmlEncode();
			CalendarPlannedItem calendarPlannedItem2 = calendarPlannedItem;
			scheduleModel.SelectedItem = new CalendarItemModel<ICalendarPlannedItem>(calendarPlannedItem2, new Guid(providerUid));
		}
		return (ActionResult)(object)((Controller)this).PartialView("Controls/FullCalendar", (object)scheduleModel);
	}

	public ActionResult PopupUserView(IUser user, string date, string providerUid, string itemId, string itemTheme)
	{
		ISchedule userSchedule = ScheduleManager.Instance.GetUserSchedule(user);
		return (ActionResult)(object)((Controller)this).RedirectToAction("PopupView", (object)new
		{
			id = userSchedule.Id,
			date = date,
			providerUid = providerUid,
			itemId = itemId,
			itemTheme = itemTheme
		});
	}

	public ActionResult AddFovarite(long id)
	{
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule != null && base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, schedule) && base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, schedule))
		{
			ScheduleLogManager.SetFavorite(schedule, base.AuthenticationService.GetCurrentUser<IUser>(), favorite: true);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult RemoveFovarite(long id)
	{
		ISchedule schedule = base.Manager.LoadOrNull(id);
		if (schedule != null)
		{
			ScheduleLogManager.SetFavorite(schedule, base.AuthenticationService.GetCurrentUser<IUser>(), favorite: false);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[CustomGridAction]
	public ActionResult PlannedGrid(GridCommand command, bool rePlaned, string searchString)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (command == null)
		{
			command = new GridCommand();
		}
		command.set_PageSize(10);
		IEnumerable<ICalendarItemSearchProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ICalendarItemSearchProvider>();
		List<CalendarItemModel<ICalendarPlannedItem>> list = extensionPoints.SelectMany((ICalendarItemSearchProvider p) => (rePlaned ? p.GetRePlannedItems(base.AuthenticationService.GetCurrentUser<IUser>(), searchString) : p.GetUnPlannedItems(base.AuthenticationService.GetCurrentUser<IUser>(), searchString)).Select((ICalendarPlannedItem i) => new CalendarItemModel<ICalendarPlannedItem>(i, p.Uid))).ToList();
		GridData<CalendarItemModel<ICalendarPlannedItem>> gridData = new GridData<CalendarItemModel<ICalendarPlannedItem>>
		{
			DataSource = command.ApplyPaging(list),
			IsAjax = true,
			IsPageable = true,
			PageSize = 10,
			Command = command,
			PageIndex = command.get_Page()
		};
		gridData.SetCount((GridData<CalendarItemModel<ICalendarPlannedItem>> d, FetchOptions f) => list.Count());
		return (ActionResult)(object)((Controller)this).PartialView("Controls/PlannedGrid", (object)gridData);
	}

	private string GetDate(DateTime date)
	{
		return date.ToCurrentFullFormat();
	}
}
