using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.KPI.Models;

[FilterFor(typeof(IPersistedCustomPeriod))]
public interface IPersistedCustomPeriodFilter : IEntityFilter
{
	DateTimeRange PeriodStart { get; set; }

	DateTimeRange PeriodEnd { get; set; }

	IPeriodicity Periodicity { get; set; }
}
