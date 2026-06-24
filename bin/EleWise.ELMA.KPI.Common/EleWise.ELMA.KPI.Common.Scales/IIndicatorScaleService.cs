using System;
using System.Collections.Generic;
using EleWise.ELMA.KPI.Common.Interfaces;

namespace EleWise.ELMA.KPI.Common.Scales;

public interface IIndicatorScaleService : IRepository<IIndicatorScale>, IGenericRepository<IIndicatorScale, Guid>
{
	IEnumerable<IIndicatorScale> GetScales();
}
