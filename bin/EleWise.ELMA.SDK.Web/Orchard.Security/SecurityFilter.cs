using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Logging;
using Orchard.Logging;
using Orchard.Mvc.Filters;
using Orchard.UI.Admin;

namespace Orchard.Security;

public class SecurityFilter : FilterProvider, IExceptionFilter, IAuthorizationFilter
{
	private readonly IAuthorizer _authorizer;

	public ILogger Logger { get; set; }

	public SecurityFilter(IAuthorizer authorizer)
	{
		_authorizer = authorizer;
		Logger = NullLogger.Instance;
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		bool flag = filterContext.get_ActionDescriptor().GetCustomAttributes(typeof(AlwaysAccessibleAttribute), true).Any();
		if (!flag && filterContext.get_ActionDescriptor().get_ControllerDescriptor().get_ControllerType()
			.GetCustomAttributes(typeof(AlwaysAccessibleAttribute), inherit: true)
			.Any())
		{
			flag = true;
		}
		if (!AdminFilter.IsApplied(((ControllerContext)filterContext).get_RequestContext()) && !flag && !_authorizer.Authorize(StandardPermissions.AccessFrontEnd))
		{
			filterContext.set_Result((ActionResult)new HttpUnauthorizedResult());
		}
	}

	public void OnException(ExceptionContext filterContext)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (filterContext.get_Exception() is OrchardSecurityException)
		{
			try
			{
				Logger.Information(filterContext.get_Exception(), "Security exception converted to access denied result");
			}
			catch
			{
			}
			filterContext.set_Result((ActionResult)new HttpUnauthorizedResult());
			filterContext.set_ExceptionHandled(true);
		}
	}
}
