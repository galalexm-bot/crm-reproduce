using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.KPI.Common.Managers;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Common;
using NHibernate.Util;

namespace EleWise.ELMA.KPI.Common.Interfaces;

public static class PeriodicityServiceExtensions
{
	private static ICollection<IPeriodicity> periodicities => PeriodicityManager.Instance.FindAll();

	public static TimePeriod GetTimePeriod(this IPeriodicityService periodicityService, IPeriodicity periodicity, DateTime date)
	{
		Pair<DateTime, DateTime> period = periodicityService.GetPeriod(periodicity, date);
		string periodTextRepr = periodicityService.GetPeriodTextRepr(periodicity, period);
		string periodShortTextRepr = periodicityService.GetPeriodShortTextRepr(periodicity, period);
		return new TimePeriod(period, periodTextRepr, periodShortTextRepr, periodicity.Uid);
	}

	public static TimePeriod GetTimePeriod(this IPeriodicityService periodicityService, IPeriodicity periodicity, Pair<DateTime, DateTime> range)
	{
		string periodTextRepr = periodicityService.GetPeriodTextRepr(periodicity, range);
		string periodShortTextRepr = periodicityService.GetPeriodShortTextRepr(periodicity, range);
		return new TimePeriod(range, periodTextRepr, periodShortTextRepr, periodicity.Uid);
	}

	public static IPeriodicity GetPeriodicity(this IPeriodicityService periodicityService, Pair<DateTime, DateTime> period)
	{
		foreach (IPeriodicity periodicity in periodicities)
		{
			if (EnumerableExtensions.FirstOrNull((IEnumerable)periodicityService.GetPeriods(periodicity, period.First, period.Second)) is Pair<DateTime, DateTime> pair && pair.First.Date.Equals(period.First.Date) && pair.Second.Date.Equals(period.Second.Date))
			{
				return periodicity;
			}
		}
		return null;
	}

	public static Pair<DateTime, DateTime> GetPrevPeriod(this IPeriodicityService periodicityService, Pair<DateTime, DateTime> period, IPeriodicity fromPeriodicity)
	{
		periodicities.TakeWhile((IPeriodicity p) => p.Uid != fromPeriodicity.Uid).Reverse().ToList()
			.Insert(0, fromPeriodicity);
		foreach (IPeriodicity periodicity in periodicities)
		{
			List<Pair<DateTime, DateTime>> list = periodicityService.GetPeriods(periodicity, period.First, period.Second).ToList();
			if (list.Count == 1 && list[0].Equals(period))
			{
				return periodicityService.GetPrevPeriod(periodicity, period);
			}
		}
		throw new ArgumentException(SR.T("Не удалось установить периодичность периода \"{0}\"", period));
	}

	public static string GetPeriodShortText(this IPeriodicityService periodicityService, DateTime startPeriod, DateTime endPeriod)
	{
		Pair<DateTime, DateTime> period = new Pair<DateTime, DateTime>(startPeriod, endPeriod);
		IPeriodicity periodicity = periodicityService.GetPeriodicity(period);
		return periodicityService.GetPeriodShortTextRepr(periodicity, period);
	}
}
