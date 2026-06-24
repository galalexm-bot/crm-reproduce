using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class WorkPlaceCustomizerController : Controller
{
	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult EnableCustomizer()
	{
		if (!WorkPlaceExtensions.CustomizerEnabled)
		{
			WorkPlaceExtensions.EnableCustomizer();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Portal", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		});
	}

	[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
	public ActionResult DisableCustomizer()
	{
		if (!WorkPlaceExtensions.CustomizerEnabled)
		{
			return (ActionResult)(object)((Controller)this).Redirect("/");
		}
		WorkPlaceExtensions.DisableCustomizer();
		long? customizatorId = WorkPlaceExtensions.CustomizatorId;
		if (customizatorId.HasValue && customizatorId != AuthenticationService.GetCurrentUser<IUser>().Id)
		{
			IUser user = UserManager.Instance.Load(customizatorId.Value);
			IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
			try
			{
				((Controller)this).get_Session().Clear();
				serviceNotNull.SignIn(user);
			}
			catch (Exception)
			{
				serviceNotNull.SignOut();
			}
			return (ActionResult)(object)((Controller)this).Redirect("/");
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Request().UrlReferrer.PathAndQuery);
	}
}
