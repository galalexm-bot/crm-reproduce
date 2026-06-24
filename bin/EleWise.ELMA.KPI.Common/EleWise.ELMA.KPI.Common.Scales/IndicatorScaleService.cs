using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.KPI.Common.Interfaces;

namespace EleWise.ELMA.KPI.Common.Scales;

[Service]
public class IndicatorScaleService : IIndicatorScaleService, IRepository<IIndicatorScale>, IGenericRepository<IIndicatorScale, Guid>
{
	private readonly IIndicatorScale[] scales = new IIndicatorScale[5]
	{
		StableIndicatorScale.Instance,
		IncreaseIndicatorScale.Instance,
		ReductionIndicatorScale.Instance,
		MaxByPlanIndicatorScale.Instance,
		MinByPlanIndicatorScale.Instance
	};

	public IIndicatorScale Get(Guid id)
	{
		return scales.First((IIndicatorScale scale) => scale.Id == id);
	}

	public IEnumerable<IIndicatorScale> GetScales()
	{
		return scales;
	}

	public int GetIndex(Guid id)
	{
		return Array.IndexOf(scales, Get(id));
	}
}
