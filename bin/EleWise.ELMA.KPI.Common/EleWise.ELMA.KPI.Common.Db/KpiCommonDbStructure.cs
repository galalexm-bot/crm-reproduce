using System;
using EleWise.ELMA.KPI.Common.Managers;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Security.Db;

namespace EleWise.ELMA.KPI.Common.Db;

public class KpiCommonDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void AddDefaultPeriodicities()
	{
		CreatePeriodicity(PeriodicityService.YearPeriodicy.Uid, 0, PeriodGroupingType.FirstDay, PeriodicityManager.Year, PeriodicityType.Year, PeriodicityCalendarType.AllDays);
		CreatePeriodicity(PeriodicityService.HalfYearPeriodicy.Uid, 1, PeriodGroupingType.FirstDay, PeriodicityManager.HalfYear, PeriodicityType.HalfYear, PeriodicityCalendarType.AllDays);
		CreatePeriodicity(PeriodicityService.QuarterPeriodicy.Uid, 2, PeriodGroupingType.FirstDay, PeriodicityManager.Quarter, PeriodicityType.Quarter, PeriodicityCalendarType.AllDays);
		CreatePeriodicity(PeriodicityService.MonthPeriodicy.Uid, 3, PeriodGroupingType.FirstDay, PeriodicityManager.Month, PeriodicityType.Month, PeriodicityCalendarType.AllDays);
		CreatePeriodicity(PeriodicityService.WeekPeriodicy.Uid, 4, PeriodGroupingType.FirstDay, PeriodicityManager.Week, PeriodicityType.Week, PeriodicityCalendarType.AllDays);
		CreatePeriodicity(PeriodicityService.DayPeriodicy.Uid, 5, PeriodGroupingType.FirstDay, PeriodicityManager.Day, PeriodicityType.Day, PeriodicityCalendarType.AllDays);
	}

	private void CreatePeriodicity(Guid uid, int order, PeriodGroupingType groupingType, string name, PeriodicityType type, PeriodicityCalendarType calendarType)
	{
		IPeriodicity periodicity = InterfaceActivator.Create<IPeriodicity>();
		periodicity.Uid = uid;
		periodicity.Name = name;
		periodicity.GroupingType = groupingType;
		periodicity.Type = type;
		periodicity.CalendarType = calendarType;
		periodicity.Order = order;
		periodicity.Save();
	}
}
