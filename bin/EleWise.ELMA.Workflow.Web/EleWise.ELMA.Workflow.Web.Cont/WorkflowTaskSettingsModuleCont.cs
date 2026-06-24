using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Workflow.Web.Controllers;

[Component(Order = 100)]
public class WorkflowTaskSettingsModuleController : GlobalSettingsModuleControllerBase<WorkflowTaskSettings, WorkflowTaskSettingsModule>
{
	public WorkflowTaskSettingsModuleController(WorkflowTaskSettingsModule module)
		: base(module)
	{
	}
}
