using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Workflow;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("WorkflowProcess", "EleWise.ELMA.Workflow")]
internal interface IWorkflowProcessService
{
	[GlobalFunction("7718c600-7d79-4204-bfab-a7cab97f5817")]
	System.Threading.Tasks.Task<StartableProcessesInfo> StartableProcesses();

	[GlobalFunction("0d5ab8b2-6e9f-4aed-8d66-3dd5f5a11815")]
	System.Threading.Tasks.Task<EntityFormView> GetForm(GetProcessForm request);
}
