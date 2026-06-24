using System;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class TemporaryAuthenticationFilterAttribute : ActionFilterAttribute, IAuthorizationFilter
{
	public TemporaryAuthenticationFilterAttribute()
	{
		((FilterAttribute)this).set_Order(0);
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		if (filterContext == null)
		{
			throw new ArgumentNullException("filterContext");
		}
		ITemporaryAuthenticationService service = Locator.GetService<ITemporaryAuthenticationService>();
		if (service == null)
		{
			return;
		}
		TemporaryAuthenticationInfo fromContext = service.GetFromContext(((ControllerContext)filterContext).get_HttpContext());
		if (fromContext == null)
		{
			return;
		}
		IAuthenticationService service2 = Locator.GetService<IAuthenticationService>();
		if (service2 != null)
		{
			IUser currentUser = service2.GetCurrentUser();
			IUser user = fromContext.GetUser();
			if (currentUser == null || Convert.ToInt64(currentUser.GetId()) != Convert.ToInt64(user.GetId()))
			{
				service2.SignOut();
				service2.SignIn(user);
			}
		}
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
		ITemporaryAuthenticationService service = Locator.GetService<ITemporaryAuthenticationService>();
		if (service != null)
		{
			TemporaryAuthenticationInfo fromContext = service.GetFromContext(((ControllerContext)filterContext).get_HttpContext());
			if (fromContext != null)
			{
				service.Remove(fromContext.Key);
			}
		}
	}
}
