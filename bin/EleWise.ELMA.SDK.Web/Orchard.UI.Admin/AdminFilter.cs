using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Localization;
using Orchard.Mvc.Filters;
using Orchard.Security;

namespace Orchard.UI.Admin;

public class AdminFilter : FilterProvider, IAuthorizationFilter
{
	private readonly IAuthorizer _authorizer;

	public Localizer T { get; set; }

	public AdminFilter(IAuthorizer authorizer)
	{
		_authorizer = authorizer;
		T = NullLocalizer.Instance;
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		if (IsAdmin(filterContext))
		{
			Apply(((ControllerContext)filterContext).get_RequestContext());
			if (!_authorizer.Authorize(StandardPermissions.AccessAdminPanel, T("Can't access the admin")))
			{
				filterContext.set_Result((ActionResult)new HttpUnauthorizedResult());
			}
		}
	}

	public static void Apply(RequestContext context)
	{
		context.HttpContext.Items[typeof(AdminFilter)] = null;
	}

	public static bool IsApplied(RequestContext context)
	{
		return context.HttpContext.Items.Contains(typeof(AdminFilter));
	}

	private static bool IsAdmin(AuthorizationContext filterContext)
	{
		if (IsNameAdmin(filterContext) || IsNameAdminProxy(filterContext))
		{
			return true;
		}
		IEnumerable<AdminAttribute> adminAttributes = GetAdminAttributes(filterContext.get_ActionDescriptor());
		if (adminAttributes != null && adminAttributes.Any())
		{
			return true;
		}
		return false;
	}

	private static bool IsNameAdmin(AuthorizationContext filterContext)
	{
		return string.Equals(filterContext.get_ActionDescriptor().get_ControllerDescriptor().get_ControllerName(), "Admin", StringComparison.OrdinalIgnoreCase);
	}

	private static bool IsNameAdminProxy(AuthorizationContext filterContext)
	{
		if (filterContext.get_ActionDescriptor().get_ControllerDescriptor().get_ControllerName()
			.StartsWith("AdminControllerProxy", StringComparison.InvariantCultureIgnoreCase))
		{
			return filterContext.get_ActionDescriptor().get_ControllerDescriptor().get_ControllerName()
				.Length == "AdminControllerProxy".Length + 32;
		}
		return false;
	}

	private static IEnumerable<AdminAttribute> GetAdminAttributes(ActionDescriptor descriptor)
	{
		return descriptor.GetCustomAttributes(typeof(AdminAttribute), true).Concat(descriptor.get_ControllerDescriptor().GetCustomAttributes(typeof(AdminAttribute), true)).OfType<AdminAttribute>();
	}
}
