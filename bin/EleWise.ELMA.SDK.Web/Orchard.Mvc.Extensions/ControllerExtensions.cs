using System;
using System.Web.Mvc;
using Orchard.Utility.Extensions;

namespace Orchard.Mvc.Extensions;

public static class ControllerExtensions
{
	public static ActionResult RedirectLocal(this Controller controller, string redirectUrl, Func<ActionResult> invalidUrlBehavior)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(redirectUrl) && controller.get_Request().IsLocalUrl(redirectUrl))
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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (!controller.get_Request().IsLocalUrl(redirectUrl))
		{
			return (ActionResult)new RedirectResult(defaultUrl ?? "~/");
		}
		return (ActionResult)new RedirectResult(redirectUrl);
	}
}
