using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Tasks.Components;

public class TaskControlSettingsHelper
{
	public static bool SetControl()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		TaskControlSettingsModel taskControlSettingsModel = ((currentUser == null) ? null : PersonalizationAdministration.LoadState<TaskControlSettingsModel>(currentUser.UserName, "UserTaskControlSettings"));
		if (Locator.GetServiceNotNull<TasksSettingsModule>().Settings.EnableUserSettings && taskControlSettingsModel != null && !taskControlSettingsModel.UseSystemSettings)
		{
			return taskControlSettingsModel.SetControl;
		}
		return Locator.GetServiceNotNull<TasksSettingsModule>().Settings.SetControl;
	}

	public static TaskControlType DefaultControlType()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		TaskControlSettingsModel taskControlSettingsModel = ((currentUser == null) ? null : PersonalizationAdministration.LoadState<TaskControlSettingsModel>(currentUser.UserName, "UserTaskControlSettings"));
		if (Locator.GetServiceNotNull<TasksSettingsModule>().Settings.EnableUserSettings && taskControlSettingsModel != null && !taskControlSettingsModel.UseSystemSettings)
		{
			return taskControlSettingsModel.DefaultControlType;
		}
		return Locator.GetServiceNotNull<TasksSettingsModule>().Settings.DefaultControlType;
	}

	public static bool AllowChangeControl()
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (serviceNotNull.HasPermission(currentUser, PermissionProvider.AccessToAllTasks))
		{
			return true;
		}
		return Locator.GetServiceNotNull<TasksSettingsModule>().Settings.AllowChangeControl;
	}
}
