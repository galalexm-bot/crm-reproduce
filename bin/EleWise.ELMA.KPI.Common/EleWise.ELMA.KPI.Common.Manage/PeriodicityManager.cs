using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.KPI.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class PeriodicityManager : EntityManager<IPeriodicity, long>
{
	private IPeriodicity _periodicityYear;

	private IPeriodicity _periodicityQuarter;

	private IPeriodicity _periodicityHalfYear;

	private IPeriodicity _periodicityMonth;

	private IPeriodicity _periodicityWeek;

	private IPeriodicity _periodicityDay;

	public static string Year => SR.T("Год");

	public static string HalfYear => SR.T("Полугодие");

	public static string Quarter => SR.T("Квартал");

	public static string Month => SR.T("Месяц");

	public static string Week => SR.T("Неделя");

	public static string Day => SR.T("День");

	public IPeriodicity PeriodicityYear
	{
		get
		{
			if (_periodicityYear == null)
			{
				_periodicityYear = LoadByType(PeriodicityType.Year);
			}
			return _periodicityYear;
		}
	}

	public IPeriodicity PeriodicityQuarter
	{
		get
		{
			if (_periodicityQuarter == null)
			{
				_periodicityQuarter = LoadByType(PeriodicityType.Quarter);
			}
			return _periodicityQuarter;
		}
	}

	public IPeriodicity PeriodicityHalfYear
	{
		get
		{
			if (_periodicityHalfYear == null)
			{
				_periodicityHalfYear = LoadByType(PeriodicityType.HalfYear);
			}
			return _periodicityHalfYear;
		}
	}

	public IPeriodicity PeriodicityMonth
	{
		get
		{
			if (_periodicityMonth == null)
			{
				_periodicityMonth = LoadByType(PeriodicityType.Month);
			}
			return _periodicityMonth;
		}
	}

	public IPeriodicity PeriodicityWeek
	{
		get
		{
			if (_periodicityWeek == null)
			{
				_periodicityWeek = LoadByType(PeriodicityType.Week);
			}
			return _periodicityWeek;
		}
	}

	public IPeriodicity PeriodicityDay
	{
		get
		{
			if (_periodicityDay == null)
			{
				_periodicityDay = LoadByType(PeriodicityType.Day);
			}
			return _periodicityDay;
		}
	}

	public new static PeriodicityManager Instance => Locator.GetServiceNotNull<PeriodicityManager>();

	public IPeriodicity LoadByName(string name)
	{
		IPeriodicityFilter periodicityFilter = InterfaceActivator.Create<IPeriodicityFilter>();
		periodicityFilter.Name = name;
		return Find(periodicityFilter, FetchOptions.All).FirstOrDefault();
	}

	public IPeriodicity LoadByType(PeriodicityType periodicityType)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Type", (object)periodicityType)).AddOrder(Order.Asc("Order")).SetMaxResults(1)
			.List<IPeriodicity>()
			.FirstOrDefault();
	}

	public IPeriodicity LoadByOrder(long order)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Gt("Order", (object)order)).AddOrder(Order.Asc("Order")).SetMaxResults(1)
			.List<IPeriodicity>()
			.FirstOrDefault();
	}

	public IPeriodicity GetMaxPeriodicity()
	{
		return CreateCriteria().AddOrder(Order.Asc("Order")).SetMaxResults(1).List<IPeriodicity>()
			.FirstOrDefault();
	}

	public IPeriodicity GetMinPeriodicity()
	{
		return CreateCriteria().AddOrder(Order.Desc("Order")).SetMaxResults(1).List<IPeriodicity>()
			.FirstOrDefault();
	}

	public Dictionary<long, IPeriodicity> GetAllPeriodicities()
	{
		Dictionary<long, IPeriodicity> allPeriodicities = new Dictionary<long, IPeriodicity>();
		FindAll().ForEach(delegate(IPeriodicity p)
		{
			allPeriodicities.Add(p.Order, p);
		});
		return allPeriodicities;
	}

	public IEnumerable<IPeriodicity> GetPeriodicitiesUnderOrder(long order)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.Le("Order", (object)order));
		obj.AddOrder(Order.Asc("Order"));
		return obj.List<IPeriodicity>();
	}

	public List<IPeriodicity> GetPeriodicitiesByUids(Guid[] uids)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)uids)).List<IPeriodicity>().ToList();
	}
}
