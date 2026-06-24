using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

public class WorkflowInstanceMigrationItemController : BPMController<IWorkflowInstanceMigrationItem, long>
{
	public WorkflowInstanceMigrationPackageManager WorkflowMigrationPackageManager { get; set; }

	public ActionResult ShowPackageItems(long id)
	{
		((Controller)(object)this).SetCurrentMenuItem("change-version-packages-list-active");
		WorkflowInstanceMigrationPackageViewModel workflowInstanceMigrationPackageViewModel = new WorkflowInstanceMigrationPackageViewModel(WorkflowMigrationPackageManager.Load(id));
		return (ActionResult)(object)((Controller)this).View("Index", (object)workflowInstanceMigrationPackageViewModel);
	}

	public ActionResult GetPacketStatus(long id)
	{
		IWorkflowInstanceMigrationPackage workflowInstanceMigrationPackage = WorkflowMigrationPackageManager.Load(id);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			status = (int)workflowInstanceMigrationPackage.Status.Value
		});
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IWorkflowInstanceMigrationItemFilter filter, long packageId)
	{
		if (filter == null)
		{
			filter = new InstanceOf<IWorkflowInstanceMigrationItemFilter>().New;
		}
		filter.Package = WorkflowMigrationPackageManager.Load(packageId);
		return (ActionResult)(object)((Controller)this).PartialView((object)CreateGridData(command, filter));
	}
}
