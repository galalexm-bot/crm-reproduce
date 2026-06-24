using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IReplacement))]
public interface IReplacementFilter : IEntityFilter
{
	IUser SourceUser { get; set; }

	IUser TargetUser { get; set; }

	DateTimeRange StartDate { get; set; }

	ReplacementStatus? Status { get; set; }

	DateTimeRange EndDate { get; set; }
}
