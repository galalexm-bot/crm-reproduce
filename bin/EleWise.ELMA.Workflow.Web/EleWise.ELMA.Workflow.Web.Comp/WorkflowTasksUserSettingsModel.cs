using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class WorkflowTasksUserSettingsModelHandler : IUserSettingsModelHandler
{
	public void Process(IUser user, IUserSettingsModel model)
	{
		if (model is IWorkflowTasksUserSettingsModel workflowTasksUserSettingsModel)
		{
			PersonalizationAdministration.SaveState(user.UserName, "UserWorkflowTasksSettings", workflowTasksUserSettingsModel.Tasks);
		}
	}
}
