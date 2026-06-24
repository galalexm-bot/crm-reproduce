using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Security;

internal static class PermissionActionResultImpl
{
	public static ActionResult AccessDeniedResult([NotNull] SecurityException securityException, ControllerBase controller)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		Contract.ArgumentNotNull(securityException, "securityException");
		string message = securityException.Message;
		string text = "";
		string text2 = controller.get_ControllerContext().get_RouteData().Values.Select((KeyValuePair<string, object> p) => p.Key + "=" + p.Value).ToSeparatedString(", ");
		if (controller.get_ControllerContext().get_IsChildAction())
		{
			text = "";
		}
		else
		{
			HttpContextBase httpContext = controller.get_ControllerContext().get_HttpContext();
			if (httpContext != null && httpContext.Request != null && httpContext.Request.Url != null)
			{
				text = httpContext.Request.Url.ToString();
			}
		}
		string text3 = controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("X-Requested-With");
		bool result;
		bool flag = bool.TryParse(controller.get_ControllerContext().get_RequestContext().HttpContext.Request.Headers.Get("Spa-Request"), out result) && result;
		ISecurityExceptionView securityExceptionView = ComponentManager.Current.GetExtensionPoints<ISecurityExceptionView>().FirstOrDefault((ISecurityExceptionView p) => p.CheckType(securityException));
		if (controller.get_ControllerContext().get_IsChildAction() || (text3 == "XMLHttpRequest" && !flag))
		{
			ViewDataDictionary viewData = controller.get_ViewData();
			if (securityExceptionView != null)
			{
				return securityExceptionView.Result(securityException, controller, text, text2);
			}
			viewData.set_Model((object)new AccessDeniedModel
			{
				Reason = message,
				Url = text,
				RouteDataText = text2
			});
			PartialViewResult val = new PartialViewResult();
			((ViewResultBase)val).set_ViewName("~/Modules/EleWise.ELMA.BPM.Web.Security/Views/Account/AccessDenided.cshtml");
			((ViewResultBase)val).set_ViewData(viewData);
			((ViewResultBase)val).set_TempData(controller.get_TempData());
			return (ActionResult)val;
		}
		RouteValueDictionary routeValueDictionary = ((securityExceptionView == null) ? new RouteValueDictionary
		{
			{ "action", "AccessDenided" },
			{ "controller", "Account" },
			{ "area", "EleWise.ELMA.BPM.Web.Security" },
			{ "Reason", message },
			{ "Url", text },
			{ "RouteDataText", text2 }
		} : securityExceptionView.ResultRoute(securityException, controller, text, text2));
		return (ActionResult)new RedirectToRouteResult(routeValueDictionary);
	}

	public static void CheckPermission([NotNull] ISecurityService securityService, [NotNull] Permission permission, bool inverse = false)
	{
		if (securityService == null)
		{
			throw new ArgumentNullException("securityService");
		}
		if (permission == null)
		{
			throw new ArgumentNullException("permission");
		}
		if (!(securityService.HasPermission(permission) ^ inverse))
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
		}
	}

	public static void CheckPermission([NotNull] ISecurityService securityService, [NotNull] Permission permission, [NotNull] object target)
	{
		if (securityService == null)
		{
			throw new ArgumentNullException("securityService");
		}
		if (permission == null)
		{
			throw new ArgumentNullException("permission");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (!securityService.HasPermission(permission, target))
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
		}
	}

	public static void CheckInstanceAttributePermission(ActionExecutingContext filterContext, bool Inverse, [NotNull] ISecurityService securityService, [NotNull] IPermissionManagmentService permissionManagmentService)
	{
		foreach (var item in from p in filterContext.get_ActionDescriptor().GetParameters()
			where p.get_ParameterName() != null
			select new
			{
				ParameterName = p.get_ParameterName(),
				ParameterAttr = AttributeHelper<InstancePermissionAttribute>.GetAttributeForParameterDescriptor(p, inherited: false)
			} into mp
			where mp.ParameterAttr != null
			select mp)
		{
			Permission permission = permissionManagmentService.GetPermission(item.ParameterAttr.PermissionId);
			if (permission == null)
			{
				throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", item.ParameterAttr.PermissionId));
			}
			if (!filterContext.get_ActionParameters().TryGetValue(item.ParameterName, out var value))
			{
				continue;
			}
			object obj;
			if (item.ParameterAttr.Type == null)
			{
				if (CastingAGenericType(value.GetType().BaseType))
				{
					obj = value.GetPropertyValue("Entity", value);
					if (obj == value)
					{
						break;
					}
				}
				else
				{
					obj = value;
				}
			}
			else
			{
				IEntityManager entityManager = ModelHelper.GetEntityManager(item.ParameterAttr.Type);
				long? num = value as long?;
				if (!num.HasValue || num == 0)
				{
					break;
				}
				obj = entityManager.LoadOrNull(value);
			}
			if (!securityService.HasPermission(permission, obj) ^ Inverse)
			{
				throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
			}
		}
	}

	private static bool CastingAGenericType(Type baseType)
	{
		if (baseType != null && baseType.IsGenericType)
		{
			if (!(baseType.GetGenericTypeDefinition() == typeof(EntityModel<>)))
			{
				if (!(baseType.BaseType != null))
				{
					return false;
				}
				return CastingAGenericType(baseType.BaseType);
			}
			return true;
		}
		return false;
	}
}
