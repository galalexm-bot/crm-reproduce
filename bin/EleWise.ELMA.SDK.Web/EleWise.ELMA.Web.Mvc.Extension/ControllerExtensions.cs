using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ControllerExtensions
{
	public static ActionResult RedirectLocal(this Controller controller, string redirectUrl, Func<ActionResult> invalidUrlBehavior)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(redirectUrl) && controller.get_Url().IsLocalUrl(redirectUrl))
		{
			return (ActionResult)new RedirectResult(redirectUrl);
		}
		return invalidUrlBehavior?.Invoke();
	}

	public static ActionResult RedirectLocal(this Controller controller, string redirectUrl)
	{
		return controller.RedirectLocal(redirectUrl, (string)null);
	}

	public static ActionResult RedirectLocal(this Controller controller, string redirectUrl, string defaultUrl)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(redirectUrl) && controller.get_Url().IsLocalUrl(redirectUrl))
		{
			return (ActionResult)new RedirectResult(redirectUrl);
		}
		return (ActionResult)new RedirectResult(defaultUrl ?? "~/");
	}
}
