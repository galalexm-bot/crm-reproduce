using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IGroundsForAbsence))]
public interface IGroundsForAbsenceFilter : IEntityFilter
{
	string Name { get; set; }
}
