using System;
using System.Linq;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.PeriodicalEntitySettings;
using EleWise.ELMA.Common.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Newtonsoft.Json.Converters;
using NHibernate;

namespace EleWise.ELMA.Common.Extensions;

public static class PeriodicalEntityHelper
{
	public static IProductionCalendarService ProductionCalendar => Locator.GetServiceNotNull<IProductionCalendarService>();

	private static int Month(DateTime date)
	{
		return date.Year * 12 + date.Month;
	}

	private static DateTime MoveBeforeHoliday(DateTime date, bool moveBeforeHoliday)
	{
		IProductionSchedule globalProductionSchedule = Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule();
		while (moveBeforeHoliday && !globalProductionSchedule.IsWorkDay(date))
		{
			date = date.AddDays(-1.0);
		}
		return date;
	}

	internal static DateTime GetNextDate(DateTime fromDate, DateTime currentDate, Func<DateTime, DateTime, int> countFunc, Func<DateTime, int, DateTime> addFunc, bool moveBeforeHoliday)
	{
		int num = countFunc(fromDate, currentDate);
		DateTime dateTime = MoveBeforeHoliday(addFunc(fromDate, num), moveBeforeHoliday);
		while (dateTime <= currentDate)
		{
			dateTime = MoveBeforeHoliday(addFunc(fromDate, ++num), moveBeforeHoliday);
		}
		return dateTime;
	}

	public static DateTime GetNextDate(this Periodicity period, DateTime currentDate)
	{
		return period.GetNextDate(currentDate, currentDate);
	}

	public static DateTime GetNextDate(this IPeriodicalEntity template, DateTime currentDate)
	{
		return template.Period.GetNextDate(currentDate, currentDate);
	}

	public static DateTime GetNextDate(this IPeriodicalEntity template, DateTime fromDate, DateTime currentDate)
	{
		return template.Period.GetNextDate(fromDate, currentDate);
	}

	public static DateTime MoveDate(Periodicity period, DateTime oldEventDate, DateTime oldTemplateDate, DateTime newTemplateDate)
	{
		if (period == Periodicity.WorkingDays)
		{
			IProductionSchedule globalProductionSchedule = ProductionCalendar.GetGlobalProductionSchedule();
			return newTemplateDate.AddDays((globalProductionSchedule.AddDays(addDays: globalProductionSchedule.GetWorkDays(oldTemplateDate, oldEventDate) - 1, startRuntimeDateTime: newTemplateDate).Date - newTemplateDate.Date).Days);
		}
		TimeSpan timeSpan = oldTemplateDate - newTemplateDate;
		return GetNextDate(currentDate: (oldEventDate - timeSpan).AddMinutes(-1.0), period: period, fromDate: newTemplateDate);
	}

	public static DateTime GetNextDate(this Periodicity period, DateTime fromDate, DateTime currentDate, bool moveBeforeHoliday = false)
	{
		IProductionSchedule globalProductionSchedule = Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule();
		switch (period)
		{
		case Periodicity.Monthly:
			return GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => Month(c) - Month(f), (DateTime d, int c) => d.AddMonths(c), moveBeforeHoliday);
		case Periodicity.Quarterly:
			return GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (Month(c) - Month(f)) / 3, (DateTime d, int c) => d.AddMonths(c * 3), moveBeforeHoliday);
		case Periodicity.Yearly:
			return GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => c.Year - f.Year, (DateTime d, int c) => d.AddYears(c), moveBeforeHoliday);
		case Periodicity.Weekly:
			return GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (int)(c - f).TotalDays / 7, (DateTime d, int c) => d.AddDays(c * 7), globalProductionSchedule.IsWorkDay(fromDate) && moveBeforeHoliday);
		case Periodicity.WorkingDays:
		{
			DateTime dateTime = GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (int)(c - f).TotalDays, (DateTime d, int c) => d.AddDays(c), moveBeforeHoliday: false);
			while (!globalProductionSchedule.IsWorkDay(dateTime))
			{
				dateTime = dateTime.AddDays(1.0);
			}
			return dateTime;
		}
		default:
			return GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (int)(c - f).TotalDays, (DateTime d, int c) => d.AddDays(c), moveBeforeHoliday: false);
		}
	}

	public static void CopyReminders(this IPeriodicalEntity template, IEntity entity)
	{
		if (template.IsNew())
		{
			return;
		}
		foreach (IReminder item in from rt in ReminderManager.Instance.Find((IReminder f) => f.RefObject == ReferenceOnEntity.Create(template))
			select ReminderManager.Instance.CreateByTemplate(rt, entity) into r
			where r != null
			select r)
		{
			item.Save();
		}
	}

	public static void UpdateUntilDate(this IPeriodicalEntity template, DateTime date)
	{
		string tableName = ((EntityMetadata)MetadataLoader.LoadMetadata(template.CastAsRealType().GetType())).TableName;
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession(string.Empty);
		((IQuery)session.CreateSQLQuery(string.Format("UPDATE {0} SET {1}=? WHERE {2}=?", serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded("LastPeriodDate"), serviceNotNull.Dialect.QuoteIfNeeded("Id")))).SetParameter<DateTime>(0, date).SetParameter(1, template.GetId()).ExecuteUpdate(cleanUpCache: false);
		session.CleanUpCache(template);
		template.LastPeriodDate = date;
	}

	internal static IPeriodicalEntitySettings CreateSettingsFromEntity(this IPeriodicalEntityExtension periodicalEntity)
	{
		return ((CustomCreationConverter<IPeriodicalEntitySettings>)new PeriodicalEntitySettingsCustomCreationConverter(periodicalEntity)).Create((Type)null);
	}

	public static IPeriodicalEntitySettings GetPeriodicalEntitySettings(this IPeriodicalEntityExtension periodicalEntity)
	{
		return periodicalEntity.Period.DeserializeSettings(periodicalEntity.SettingsData);
	}

	public static string GetSerializedPeriodicalEntitySettings(this IPeriodicalEntityExtension periodicalEntity)
	{
		return PeriodicalEntitySettingsSerializer.Serialize(periodicalEntity.GetPeriodicalEntitySettings() ?? periodicalEntity.CreateSettingsFromEntity());
	}

	public static IPeriodicalEntitySettings DeserializeSettings(this Periodicity period, string data)
	{
		return PeriodicalEntitySettingsSerializer.Deserialize(period, data);
	}

	public static void SetPeriodicalEntitySettings(this IPeriodicalEntityExtension periodicalEntity, IPeriodicalEntitySettings settings)
	{
		periodicalEntity.SettingsData = PeriodicalEntitySettingsSerializer.Serialize(settings);
	}

	public static void CreatePeriodicalEntity(this IPeriodicalEntityManager manager, IPeriodicalEntity template, bool continueFromLastDate, bool startDateIsMain, bool useProductionCalendar, bool moveBeforeHoliday)
	{
		if (template == null || template.Closed)
		{
			return;
		}
		if (template.UntilDate.HasValue && template.UntilDate < DateTime.Today)
		{
			template.Closed = true;
			template.Save();
			return;
		}
		DateTime dateTime = DateTime.Today;
		long num = manager.CountByTemplate(template, dateTime);
		int forwardCreated = template.ForwardCreated;
		if (forwardCreated <= 0)
		{
			forwardCreated = manager.GetForwardCreated();
		}
		if (num >= forwardCreated || (template.UntilDate.HasValue && template.LastPeriodDate.HasValue && template.Period.GetNextDate(template.LastPeriodDate.Value).Date > template.UntilDate.Value.Date))
		{
			return;
		}
		if (Locator.GetServiceNotNull<IUnitOfWorkManager>().HasActiveTransaction(string.Empty))
		{
			PeriodicalEntityPostCommitListener.AddUpdatePeriodicalEntity(manager, template, continueFromLastDate);
			return;
		}
		DateTime startDate = template.StartDate;
		DateTime endDate = template.EndDate;
		if (startDate > dateTime)
		{
			dateTime = startDate.Date;
		}
		IProductionSchedule globalProductionSchedule = Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule();
		Func<Periodicity, DateTime, DateTime, bool, DateTime> func = GetNextDate;
		IPeriodicalEntitySettings entitySettings;
		if (template is IPeriodicalEntityExtension periodicalEntity && (entitySettings = periodicalEntity.GetPeriodicalEntitySettings()) != null)
		{
			func = (Periodicity p, DateTime f, DateTime c, bool m) => entitySettings.GetNextDate(f, c);
		}
		TimeSpan timeSpan = (useProductionCalendar ? globalProductionSchedule.EvalWorkTimeSpanDifference(startDate, endDate) : (endDate - startDate));
		DateTime dateTime2;
		DateTime dateTime3;
		if (continueFromLastDate)
		{
			dateTime2 = ((template.LastPeriodDate.HasValue && template.LastPeriodDate.Value > startDate) ? template.LastPeriodDate.Value : startDate);
			dateTime3 = (useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime2, timeSpan) : (dateTime2 + timeSpan));
		}
		else if (startDateIsMain)
		{
			dateTime2 = func(template.Period, startDate, dateTime.AddTicks(-1L), moveBeforeHoliday);
			dateTime3 = (useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime2, timeSpan) : (dateTime2 + timeSpan));
		}
		else
		{
			dateTime3 = func(template.Period, endDate, useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime.AddTicks(-1L), timeSpan) : (dateTime.AddTicks(-1L) + timeSpan), moveBeforeHoliday);
			dateTime2 = (useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime3, -timeSpan) : (dateTime3 - timeSpan));
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		AuthenticationService.SetAuthenticatedUserForRequest(template.CreationAuthor);
		DateTime? dateTime4 = template.LastPeriodDate;
		while (num < forwardCreated && (!template.UntilDate.HasValue || dateTime2.Date <= template.UntilDate.Value.Date))
		{
			if (!dateTime4.HasValue || dateTime2 > dateTime4.Value)
			{
				manager.CreateByTemplate(template, dateTime2, dateTime3);
				dateTime4 = dateTime2;
				if (dateTime2 >= dateTime)
				{
					num++;
				}
			}
			if (startDateIsMain)
			{
				dateTime2 = func(template.Period, startDate, dateTime2, moveBeforeHoliday);
				dateTime3 = (useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime2, timeSpan) : (dateTime2 + timeSpan));
			}
			else
			{
				dateTime3 = func(template.Period, endDate, dateTime3, moveBeforeHoliday);
				dateTime2 = (useProductionCalendar ? globalProductionSchedule.EvalTargetTime(dateTime3, -timeSpan) : (dateTime3 - timeSpan));
			}
		}
		if (currentUser != null)
		{
			AuthenticationService.SetAuthenticatedUserForRequest(currentUser);
		}
		else
		{
			AuthenticationService.SignOut();
		}
	}
}
