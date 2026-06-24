using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Projects.Models;

[FilterFor(typeof(IBudgetIncomeItemRef))]
public interface IBudgetIncomeItemRefFilter : IEntityFilter
{
	string Name { get; set; }
}
