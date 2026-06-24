using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.KPI.Models;

[FilterFor(typeof(IProjectionScaleItem))]
public interface IProjectionScaleItemFilter : IEntityFilter
{
	DoubleRange MinValue { get; set; }

	DoubleRange MaxValue { get; set; }

	DoubleRange ResultValue { get; set; }

	IProjectionScale ProjectionScale { get; set; }
}
