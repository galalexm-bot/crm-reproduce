using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IApprovalTask))]
public interface IApprovalTaskFilter : ITaskBaseFilter, IEntityFilter
{
	ApprovalStatus? ApprovalStatus { get; set; }
}
