using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Workflow.Models;

internal interface IWorkflowTablePartEntity
{
	void Initialize(IEntity firstEntity);
}
