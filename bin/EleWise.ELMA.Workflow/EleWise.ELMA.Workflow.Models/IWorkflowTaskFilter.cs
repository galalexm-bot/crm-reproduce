using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowTask))]
public interface IWorkflowTaskFilter : ITaskBaseFilter, IEntityFilter
{
}
