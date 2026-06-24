using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Projects.Models;

[FilterFor(typeof(IBudgetExpenseItemRef))]
public interface IBudgetExpenseItemRefFilter : IEntityFilter
{
	string Name { get; set; }
}
