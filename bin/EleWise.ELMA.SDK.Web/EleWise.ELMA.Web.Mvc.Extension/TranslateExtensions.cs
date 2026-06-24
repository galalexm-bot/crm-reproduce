using System;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class TranslateExtensions
{
	public static bool CheckTranslateAvailable()
	{
		bool num = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CommonPermissions.TranslateSystemPermission);
		if (!num && TranslateService.Instance.IsTranslationModeEnabled())
		{
			IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
			if (currentUser != null)
			{
				TranslateService.Instance.EnabledTranslationMode(Convert.ToInt64(currentUser.GetId()), enabled: false);
			}
		}
		return num;
	}
}
