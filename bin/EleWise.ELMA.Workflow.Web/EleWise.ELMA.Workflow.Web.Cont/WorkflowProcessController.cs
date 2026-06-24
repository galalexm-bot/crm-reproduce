using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[RouteArea("EleWise.ELMA.Workflow.Web")]
public class WorkflowProcessController : BPMController<IWorkflowProcess, long>
{
	public ActionResult ImageMap(long id)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		IWorkflowProcess workflowProcess = base.Manager.LoadOrNull(id);
		if (workflowProcess != null)
		{
			return (ActionResult)new FileStreamResult(Locator.GetServiceNotNull<IDiagramExporterService>().ExportDiagramWorkflowProcess(workflowProcess), "image/jpeg");
		}
		return null;
	}
}
