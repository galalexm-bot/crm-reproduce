using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Scheduling;

namespace EleWise.ELMA.KPI.Common.Managers;

[Service]
public class PeriodicityService : IPeriodicityService
{
	public interface IDefaultPeriodicy
	{
		Guid Uid { get; }

		Pair<DateTime, DateTime> GetPeriod(DateTime date, IPeriodicity periodicity);

		Pair<DateTime, DateTime> GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity);

		string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity);

		string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity);
	}

	public class MonthPeriodicy : IDefaultPeriodicy
	{
		public static Guid Uid => new Guid("98ECE429-4CAA-4f1e-AD65-BB6CE2873F75");

		Guid IDefaultPeriodicy.Uid => Uid;

		public Pair<DateTime, DateTime> GetPeriod(DateTime date, IPeriodicity periodicity)
		{
			DateTime first = new DateTime(date.Year, date.Month, 1);
			DateTime second = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)).AddDays(1.0).AddSeconds(-1.0);
			return new Pair<DateTime, DateTime>(first, second);
		}

		public Pair<DateTime, DateTime> GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			DateTime first = period.First.AddMonths(1);
			DateTime second = new DateTime(first.Year, first.Month, DateTime.DaysInMonth(first.Year, first.Month)).AddDays(1.0).AddSeconds(-1.0);
			return new Pair<DateTime, DateTime>(first, second);
		}

		public string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("MMMM yyyy");
		}

		public string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("MMMM");
		}
	}

	public class DayPeriodicy : IDefaultPeriodicy
	{
		public static Guid Uid => new Guid("7E0E4D76-DCBC-4792-B43E-42F86F22BC09");

		Guid IDefaultPeriodicy.Uid => Uid;

		public Pair<DateTime, DateTime> GetPeriod(DateTime date, IPeriodicity periodicity)
		{
			DateTime first = new DateTime(date.Year, date.Month, date.Day);
			return new Pair<DateTime, DateTime>(first, first.AddDays(1.0).AddSeconds(-1.0));
		}

		public Pair<DateTime, DateTime> GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			DateTime first = period.First.AddDays(1.0);
			DateTime second = first.AddDays(1.0).AddSeconds(-1.0);
			return new Pair<DateTime, DateTime>(first, second);
		}

		public string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("d");
		}

		public string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("dd");
		}
	}

	public class WeekPeriodicy : IDefaultPeriodicy
	{
		public static Guid Uid => new Guid("F2B03B4A-D4B6-4611-B570-2656728EB693");

		Guid IDefaultPeriodicy.Uid => Uid;

		public Pair<DateTime, DateTime> GetPeriod(DateTime date, IPeriodicity periodicity)
		{
			CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
			DayOfWeek firstDayOfWeek = currentCulture.DateTimeFormat.FirstDayOfWeek;
			int num = currentCulture.Calendar.GetDayOfWeek(date) - firstDayOfWeek;
			if (num < 0)
			{
				num += 7;
			}
			DateTime first = date.AddDays(-num);
			DateTime second = first.AddDays(7.0).AddSeconds(-1.0);
			return new Pair<DateTime, DateTime>(first, second);
		}

		public Pair<DateTime, DateTime> GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			DateTime first = period.First.AddDays(7.0);
			DateTime second = first.AddDays(7.0).AddSeconds(-1.0);
			return new Pair<DateTime, DateTime>(first, second);
		}

		public string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("d") + " - " + period.Second.ToString("d");
		}

		public string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("dd/MM") + "-" + period.Second.ToString("dd/MM");
		}
	}

	public abstract class YearPeriodicyBase : IDefaultPeriodicy
	{
		public Guid Uid => Guid.Empty;

		public Pair<DateTime, DateTime> GetPeriod(DateTime date, IPeriodicity periodicity)
		{
			return GetPeriodsFromCurrentYear(date, periodicity).First((Pair<DateTime, DateTime> q) => q.First <= date && date <= q.Second);
		}

		private IEnumerable<Pair<DateTime, DateTime>> GetPeriodsFromCurrentYear(DateTime date, IPeriodicity periodicity)
		{
			int year = date.Year;
			DateTime start = new DateTime(year, 1, 1);
			Pair<DateTime, DateTime> period = MakeQuarter(start);
			while (true)
			{
				yield return period;
				period = GetNextPeriod(period, periodicity);
			}
		}

		public Pair<DateTime, DateTime> MakeQuarter(DateTime start)
		{
			return new Pair<DateTime, DateTime>(start, GetPeriodEnd(start));
		}

		protected abstract DateTime GetPeriodEnd(DateTime start);

		public Pair<DateTime, DateTime> GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return MakeQuarter(period.Second.AddSeconds(1.0));
		}

		public abstract string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity);

		public abstract string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity);
	}

	public class QuarterPeriodicy : YearPeriodicyBase
	{
		public new static Guid Uid => new Guid("B20CEABC-0AFE-4173-B08C-52697AA866D3");

		protected override DateTime GetPeriodEnd(DateTime start)
		{
			return start.AddMonths(3).AddSeconds(-1.0);
		}

		public override string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			int num = (period.First.Month - 1) / 3 + 1;
			return SR.T("Квартал {0}", num) + " " + period.First.Year;
		}

		public override string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			int num = (period.First.Month - 1) / 3 + 1;
			return SR.T("Квартал {0}", num);
		}
	}

	public class HalfYearPeriodicy : YearPeriodicyBase
	{
		public new static Guid Uid => new Guid("8FCC3DF9-51FA-41c1-8FC6-152E9A60B2D6");

		protected override DateTime GetPeriodEnd(DateTime start)
		{
			return start.AddMonths(6).AddSeconds(-1.0);
		}

		public override string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			int num = (period.First.Month - 1) / 6 + 1;
			return SR.T("Полугодие {0}", num) + " " + period.First.Year;
		}

		public override string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			int num = (period.First.Month - 1) / 6 + 1;
			return SR.T("Полугодие {0}", num);
		}
	}

	public class YearPeriodicy : YearPeriodicyBase
	{
		public new static Guid Uid => new Guid("7B5949E9-8232-4b65-ADF3-C6515412710F");

		protected override DateTime GetPeriodEnd(DateTime start)
		{
			return start.AddMonths(12).AddSeconds(-1.0);
		}

		public override string GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("yyyy");
		}

		public override string GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
		{
			return period.First.ToString("yyyy");
		}
	}

	private readonly Dictionary<PeriodicityType, IDefaultPeriodicy> periodicies = new Dictionary<PeriodicityType, IDefaultPeriodicy>
	{
		{
			PeriodicityType.Year,
			new YearPeriodicy()
		},
		{
			PeriodicityType.HalfYear,
			new HalfYearPeriodicy()
		},
		{
			PeriodicityType.Quarter,
			new QuarterPeriodicy()
		},
		{
			PeriodicityType.Month,
			new MonthPeriodicy()
		},
		{
			PeriodicityType.Week,
			new WeekPeriodicy()
		},
		{
			PeriodicityType.Day,
			new DayPeriodicy()
		}
	};

	[NotNull]
	public IProductionCalendarService ProductionCalendarService { get; set; }

	public IEnumerable<Pair<DateTime, DateTime>> GetPeriods(IPeriodicity periodicity, DateTime start, DateTime end)
	{
		if (end < start)
		{
			throw new ArgumentException("start has to be larger then end");
		}
		if (periodicity != null && periodicity.Type != 0)
		{
			IDefaultPeriodicy defaultPeriodicy;
			if (periodicity.Type != PeriodicityType.Custom)
			{
				defaultPeriodicy = periodicies[periodicity.Type];
			}
			else
			{
				IDefaultPeriodicy instance = PeriodManager.Instance;
				defaultPeriodicy = instance;
			}
			IDefaultPeriodicy periodicy = defaultPeriodicy;
			start = new DateTime(start.Year, start.Month, start.Day);
			Pair<DateTime, DateTime> currentPeriod = periodicy.GetPeriod(start, periodicity);
			while (currentPeriod != null && currentPeriod.First <= end)
			{
				yield return currentPeriod;
				currentPeriod = periodicy.GetNextPeriod(currentPeriod, periodicity);
			}
		}
	}

	public IEnumerable<Pair<DateTime, DateTime>> GetSubPeriods(IPeriodicity periodicity, DateTime start, DateTime end)
	{
		if (periodicity == null)
		{
			return new List<Pair<DateTime, DateTime>>();
		}
		if (end < start)
		{
			throw new ArgumentException("start has to be larger then end");
		}
		IEnumerable<Pair<DateTime, DateTime>> periods = GetPeriods(periodicity, start, end);
		if (periodicity.GroupingType == PeriodGroupingType.FirstDay)
		{
			return periods.Where((Pair<DateTime, DateTime> p) => p.First <= end && p.First >= start);
		}
		if (periodicity.GroupingType == PeriodGroupingType.LastDay)
		{
			return periods.Where((Pair<DateTime, DateTime> p) => p.Second <= end && p.Second >= start);
		}
		if (periodicity.GroupingType == PeriodGroupingType.MiddleDay)
		{
			return periods.Where(delegate(Pair<DateTime, DateTime> p)
			{
				int num = p.Second.Subtract(p.First).Days / 2;
				DateTime dateTime = p.First.AddDays(num);
				return dateTime <= end && dateTime >= start;
			});
		}
		return from p in GetPeriods(periodicity, start, end)
			where p.Second <= end
			select p;
	}

	public Pair<DateTime, DateTime> GetPeriod(IPeriodicity periodicity, DateTime date)
	{
		if (periodicity.Type == PeriodicityType.None)
		{
			throw new ArgumentException(SR.T("Периодичность не определена"));
		}
		date = new DateTime(date.Year, date.Month, date.Day);
		IDefaultPeriodicy defaultPeriodicy;
		if (periodicity.Type != PeriodicityType.Custom)
		{
			defaultPeriodicy = periodicies[periodicity.Type];
		}
		else
		{
			IDefaultPeriodicy instance = PeriodManager.Instance;
			defaultPeriodicy = instance;
		}
		return defaultPeriodicy.GetPeriod(date, periodicity);
	}

	public string GetPeriodTextRepr(IPeriodicity periodicity, Pair<DateTime, DateTime> period)
	{
		if (periodicity.Type == PeriodicityType.None)
		{
			return SR.T("N/A");
		}
		IDefaultPeriodicy defaultPeriodicy;
		if (periodicity.Type != PeriodicityType.Custom)
		{
			defaultPeriodicy = periodicies[periodicity.Type];
		}
		else
		{
			IDefaultPeriodicy instance = PeriodManager.Instance;
			defaultPeriodicy = instance;
		}
		return defaultPeriodicy.GetTextRepr(period, periodicity);
	}

	public string GetPeriodShortTextRepr(IPeriodicity periodicity, Pair<DateTime, DateTime> period)
	{
		if (periodicity.Type == PeriodicityType.None)
		{
			return SR.T("N/A");
		}
		IDefaultPeriodicy defaultPeriodicy;
		if (periodicity.Type != PeriodicityType.Custom)
		{
			defaultPeriodicy = periodicies[periodicity.Type];
		}
		else
		{
			IDefaultPeriodicy instance = PeriodManager.Instance;
			defaultPeriodicy = instance;
		}
		return defaultPeriodicy.GetShortTextRepr(period, periodicity);
	}

	public Pair<DateTime, DateTime> GetPrevPeriod(IPeriodicity periodicity, Pair<DateTime, DateTime> period)
	{
		DateTime dateTime = period.First.AddDays(-1.0);
		if ((periodicity.Type == PeriodicityType.Day) & (periodicity.CalendarType == PeriodicityCalendarType.ProductionSchedule))
		{
			while (!ProductionCalendarService.GetGlobalProductionSchedule().IsWorkDay(dateTime))
			{
				dateTime = dateTime.AddDays(-1.0);
			}
		}
		return GetPeriod(periodicity, dateTime);
	}

	public Pair<DateTime, DateTime> GetNextPeriod(IPeriodicity periodicity, Pair<DateTime, DateTime> period)
	{
		DateTime dateTime = period.Second.AddDays(1.0);
		if ((periodicity.Type == PeriodicityType.Day) & (periodicity.CalendarType == PeriodicityCalendarType.ProductionSchedule))
		{
			while (!ProductionCalendarService.GetGlobalProductionSchedule().IsWorkDay(dateTime))
			{
				dateTime = dateTime.AddDays(1.0);
			}
		}
		return GetPeriod(periodicity, dateTime);
	}

	public IPeriodicity GetMaxPeriodicity()
	{
		return PeriodicityManager.Instance.GetMaxPeriodicity() ?? throw new InvalidDataException(SR.T("Необходимо добавить периодичностей"));
	}

	public IPeriodicity GetMinPeriodicity()
	{
		return PeriodicityManager.Instance.GetMinPeriodicity() ?? throw new InvalidDataException(SR.T("Необходимо добавить периодичностей"));
	}

	public IEnumerable<IPeriodicity> FindAll()
	{
		return from p in PeriodicityManager.Instance.FindAll()
			orderby p.Order
			select p;
	}

	public IPeriodicity GetSubPeriodicity(long order)
	{
		return PeriodicityManager.Instance.LoadByOrder(order);
	}

	public IPeriodicity Load(Guid uid)
	{
		return PeriodicityManager.Instance.Load(uid);
	}
}
