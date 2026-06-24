using System;
using System.Collections.Generic;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Common.Interfaces;

public interface IPeriodicityService
{
	string GetPeriodTextRepr(IPeriodicity periodicity, Pair<DateTime, DateTime> period);

	string GetPeriodShortTextRepr(IPeriodicity periodicity, Pair<DateTime, DateTime> period);

	Pair<DateTime, DateTime> GetPeriod(IPeriodicity periodicity, DateTime date);

	IEnumerable<Pair<DateTime, DateTime>> GetPeriods(IPeriodicity periodicity, DateTime start, DateTime end);

	IEnumerable<Pair<DateTime, DateTime>> GetSubPeriods(IPeriodicity periodicity, DateTime start, DateTime end);

	Pair<DateTime, DateTime> GetPrevPeriod(IPeriodicity periodicity, Pair<DateTime, DateTime> period);

	Pair<DateTime, DateTime> GetNextPeriod(IPeriodicity periodicity, Pair<DateTime, DateTime> period);

	IPeriodicity GetMaxPeriodicity();

	IPeriodicity GetMinPeriodicity();

	IEnumerable<IPeriodicity> FindAll();

	IPeriodicity GetSubPeriodicity(long order);

	IPeriodicity Load(Guid uid);
}
