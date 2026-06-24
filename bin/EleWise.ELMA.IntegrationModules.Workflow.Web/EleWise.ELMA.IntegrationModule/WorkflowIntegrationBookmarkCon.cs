using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.IntegrationModules.Workflow.Web.Controllers;

public class WorkflowIntegrationBookmarkController : BPMController<IWorkflowIntegrationBookmark, long>
{
	public IWorkflowRuntimeService WorkflowRuntimeService { get; set; }

	[HttpPost]
	[TransactionAction]
	public ActionResult CloseWorkflowIntegrationBookmark(long workflowIntegrationBookmarkId)
	{
		IWorkflowIntegrationBookmark workflowIntegrationBookmark = base.Manager.LoadOrNull(workflowIntegrationBookmarkId);
		if (workflowIntegrationBookmark == null)
		{
			throw new ObjectNotFoundException(SR.T("Точка останова интеграции"), workflowIntegrationBookmarkId);
		}
		workflowIntegrationBookmark.Integration.Status = IntegrationModuleActivityStatus.Terminated;
		IntegrationExecuteData data = new IntegrationExecuteData(workflowIntegrationBookmark);
		WorkflowRuntimeService.Execute(data);
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", "WorkflowInstance", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = workflowIntegrationBookmark.WorkflowInstanceId
		});
	}
}
