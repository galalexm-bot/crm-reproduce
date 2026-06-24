using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Models;

[FilterFor(typeof(IPeriodicity))]
public interface IPeriodicityFilter : IEntityFilter
{
	string Name { get; set; }

	long? Order { get; set; }
}
