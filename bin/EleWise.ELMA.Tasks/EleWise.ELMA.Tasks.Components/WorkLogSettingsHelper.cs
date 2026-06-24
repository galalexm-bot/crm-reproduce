using System;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Tasks.Components;

public static class WorkLogSettingsHelper
{
	private static ISecurityService _securityService;

	public static ISecurityService SecurityService => _securityService ?? (_securityService = Locator.GetServiceNotNull<ISecurityService>());

	public static WorkLogSettings GetSettings()
	{
		return Locator.GetServiceNotNull<WorkLogSettingsModule>().Settings;
	}

	public static bool WorkLogEnabled()
	{
		if (SecurityService.HasPermission(PermissionProvider.TasksAccessPermission))
		{
			return GetSettings().WorkLogEnabled;
		}
		return false;
	}

	[Obsolete("Метод устарел. Используйте вместо него метод WorkLogEnabled.")]
	public static bool WorkLogJurnalEnabled()
	{
		return WorkLogEnabled();
	}
}
