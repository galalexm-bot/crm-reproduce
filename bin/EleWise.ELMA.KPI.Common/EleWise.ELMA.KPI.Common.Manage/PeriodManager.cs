using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.KPI.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class PeriodManager : EntityManager<IPersistedCustomPeriod, long>, PeriodicityService.IDefaultPeriodicy
{
	public new static PeriodManager Instance => Locator.GetServiceNotNull<PeriodManager>();

	Guid PeriodicityService.IDefaultPeriodicy.Uid => Guid.Empty;

	public IEnumerable<IPersistedCustomPeriod> GetPeriods(IPeriodicity periodicity)
	{
		IPersistedCustomPeriodFilter persistedCustomPeriodFilter = InterfaceActivator.Create<IPersistedCustomPeriodFilter>();
		persistedCustomPeriodFilter.Periodicity = periodicity;
		return Find(persistedCustomPeriodFilter, FetchOptions.All);
	}

	[Transaction]
	public virtual void SetPeriods(IPeriodicity periodicity, IEnumerable<IPersistedCustomPeriod> newPeriods)
	{
		IPersistedCustomPeriodFilter persistedCustomPeriodFilter = InterfaceActivator.Create<IPersistedCustomPeriodFilter>();
		persistedCustomPeriodFilter.Periodicity = periodicity;
		foreach (IPersistedCustomPeriod item in Find(persistedCustomPeriodFilter, FetchOptions.All))
		{
			Delete(item);
		}
		foreach (IPersistedCustomPeriod newPeriod in newPeriods)
		{
			IPersistedCustomPeriod persistedCustomPeriod = InterfaceActivator.Create<IPersistedCustomPeriod>();
			persistedCustomPeriod.PeriodStart = newPeriod.PeriodStart;
			persistedCustomPeriod.PeriodEnd = newPeriod.PeriodEnd;
			persistedCustomPeriod.Periodicity = periodicity;
			persistedCustomPeriod.TextRepr = newPeriod.TextRepr;
			Save(persistedCustomPeriod);
		}
	}

	Pair<DateTime, DateTime> PeriodicityService.IDefaultPeriodicy.GetPeriod(DateTime date, IPeriodicity periodicity)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		IPersistedCustomPeriodFilter persistedCustomPeriodFilter = InterfaceActivator.Create<IPersistedCustomPeriodFilter>();
		persistedCustomPeriodFilter.Periodicity = periodicity;
		DateTimeRange periodStart = default(DateTimeRange);
		periodStart.From = serviceNotNull.Dialect.MinDateTime;
		periodStart.To = date;
		DateTimeRange periodEnd = default(DateTimeRange);
		periodEnd.From = date;
		periodEnd.To = serviceNotNull.Dialect.MaxDateTime;
		persistedCustomPeriodFilter.PeriodStart = periodStart;
		persistedCustomPeriodFilter.PeriodEnd = periodEnd;
		IPersistedCustomPeriod persistedCustomPeriod = Find(persistedCustomPeriodFilter, FetchOptions.All).FirstOrDefault();
		if (persistedCustomPeriod == null)
		{
			return null;
		}
		return new Pair<DateTime, DateTime>(persistedCustomPeriod.PeriodStart, persistedCustomPeriod.PeriodEnd);
	}

	Pair<DateTime, DateTime> PeriodicityService.IDefaultPeriodicy.GetNextPeriod(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
	{
		IPersistedCustomPeriodFilter persistedCustomPeriodFilter = InterfaceActivator.Create<IPersistedCustomPeriodFilter>();
		persistedCustomPeriodFilter.Periodicity = periodicity;
		IPersistedCustomPeriod persistedCustomPeriod = (from p in Find(persistedCustomPeriodFilter, FetchOptions.All)
			orderby p.PeriodStart
			select p).FirstOrDefault((IPersistedCustomPeriod p) => p.PeriodStart > period.Second);
		if (persistedCustomPeriod == null)
		{
			return null;
		}
		return new Pair<DateTime, DateTime>(persistedCustomPeriod.PeriodStart, persistedCustomPeriod.PeriodEnd);
	}

	string PeriodicityService.IDefaultPeriodicy.GetTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
	{
		IPersistedCustomPeriodFilter persistedCustomPeriodFilter = InterfaceActivator.Create<IPersistedCustomPeriodFilter>();
		persistedCustomPeriodFilter.Periodicity = periodicity;
		DateTimeRange periodStart = default(DateTimeRange);
		periodStart.From = period.First;
		periodStart.To = period.First;
		DateTimeRange periodEnd = default(DateTimeRange);
		periodEnd.From = period.Second;
		periodEnd.To = period.Second;
		persistedCustomPeriodFilter.PeriodStart = periodStart;
		persistedCustomPeriodFilter.PeriodEnd = periodEnd;
		IPersistedCustomPeriod persistedCustomPeriod = Find(persistedCustomPeriodFilter, FetchOptions.All).FirstOrDefault();
		if (persistedCustomPeriod == null)
		{
			return string.Empty;
		}
		return persistedCustomPeriod.TextRepr;
	}

	string PeriodicityService.IDefaultPeriodicy.GetShortTextRepr(Pair<DateTime, DateTime> period, IPeriodicity periodicity)
	{
		return ((PeriodicityService.IDefaultPeriodicy)this).GetTextRepr(period, periodicity);
	}
}
