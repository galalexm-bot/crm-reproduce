using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IUnitMeasure))]
public interface IUnitMeasureFilter : IEntityFilter
{
	string Name { get; set; }

	bool? IsWPI { get; set; }

	bool? IsSelectList { get; set; }
}
