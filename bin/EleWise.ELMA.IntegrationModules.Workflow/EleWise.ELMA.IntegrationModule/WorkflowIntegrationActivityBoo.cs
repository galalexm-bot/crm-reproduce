using System;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

public class WorkflowIntegrationActivityBookmarkInfo : WorkflowOperationInfo
{
	public long Id { get; set; }

	public DateTime? CreationDate { get; set; }

	public IntegrationModuleActivityStatus Status { get; set; }

	public string ActivityName { get; set; }
}
