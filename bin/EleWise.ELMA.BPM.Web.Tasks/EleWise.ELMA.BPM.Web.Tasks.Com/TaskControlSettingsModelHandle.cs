using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TaskControlSettingsModelHandler : IUserSettingsModelHandler
{
	public WorkLogManager WorkLogManager { get; set; }

	public void Process(IUser user, IUserSettingsModel model)
	{
		if (model is ITaskControlSettingsModel taskControlSettingsModel && taskControlSettingsModel.TaskControlSettings != null)
		{
			if (taskControlSettingsModel.TaskControlSettings != null && taskControlSettingsModel.TaskControlSettings.AutomaticSendingOfWorkLog)
			{
				WorkLogManager.SaveAutoSaveWorkLogsUsers(user);
			}
			else
			{
				WorkLogManager.RemoveAutoSaveWorkLogsUsers(user);
			}
			PersonalizationAdministration.SaveState(user.UserName, "UserTaskControlSettings", taskControlSettingsModel.TaskControlSettings);
		}
	}
}
