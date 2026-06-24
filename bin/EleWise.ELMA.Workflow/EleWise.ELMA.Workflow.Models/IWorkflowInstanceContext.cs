using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Workflow.Models;

public interface IWorkflowInstanceContext : IEntity<long>, IEntity, IIdentified
{
	IWorkflowInstance WorkflowInstance { get; }
}
