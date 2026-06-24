using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Projects.Models.Resources;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class ConfigDataModel
{
	public static class PrefixProvider
	{
		public const string Config = "Config";

		public const string Base = "BaseConfig";

		public const string WeekDayCollection = "WeekDayCollection";

		public const string ExceptionalDayCollection = "ExceptionalDayCollection";

		public const string Sunday = "Sunday";

		public const string Monday = "Monday";

		public const string Tuesday = "Tuesday";

		public const string Wednesday = "Wednesday";

		public const string Thursday = "Thursday";

		public const string Friday = "Friday";

		public const string Saturday = "Saturday";

		public const string ExceptionalDay = "ExceptionalDay";

		public static string GetWeekDayPrefix(DayOfWeek dayOfWeek)
		{
			return dayOfWeek switch
			{
				System.DayOfWeek.Sunday => "Sunday", 
				System.DayOfWeek.Monday => "Monday", 
				System.DayOfWeek.Tuesday => "Tuesday", 
				System.DayOfWeek.Wednesday => "Wednesday", 
				System.DayOfWeek.Thursday => "Thursday", 
				System.DayOfWeek.Friday => "Friday", 
				System.DayOfWeek.Saturday => "Saturday", 
				_ => throw new ArgumentException(SR.T("Для значения перечисления \"{0}\" префикс отсутствует")), 
			};
		}
	}

	private const int AdvancedModeTreshold = 3;

	public DateTime WorkingTimeStart { get; set; }

	public DateTime WorkingTimeEnd { get; set; }

	public DateTime BreakTimeStart { get; set; }

	public DateTime BreakTimeEnd { get; set; }

	public bool WithBreakTime { get; set; }

	public bool SimpleModeEnable { get; set; }

	public string Prefix { get; set; }

	public string GridId { get; set; }

	public DayType DayType { get; set; }

	[JsonIgnore]
	public IEnumerable<IBaseTimeInterval> BaseTimeIntervals { get; set; }

	public string JsonBaseTimeIntervalCollection { get; set; }

	public DayOfWeek? DayOfWeek { get; set; }

	public DateTime? ExceptionalDate { get; set; }

	[JsonIgnore]
	public IEnumerable<IWorkTimeInterval> WorkingTimeIntervals { get; set; }

	public string JsonWorkingTimeIntervalCollection { get; set; }

	[JsonIgnore]
	public IEnumerable<IHolidayInterval> HolidayIntervals { get; set; }

	public string JsonHolidayIntervalCollection { get; set; }

	private void SimpleModeDataByCustomWorkingDayInitialize(IEnumerable<TimeInterval> timeIntervalCollection)
	{
		if (timeIntervalCollection == null)
		{
			throw new ArgumentNullException("timeIntervalCollection");
		}
		IList<TimeInterval> list = (timeIntervalCollection as IList<TimeInterval>) ?? timeIntervalCollection.ToList();
		if (ConfigDataModelExtension.IsSimpleModeAllowed(list))
		{
			SimpleModeEnable = true;
			switch (list.Count)
			{
			case 1:
				WithBreakTime = false;
				WorkingTimeStart = DateTime.Today.Add(list.First().Start).ToRuntimeDateTimeFromClient(TZ.Server);
				WorkingTimeEnd = DateTime.Today.Add(list.Last().End).ToRuntimeDateTimeFromClient(TZ.Server);
				BreakTimeStart = DateTime.Today.Add(new TimeSpan(12, 0, 0)).ToRuntimeDateTimeFromClient(TZ.Server);
				BreakTimeEnd = DateTime.Today.Add(new TimeSpan(13, 0, 0)).ToRuntimeDateTimeFromClient(TZ.Server);
				break;
			case 2:
				WithBreakTime = true;
				WorkingTimeStart = DateTime.Today.Add(list.First().Start).ToRuntimeDateTimeFromClient(TZ.Server);
				WorkingTimeEnd = DateTime.Today.Add(list.Last().End).ToRuntimeDateTimeFromClient(TZ.Server);
				BreakTimeStart = DateTime.Today.Add(list.First().End).ToRuntimeDateTimeFromClient(TZ.Server);
				BreakTimeEnd = DateTime.Today.Add(list.Last().Start).ToRuntimeDateTimeFromClient(TZ.Server);
				break;
			}
		}
	}

	public ConfigDataModel()
	{
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection)
		: this(baseTimeIntervalCollection, string.Empty)
	{
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, string uid)
	{
		Prefix = AddBind(uid, "BaseConfig");
		GridId = $"{Prefix}Grid{uid}";
		DayType = DayType.CustomWorkingDay;
		IList<IBaseTimeInterval> source = (baseTimeIntervalCollection as IList<IBaseTimeInterval>) ?? baseTimeIntervalCollection.ToList();
		BaseTimeIntervals = source.OrderBy((IBaseTimeInterval bi) => bi.Start);
		JsonBaseTimeIntervalCollection = ConfigDataModelExtension.BaseTimeIntervalCollectionSerialize(BaseTimeIntervals);
		SimpleModeDataByCustomWorkingDayInitialize(from bi in source
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into bi
			orderby bi.Start
			select bi);
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection, DayOfWeek dayOfWeek)
		: this(baseTimeIntervalCollection, workingTimeIntervalCollection, dayOfWeek, string.Empty)
	{
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection, DayOfWeek dayOfWeek, string uid)
	{
		Prefix = AddBind(uid, PrefixProvider.GetWeekDayPrefix(dayOfWeek));
		GridId = $"{Prefix}Grid{uid}";
		int denormalizedIndex = dayOfWeek.GetWorkTimeIntervalDayOfWeek();
		List<IWorkTimeInterval> list = workingTimeIntervalCollection.Where((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue && wi.DayOfWeek == denormalizedIndex).ToList();
		IList<IBaseTimeInterval> list2 = (baseTimeIntervalCollection as IList<IBaseTimeInterval>) ?? baseTimeIntervalCollection.ToList();
		SimpleModeDataByCustomWorkingDayInitialize(list.Any() ? (from bi in list
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into wi
			orderby wi.Start
			select wi) : (from bi in list2
			select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into bi
			orderby bi.Start
			select bi));
		DayType = ((!list.Any()) ? DayType.Holiday : ((!ConfigDataModelExtension.IsBaseWorkingDay(list2, list)) ? DayType.CustomWorkingDay : DayType.WorkingDay));
		DayOfWeek = dayOfWeek;
		WorkingTimeIntervals = list;
		JsonWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionSerialize(WorkingTimeIntervals);
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection, IEnumerable<IHolidayInterval> holidayTimeIntervalCollection, DateTime? runtimeDateTime)
		: this(baseTimeIntervalCollection, workingTimeIntervalCollection, holidayTimeIntervalCollection, runtimeDateTime, string.Empty)
	{
	}

	public ConfigDataModel(IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection, IEnumerable<IHolidayInterval> holidayTimeIntervalCollection, DateTime? runtimeDateTime, string uid)
	{
		Prefix = AddBind(uid, "ExceptionalDay");
		GridId = $"{Prefix}Grid{uid}";
		List<IBaseTimeInterval> list = baseTimeIntervalCollection.ToList();
		bool flag = false;
		if (runtimeDateTime.HasValue)
		{
			List<IHolidayInterval> list2 = holidayTimeIntervalCollection.Where((IHolidayInterval hi) => runtimeDateTime >= hi.DateStart && runtimeDateTime <= hi.DateFinish).ToList();
			List<IWorkTimeInterval> list3 = (list2.Any() ? new List<IWorkTimeInterval>() : workingTimeIntervalCollection.Where((IWorkTimeInterval wi) => !wi.DayOfWeek.HasValue && wi.DateExceptionStart.HasValue && wi.DateExceptionFinish.HasValue && runtimeDateTime >= wi.DateExceptionStart && runtimeDateTime <= wi.DateExceptionFinish).ToList());
			flag = list2.Any() || list3.Any();
			if (flag)
			{
				SimpleModeDataByCustomWorkingDayInitialize(list3.Any() ? (from wi in list3
					select new TimeInterval(wi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (wi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : wi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into wi
					orderby wi.Start
					select wi) : (from bi in list
					select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into bi
					orderby bi.Start
					select bi));
				DayType = ((!list3.Any()) ? DayType.Holiday : ((!ConfigDataModelExtension.IsBaseWorkingDay(list, list3)) ? DayType.CustomWorkingDay : DayType.WorkingDay));
				ExceptionalDate = runtimeDateTime;
				WorkingTimeIntervals = list3;
				JsonWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionSerialize(WorkingTimeIntervals);
				HolidayIntervals = list2;
				JsonHolidayIntervalCollection = ConfigDataModelExtension.HolidayIntervalCollectionSerialize(HolidayIntervals);
			}
		}
		if (!flag)
		{
			SimpleModeDataByCustomWorkingDayInitialize(from bi in list
				select new TimeInterval(bi.Start.ToClientDateTime(TZ.Server).TimeOfDay, (bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay == TimeSpan.Zero) ? TimeSpan.FromDays(1.0) : bi.Finish.ToClientDateTime(TZ.Server).TimeOfDay) into bi
				orderby bi.Start
				select bi);
			DayType = DayType.CustomWorkingDay;
			ExceptionalDate = runtimeDateTime ?? TZ.CurrentClientDate.ToRuntimeDateTimeFromClient(TZ.Server);
			WorkingTimeIntervals = list.Select(delegate(IBaseTimeInterval bi)
			{
				IWorkTimeInterval workTimeInterval = EntityManager<IWorkTimeInterval>.Create();
				workTimeInterval.Start = bi.Start;
				workTimeInterval.Finish = bi.Finish;
				workTimeInterval.DateExceptionStart = runtimeDateTime;
				workTimeInterval.DateExceptionFinish = runtimeDateTime;
				return workTimeInterval;
			});
			JsonWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionSerialize(WorkingTimeIntervals);
			HolidayIntervals = new List<IHolidayInterval>();
			JsonHolidayIntervalCollection = ConfigDataModelExtension.HolidayIntervalCollectionSerialize(HolidayIntervals);
		}
	}

	private string AddBind(string uid, string prefix)
	{
		if (!string.IsNullOrEmpty(uid))
		{
			return $"Bind{uid}.{prefix}";
		}
		return prefix;
	}
}
