using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public static class ConfigDataModelFactory
{
	public static ConfigDataModel CreateWeekDayCollectionConfigModel(IResourceCalendar productionSchedule)
	{
		return CreateWeekDayCollectionConfigModel(productionSchedule, string.Empty);
	}

	public static ConfigDataModel CreateWeekDayCollectionConfigModel(IResourceCalendar productionSchedule, string uid)
	{
		ConfigDataModel configDataModel = new ConfigDataModel();
		configDataModel.Prefix = AddBind(uid, "WeekDayCollection");
		configDataModel.GridId = $"{configDataModel.Prefix}Grid{uid}";
		IOrderedEnumerable<IWorkTimeInterval> workingTimeIntervalCollection = (IOrderedEnumerable<IWorkTimeInterval>)(configDataModel.WorkingTimeIntervals = from wi in (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals
			where wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue
			orderby wi.Start
			select wi);
		configDataModel.JsonWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionSerialize(workingTimeIntervalCollection);
		configDataModel.SimpleModeEnable = (from wi in configDataModel.WorkingTimeIntervals
			group wi by wi.DayOfWeek).All((IGrouping<int?, IWorkTimeInterval> g) => ConfigDataModelExtension.IsSimpleModeAllowed(g));
		return configDataModel;
	}

	public static IEnumerable<ConfigDataModel> CreateWeekDayConfigDataCollection(IResourceCalendar productionSchedule)
	{
		return CreateWeekDayConfigDataCollection(productionSchedule, string.Empty);
	}

	public static IEnumerable<ConfigDataModel> CreateWeekDayConfigDataCollection(IResourceCalendar productionSchedule, string uid)
	{
		List<ConfigDataModel> list = new List<ConfigDataModel>();
		int firstDayOfWeek = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
		for (int i = 0; i < 7; i++)
		{
			DayOfWeek dayOfWeek = (DayOfWeek)((i + firstDayOfWeek) % 7);
			ConfigDataModel item = new ConfigDataModel((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals, (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals, dayOfWeek, uid);
			list.Add(item);
		}
		return list;
	}

	public static ConfigDataModel CreateExceptionalDayCollectionConfigModel(IResourceCalendar productionSchedule)
	{
		return CreateExceptionalDayCollectionConfigModel(productionSchedule, string.Empty);
	}

	public static ConfigDataModel CreateExceptionalDayCollectionConfigModel(IResourceCalendar productionSchedule, string uid)
	{
		ConfigDataModel configDataModel = new ConfigDataModel();
		configDataModel.Prefix = AddBind(uid, "ExceptionalDayCollection");
		configDataModel.GridId = $"{configDataModel.Prefix}Grid{uid}";
		IOrderedEnumerable<IWorkTimeInterval> workingTimeIntervalCollection = (IOrderedEnumerable<IWorkTimeInterval>)(configDataModel.WorkingTimeIntervals = from wi in (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals
			where !wi.DayOfWeek.HasValue && wi.DateExceptionStart.HasValue && wi.DateExceptionFinish.HasValue
			orderby wi.DateExceptionStart, wi.Start
			select wi);
		configDataModel.JsonWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionSerialize(workingTimeIntervalCollection);
		IOrderedEnumerable<IHolidayInterval> jsonHolidayTimeIntervalCollection = (IOrderedEnumerable<IHolidayInterval>)(configDataModel.HolidayIntervals = ((IEnumerable<IHolidayInterval>)productionSchedule.HolidayIntervals).OrderBy((IHolidayInterval hi) => hi.DateStart));
		configDataModel.JsonHolidayIntervalCollection = ConfigDataModelExtension.HolidayIntervalCollectionSerialize(jsonHolidayTimeIntervalCollection);
		ProductionScheduleData productionScheduleData = ProductionScheduleDataFactory.CreateByEntity(productionSchedule);
		configDataModel.SimpleModeEnable = productionScheduleData.ExceptionalDays.All((ExceptionalDay ed) => ConfigDataModelExtension.IsSimpleModeAllowed(ed.WorkingTimeIntervals));
		return configDataModel;
	}

	public static IEnumerable<ConfigDataModel> CreateExceptionalDayConfigDataCollection(IResourceCalendar productionSchedule)
	{
		return CreateExceptionalDayConfigDataCollection(productionSchedule, string.Empty);
	}

	public static IEnumerable<ConfigDataModel> CreateExceptionalDayConfigDataCollection(IResourceCalendar productionSchedule, string uid)
	{
		if (productionSchedule.IsNew())
		{
			return new List<ConfigDataModel>();
		}
		return from ed in ProductionScheduleDataFactory.CreateByEntity(productionSchedule).ExceptionalDays
			select ed.Date.ToRuntimeDateTimeFromClient(TZ.Server) into exceptionalDate
			select new ConfigDataModel((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals, (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals, (IEnumerable<IHolidayInterval>)productionSchedule.HolidayIntervals, exceptionalDate, uid);
	}

	internal static string AddBind(string uid, string prefix)
	{
		if (!string.IsNullOrEmpty(uid))
		{
			return $"Bind{uid}.{prefix}";
		}
		return prefix;
	}
}
