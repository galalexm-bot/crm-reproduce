using EleWise.ELMA.Modules;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow;

internal interface IInternalWorkflowService : ILicensedUnit
{
	void Run(IWorkflowInstance instance);
}
