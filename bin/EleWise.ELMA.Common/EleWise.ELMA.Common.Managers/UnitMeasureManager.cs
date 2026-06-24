using System;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.Common.Managers;

public class UnitMeasureManager : EntityManager<IUnitMeasure, long>
{
	private IUnitMeasure _rubles;

	private IUnitMeasure _percents;

	public new static UnitMeasureManager Instance => Locator.GetServiceNotNull<UnitMeasureManager>();

	public static string RublesName => SR.T("Рубли");

	public IUnitMeasure Rubles
	{
		get
		{
			if (_rubles == null)
			{
				_rubles = LoadByUid(new Guid("EE0EBF00-1EF9-4503-AFC6-87424F90D9BE"));
			}
			return _rubles;
		}
	}

	public static string PercentsName => SR.T("Проценты");

	public IUnitMeasure Percents
	{
		get
		{
			if (_percents == null)
			{
				_percents = LoadByUid(new Guid("2F298AB5-4A75-4aff-A2EF-241CA72614DC"));
			}
			return _percents;
		}
	}

	public IUnitMeasure LoadByName(string name)
	{
		IUnitMeasureFilter unitMeasureFilter = InterfaceActivator.Create<IUnitMeasureFilter>();
		unitMeasureFilter.Name = name;
		return Find(unitMeasureFilter, FetchOptions.All).FirstOrDefault();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		if (filter is IUnitMeasureFilter unitMeasureFilter)
		{
			unitMeasureFilter.IsWPI = unitMeasureFilter.IsWPI ?? false;
			base.SetupFilter(criteria, (IEntityFilter)unitMeasureFilter);
		}
	}
}
