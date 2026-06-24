using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Calendar.Services;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.PeriodicalEntitySettings;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Calendar.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Calendar")]
[Permission("47DB2A47-0E59-420E-87E7-E85890750CA1")]
public class EventController : BPMController<ICalendarEvent, long>
{
	private class CalendarItemCompareStartDate : IComparer<ICalendarItem>
	{
		public int Compare(ICalendarItem x, ICalendarItem y)
		{
			if (x.StartDate > y.StartDate)
			{
				return 1;
			}
			if (x.StartDate < y.StartDate)
			{
				return -1;
			}
			return 0;
		}
	}

	public ScheduleManager ScheduleManager { get; set; }

	public CalendarEventPeriodicalManager PeriodicalManager { get; set; }

	public UserManager UserManager { get; set; }

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[NotNull]
	public IAvailableTimeSlotsService AvailableTimeSlotsService { get; set; }

	[NotNull]
	public IProductionCalendarService ProductionCalendarService { get; set; }

	[NotNull]
	public new CalendarEventManager Manager => Locator.GetServiceNotNull<CalendarEventManager>();

	private ICollection<ISchedule> GetAvalibleSchedules()
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Shared = true;
		scheduleFilter.PermissionId = PermissionProvider.ScheduleEditPermission.Id;
		return ScheduleManager.Find(scheduleFilter, FetchOptions.All);
	}

	private CalendarEventModel CreateModel(string start, string end, long[] idUsers = null, long? scheduleId = null, bool forAll = false, bool forDepartment = false)
	{
		DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 30 * Convert.ToInt32(DateTime.Now.Minute / 30), 0);
		DateTime dateTime2 = (string.IsNullOrEmpty(start) ? dateTime : DateTime.Parse(start));
		DateTime endDate = (string.IsNullOrEmpty(end) ? dateTime2.AddMinutes(30.0) : DateTime.Parse(end));
		CalendarEventModel calendarEventModel = new CalendarEventModel(InterfaceActivator.Create<ICalendarEventPeriodical>(), ViewType.Create);
		calendarEventModel.Entity.StartDate = dateTime2;
		calendarEventModel.Entity.EndDate = endDate;
		calendarEventModel.Entity.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		((ICalendarEventPeriodical)calendarEventModel.Entity).UntilDate = dateTime2;
		ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
		calendarEventUser.User = calendarEventModel.Entity.CreationAuthor;
		calendarEventUser.Status = CalendarEventUserStatus.Participant;
		calendarEventUser.Event = calendarEventModel.Entity;
		calendarEventModel.Entity.EventUsers.Add(calendarEventUser);
		if (forAll || forDepartment)
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.ShowBlock = false;
			userFilter.ShowOnlySubordinateAndSelf = forDepartment;
			foreach (IUser item in UserManager.Find(userFilter, FetchOptions.All))
			{
				if (item.Id != calendarEventModel.Entity.CreationAuthor.Id)
				{
					try
					{
						ICalendarEventUser calendarEventUser2 = InterfaceActivator.Create<ICalendarEventUser>();
						calendarEventUser2.User = item;
						calendarEventUser2.Status = CalendarEventUserStatus.Participant;
						calendarEventUser2.Event = calendarEventModel.Entity;
						calendarEventModel.Entity.EventUsers.Add(calendarEventUser2);
					}
					catch
					{
					}
				}
			}
		}
		else if (idUsers != null && idUsers.Length != 0)
		{
			foreach (long num in idUsers)
			{
				if (num != calendarEventModel.Entity.CreationAuthor.Id)
				{
					try
					{
						ICalendarEventUser calendarEventUser3 = InterfaceActivator.Create<ICalendarEventUser>();
						calendarEventUser3.User = UserManager.Load(num);
						calendarEventUser3.Status = CalendarEventUserStatus.Participant;
						calendarEventUser3.Event = calendarEventModel.Entity;
						calendarEventModel.Entity.EventUsers.Add(calendarEventUser3);
					}
					catch
					{
					}
				}
			}
		}
		calendarEventModel.AllowSchedules = GetAvalibleSchedules();
		if (scheduleId.HasValue)
		{
			ISchedule schedule = null;
			try
			{
				schedule = ScheduleManager.LoadOrNull(scheduleId.Value);
			}
			catch (Exception)
			{
			}
			if (schedule != null)
			{
				if (schedule.Owner != null && ((IEnumerable<ICalendarEventUser>)calendarEventModel.Entity.EventUsers).All((ICalendarEventUser eu) => eu.User.Id != schedule.Owner.Id))
				{
					try
					{
						ICalendarEventUser calendarEventUser4 = InterfaceActivator.Create<ICalendarEventUser>();
						calendarEventUser4.User = schedule.Owner;
						calendarEventUser4.Status = CalendarEventUserStatus.Participant;
						calendarEventUser4.Event = calendarEventModel.Entity;
						calendarEventModel.Entity.EventUsers.Add(calendarEventUser4);
					}
					catch
					{
					}
				}
				else if (calendarEventModel.AllowSchedules.Any() && schedule.Owner == null)
				{
					calendarEventModel.Entity.Schedules.Add(schedule);
				}
			}
		}
		calendarEventModel.Entity.IsPrivate = false;
		return calendarEventModel;
	}

	[ContentItem(Name = "SR.M('Создать событие')", Id = "calendar-create-event", Image24 = "#add_event.svg")]
	public ActionResult Create(string start, string end, long[] idUsers = null, long? schedule = null, bool forAll = false, bool forDepartment = false, long[] participants = null, long[] informers = null, string subject = null, string place = null)
	{
		base.ViewTitle = SR.T("Календарь - Событие");
		CalendarEventModel calendarEventModel = CreateModel(TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), idUsers, schedule, forAll, forDepartment);
		if ((participants != null && participants.Length != 0) || (informers != null && informers.Length != 0))
		{
			((ICollection<ICalendarEventUser>)calendarEventModel.Entity.EventUsers).Clear();
		}
		if (participants != null && participants.Length != 0)
		{
			long[] array = participants;
			foreach (long id in array)
			{
				ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser.Event = calendarEventModel.Entity;
				calendarEventUser.Status = CalendarEventUserStatus.Participant;
				calendarEventUser.User = UserManager.Instance.Load(id);
				calendarEventModel.Entity.EventUsers.Add(calendarEventUser);
			}
		}
		if (informers != null && informers.Length != 0)
		{
			long[] array = informers;
			foreach (long id2 in array)
			{
				ICalendarEventUser calendarEventUser2 = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser2.Event = calendarEventModel.Entity;
				calendarEventUser2.Status = CalendarEventUserStatus.InfromTo;
				calendarEventUser2.User = UserManager.Instance.Load(id2);
				calendarEventModel.Entity.EventUsers.Add(calendarEventUser2);
			}
		}
		if (!string.IsNullOrEmpty(subject))
		{
			calendarEventModel.Entity.Subject = subject;
		}
		if (!string.IsNullOrEmpty(place))
		{
			calendarEventModel.Entity.Place = place;
		}
		return (ActionResult)(object)((Controller)this).View((object)calendarEventModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Create(CalendarEventModel model)
	{
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View("Create", (object)model);
		}
		if (model.PeriodicalEntity != null && model.StopRepeat && model.PeriodicalEntity.UntilDate < model.Entity.StartDate.Date)
		{
			base.Notifier.Error(SR.T("Дата завершения периодического события должна быть позже даты начала"));
			model.ApplyUsers();
			return (ActionResult)(object)((Controller)this).View("Create", (object)model);
		}
		if (model.PeriodicalEntity != null && model.Period.HasValue)
		{
			IPeriodicalEntitySettings settingsFromModel;
			try
			{
				settingsFromModel = GetSettingsFromModel(model);
			}
			catch (Exception exception)
			{
				base.Logger.Error(SR.T("Ошибка при извлечении настроек периодического события"), exception);
				base.Notifier.Error(SR.T("Ошибка при извлечении настроек периодического события"));
				return (ActionResult)(object)((Controller)this).View("Create", (object)model);
			}
			if (settingsFromModel != null && !IsValidSettings(settingsFromModel))
			{
				base.Notifier.Error(SR.T("Некорректные настройки периодического события"));
				return (ActionResult)(object)((Controller)this).View("Create", (object)model);
			}
			if (settingsFromModel != null)
			{
				model.PeriodicalEntity.SetPeriodicalEntitySettings(settingsFromModel);
			}
		}
		CreateEvent(model);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Scheduler");
	}

	private ICalendarEvent CreateEvent(CalendarEventModel model)
	{
		model.ApplyUsers();
		model.BindSchedules(GetAvalibleSchedules());
		Manager.ResetConfirmationForUsers(model.Entity);
		ICalendarEventPeriodical periodicalEntity = model.PeriodicalEntity;
		if (periodicalEntity != null && model.Period.HasValue)
		{
			periodicalEntity.Period = model.Period.Value;
			if (!model.StopRepeat)
			{
				periodicalEntity.UntilDate = null;
			}
			PeriodicalManager.Save(periodicalEntity);
			PeriodicalManager.CreatingPeriodicEntities(periodicalEntity, continueFromLastDate: false);
		}
		else
		{
			Manager.Save(model.Entity);
		}
		return model.Entity;
	}

	private bool IsValidSettings(IPeriodicalEntitySettings settings)
	{
		return settings.RepeatEvery > 0;
	}

	private IPeriodicalEntitySettings GetSettingsFromModel(CalendarEventModel model)
	{
		if (model.PeriodicalEntitySettings.IsNullOrEmpty() || !model.Period.HasValue)
		{
			return null;
		}
		return model.Period.Value.DeserializeSettings(model.PeriodicalEntitySettings);
	}

	public ActionResult ChangeTime(long id)
	{
		CalendarEventModel calendarEventModel = new CalendarEventModel(Manager.Load(id), ViewType.Edit)
		{
			CurrentUser = base.AuthenticationService.GetCurrentUser<IUser>()
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/ChangeTime", (object)calendarEventModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult ChangeTime(CalendarEventModel model)
	{
		if (Manager.CanChangeTime(model.Entity, model.Entity.StartDate, model.Entity.EndDate, null))
		{
			Manager.ChangeTime(model.Entity, model.Entity.StartDate, model.Entity.EndDate, model.Comment);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
		{
			id = model.Entity.Id
		});
	}

	public ActionResult Edit(long id)
	{
		base.ViewTitle = string.Format("{0} - {1} - {2}", SR.Calendar, SR.T("Событие"), SR.T("Просмотр"));
		ICalendarEvent calendarEvent = Manager.Load(id);
		if (!Manager.CanEdit(calendarEvent))
		{
			base.Notifier.Error(SR.T("Нет доступа на изменения события - {0}", calendarEvent.Subject));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
			{
				id = calendarEvent.Id
			});
		}
		CalendarEventModel calendarEventModel = new CalendarEventModel(calendarEvent.CastAsRealType(), ViewType.Edit)
		{
			CurrentUser = base.AuthenticationService.GetCurrentUser<IUser>(),
			CanEdit = true,
			AllowSchedules = GetAvalibleSchedules()
		};
		ICalendarEventPeriodical periodicalEntity = calendarEventModel.PeriodicalEntity;
		if (periodicalEntity != null && (!periodicalEntity.UntilDate.HasValue || periodicalEntity.UntilDate.Value.EqualsUpToMinute(DateTime.MaxValue)))
		{
			periodicalEntity.UntilDate = ((calendarEvent.StartDate > DateTime.Now) ? calendarEvent.StartDate : DateTime.Now);
		}
		return (ActionResult)(object)((Controller)this).View("Create", (object)calendarEventModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Edit(CalendarEventModel model)
	{
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View("Create", (object)model);
		}
		if (!Manager.CanEdit(model.Entity))
		{
			base.Notifier.Error(SR.T("Нет доступа на изменения события - {0}", model.Entity.Subject));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
			{
				id = model.Entity.Id
			});
		}
		if (model.PeriodicalEntity != null && model.Period.HasValue)
		{
			IPeriodicalEntitySettings settingsFromModel;
			try
			{
				settingsFromModel = GetSettingsFromModel(model);
			}
			catch (Exception exception)
			{
				base.Logger.Error(SR.T("Ошибка при извлечении настроек периодического события"), exception);
				base.Notifier.Error(SR.T("Ошибка при извлечении настроек периодического события"));
				return (ActionResult)(object)((Controller)this).View("Create", (object)model);
			}
			if (settingsFromModel != null && !IsValidSettings(settingsFromModel))
			{
				base.Notifier.Error(SR.T("Некорректные настройки периодического события"));
				return (ActionResult)(object)((Controller)this).View("Create", (object)model);
			}
			if (settingsFromModel != null)
			{
				model.PeriodicalEntity.SetPeriodicalEntitySettings(settingsFromModel);
			}
		}
		if (((Controller)this).TryValidateModel((object)model.Entity))
		{
			model.ApplyUsers();
			model.BindSchedules(GetAvalibleSchedules());
			ICalendarEventPeriodical periodicalEntity = model.PeriodicalEntity;
			if (periodicalEntity != null && model.Period.HasValue)
			{
				periodicalEntity.Period = model.Period.Value;
				if (!model.StopRepeat)
				{
					periodicalEntity.UntilDate = null;
				}
				IPeriodicalEntitySettings periodicalEntitySettings = periodicalEntity.GetPeriodicalEntitySettings();
				IPeriodicalEntitySettings obj = ((model.OldPeriod.HasValue && !model.OldPeriodicalEntitySettings.IsNullOrEmpty()) ? model.OldPeriod.Value.DeserializeSettings(model.OldPeriodicalEntitySettings) : null);
				if (model.OldPeriod != periodicalEntity.Period || (periodicalEntitySettings != null && !periodicalEntitySettings.Equals(obj)))
				{
					PeriodicalManager.ChangePeriodicity(periodicalEntity);
				}
				else if (!model.Entity.StartDate.EqualsUpToMinute(model.OldStartDate) || !model.Entity.EndDate.EqualsUpToMinute(model.OldEndDate))
				{
					PeriodicalManager.ChangeEventsDates(periodicalEntity, model.OldStartDate, model.OldEndDate);
				}
				else
				{
					PeriodicalManager.UpdateEvents(periodicalEntity);
				}
			}
			else if ((model.Entity.ConfirmParticipation && (!model.Entity.StartDate.EqualsUpToMinute(model.OldStartDate) || !model.Entity.EndDate.EqualsUpToMinute(model.OldEndDate))) || (model.Entity.ConfirmParticipation != model.OldConfirmParticipation && model.Entity.ConfirmParticipation))
			{
				Manager.ResetConfirmationForUsers(model.Entity);
			}
			((IEnumerable<ICalendarEventUser>)model.Entity.EventUsers).Where((ICalendarEventUser eu) => eu.IsNew()).ForEach(delegate(ICalendarEventUser eu)
			{
				eu.Save();
			});
			model.Entity.Save();
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, model.Entity, "81e2a8ae-ab4c-4cfd-ab95-21c604c581c3"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Scheduler");
	}

	public ActionResult GetEventSettings(Periodicity periodicity, string settingsData)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		IPeriodicalEntitySettings periodicalEntitySettings = periodicity.DeserializeSettings(settingsData);
		return (ActionResult)(periodicity switch
		{
			Periodicity.Weekly => ((Controller)this).PartialView("Periodicity/WeeklySettings", (object)(WeeklyPeriodicalEntitySettings)periodicalEntitySettings), 
			Periodicity.Monthly => ((Controller)this).PartialView("Periodicity/MonthlySettings", (object)(MonthlyPeriodicalEntitySettings)periodicalEntitySettings), 
			_ => (object)new EmptyResult(), 
		});
	}

	[TransactionAction]
	public virtual ActionResult Delete(long id, bool? all)
	{
		ICalendarEvent calendarEvent = Manager.Load(id);
		if (!Manager.CanDeleteEvent(calendarEvent, all ?? false))
		{
			base.Notifier.Error(SR.T("Нет доступа на изменения события - {0}", calendarEvent.Subject));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
			{
				id = calendarEvent.Id
			});
		}
		Manager.DeleteEvent(calendarEvent, all ?? false);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Scheduler");
	}

	public ActionResult View(long id)
	{
		ICalendarEvent calendarEvent = Manager.Load(id);
		base.ViewTitle = string.Format("{0} - {1} - {2}", SR.Calendar, SR.T("Событие"), SR.T("Просмотр"));
		CalendarEventModel calendarEventModel = new CalendarEventModel(calendarEvent, ViewType.Display)
		{
			CurrentUser = base.AuthenticationService.GetCurrentUser<IUser>(),
			CanEdit = Manager.CanEdit(calendarEvent),
			CanEditAll = Manager.CanDeleteEvent(calendarEvent, all: true)
		};
		ICalendarEventUser calendarEventUser = ((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).FirstOrDefault((ICalendarEventUser eu) => eu.User.Id == base.AuthenticationService.GetCurrentUser<IUser>().Id && eu.Status == CalendarEventUserStatus.Participant);
		if (calendarEventUser != null && calendarEvent.ConfirmParticipation && !calendarEvent.Completed && !(calendarEvent is ICalendarEventPeriodical))
		{
			calendarEventModel.ShowConfirmParticipation = calendarEventUser.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.None || calendarEventUser.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.NotConfirmed;
			calendarEventModel.ShowNotConfirmParticipation = calendarEventUser.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.None || calendarEventUser.Confirmed == EleWise.ELMA.Calendar.Models.ConfirmParticipation.Confirmed;
		}
		SetAsReadForFeed(calendarEvent);
		return (ActionResult)(object)((Controller)this).View((object)calendarEventModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult ConfirmParticipation([NotNull][Bind(Prefix = "ConfirmParticipation")] CommentWithAttachments commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ICalendarEvent calendarEvent = Manager.Load(commentModel.ObjectId);
		string text = Manager.ConfirmParticipation(calendarEvent, base.AuthenticationService.GetCurrentUser<IUser>(), EleWise.ELMA.Calendar.Models.ConfirmParticipation.Confirmed, commentModel.ActionModel);
		if (!string.IsNullOrEmpty(text))
		{
			MvcHtmlString text2 = MvcHtmlString.Create(string.Format("{0} <a href='{2}'>{1}</a>", text.HtmlEncode(), calendarEvent.Subject.HtmlEncode(), ((Controller)this).get_Url().Entity(calendarEvent)));
			base.Notifier.Information(text2);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = commentModel.ObjectId
		});
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult NotConfirmParticipation([NotNull][Bind(Prefix = "NotConfirmParticipation")] CommentWithAttachments commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ICalendarEvent calendarEvent = Manager.Load(commentModel.ObjectId);
		string text = Manager.ConfirmParticipation(calendarEvent, base.AuthenticationService.GetCurrentUser<IUser>(), EleWise.ELMA.Calendar.Models.ConfirmParticipation.NotConfirmed, commentModel.ActionModel);
		if (!string.IsNullOrEmpty(text))
		{
			MvcHtmlString text2 = MvcHtmlString.Create(string.Format("{0} <a href='{2}'>{1}</a>", text.HtmlEncode(), calendarEvent.Subject.HtmlEncode(), ((Controller)this).get_Url().Entity(calendarEvent)));
			base.Notifier.Information(text2);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = commentModel.ObjectId
		});
	}

	[TransactionAction]
	public virtual string CompleteEvent(long id)
	{
		ICalendarEvent @event = Manager.Load(id);
		if (!Manager.CanEdit(@event))
		{
			return "False";
		}
		Manager.CompleteEvent(@event, null);
		return "Ok";
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult CompleteEvent(CommentWithAttachments model)
	{
		ICalendarEvent calendarEvent = Manager.Load(model.ObjectId);
		if (!Manager.CanEdit(calendarEvent))
		{
			base.Notifier.Error(SR.T("Нет доступа на изменения события - " + calendarEvent.Subject));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
			{
				id = calendarEvent.Id
			});
		}
		Manager.CompleteEvent(calendarEvent, model.ActionModel);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Scheduler");
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult CrossingEvents([JsonBinder] CrossingModel model)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		if (model == null)
		{
			ContentResult val = new ContentResult();
			val.set_Content(SR.T("Ошибка получения данных"));
			return (ActionResult)val;
		}
		List<ISchedule> list = new List<ISchedule>();
		InstanceOf<IScheduleFilter> instanceOf = new InstanceOf<IScheduleFilter>();
		instanceOf.New.Owners = (ISet<IUser>)(object)new HashedSet<IUser>();
		instanceOf.New.DisableSecurity = true;
		IScheduleFilter @new = instanceOf.New;
		if (model.UserIds == null && model.ScheduleIds == null)
		{
			if (model.CurrentTypeUid.HasValue && model.CurrentId.HasValue)
			{
				foreach (ICrossingCalendarProvider item in from point in ComponentManager.Current.GetExtensionPoints<ICrossingCalendarProvider>()
					where point.TypeUids.Contains(model.CurrentTypeUid.Value)
					select point)
				{
					item.FillData(model.CurrentTypeUid.Value, model.CurrentId.Value, (ICollection<IUser>)@new.Owners, list);
				}
			}
		}
		else
		{
			if (model.UserIds != null && model.UserIds.Any())
			{
				long[] userIds = model.UserIds;
				foreach (long id2 in userIds)
				{
					@new.Owners.Add(UserManager.Load(id2));
				}
			}
			if (model.ScheduleIds != null && model.ScheduleIds.Any())
			{
				list.AddRange(model.ScheduleIds.Select((long id) => ScheduleManager.Load(id)));
			}
		}
		if (((IEnumerable<IUser>)@new.Owners).Any())
		{
			list.AddRange(ScheduleManager.Find(@new, FetchOptions.All).ToList());
		}
		if (!list.Any())
		{
			return (ActionResult)new EmptyResult();
		}
		DateTime dateTime = DateTime.Parse(model.StartDate).ToRuntimeDateTimeFromClient();
		DateTime dateTime2 = DateTime.Parse(model.EndDate).ToRuntimeDateTimeFromClient();
		if (dateTime > dateTime2)
		{
			ContentResult val2 = new ContentResult();
			val2.set_Content(SR.T("Дата начала события больше даты окончания"));
			return (ActionResult)val2;
		}
		if (dateTime == dateTime2)
		{
			return (ActionResult)new EmptyResult();
		}
		CrossedEventsModel crossedEventsModel = new CrossedEventsModel();
		crossedEventsModel.CrossedEvents = Manager.CrossingEvents(list, dateTime, dateTime2, model.CurrentId, model.CurrentTypeUid);
		foreach (KeyValuePair<ISchedule, List<ICalendarItem>> crossedEvent in crossedEventsModel.CrossedEvents)
		{
			crossedEvent.Value.Sort(new CalendarItemCompareStartDate());
		}
		crossedEventsModel.UserIds = ((model.UserIds != null && model.UserIds.Any()) ? model.UserIds : ((IEnumerable<IUser>)@new.Owners).Select((IUser m) => m.Id).ToArray());
		IEnumerable<ICalendarItem> source = crossedEventsModel.CrossedEvents.SelectMany((KeyValuePair<ISchedule, List<ICalendarItem>> e) => e.Value);
		if (!crossedEventsModel.CrossedEvents.Any() || !source.Any())
		{
			return (ActionResult)new EmptyResult();
		}
		((ControllerBase)this).get_ViewData().set_Item("SubmitForm", (object)model.SubmitForm);
		((ControllerBase)this).get_ViewData().set_Item("PopupId", (object)model.PopupId);
		((ControllerBase)this).get_ViewData().set_Item("StartDate", (object)model.StartDate);
		((ControllerBase)this).get_ViewData().set_Item("OnSubmitScript", (object)model.OnSubmitScript);
		((ControllerBase)this).get_ViewData().set_Item("SubmitScript", (object)model.SubmitScript);
		return (ActionResult)(object)((Controller)this).PartialView("Partial/CrossedEventsWindow", (object)crossedEventsModel);
	}

	public DateTime DateFromDatePicker(string day)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(day)).ToLocalTime();
	}

	[TransactionAction]
	public virtual ActionResult AddDay(CalendarEventAddDayModel calendarEventAddDayModel)
	{
		ICalendarEvent calendarEvent = Manager.Load(calendarEventAddDayModel.EntityId);
		if (!Manager.CanEdit(calendarEvent))
		{
			base.Notifier.Error(SR.T("Нет доступа на изменения события - " + calendarEvent.Subject));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Event", (object)new
			{
				id = calendarEvent.Id
			});
		}
		if (!string.IsNullOrEmpty(calendarEventAddDayModel.Comment))
		{
			IComment comment = InterfaceActivator.Create<IComment>();
			comment.Text = calendarEventAddDayModel.Comment;
			comment.Save();
			calendarEvent.Comments.Add(comment);
		}
		if (calendarEventAddDayModel.UseDates)
		{
			Manager.ChangeTime(calendarEvent, calendarEventAddDayModel.StartDate, calendarEventAddDayModel.EndDate, null);
		}
		else
		{
			Manager.ChangeTime(calendarEvent, calendarEvent.StartDate.AddDays(1.0), calendarEvent.EndDate.AddDays(1.0), null);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", (object)new
		{
			id = calendarEventAddDayModel.EntityId
		});
	}

	public ActionResult SearchAvailableTimeSlotsPopup(AvailableTimeSearch model)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		Contract.ArgumentNotNull(model, "model");
		if (model.UserIds == null || !model.UserIds.Any())
		{
			return (ActionResult)new EmptyResult();
		}
		AvailableTimeResult availableTimeResult = new AvailableTimeResult(model);
		availableTimeResult.EndDate = ProductionCalendarService.AddDays(availableTimeResult.StartDate, 4) + availableTimeResult.StartDate.TimeOfDay;
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(availableTimeResult.Prefix);
		return (ActionResult)(object)((Controller)this).PartialView("Partial/AvailableTimePopup", (object)availableTimeResult);
	}

	public ActionResult FindAvailableTimeSlotsJson(AvailableTimeResult model)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		Contract.ArgumentNotNull(model, "model");
		if (model.EndDate <= model.StartDateToPaging)
		{
			return (ActionResult)new EmptyResult();
		}
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("Partial/AvailableTimeSlots");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(FindAvailableTimeSlotsInner(model));
		HtmlCatchViewResult htmlCatchViewResult2 = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new HtmlCatchViewResult[1] { htmlCatchViewResult2 }, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			Dictionary<string, object> obj = new Dictionary<string, object>
			{
				["html"] = ((HtmlCatchViewResult)(object)results.First()).HtmlResult,
				["startDateToPaging"] = ((ControllerBase)this).get_ViewData().get_Item("startDateToPaging")
			};
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(obj.ToJson());
		});
	}

	public ActionResult FindAvailableTimeSlotsView(AvailableTimeResult model)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Contract.ArgumentNotNull(model, "model");
		PartialViewResult val = new PartialViewResult();
		((ViewResultBase)val).set_ViewName("Partial/AvailableTimeSlots");
		((ViewResultBase)val).set_ViewData(FindAvailableTimeSlotsInner(model));
		return (ActionResult)val;
	}

	private ViewDataDictionary FindAvailableTimeSlotsInner(AvailableTimeResult model)
	{
		List<TimeSlot> list = new List<TimeSlot>();
		List<ISchedule> list2 = new List<ISchedule>();
		List<ICalendarItem> list3 = new List<ICalendarItem>();
		TimeSlot[] array = new TimeSlot[1] { DatesPaging(model.StartDate, model.EndDate, model.StartDateToPaging) };
		long[] idArray = ClassSerializationHelper.DeserializeObjectByJson<long[]>(model.UserIds).Distinct().ToArray();
		if (model.ScheduleIds != null && model.ScheduleIds.Any())
		{
			list2.AddRange(model.ScheduleIds.Select((long id) => ScheduleManager.Load(id)));
			foreach (ISchedule item in list2)
			{
				CalendarItemCollection calendarItems = Manager.GetCalendarItems(model.StartDate, model.EndDate, item);
				list3.AddRange(calendarItems.Items);
			}
		}
		list = AvailableTimeSlotsService.GetIntervals(UserManager.FindByIdArray(idArray), list3, array).ToList();
		((ControllerBase)this).get_ViewData().set_Model((object)new AvailableTimeSlots
		{
			AvailableTimeSlotsByDays = CutToParts(list, model.Duration),
			Prefix = model.Prefix
		});
		DateTime dateTime = ((model.EndDate >= array[0].EndDate) ? array[0].EndDate : default(DateTime));
		((ControllerBase)this).get_ViewData().set_Item("startDateToPaging", (object)dateTime.ToString());
		return ((ControllerBase)this).get_ViewData();
	}

	private TimeSlot DatesPaging(DateTime startDate, DateTime endDate, DateTime startDateToPaging)
	{
		DateTime dateTime = ((startDateToPaging > DateTime.MinValue) ? startDateToPaging : startDate);
		DateTime dateTime2 = ProductionCalendarService.AddDays(dateTime, 5);
		if (endDate <= dateTime2)
		{
			dateTime2 = endDate;
		}
		return new TimeSlot(dateTime, dateTime2);
	}

	private IEnumerable<IGrouping<DateTime, TimeSlot>> CutToParts(IEnumerable<TimeSlot> bigSlots, EventDuration eventDuration)
	{
		TimeSpan value = TimeSpan.FromMinutes((double)eventDuration);
		List<TimeSlot> list = new List<TimeSlot>();
		foreach (TimeSlot bigSlot in bigSlots)
		{
			DateTime startDate = bigSlot.StartDate;
			DateTime dateTime = startDate.Add(value);
			while (dateTime <= bigSlot.EndDate)
			{
				list.Add(new TimeSlot(startDate, dateTime));
				startDate = dateTime;
				dateTime = startDate.Add(value);
			}
		}
		return from m in list
			group m by m.StartDate.Date;
	}
}
