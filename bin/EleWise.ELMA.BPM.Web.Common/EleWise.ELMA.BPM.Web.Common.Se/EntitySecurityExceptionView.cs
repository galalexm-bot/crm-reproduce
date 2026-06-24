using System;
using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component(Order = 10)]
public class EntitySecurityExceptionView : ISecurityExceptionView
{
	public bool CheckType(SecurityException exception)
	{
		return exception is EntitySecurityException;
	}

	public ActionResult Result(SecurityException securityException, ControllerBase controller, string url, string routeDataText)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		EntitySecurityException exception = (EntitySecurityException)securityException;
		controller.get_ViewData().set_Model((object)new AccessDeniedEntityModel
		{
			Reason = securityException.Message,
			Url = url,
			RouteDataText = routeDataText,
			Exception = exception
		});
		PartialViewResult val = new PartialViewResult();
		((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.BPM.Web.Common/Views/Shared/Entity/AccessDenided.cshtml");
		((ViewResultBase)val).set_ViewData(controller.get_ViewData());
		((ViewResultBase)val).set_TempData(controller.get_TempData());
		return (ActionResult)val;
	}

	public RouteValueDictionary ResultRoute(SecurityException securityException, ControllerBase controller, string url, string routeDataText)
	{
		EntitySecurityException ex = (EntitySecurityException)securityException;
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "action", "AccessDenided" },
			{ "controller", "Entity" },
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{ "reason", ex.Message },
			{ "url", url },
			{ "routeDataText", routeDataText },
			{ "typeUid", ex.TypeUid },
			{ "entityId", ex.EntityId }
		};
		int num = 0;
		foreach (Guid permission in ex.Permissions)
		{
			routeValueDictionary.Add($"permissions[{num}]", permission);
			num++;
		}
		return routeValueDictionary;
	}
}
